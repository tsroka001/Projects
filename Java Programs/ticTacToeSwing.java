/*
 * Tom Sroka
 * ticTacToeSwing class file
 * ticTacToeSwing.java
 * This file contains methods that are used to
 * executie a simple tic tac toe game.
 */

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;


public class ticTacToeSwing extends JFrame
                          implements ActionListener {

    //Class level variables
    private int iTurn = 0;
    private int iWinPoints[] = new int[] {0,0,0,0,0,0,0,0};
	
    // JLabels:
    private JLabel jlbNameX;
    private JLabel jlbNameO;
    
    // JTextFields:
    private JTextField jtfNameX;
    private JTextField jtfNameO;
    
    // Jbuttons:
    private JButton jbtn1;
    private JButton jbtn2;
    private JButton jbtn3;
    private JButton jbtn4;
    private JButton jbtn5;
    private JButton jbtn6;
    private JButton jbtn7;
    private JButton jbtn8;
    private JButton jbtn9;
    private JButton jbtnR;
    private JButton jbtnE;
    
    // Panels:
    private JPanel jpnlCanvas = new JPanel();
    private JPanel jpnlCenter = new JPanel();
    private JPanel jpnlTop = new JPanel();
    private JPanel jpnlBot = new JPanel();

    //Set the app font
    private Font fontChosenFont = new Font("Arial", Font.BOLD, 20);

    /*****************************************************************************/
    /* Class Constructor                                                         */
    /*****************************************************************************/

    public ticTacToeSwing(String sTitle) {

      // Prepare the JFrame/Window
      super(sTitle);
      setSize(400,500);
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      
      // Set the layouts
      jpnlCanvas.setLayout(new BorderLayout(5, 5));
      jpnlCenter.setLayout(new GridLayout(3, 3, 5, 5));
      jpnlTop.setLayout(new GridLayout(1, 4, 5, 5));
      jpnlBot.setLayout(new GridLayout(1, 2, 5, 5));
      
      //Instantiate the labels and text fields
      jlbNameX = new JLabel("Player X: ", SwingConstants.RIGHT);
      jlbNameO = new JLabel("Player O: ", SwingConstants.RIGHT);
      jtfNameX = new JTextField(10);
      jtfNameO = new JTextField(10);
            
      jpnlTop.add(jlbNameO);
      jpnlTop.add(jtfNameO);
      jpnlTop.add(jlbNameX);
      jpnlTop.add(jtfNameX);
      
      jlbNameO.setForeground(Color.green);
      jtfNameO.setForeground(Color.green);
      jlbNameX.setForeground(Color.red);
      jtfNameX.setForeground(Color.red);
      
      // Instantiate the JButtons with the button number and caption and add to JPanel.
      jbtn1 = instantiateJButton("1", "");
      jbtn2 = instantiateJButton("2", "");
      jbtn3 = instantiateJButton("3", "");
      jbtn4 = instantiateJButton("4", "");
      jbtn5 = instantiateJButton("5", "");
      jbtn6 = instantiateJButton("6", "");
      jbtn7 = instantiateJButton("7", "");
      jbtn8 = instantiateJButton("8", "");
      jbtn9 = instantiateJButton("9", "");
      jbtnR = instantiateJButton("10", "Reset");
      jbtnE = instantiateJButton("11", "Exit");
           
      //finalize the screen layout
      jpnlCanvas.add(jpnlTop, BorderLayout.NORTH);
      jpnlCanvas.add(jpnlCenter, BorderLayout.CENTER);
      jpnlCanvas.add(jpnlBot, BorderLayout.SOUTH);
      
      // Prepare the containter
      Container ca = getContentPane();
      ca.setBackground(Color.lightGray);
      ca.add(jpnlCanvas);
      setContentPane(ca);
      setVisible(true);

    }  // end constructor

    private JButton instantiateJButton(String sBtnNum, String sTitle)
    {
       // For each JButton passed to this method it will:
       // 1. Instantiate a JButton to work with
       // 2. Set the Action Command to that button number that was passed to the method
       // 3. Register for Event Handling
       // 4. Set the font to a larger size that was chosen by the programmer
       // 5. Add it to the appropriate panel
       // 6. Return the JButton that was just instantiated
       JButton jbtnButton = new JButton(sTitle);
       jbtnButton.setActionCommand(sBtnNum);
       jbtnButton.addActionListener(this);
       jbtnButton.setFont(fontChosenFont);
       if (Integer.parseInt(sBtnNum) > 9)
    	   jpnlBot.add(jbtnButton);
       else
    	   jpnlCenter.add(jbtnButton);
       return jbtnButton;

    }  // end instantiateJButton

    /*****************************************************************************/
    /* Class Event Handler                                                       */
    /*****************************************************************************/

    public void actionPerformed(java.awt.event.ActionEvent e)
    {

      // Find out which JButton was pressed by using the Action Command value:
      String sActionCommand = e.getActionCommand();
      //create a temporary string variable to hold the player name if needed
      String sName = "";
      //determine which button was pressed and execute the proper code
      if ( Integer.parseInt(sActionCommand) == 10) //Reset Button
      {
    	  reset();
      }
      else if(Integer.parseInt(sActionCommand) == 11) //Exit Button
      {
    	  System.exit(0);
      }
      else //Any of the 9 Tic Tac Toe board buttons
      {
    	  //increment the turn
    	  //Because iTurn is never reset, after the initial game the loser always plays first
    	  ++iTurn;
          //retrieve the jButton that was pressed
          JButton jbtnSource = (JButton) e.getSource();
          //determine what color to color the text of the button
          if(iTurn%2 == 0)
          {
        	  jbtnSource.setForeground(Color.red);
          }
          else
          {
        	  jbtnSource.setForeground(Color.green);
          }
          //label the button chosen with either an X or an O
          jbtnSource.setText(nextPlayer());
          //disable the button clicked
          jbtnSource.setEnabled(false);
          //check if win conditions are met
          if(checkWin(Integer.parseInt(sActionCommand)))
          {
        	  //retrieve the name of this turn's player
        	  if (iTurn%2 == 0)
          		  sName = jtfNameX.getText();
          	  else
          		  sName = jtfNameO.getText();
        	  //show a message of who won the game
        	  JOptionPane.showMessageDialog(null,
        			    sName + " won the game!",
        		        this.getTitle(), // <--- get the title of the JFrame
        		        JOptionPane.INFORMATION_MESSAGE);
        	  //reset the game field
        	  reset();
          }
      }
      
    }  // end actionPerformed(java.awt.event.ActionEvent e)
    
    //Function that returns the current players mark based on current turn
    private String nextPlayer()
    {
    	if (iTurn%2 == 0)
    	{
    		return "X";
    	}
    	else
    	{
    		return "O";
    	}
    }
    
    //Function that checks for victory conditions and returns true if victory achieved
    private boolean checkWin(int iBtnNum)
    {
    	//to see if a person has won I use an array of length 8 to represent each of the 8 possible 
    	// winning lines. By incrementing or decrementing the values from zero I check to see
    	// if the value hits 3 (playerX) or -3 (playerO) has won. The diagram below attempts to 
    	// aid in understanding what the array represents on the tic tac toe board.
    	
    	//     012 | 23 | 245
    	//     --------------
    	//      16 |0356| 46
    	//     --------------
    	//     157 | 37 | 047
    	
    	int iX = 0;
    	
    	if (iTurn%2 == 0)
    		iX = 1;
    	else
    		iX = -1;
    	
    	switch (iBtnNum)
    	{
	    	case 1: iWinPoints[0] += iX; iWinPoints[1] += iX; iWinPoints[2] += iX; break;
	    	case 2: iWinPoints[2] += iX; iWinPoints[3] += iX; break;
	    	case 3: iWinPoints[2] += iX; iWinPoints[4] += iX; iWinPoints[5] += iX; break;
	    	case 4: iWinPoints[1] += iX; iWinPoints[6] += iX; break;
	    	case 5: iWinPoints[0] += iX; iWinPoints[3] += iX; iWinPoints[5] += iX; iWinPoints[6] += iX; break;
	    	case 6: iWinPoints[4] += iX; iWinPoints[6] += iX; break;
	    	case 7: iWinPoints[1] += iX; iWinPoints[5] += iX; iWinPoints[7] += iX; break;
	    	case 8: iWinPoints[3] += iX; iWinPoints[7] += iX; break;
	    	case 9: iWinPoints[0] += iX; iWinPoints[4] += iX; iWinPoints[7] += iX; break;
    	}
    	 
    	for(int i = 0; i<8; i++)
    	{
    		if(iWinPoints[i] == 3 || iWinPoints[i] == -3)
    			return true;
    	}
    	return false;
    }
    
    //Function that resets all modified fields to their default styles
    private void reset()
    {
    	for(int i = 0; i<8; i++)
    		iWinPoints[i] = 0;
    	
    	jbtn1.setText("");
    	jbtn2.setText("");
    	jbtn3.setText("");
    	jbtn4.setText("");
    	jbtn5.setText("");
    	jbtn6.setText("");
    	jbtn7.setText("");
    	jbtn8.setText("");
    	jbtn9.setText("");
    	jbtn1.setForeground(Color.black);
    	jbtn2.setForeground(Color.black);
    	jbtn3.setForeground(Color.black);
    	jbtn4.setForeground(Color.black);
    	jbtn5.setForeground(Color.black);
    	jbtn6.setForeground(Color.black);
    	jbtn7.setForeground(Color.black);
    	jbtn8.setForeground(Color.black);
    	jbtn9.setForeground(Color.black);
    	jbtn1.setEnabled(true);
    	jbtn2.setEnabled(true);
    	jbtn3.setEnabled(true);
    	jbtn4.setEnabled(true);
    	jbtn5.setEnabled(true);
    	jbtn6.setEnabled(true);
    	jbtn7.setEnabled(true);
    	jbtn8.setEnabled(true);
    	jbtn9.setEnabled(true);
    	
    	
    }

    /*****************************************************************************/
    /* Execution Starting Point                                                  */
    /*****************************************************************************/

    public static void main(String[] args) {

    	ticTacToeSwing ticTacToeGame = new ticTacToeSwing("Tic Tac Toe Swing");

    } // end main(String[] args)

}  // end ticTacToeSwing class

