//-----------------------------------------------------------------
// Station Hopper Application
// C++ Source - Hopper.cpp
//-----------------------------------------------------------------

//-----------------------------------------------------------------
// Include Files
//-----------------------------------------------------------------
#include "Hopper.h"

//-----------------------------------------------------------------
// Game Engine Functions
//-----------------------------------------------------------------
BOOL GameInitialize(HINSTANCE hInstance)
{
  // Create the game engine
  g_pGame = new GameEngine(hInstance, TEXT("Station Hopper"),
	TEXT("Station Hopper"), IDI_HOPPER, IDI_HOPPER_SM, 800, 600);
  if (g_pGame == NULL){
    return FALSE;
  }

  // Set the frame rate
  g_pGame->SetFrameRate(60);

  
  // Store the instance handle
  g_hInstance = hInstance;

  return TRUE;
}

void GameStart(HWND hWindow)
{
  // Seed the random number generator
  srand(GetTickCount());

  // Create the offscreen device context and bitmap
  g_hOffscreenDC = CreateCompatibleDC(GetDC(hWindow));
  g_hOffscreenBitmap = CreateCompatibleBitmap(GetDC(hWindow),
    g_pGame->GetWidth(), g_pGame->GetHeight());
  SelectObject(g_hOffscreenDC, g_hOffscreenBitmap);

  // Create and load the bitmaps
  HDC hDC = GetDC(hWindow);
  g_pStationsBitmap = new Bitmap(hDC, IDB_STATIONS, g_hInstance);
  g_pVesselBitmap = new Bitmap(hDC, IDB_VESSEL, g_hInstance);
  g_pShipBitmaps[0] = new Bitmap(hDC, IDB_ARBITER, g_hInstance);
  g_pShipBitmaps[1] = new Bitmap(hDC, IDB_SCOUT, g_hInstance);
  g_pShipBitmaps[2] = new Bitmap(hDC, IDB_CARRIER, g_hInstance);
  g_pShipBitmaps[3] = new Bitmap(hDC, IDB_BATTLECRUISER, g_hInstance);
  g_pShipBitmaps[4] = new Bitmap(hDC, IDB_INTERCEPTOR, g_hInstance);
  g_pHeartBitmap = new Bitmap(hDC, IDB_HEART, g_hInstance);

  // Create the Vessel and Ship sprites
  Sprite* pSprite;
  RECT    rcBounds = { 0, 0, 800, 600 };
  g_pVesselSprite = new Sprite(g_pVesselBitmap, rcBounds, BA_STOP);
  g_pVesselSprite->SetPosition(380, 2);
  g_pVesselSprite->SetVelocity(0, 0);
  g_pVesselSprite->SetZOrder(1);
  g_pGame->AddSprite(g_pVesselSprite);
  pSprite = new Sprite(g_pShipBitmaps[0], rcBounds, BA_WRAP);
  pSprite->SetPosition(0, 100);
  pSprite->SetVelocity(9, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[0], rcBounds, BA_WRAP);
  pSprite->SetPosition(0, 150);
  pSprite->SetVelocity(11, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[1], rcBounds, BA_WRAP);
  pSprite->SetPosition(0, 200);
  pSprite->SetVelocity(7,0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[1], rcBounds, BA_WRAP);
  pSprite->SetPosition(0, 235);
  pSprite->SetVelocity(9,0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[4], rcBounds, BA_WRAP);
  pSprite->SetPosition(760, 362);
  pSprite->SetVelocity(-4, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[4], rcBounds, BA_WRAP);
  pSprite->SetPosition(720, 367);
  pSprite->SetVelocity(-4, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[2], rcBounds, BA_WRAP);
  pSprite->SetPosition(0, 300);
  pSprite->SetVelocity(-3, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[4], rcBounds, BA_WRAP);
  pSprite->SetPosition(15, 270);
  pSprite->SetVelocity(-4, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[4], rcBounds, BA_WRAP);
  pSprite->SetPosition(100, 272);
  pSprite->SetVelocity(-4, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);
  pSprite = new Sprite(g_pShipBitmaps[3], rcBounds, BA_WRAP);
  pSprite->SetPosition(0, 400);
  pSprite->SetVelocity(-4, 0);
  pSprite->SetZOrder(2);
  g_pGame->AddSprite(pSprite);

  // Initialize the remaining global variables
  g_iInputDelay = 0;
  g_iNumLives = 3;
  g_iScore = 0;
  g_bGameOver = FALSE;

  // Play the background music
  g_pGame->PlayMIDISong(TEXT("Res\\Music.mid"));
}

void GameEnd()
{
  // Close the MIDI player for the background music
  g_pGame->CloseMIDIPlayer();

  // Cleanup the offscreen device context and bitmap
  DeleteObject(g_hOffscreenBitmap);
  DeleteDC(g_hOffscreenDC);  

  // Cleanup the bitmaps
  delete g_pStationsBitmap;
  delete g_pVesselBitmap;
  for (int i = 0; i < 4; i++){
    delete g_pShipBitmaps[i];
  }
  delete g_pHeartBitmap;

  // Cleanup the sprites
  g_pGame->CleanupSprites();

  // Cleanup the game engine
  delete g_pGame;
}

void GameActivate(HWND hWindow)
{
  // Resume the background music
  g_pGame->PlayMIDISong(TEXT(""), FALSE);
}

void GameDeactivate(HWND hWindow)
{
  // Pause the background music
  g_pGame->PauseMIDISong();
}

void GamePaint(HDC hDC)
{
  // Draw the background Stations
  g_pStationsBitmap->Draw(hDC, 0, 0);

  // Draw the sprites
  g_pGame->DrawSprites(hDC);

  // Draw the number of remaining Vessel lives
  for (int i = 0; i < g_iNumLives; i++){
    g_pHeartBitmap->Draw(hDC,
      706 + (g_pHeartBitmap->GetWidth() * i), 582, TRUE);
  }
}

void GameCycle()
{
  if (!g_bGameOver)
  {
        // Update the sprites
    g_pGame->UpdateSprites();

    // Obtain a device context for repainting the game
    HWND  hWindow = g_pGame->GetWindow();
    HDC   hDC = GetDC(hWindow);

    // Paint the game to the offscreen device context
    GamePaint(g_hOffscreenDC);

    // Blit the offscreen bitmap to the game screen
    BitBlt(hDC, 0, 0, g_pGame->GetWidth(), g_pGame->GetHeight(),
      g_hOffscreenDC, 0, 0, SRCCOPY);

    // Cleanup
    ReleaseDC(hWindow, hDC);
  }
}

void HandleKeys()
{
  HWND  hWindow = g_pGame->GetWindow();
  if (!g_bGameOver )
  {
    // Move the Vessel based upon key presses
	if (GetAsyncKeyState(VK_ESCAPE) < 0){
		GameEnd();
	}
	if (GetAsyncKeyState(VK_LEFT) < 0){
      MoveVessel(-3, 0);
	}
	else if (GetAsyncKeyState(VK_RIGHT) < 0){
      MoveVessel(3, 0);
	}
	if (GetAsyncKeyState(VK_UP) < 0){
		MoveVessel(0, -3);
	}
    else if (GetAsyncKeyState(VK_DOWN) < 0){
      MoveVessel(0, 3);
	}
  }
}

void MouseButtonDown(int x, int y, BOOL bLeft)
{
  // Start a new game, if necessary
  if (g_bGameOver){
    // Restart the background music
    g_pGame->PlayMIDISong();

    // Initialize the game variables
    g_iNumLives = 3;
    g_iScore = 0;
    g_bGameOver = FALSE;
  }
}

void MouseButtonUp(int x, int y, BOOL bLeft)
{
}

void MouseMove(int x, int y)
{
}


BOOL SpriteCollision(Sprite* pSpriteHitter, Sprite* pSpriteHittee)
{
  // See if the Vessel was hit
  if (pSpriteHittee == g_pVesselSprite)
  {
    // Move the Vessel back to the start
    g_pVesselSprite->SetPosition(380, 0);

    // See if the game is over
    if (--g_iNumLives > 0)
      // Play a sound for the Vessel getting hit
      PlaySound((LPCSTR)IDW_EXPLODE, g_hInstance, SND_ASYNC | SND_RESOURCE);
    else
    {
      // Play a sound for the game ending
      PlaySound((LPCSTR)IDW_GAMEOVER, g_hInstance, SND_ASYNC | SND_RESOURCE);

      // Display game over message
      TCHAR szText[64];
      wsprintf(szText, "Game Over! You scored %d points.", g_iScore);
      MessageBox(g_pGame->GetWindow(), szText, TEXT("Station Hopper"), MB_OK);
      g_bGameOver = TRUE;

      // Pause the background music
      g_pGame->PauseMIDISong();
    }

    return FALSE;
  }

  return TRUE;
}

//-----------------------------------------------------------------
// Functions
//-----------------------------------------------------------------
void MoveVessel(int iXDistance, int iYDistance)
{
  
  //Play a vessel sound effect
  PlayVesselSound();

  // Move the Vessel to its new position
  g_pVesselSprite->OffsetPosition(iXDistance, iYDistance);

  // See if the Vessel made it across
  if (g_pVesselSprite->GetPosition().bottom > 600)
  {
    // Play a sound for the Vessel making it safely across
    PlaySound((LPCSTR)IDW_CELEBRATE, g_hInstance, SND_ASYNC | SND_RESOURCE);

    // Move the Vessel back to the start and add to the score
    g_pVesselSprite->SetPosition(380,0    );
    g_iScore += 150;
  }
}

void PlayVesselSound()
{
	if ((rand()%45) == 1){
		switch(rand()%8)
		{
			case 1: 
				PlaySound((LPCSTR)IDW_V_1,g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 2: 
				PlaySound((LPCSTR)IDW_V_2, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 3: 
				PlaySound((LPCSTR)IDW_V_3, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 4: 
				PlaySound((LPCSTR)IDW_V_4, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 5: 
				PlaySound((LPCSTR)IDW_V_5, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 6: 
				PlaySound((LPCSTR)IDW_V_6, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 7: 
				PlaySound((LPCSTR)IDW_V_7, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			case 8: 
				PlaySound((LPCSTR)IDW_V_8, g_hInstance, SND_ASYNC | SND_NOSTOP | SND_RESOURCE);
				break;
			default:
				break;
		}
	}
}
