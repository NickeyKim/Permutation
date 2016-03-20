using System;
using System.Text;


namespace Permutation
{
	public class Permutations
	{
		/*if passed the last position,
		 * 	print String
		 * 	return
		 *for each character in the string
		 *	if it was used, move on next char
		 *	input the char to current position
		 *		mark the char used
		 *		CurPos+1, recursion to the rest,
		 *      mark the char unused
		 */
		private Boolean[] used;   //in order to mark if used or unused
		private StringBuilder StrOut = new StringBuilder();
		private string StrIn;

		public Permutations (string str){
			StrIn = str;
			used = new Boolean[ StrIn.Length];
		}
		public void Permute()
		{
			if (StrOut.Length == StrIn.Length) 
			{
				Console.WriteLine (StrOut);
				return;
			}
			for(int i = 0; i < StrIn.Length; ++i)
			{
				if (used [i]) continue;
				StrOut.Append (StrIn [i]);
				used [i] = true;                             //marking it used-true
				Permute ();
				used [i] = false;
				StrOut.Remove (StrOut.Length-1, 1);
			}
		}


		public static void Main (string[] args)
		{
			Permutations Perm = new Permutations ("abcde");
			Perm.Permute ();

			Console.WriteLine ("Hello World!");
		}
	}
}
