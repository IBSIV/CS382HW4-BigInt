/*
 * Things that must be accomplished:
 * This project but use an array to store numbers. This is the simpliest way to do it.
 * There must be a boolean value that allows for negative numbers.
 * There must be a way to compare to the two numbers in the following ways:
 * 
 * 
 * 		-Greater than--complete
 * 		-Greater than or equal to--complete
 * 		-Less than--complete
 * 		-Less than or equal to--complete
 * 		-Equal--complete
 * 
 * 
 * 
 * It must implement the following operations
 * 		-Addition--method head made--DONE for cases of BOTH positive or BOTH negative--ALL COMPLETE
 * 		-Subtraction--method head made--ALL COMPLETE
 * 		-Multiplication--method head made--ALL COMPLETE
 * 		-Division--method head made
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * */

using System;
using System.Collections.Generic;

namespace BigNum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string number;
			string secondNum;
			//	int[] x;
			//	x = new int[10000]; 
			//number=new char[10000];
			Console.WriteLine ("Please input a number:\n");
			number = Console.ReadLine ();
			numberRep First = new numberRep (number);
			Console.WriteLine ("Please input another number:\n");
			secondNum = Console.ReadLine ();
			numberRep Second = new numberRep (secondNum);
			//Console.WriteLine (Second.baseArray.Length+"\n\n");


			//Console.WriteLine (Second.negative);

			//First.printBigNum (Second);
			numberRep ReturnRep = new numberRep ();
			First.printBigNum (First);
			Console.Write (" + ");
			First.printBigNum (Second);
			Console.Write (" = ");
			First.printBigNum(First.GetRidOfZeros(ReturnRep=First.Addition(First,Second)));
			Console.Write ("\n");



			 
			First.printBigNum (First);
			Console.Write (" - ");
			First.printBigNum (Second);
			Console.Write (" = ");
			First.printBigNum(First.GetRidOfZeros(ReturnRep=First.Subtraction(First,Second)));
			Console.Write ("\n");



			First.printBigNum (First);
			Console.Write (" * ");
			First.printBigNum (Second);
			Console.Write (" = ");
			First.printBigNum(First.GetRidOfZeros(ReturnRep=First.Multiplication(First,Second)));
			Console.Write ("\n");



			First.printBigNum (First);
			Console.Write (" / ");
			First.printBigNum (Second);
			Console.Write (" = ");
			First.printBigNum(First.GetRidOfZeros(ReturnRep=First.Multiplication(First,Second)));
			Console.Write ("\n");



			First.printBigNum (First);
			Console.Write (" > ");
			First.printBigNum (Second);
			Console.Write (" = ");
			Boolean x=First.GreaterThan (First, Second);
			Console.Write (x);
			Console.Write ("\n");


			First.printBigNum (First);
			Console.Write (" < ");
			First.printBigNum (Second);
			Console.Write (" = ");
			x=First.LessThan (First, Second);
			Console.Write (x);
			Console.Write ("\n");



			First.printBigNum (First);
			Console.Write (" >= ");
			First.printBigNum (Second);
			Console.Write (" = ");
			x=First.GreaterThanOrEqualTo (First, Second);
			Console.Write (x);
			Console.Write ("\n");



		


			First.printBigNum (First);
			Console.Write (" <= ");
			First.printBigNum (Second);
			Console.Write (" = ");
			x=First.LessThanOrEqualTo (First, Second);
			Console.Write (x);
			Console.Write ("\n");


			First.printBigNum (First);
			Console.Write (" == ");
			First.printBigNum (Second);
			Console.Write (" = ");
			x=First.EqualTo (First, Second);
			Console.Write (x);
			Console.Write ("\n");

			//Console.WriteLine (k.negative);

			Console.ReadLine ();






		}
	}

	public class numberRep
	{
		public int [] baseArray{ get; set; }

		public Boolean isNegative{ get; set; }

		public numberRep ()//empty constructor for simple creations
		{
		}

		public numberRep (string inputStream)
		{//BEGINNING OF CONSTRUCTOR
			if (inputStream [0] == '-') {
				Console.WriteLine ("got here, it sees negatives");
				isNegative = true;
			}
			baseArray = new int[inputStream.Length];


			/*
			 * 
			 * ############################################
			 * Poitive numbers go in here to be constructed.
			 * ############################################
			 * 
			 * 
			 * */
			if (isNegative == false) {
				for (int i = 0; i < inputStream.Length; i++) {
					baseArray [i] = ((int)inputStream [i] - 48);
					if (baseArray [i] < 0 || baseArray [i] > 10) {
						Console.WriteLine ((char)(baseArray [i] + 48) + " is not a number from 0-9, terminating program");
						break;
					}
					//Console.WriteLine (baseArray [i] + "\n");
				}
			} 

			/*
			 * 
			 * 
			 * ############################################
			 * Negative Numbers go in here to be Constructed
			 * ############################################
			 * 
			 * 
			 * */
			else {
				baseArray = new int[inputStream.Length - 1];
				for (int i = 0; i < inputStream.Length - 1; i++) {
					baseArray [i] = ((int)inputStream [i + 1] - 48);
					if (baseArray [i] < 0 || baseArray [i] > 10) {
						Console.WriteLine ((char)(baseArray [i] + 48) + " is not a number from 0-9, terminating program");
						break;
					}

			
				}
			}
		}
//END OF CONSTRUCTOR
		public int compareTo (numberRep first, numberRep second)//first is the first numberRep, second is the second numberRep-- This method compares them
		{//BEGINNING OF compareTo METHOD

			/* RETURNS:
				1- if x is greater than y
				-1- if y is greater than x
				0- if they are equal
			*/
			int xLength = first.baseArray.Length;
			int yLength = second.baseArray.Length;
			if (xLength > yLength) {//just by length we know that x is larger in size y---check for negative

				if (first.isNegative == false) {//X is positive ,it doesn't matter here if y is positive or not, x's length is larger and it is positive

					return 1;


				} else {//X is NEGATIVE, it doesnt matter if y is negative or not, Y is smaller in size so even if it is negative, it is still larger than X
				
					return -1;
				
				
				}



			} 
			if (xLength < yLength) {
				if (second.isNegative == false) {//Y is positive ,it doesn't matter here if X is positive or not, Y's length is larger and it is positive

					return -1;


				} else {//Y is NEGATIVE, it doesnt matter if x is negative or not, X is smaller in size so even if it is negative, it is still larger than Y

					return 1;



				} 
			}
			if (xLength == yLength) {//This is the tricky one and must be done carefully. We know in this one that both numbers LENGTHS are the same. Now we much check from right to left if there digits are the same

			
				for (int i = 0; i < first.baseArray.Length; i++) {//go through each array item in both arrays
					if (first.baseArray [i] > second.baseArray [i]) {//first number's i is larger than the second number's i


						//###########################
						//CHECKS SIGN DIFFERENCES
						//###########################
						if (first.isNegative == false) {
							return 1;
						} else {
							return -1;
						}
					}
					if (first.baseArray [i] < second.baseArray [i]) {
						if (second.isNegative == false) {
							return -1;
						} else {
							return 1;
						}
							
					} else {

					}

				}

				if (first.isNegative == true && second.isNegative == true) {
					return 0;
				}
				if (first.isNegative == false && second.isNegative == true) {
					return 1;
				}
				if (first.isNegative == true && second.isNegative == false) {
					return -1;
				} else {
					return 0;
				}
					
			}
			return 0;//they are all the same.

		}
//END OF CompareTo METHOD
		public Boolean GreaterThan (numberRep x, numberRep y)//if compareTo returns 1 then this method returns true
		{
			int j = x.compareTo (x, y);
			if (j == 1) {
				return true;
			}
			if (j == -1) {
				return false;
			} else {
				return false;
			}
		

		}

		public Boolean LessThan (numberRep x, numberRep y)//if compareTo returns -1 then this method returns true
		{
			int j = x.compareTo (x, y);
			if (j == 1) {
				return false;
			}
			if (j == -1) {
				return true;
			} else {
				return false;
			}


		}

		public Boolean EqualTo (numberRep x, numberRep y)//if compareTo returns 0 then this method returns true
		{
			int j = x.compareTo (x, y);
			if (j == 1) {
				return false;
			}
			if (j == -1) {
				return false;
			} else {
				return true;
			}


		}

		public Boolean LessThanOrEqualTo (numberRep x, numberRep y)//if compareTo returns -1 OR 0 this method returns true
		{
			int j = x.compareTo (x, y);
			if (j == 1) {
				return false;
			}
			if (j == -1) {
				return true;
			} else {
				return true;
			}


		}

		public Boolean GreaterThanOrEqualTo (numberRep x, numberRep y)//if compareTo returns 1 or 0 this method returns true
		{
			int j = x.compareTo (x, y);
			if (j == 1) {
				return true;
			}
			if (j == -1) {
				return false;
			} else {
				return true;
			}


		}

		public numberRep Addition (numberRep firstNumberRepToAdd, numberRep SecondNumberRepToAdd)
		{
		
			int firstNumbersLength = firstNumberRepToAdd.baseArray.Length;//get length of x
			int secondNumbersLength = SecondNumberRepToAdd.baseArray.Length;//get length of y
			numberRep placeHolder = new numberRep ();//make a placeholder numberrep
			int largestLength;
			int carryover = 0;
			//finding highest number
			if (firstNumbersLength > secondNumbersLength) {
				largestLength = firstNumbersLength;
			}
			if (firstNumbersLength < secondNumbersLength) {
				largestLength = secondNumbersLength;
			} else {
				largestLength = firstNumbersLength;
			}
			int placeholderlength;
			placeHolder.baseArray = new int[largestLength];//placeholder is used to actually store the SUM of the two numbers, it is of length largestLength to begin with because this is a rough 
			//approximation of how long the sum will be.
			placeholderlength = placeHolder.baseArray.Length;
			int q;
			int p;
			if ((firstNumberRepToAdd.isNegative == false && SecondNumberRepToAdd.isNegative == false) || (firstNumberRepToAdd.isNegative == true && SecondNumberRepToAdd.isNegative == true)) {//both numbers are positive or negative
				//The reason behind grouping them this way is that they both use the same method of addition just different signs which are assigned at the end of this if statement
				while (firstNumbersLength > 0 || secondNumbersLength > 0) {
					//Console.WriteLine(x.baseArray [xLength - 1]);
					//Console.WriteLine(y.baseArray [yLength - 1]);
					//Console.WriteLine (y.negative);
					//try{
					//Console.WriteLine (xLength);
					//Console.WriteLine (yLength);
					if (firstNumbersLength > 0) {
						p = firstNumberRepToAdd.baseArray [firstNumbersLength - 1];
					} else {
						p = 0;
					}
					if (secondNumbersLength > 0) {
						q = SecondNumberRepToAdd.baseArray [secondNumbersLength - 1];
					} else {
						q = 0;
					}
					//Console.WriteLine (p + "<----THIS IS P");
					//Console.WriteLine (q + "<----THIS IS Q");

					//Console.WriteLine (carryover + "<----THIS IS CARRYOVER");
					int placementInt = (p + q + carryover);//the number is a certain row of one variable, plus the number in the same row of the second variable, plus any leftover amount from the previous row
					//carryover is initialized to zero so on the first addition it is zero and can be manipulated from there
					//Console.WriteLine (placementInt+"<--- look at this");
					carryover = 0;
					if (placementInt > 9) {
						while (placementInt > 9)
							placementInt = placementInt - 10;
						carryover++;
					}
					//	Console.WriteLine ("PLACEMENTINT" + placementInt);
					placeHolder.baseArray [placeholderlength - 1] = placementInt;
					firstNumbersLength--;
					secondNumbersLength--;
					placeholderlength--;
					//}
					//catch{
					//}
				}
				if (firstNumbersLength <= 0 && secondNumbersLength <= 0 && carryover != 0) {
					//this if statement functions as so:
					//if the numbers get to the very end and the addition ended up increasing the order of magnitude then this statement increases the size of the array by 1 and inserts the 
					//carryover amount into the farthest left spot
					int[] holder = new int[largestLength + 1];
					for (int h = placeHolder.baseArray.Length - 1; h >= 0; h--) {
						holder [h + 1] = placeHolder.baseArray [h];
					}
					holder [0] = carryover;
					placeHolder.baseArray = holder;
				}

				if (firstNumberRepToAdd.isNegative == true && SecondNumberRepToAdd.isNegative == true) {
					placeHolder.isNegative = true;
				}

				//printBigNum (placeHolder);
			
			}

			if ((firstNumberRepToAdd.isNegative == false && SecondNumberRepToAdd.isNegative == true)) {//these cases are better handled by subtraction(first number positive, second number negative)
				SecondNumberRepToAdd.isNegative = false;
				placeHolder = Subtraction (firstNumberRepToAdd, SecondNumberRepToAdd);
			}
			if (firstNumberRepToAdd.isNegative == true && SecondNumberRepToAdd.isNegative == false) {//these casesare better handled by subtraction(first number negative, second number positive
				firstNumberRepToAdd.isNegative = true;
				placeHolder = Subtraction (SecondNumberRepToAdd, firstNumberRepToAdd);
			}

			return placeHolder;


		
		
		}

		public void printBigNum (numberRep VarNumberRep)//simply travels through the array, element by element printing the whole array
		{
			if (VarNumberRep.isNegative == false) {
				for (int u = 0; u < VarNumberRep.baseArray.Length; u++) {
					Console.Write (VarNumberRep.baseArray [u]);
				}

			} else {
				Console.Write ("-");
				for (int u = 0; u < VarNumberRep.baseArray.Length; u++) {
					Console.Write (VarNumberRep.baseArray [u]);
				}
			}



		}

		public numberRep  Subtraction (numberRep FirstNumberToSubtract, numberRep SecondNumberToSubtract)
		{
			int FirstLength = FirstNumberToSubtract.baseArray.Length;//get length of x
			int SecondLength = SecondNumberToSubtract.baseArray.Length;//get length of y
			numberRep placeHolder = new numberRep ();//make a placeholder numberrep
			int largest;
			//int carryover=0;
			//finding highest number
			if (FirstLength > SecondLength) {
				largest = FirstLength;
			}
			if (FirstLength < SecondLength) {
				largest = SecondLength;
			} else {
				largest = FirstLength;
			}
			int placeholderlength;
			placeHolder.baseArray = new int[largest];
			placeholderlength = placeHolder.baseArray.Length;

			//This process goes through all the possible combinations of positive and negative numbers and has a solution for all of them

			if (FirstNumberToSubtract.isNegative == false && SecondNumberToSubtract.isNegative == true) {//first number positive, second number negative, change sign of second number and add them
				SecondNumberToSubtract.isNegative = false;
				return placeHolder = Addition (FirstNumberToSubtract, SecondNumberToSubtract);


			}
			if (FirstNumberToSubtract.isNegative == true && SecondNumberToSubtract.isNegative == false) {//first number negative, second number positive, change sign of second one and add them
				SecondNumberToSubtract.isNegative = true;
				return placeHolder = Addition (FirstNumberToSubtract, SecondNumberToSubtract);
			}
			if (FirstNumberToSubtract.isNegative == false && SecondNumberToSubtract.isNegative == false) {//both positive, this a bit tricky
				if (placeHolder.compareTo (FirstNumberToSubtract, SecondNumberToSubtract) == -1) {//first is smaller than second

					placeHolder = Subtraction (SecondNumberToSubtract, FirstNumberToSubtract);//take difference of second and first and make the result negative
					placeHolder.isNegative = true;
					return  placeHolder;
				}
				if (placeHolder.compareTo (FirstNumberToSubtract, SecondNumberToSubtract) == 0) {//the two numbers are equal, placeholder is initalized to zero so just return placeholder
					return placeHolder;
				} else {//compareTo would return 1 i.e. the first number is bigger.
					while (FirstLength > 0 || SecondLength > 0) {//atleast one of the numbers still hasnt gone through all its rows.
						if (FirstLength > 0 && SecondLength > 0) {//both have not gone through there rows


							//this part essentially does basic subtraction and if it can't be done does the rule of taking 1 off of the number to the left and adding 10 to the number to the right
							if ((FirstNumberToSubtract.baseArray [FirstLength - 1] - SecondNumberToSubtract.baseArray [SecondLength - 1]) > 0) {
								placeHolder.baseArray [placeholderlength - 1] = (FirstNumberToSubtract.baseArray [FirstLength - 1] - SecondNumberToSubtract.baseArray [SecondLength - 1]);
							}
							if ((FirstNumberToSubtract.baseArray [FirstLength - 1] - SecondNumberToSubtract.baseArray [SecondLength - 1]) < 0) {
								FirstNumberToSubtract.baseArray [FirstLength - 2] = (FirstNumberToSubtract.baseArray [FirstLength - 2]) - 1;
								FirstNumberToSubtract.baseArray [FirstLength - 1] = (FirstNumberToSubtract.baseArray [FirstLength - 1]) + 10;
								placeHolder.baseArray [placeholderlength - 1] = (FirstNumberToSubtract.baseArray [FirstLength - 1] - SecondNumberToSubtract.baseArray [SecondLength - 1]);
							}
				
						} else {
							placeHolder.baseArray [placeholderlength - 1] = FirstNumberToSubtract.baseArray [FirstLength - 1];//since there is nothing left in the second number, the first number's rows are just brought down
						}
						//decrementation
						FirstLength--;
						SecondLength--;
						placeholderlength--;
					}

				}
			
			}
			if (FirstNumberToSubtract.isNegative == true && SecondNumberToSubtract.isNegative == true) {//since both signs are the same, they behave just like the positive numbers do except that the answer is opposite
				SecondNumberToSubtract.isNegative = false;
				FirstNumberToSubtract.isNegative = false;
				placeHolder = Subtraction (FirstNumberToSubtract, SecondNumberToSubtract);//it just takes the positive versions of the numbers and runs them through subtraction again

				if (FirstNumberToSubtract.compareTo (FirstNumberToSubtract, SecondNumberToSubtract) == 1) {//the end result is negative
					placeHolder.isNegative = true;
				} else {//the end result is positive
					placeHolder.isNegative = false;
				}
				return placeHolder;

			}




			//printBigNum (placeHolder);



		

			return placeHolder;




		}

		public numberRep Multiplication (numberRep FirstNumberToBeMulti, numberRep SecondNumberToBeMulti)//completes multiplcation the way a normal person would do
		{
			int p = FirstNumberToBeMulti.baseArray.Length * SecondNumberToBeMulti.baseArray.Length;//This variable is the total of the lengths of x and y arrays
			//makes an array of p's length
			List<int[]> listOfNumbersToBeAddedTogether = new List<int[]> ();// this will be a list of int []'s
			int xLength = FirstNumberToBeMulti.baseArray.Length;
			int overflow = 0;
			int yLength = SecondNumberToBeMulti.baseArray.Length;
			int incrementzeros = 0;
			for (int u = yLength - 1; u >= 0; u--) {
				int[] k = new int[p];//creates an array to hold the values to be added later

				for (int v = xLength - 1; v >= 0; v--) {
					//Console.WriteLine (u+" x value");
					//Console.WriteLine (v+" y value");

					int j = FirstNumberToBeMulti.baseArray [v] * SecondNumberToBeMulti.baseArray [u]+overflow;//the number in row 'v' of number 1, and the number in row 'u' of number 2, multiplied, 
					//and add overflow from previous row if needed(overflow is initalized to zero)
					overflow = 0;
					if (j > 9) {
						while (j > 9) {
							j = j - 10;
							overflow++;
						}
					}

					k [p - 1-incrementzeros] = j;//this does the trip of keeping up with zeros that should be to the right of the number.
					p--;
				}

				listOfNumbersToBeAddedTogether.Add (k);
				p = FirstNumberToBeMulti.baseArray.Length * SecondNumberToBeMulti.baseArray.Length;
				incrementzeros++;




			}
			numberRep FPlaceholder = new numberRep ();//first number to be added together to get the product
			FPlaceholder.baseArray = listOfNumbersToBeAddedTogether [0];//it is the first number in the list
			numberRep SPlaceholder = new numberRep ();//this number changes as the for loop continues, but it goes through all the numbers in the list
			for (int i = 1; i < listOfNumbersToBeAddedTogether.Count; i++) {//
				SPlaceholder.baseArray = listOfNumbersToBeAddedTogether [i];
				FPlaceholder = Addition (FPlaceholder, SPlaceholder);//the first number is equal to itself, plus the next number in line, and the next number, and the next number... so on and so worth

			}
			if((FirstNumberToBeMulti.isNegative==true&&SecondNumberToBeMulti.isNegative==false)||(FirstNumberToBeMulti.isNegative==false && SecondNumberToBeMulti.isNegative==true)){
				//these are the conditions that would need to be present to make the product negative
				FPlaceholder.isNegative = true;
			}
			//otherwise it is positive
			GetRidOfZeros (FPlaceholder);//the way space was allocated for the product, it left a huge amount of zeros to the left of the number, this method gets rid of those zeros
				return FPlaceholder;


			//THIS IS THE OLD METHOD I USED THAT STRICTLY USED ADDITION
			/*	int[] u = new int[1];
			int[] v = new int[1];
			int[] w = new int[1];

			numberRep storage = new numberRep ();
			storage.baseArray = w;
			storage.baseArray [0] = 0;
			numberRep counter = new numberRep ();//for counting number of repetitions
			counter.baseArray =u;
			counter.baseArray [0] = 0;
			numberRep increment = new numberRep ();//for incrementing number of repetitions
			increment.baseArray=v;
			increment.baseArray [0] = 1;


			if (x.negative == false && y.negative == false) {//both numbers are positive
				while (compareTo (counter, y) != 0) {
					storage = Addition (storage, x);
					counter = Addition (counter, increment);
				}

			}
			if (x.negative == true && y.negative == true) {//both numbers are negative
				x.negative = false;
				y.negative = false;
				while (compareTo (counter, y) != 0) {
					storage = Addition (storage, x);
					counter = Addition (counter, increment);
				}

			}
			if (x.negative == true && y.negative == false) {//first number is negative && second number is positive
				x.negative = false;

				while (compareTo (counter, y) != 0) {
					storage = Addition (storage, x);
					counter = Addition (counter, increment);
				}
				storage.negative = true;
			}
			if (x.negative == false && y.negative == true) {//first number is positive && second number is negative
				y.negative = false;

				while (compareTo (counter, y) != 0) {
					storage = Addition (storage, x);
					counter = Addition (counter, increment);
				}
				storage.negative = true;
			}

			return storage;*/
		}

		/*	public numberRep Division (numberRep x, numberRep y)
		{

	


		}*/
		public numberRep GetRidOfZeros(numberRep x){
			while(x.baseArray[0]==0&&x.baseArray.Length>1){
				int[] p = new int[x.baseArray.Length-1];
				for (int k = 0; k < p.Length; k++) {
					p [k] = x.baseArray [k + 1];
				}
				x.baseArray = p;

		}
			return x;
	}
}
}
