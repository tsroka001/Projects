/*
 * Tom Sroka
 * Numerology class file
 * Numerology.java
 * This file contains methods that aid in the
 * calculation of a Numerology reading.
 */
public class Numerology {

	//class level variables
	private char[] cName;
	private char[] cBirthdate;
	
	//class constructor
	public Numerology(String strName, String strBirthday)
	{
		//Convert the given strings into character arrays
		cName = strName.toCharArray();
		cBirthdate = strBirthday.toCharArray();
		
		
	}
	
	//class functions
	public String getName()
	{
		//This function returns a string containing the client's name
		String sTemp = "";
		for(int i=0; i < cName.length; i++)
		{
			sTemp += Character.toString(cName[i]);
		}
		return sTemp;
	}
	
	public String getBirthdate()
	{
		//This function returns a string containing the client's birth date
		return String.copyValueOf(cBirthdate);
	}
	
	public int getBirthDay()
	{
		//This function returns the reduced sum of the day of the client
		return reduceNum(Character.getNumericValue(cBirthdate[3]) 
			           + Character.getNumericValue(cBirthdate[4]));
	}
	
	public int getAttitude()
	{
		//This function returns the reduced sum of the day 
		// and month of the client
		return reduceNum(Character.getNumericValue(cBirthdate[0]) 
		               + Character.getNumericValue(cBirthdate[1])
		               + Character.getNumericValue(cBirthdate[3])
		               + Character.getNumericValue(cBirthdate[4]));
	}
	
	public int getLifePath()
	{
		//This function returns the reduces sum of the day
		// month, and year of the client
		return reduceNum(Character.getNumericValue(cBirthdate[0]) 
	                   + Character.getNumericValue(cBirthdate[1])
	                   + Character.getNumericValue(cBirthdate[3])
	                   + Character.getNumericValue(cBirthdate[4])
	                   + Character.getNumericValue(cBirthdate[6])
	                   + Character.getNumericValue(cBirthdate[7])
	                   + Character.getNumericValue(cBirthdate[8])
	                   + Character.getNumericValue(cBirthdate[9]));	
	}
	
	public int getPersonality()
	{
		// This function returns the number total of all
		// the consonant characters in the clients name
		int iTemp = 0;
		for(int i=0; i < cName.length; i++)
		{
			if ( ! isVowel(cName[i]))
			{
				iTemp += getNumber(cName[i]);
			}
		}
		return reduceNum(iTemp);
	}
	
	public int getPowerName()
	{
		//This function returns the reduced sum of both 
		// the personality and soul numbers
		return reduceNum(getPersonality() + getSoul());
	}
	
	public int getSoul()
	{
		// This function returns the number total of all
		// the vowel characters in the clients name in exchange 
		// for the client's soul.
		int iTemp = 0;
		for(int i=0; i < cName.length; i++)
		{
			if ( isVowel(cName[i]))
			{
				iTemp += getNumber(cName[i]);
			}
		}
		return reduceNum(iTemp);
	}
	
	private boolean isVowel(char cChar)
	{
		//This function returns true of the given character is a vowel
		switch (Character.toUpperCase(cChar))
		{
		case 'A':
		case 'E':
		case 'I':
		case 'O':
		case 'U': return true; 
		default: return false;			
		}
	}
	
	private int getNumber(char cChar)
	{
		//This function returns a value of the character passed 
		//in based on a reference table.
		int iTemp = 0;
		if (cChar != ' ')
		{
			switch (Character.toUpperCase(cChar))
			{
			case 'A':
			case 'J':
			case 'S': iTemp = 1; break;
			case 'B':
			case 'K':
			case 'T': iTemp = 2; break;
			case 'C': 
			case 'L':
			case 'U': iTemp = 3; break;
			case 'D':
			case 'M':
			case 'V': iTemp = 4; break;
			case 'E':
			case 'N':
			case 'W': iTemp = 5; break;
			case 'F': 
			case 'O':
			case 'X': iTemp = 6; break;
			case 'G':
			case 'P':
			case 'Y': iTemp = 7; break;
			case 'H':
			case 'Q':
			case 'Z': iTemp = 8; break;
			case 'I': 
			case 'R': iTemp = 9;
			}
		}
		return iTemp;			
	}
	
	private int reduceNum(int iNum)
	{
		// This function sums up the digits of a number and returns the
		// sum in a totaled form of a 1 digit number
		// This only works on properly positive numbers less than 1000
		
		int iHundred = 0;
		int iTen = 0;
		int iDigit = 0;
		//calculate the Hundreds place
		iHundred = iNum / 100;
		//calculate the tens place
		iTen = (iNum - iHundred * 100) / 10;
		//calculate the digits place
		iDigit = (iNum - iHundred * 100 - iTen*10);
		//check to see if the sum of the digits is only 1 digit long,
		//if it is not then the function calls itself to try to simplify
		//the number again.
		if (iTen + iDigit + iHundred > 9)
			return reduceNum(iTen + iDigit +iHundred);
		else
			return iTen + iDigit + iHundred;				
	}
}






