/*
 * Tom Sroka
 * inputValidater class file
 * inputValidater.java
 * This file contains methods and classes that
 * perform a simple numeric input validation test.
 */


import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


public class inputValidater extends JFrame
{
    // Declare constants
    private static final int WIDTH=325;
    private static final int HEIGHT=100;

    // Declare JFrame components

    // JLabels:
    private JLabel jlbNumber;

    // JTextField
    private JTextField jtfNumber;


    // JButtons:
    private JButton jbutValidate, jbutClear, jbutExit;

    // Event Handlers:
    private validateButtonHandler vbHandler;
    private ClearButtonHandler    cbHandler;
    private ExitButtonHandler     ebHandler;


    // JPanels:
    JPanel jpnlMain = new JPanel();
    JPanel jpnlCenter = new JPanel();
    JPanel jpnlSouth = new JPanel();


	// Constructor
    public inputValidater()
    {
		// Set the title and size:
        setTitle("Validate Number Swing");
        setSize(WIDTH, HEIGHT);

		// Set the layouts
        jpnlMain.setLayout(new BorderLayout(5, 5));     
		jpnlCenter.setLayout(new GridLayout(1, 2, 5, 5)); 
		jpnlSouth.setLayout(new GridLayout(1, 3, 5, 5));  

		// Instantiate the components
        jlbNumber = new JLabel("Enter Number to Validate: ", SwingConstants.RIGHT);
        jtfNumber = new JTextField(10);


		// Instantiate and register/link the Validate JButton for click events
        jbutValidate = new JButton("Validate");
		vbHandler = new validateButtonHandler();
		jbutValidate.addActionListener(vbHandler);

		// Instantiate and register/link the Clear JButton for click events
		jbutClear = new JButton("Clear");
		cbHandler = new ClearButtonHandler();
		jbutClear.addActionListener(cbHandler);

        // Instantiate and register/link the Exit JButton for click events
		jbutExit = new JButton("Exit");
		ebHandler = new ExitButtonHandler();
		jbutExit.addActionListener(ebHandler);


		// Add JLabel and JTextField to the jpnlCenter panel
        jpnlCenter.add(jlbNumber);
        jpnlCenter.add(jtfNumber);

		// Add three JButtons to the jpnlSouth panel
		jpnlSouth.add(jbutValidate);
        jpnlSouth.add(jbutClear);
        jpnlSouth.add(jbutExit);


		// Finalize the screen layout and publish to the display
		jpnlMain.add(jpnlCenter, BorderLayout.CENTER);
		jpnlMain.add(jpnlSouth, BorderLayout.SOUTH);

		// Prepare the containter
		Container ca = getContentPane();
		ca.add(jpnlMain);
      	setContentPane(ca);

        // Show the JFrame and set code to respond to the user clicking on the X
        setVisible(true);
        setDefaultCloseOperation(EXIT_ON_CLOSE);

    } // end constructor


	// validateButtonHandler click event
	private class validateButtonHandler implements ActionListener
    {
      	public void actionPerformed(ActionEvent e)
      	{

			// Declare variables
			int iNumber = 0;
			boolean bValidInput = true;

			// Check to make sure user supplied value is valid:   
			try
			{
			  iNumber = Integer.parseInt(jtfNumber.getText());
		    }
		    catch (NumberFormatException nfRef)
		    {
			  jtfNumber.requestFocus();
 			  JOptionPane.showMessageDialog(null,
				                            "Please supply a valid integer",
				                            getTitle(),
				                            JOptionPane.INFORMATION_MESSAGE);

		      return;  // exit this method if there is an error
    	    }


            //////////////////////////////////////////////////////////////////
            // If user input is valid then any code here will execute       //
            //////////////////////////////////////////////////////////////////



      	} // end actionPerformed

    } // end calcButtonHandler


	// ClearButtonHandler click event
	private class ClearButtonHandler implements ActionListener
    {
     	public void actionPerformed(ActionEvent e)
      	{
			// Set to empty strings
			jtfNumber.setText("");

      	} // end actionPerformed

    } // end ClearButtonHandler


	// ExitButtonHandler click event
 	private class ExitButtonHandler implements ActionListener
    {
      	public void actionPerformed(ActionEvent e)
      	{
			System.exit(0);

      	} // end actionPerformed

    } // end ExitButtonHandler


	// Main Method
    public static void main(String args[])
    {
		// Instantiate the JFrame
        inputValidater validJFrame = new inputValidater();

  	} // end main method

} // end JFrame Class
