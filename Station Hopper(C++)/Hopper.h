//-----------------------------------------------------------------
// Station Hopper Application
// C++ Header - Hopper.h
//-----------------------------------------------------------------

#pragma once

//-----------------------------------------------------------------
// Include Files
//-----------------------------------------------------------------
#include <windows.h>
#include "Resource.h"
#include "GameEngine.h"
#include "Bitmap.h"
#include "Sprite.h"

//-----------------------------------------------------------------
// Global Variables
//-----------------------------------------------------------------
HINSTANCE   g_hInstance;
GameEngine* g_pGame;
HDC         g_hOffscreenDC;
HBITMAP     g_hOffscreenBitmap;
Bitmap*     g_pStationsBitmap;
Bitmap*     g_pVesselBitmap;
Bitmap*     g_pShipBitmaps[5];
Bitmap*     g_pHeartBitmap;
Sprite*     g_pVesselSprite;
int         g_iInputDelay;
int         g_iNumLives;
int         g_iScore;
BOOL        g_bGameOver;

//-----------------------------------------------------------------
// Function Declarations
//-----------------------------------------------------------------
void MoveVessel(int iXDistance, int iYDistance);
void PlayVesselSound();

