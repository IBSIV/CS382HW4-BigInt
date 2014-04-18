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
 * 		-Addition--method head made--DONE for cases of BOTH positive or BOTH negative
 * 		-Subtraction--method head made
 * 		-Multiplication--method head made
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
			numberRep k=First.Subtraction(First, Second);
			First.printBigNum (k);

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

		public numberRep Addition(numberRep x, numberRep y){
		
			int xLength = x.baseArray.Length;//get length of x
			int yLength = y.baseArray.Length;//get length of y
			numberRep placeHolder = new numberRep ();//make a placeholder numberrep
			int largest;
			int carryover=0;
			//finding highest number
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
					//Console.WriteLine(x.baseArray [xLength - 1]);
					//Console.WriteLine(y.baseArray [yLength - 1]);
					//Console.WriteLine (y.negative);
					//try{
					//Console.WriteLine (xLength);
					//Console.WriteLine (yLength);
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
					//Console.WriteLine (p + "<----THIS IS P");
					//Console.WriteLine (q + "<----THIS IS Q");

					//Console.WriteLine (carryover + "<----THIS IS CARRYOVER");
					int placementInt=(p + q+carryover);
					//Console.WriteLine (placementInt+"<--- look at this");
					carryover = 0;
					if (placementInt > 9) {
						while (placementInt > 9)
							placementInt = placementInt - 10;
						    carryover++;
					}
					Console.WriteLine ("PLACEMENTINT" + placementInt);
					placeHolder.baseArray [placeholderlength - 1] = placementInt;
					xLength--;
					yLength--;
					placeholderlength--;
					//}
					//catch{
					//}
				}
				if (xLength <= 0 && yLength <= 0 && carryover!=0) {
					int[] holder = new int[largest + 1];
					for (int h = placeHolder.baseArray.Length - 1; h >= 0; h--) {
						holder [h+1] = placeHolder.baseArray [h];
					}
					holder [0] = carryover;
					placeHolder.baseArray = holder;
				}

				if (x.negative == true && y.negative == true) {
					placeHolder.negative = true;
				}

				//printBigNum (placeHolder);
			
			}

			if((x.negative==false &&y.negative==true)){
				y.negative = false;
				placeHolder=Subtraction (x, y);
			}
			if (x.negative == true && y.negative == false) {
				x.negative = true;
				placeHolder = Subtraction (y, x);
			}

			return placeHolder;


		
		
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

		public numberRep  Subtraction(numberRep x, numberRep y){
			int xLength = x.baseArray.Length;//get length of x
			int yLength = y.baseArray.Length;//get length of y
			numberRep placeHolder = new numberRep ();//make a placeholder numberrep
			int largest;
			//int carryover=0;
			//finding highest number
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

			if (x.negative == false && y.negative == true) {
				y.negative = false;
				return placeHolder=Addition (x, y);


			}
			if (x.negative == true && y.negative == false) {
				y.negative = true;
				return placeHolder = Addition (x, y);
			}
			if (x.negative == false && y.negative == false) {
				if (placeHolder.compareTo (x, y) == -1) {

					placeHolder=Subtraction (y, x);
					placeHolder.negative = true;
					return  placeHolder;
				}
				if (placeHolder.compareTo (x, y) == 0) {
					return placeHolder;
				} else {//compareTo would return 1 i.e. the first number is bigger.
					while (xLength > 0 || yLength > 0) {
						if (xLength > 0 && yLength > 0) {
							if ((x.baseArray[xLength - 1] - y.baseArray [yLength-1]) > 0) {
								 placeHolder.baseArray [placeholderlength - 1] = (x.baseArray [xLength - 1] - y.baseArray [yLength-1]);
							}
							if ((x.baseArray [xLength - 1] - y.baseArray [yLength-1]) < 0) {
								x.baseArray [xLength - 2] = (x.baseArray [xLength - 2]) - 1;
								x.baseArray [xLength - 1] = (x.baseArray [xLength - 1]) + 10;
								placeHolder.baseArray [placeholderlength - 1] = (x.baseArray [xLength - 1] - y.baseArray [yLength-1]);
							}
				
						} else {
							placeHolder.baseArray [placeholderlength - 1] = x.baseArray [xLength - 1];
						}
						xLength--;
						yLength--;
						placeholderlength--;
					}

				}
			
			}
			if (x.negative == true && y.negative == true) {
				y.negative = false;
				x.negative = false;
				placeHolder=Subtraction (x, y);
				if (x.compareTo (x, y) == 1) {
					placeHolder.negative = true;
				} else {
					placeHolder.negative = false;
				}
				return placeHolder;

			}




				//printBigNum (placeHolder);



		

			return placeHolder;




		}
		public /*numberRep*/ void Multiplication(numberRep x, numberRep y){




		}
		public /*numberRep*/ void Division(numberRep x, numberRep y){




		}
}
}
