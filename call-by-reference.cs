using System;
namespace CallByReference{
	public class NumberManifulator{
		
		public void Swap(ref int a, ref int b){
			int temp;
			temp = a;
			a = b;
			b = temp;
			
		}		
		
		public static void Main(string[] args){
			NumberManifulator n = new NumberManifulator();
			int num1, num2;
			num1 = 10;
			num2 = 20;
			Console.WriteLine("Before swapping: {0}, {1}", num1, num2);
			n.Swap(ref num1, ref num2);
			
			Console.WriteLine("After swapping: {0}, {1}", num1, num2);
		}
	}
}

