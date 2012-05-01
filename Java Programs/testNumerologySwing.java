/*
 * Tom Sroka
 * testNumerologySwing class file
 * testNumerologySwing.java
 * This file contains the methods and classes
 * requred to perform a simple numerology test 
 * for the user. 
 */

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class testNumerologySwing extends JFrame
{
    private static final int WIDTH=400;
    private static final int HEIGHT=300;

    // Declare JFrame components:
    private JLabel jlblName, jlblDOB;

    private JTextField jtfName, jtfDOB;

    private JTextArea  jtaOutput;

    private JButton jbutCalculate, jbutClear, jbutExit;

    private CalculateButtonHandler calculateHandler;
    private ClearButtonHandler  clearHandler;
    private ExitButtonHandler   exitHandler;

    private JScrollPane scrollingResult;

    private JPanel jpnlTop = new JPanel();
    private JPanel jpnlCenter = new JPanel();
    private JPanel jpnlBottom = new JPanel();

    // Constructor
    public testNumerologySwing(String sTitle)
    {
		// Set the title and Size:
        setTitle(sTitle);
        setSize(WIDTH, HEIGHT);

        // Instantiate the JLabel components:
        jlblName = new JLabel("Enter Name: ", SwingConstants.LEFT);
        jlblDOB = new JLabel("Enter DOB mm/dd/yyyy: ", SwingConstants.LEFT);

        // Instantiate the JTextFields:
		jtfName = new JTextField(15);
		jtfDOB = new JTextField(10);

        // Make the JTextArea scrollable:
		jtaOutput = new JTextArea(10,1);
		scrollingResult = new JScrollPane(jtaOutput);

		// Instantiate and register the Circle button for clicks events:
		jbutCalculate = new JButton("Calculate");
        calculateHandler = new CalculateButtonHandler();
        jbutCalculate.addActionListener(calculateHandler);

		// Instantiate and register the Clear button for clicks events:
		jbutClear = new JButton("Clear");
        clearHandler = new ClearButtonHandler();
        jbutClear.addActionListener(clearHandler);

		// Instantiate and register the Exit button for clicks events:
		jbutExit = new JButton("Exit");
		exitHandler = new ExitButtonHandler();
        jbutExit.addActionListener(exitHandler);

        // Assemble the JPanels:
        jpnlTop.setLayout(new GridLayout(2, 2));
        jpnlTop.add(jlblName);
        jpnlTop.add(jtfName);
        jpnlTop.add(jlblDOB);
        jpnlTop.add(jtfDOB);

        jpnlCenter.setLayout(new GridLayout(1, 1));
        jpnlCenter.add(scrollingResult);

        jpnlBottom.setLayout(new GridLayout(1, 3));
        jpnlBottom.add(jbutCalculate);
        jpnlBottom.add(jbutClear);
        jpnlBottom.add(jbutExit);

        // Start to add the components to the JFrame:
        Container pane = getContentPane();
        pane.setLayout(new BorderLayout());

        pane.add(jpnlTop, BorderLayout.NORTH);
        pane.add(jpnlCenter, BorderLayout.CENTER);
        pane.add(jpnlBottom, BorderLayout.SOUTH);

        // Show the JFrame and set code to respond to the user clicking on the X:
        setVisible(true);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    } // end constructor


    // Calculate Button Event Handler
    private class CalculateButtonHandler implements ActionListener
    {
      public void actionPerformed(ActionEvent e)
      {

		// Populate the output by using the methods in the user defined class::
		// 1. Instantiate the Numerology class
		// 2. Invoke the methods to populate the output:

    	  NumerologyLifePathDetails tstNum = new NumerologyLifePathDetails(jtfName.getText(), jtfDOB.getText());

        jtaOutput.append("Client Name: " + tstNum.getName() + "\n");
        jtaOutput.append("Client DOB: " + tstNum.getBirthdate() + "\n");
        jtaOutput.append("Life Path: " + tstNum.getLifePath() + "\n");
        jtaOutput.append("Attitude: " + tstNum.getAttitude() + "\n");
        jtaOutput.append("Birthday: " + tstNum.getBirthDay() + "\n");
        jtaOutput.append("Personality: " + tstNum.getPersonality() + "\n");
        jtaOutput.append("Power Name: " + tstNum.getPowerName() + "\n");
        jtaOutput.append("Soul: " + tstNum.getSoul() + "\n");
        jtaOutput.append(tstNum.getLifePathDescription());
        		
      }  // end actionPerformed
    } // end CircleButtonHandler


    // Exit Button Event Handler
	private class ExitButtonHandler implements ActionListener
	{
	      public void actionPerformed(ActionEvent e)
	      {
			System.exit(0);
	      }

    } // end ExitButtonHandler

	private class ClearButtonHandler implements ActionListener
	{
	      public void actionPerformed(ActionEvent e)
	      {
            jtfName.setText("");
            jtfDOB.setText("");
            jtaOutput.setText("");
	      }
    } // end ClearButtonHandler

    public static void main(String args[])
    {
		// The only thing this main does is Instantiate the JFrame:
		// Note the name of the object is the name of the class from above.
        testNumerologySwing cs = new testNumerologySwing("Test Numerology Swing");
    }  // end main

} // end class