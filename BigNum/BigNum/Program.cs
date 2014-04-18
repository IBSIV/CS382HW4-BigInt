/*
 * Things that must be accomplished:
 * This project but use an array to store numbers. This is the simpliest way to do it.
 * There must be a boolean value that allows for negative numbers.
 * There must be a way to compare to the two numbers in the following ways:
 * 		-Greater than
 * 		-Greater than or equal to
 * 		-Less than
 * 		-Less than or equal to
 * 		-Equal
 * It must implement the following operations
 * 		-Addition
 * 		-Subtraction
 * 		-Multiplication
 * 		-Division
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * */






using System;
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
			number=Console.ReadLine ();
			numberRep First=new numberRep (number);
			Console.WriteLine ("Please input another number:\n");
			secondNum=Console.ReadLine ();
			numberRep Second = new numberRep (secondNum);
			//Console.WriteLine (Second.baseArray.Length+"\n\n");


			//Console.WriteLine (Second.negative);

			//First.printBigNum (Second);
			First.Addition (First, Second);

			Console.ReadLine ();






		}
	}
	public class numberRep
	{
		public int [] baseArray{ get; set; }
		public Boolean negative{ get; set; }
		public numberRep(){
		}

		public numberRep(string inputStream){//BEGINNING OF CONSTRUCTOR
			if (inputStream [0] == '-') {
				Console.WriteLine("got here, it sees negatives");
				negative = true;
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
			if (negative == false) {
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
				baseArray = new int[inputStream.Length-1];
				for (int i = 0; i < inputStream.Length-1; i++) {
					baseArray [i] = ((int)inputStream [i+1] - 48);
					if (baseArray [i] < 0 || baseArray [i] > 10) {
						Console.WriteLine ((char)(baseArray [i] + 48) + " is not a number from 0-9, terminating program");
						break;
					}

			
			}
		}
		}//END OF CONSTRUCTOR




	
		public int compareTo(numberRep first, numberRep second){//BEGINING OF compareTo METHOD

			/* RETURNS:
				1- if x is greater than y
				-1- if y is greater than x
				0- if they are equal
			*/
			int x = first.baseArray.Length;
			int y = second.baseArray.Length;
			if (x > y ) {//just by length we know that x is larger in size y---check for negative

				if (first.negative == false) {//X is positive ,it doesn't matter here if y is positive or not, x's length is larger and it is positive

						return 1;


				} 
				else{//X is NEGATIVE, it doesnt matter if y is negative or not, Y is smaller in size so even if it is negative, it is still larger than X
				
					return -1;
				
				
				}



			} 
			if (x < y) {
				if (second.negative == false) {//Y is positive ,it doesn't matter here if X is positive or not, Y's length is larger and it is positive

					return -1;


				} else {//Y is NEGATIVE, it doesnt matter if x is negative or not, X is smaller in size so even if it is negative, it is still larger than Y

					return 1;



				} 
			}
				if(x==y) {//This is the tricky one and must be done carefully. We know in this one that both numbers LENGTHS are the same. Now we much check from right to left if there digits are the same

			
					for (int i = 0; i < first.baseArray.Length; i++) {//go through each array item in both arrays
					if (first.baseArray [i] > second.baseArray [i]) {//first number's i is larger than the second number's i


						//###########################
						//CHECKS SIGN DIFFERENCES
						//###########################
						if(first.negative==false){
							return 1;
						}
							else{
								return -1;
							}
						}
						if (first.baseArray [i] < second.baseArray [i]) {
						if(second.negative==false){
							return -1;
						}
						else{
							return 1;
						}
							
						} else {

						}

					}

				if (first.negative == true&& second.negative== true) {
					return 0;
				}
				if (first.negative == false && second.negative == true) {
					return 1;
				}
				if (first.negative == true && second.negative == false) {
					return -1;
				} else {
					return 0;
				}
					
			}
				return 0;//they are all the same.

		}//END OF CompareTo METHOD


		public Boolean GreaterThan(numberRep x, numberRep y){
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

		public Boolean LessThan(numberRep x, numberRep y){
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
		public Boolean EqualTo(numberRep x, numberRep y){
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
		public Boolean LessThanOrEqualTo(numberRep x, numberRep y){
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
		public Boolean GreaterThanOrEqualTo(numberRep x, numberRep y){
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

		public /*numberRep*/ void Addition(numberRep x, numberRep y){
		
			int xLength = x.baseArray.Length;
			int yLength = y.baseArray.Length;
			numberRep placeHolder = new numberRep ();
			int largest;
			int carryover=0;
			if (xLength > yLength) {
				largest = xLength;
			}
			if (xLength < yLength) {
				largest = yLength;
			} else {
				largest = xLength;
			}
			int placeholderlength;
			placeHolder.baseArray= new int[largest];
			placeholderlength = placeHolder.baseArray.Length;
			int q;
			int p;
			if((x.negative==false&&y.negative==false)||(x.negative==true&&y.negative==true)){
				while (xLength > 0 || yLength > 0) {
					//try{
					Console.WriteLine (xLength);
					Console.WriteLine (yLength);
					if (xLength > 0) {
						 p = x.baseArray [xLength - 1];
					} else {
						 p = 0;
					}
					if (yLength > 0) {
						 q = y.baseArray [yLength - 1];
					} else {
						 q = 0;
					}
					Console.WriteLine (p + "<----THIS IS P");
					Console.WriteLine (q + "<----THIS IS Q");

					Console.WriteLine (carryover + "<----THIS IS CARRYOVER");
					int placementInt=(p + q+carryover);
					Console.WriteLine (placementInt+"<--- look at this");
					carryover = 0;
					if (placementInt > 9) {
						while (placementInt > 9)
							placementInt = placementInt - 10;
						    carryover++;
					}
					
					placeHolder.baseArray [placeholderlength - 1] = placementInt;
					xLength--;
					yLength--;
					placeholderlength--;
					//}
					//catch{
					//}
				}
				if (x.negative == true && y.negative == true) {
					placeHolder.negative = true;
				}
				printBigNum (placeHolder);
			
			}



		
		
		}
		public void printBigNum(numberRep x){
			if (x.negative == false) {
				for (int u = 0; u < x.baseArray.Length; u++) {
					Console.Write (x.baseArray [u]);
				}

			}
			else{
				Console.Write ("-");
				for (int u = 0; u < x.baseArray.Length; u++) {
					Console.Write (x.baseArray [u]);
				}
			}



		}

		public /*numberRep*/ void Subtraction(numberRep x, numberRep y){




		}
		public /*numberRep*/ void Multiplication(numberRep x, numberRep y){




		}
		public /*numberRep*/ void Division(numberRep x, numberRep y){




		}
}
}
