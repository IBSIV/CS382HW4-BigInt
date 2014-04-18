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
			Console.ReadLine ();






		}
	}
	public class numberRep
	{
		int [] baseArray;

		public numberRep(string inputStream){
			baseArray = new int[inputStream.Length-1];
			for (int i = 0; i < inputStream.Length; i++) {
				baseArray [i] = ((int)inputStream[i]-48);
				if(baseArray[i]<0||baseArray[i]>10){
					Console.WriteLine((char)(baseArray[i]+48)+" is not a number from 0-9, terminating program");
					break;
				}
				//	Console.WriteLine (baseArray [i] + "\n");
			}
		}

		/*public numberRep addition(numberRep first, numberRep second){

			int secondcounter = second.baseArray.Length;
			int[] placeholder;


			for (int j = first.baseArray.Length - 1; j >= 0; j--) {

			}
		}*/
		public int compareTo(numberRep first, numberRep second){
			int x = first.baseArray.Length;
			int y = second.baseArray.Length;
			if (x > y) {
				return 1;
			} else if (x < y) {
				return -1;
			} else {
				return 0;
			}

		}


	}
}