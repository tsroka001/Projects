/*
 * Tom Sroka
 * NumerologyLifePathDetails class file
 * NumerologyLifePathDetails.java
 * This file contains methods that aid in 
 * returning the results if a numerology test.
 */

public class NumerologyLifePathDetails extends Numerology{

	public NumerologyLifePathDetails(String strName, String strBirthday) {
		super(strName, strBirthday);
	}
	
	String getLifePathDescription(){
		
		switch(getLifePath())
		{
		case 1: return "The Independent: \nWants to work/think for themselves"; 
		case 2: return "The Mediator: \nAvoids conflict and wants love and harmony";
		case 3: return "The Performer: \nLikes music, art and to perform or get attention";
		case 4: return "The Teacher/Truth Seeker: \nIs meant to be a teacher or mentor and is truthful";
		case 5: return "The Adventurer: \nLikes to travel and meet others, often a extrovert";
		case 6: return "The Inner Child: \nIs meant to be a parent and/or one that is young at heart";
		case 7: return "The Naturalist: \nEnjoy nature and water and alternative life paths, open to spirituality";
		case 8: return "Executive: \nGravitates to money and power";
		case 9: return "The Humanitarian: \nHelps others and/or experiences pain and learns the hard way";
		}
		
		return null;
	}

}
