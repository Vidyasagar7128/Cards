using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
    class DistributeCards
    {
		public static String[,] cardDistribute()
		{
			String[,] arr = new String[4,13];
			cardInsert(arr);
			cardShuffle(arr);

			String[,] playercard = new String[4,9];
			for (int i = 0; i < playercard.Length; i++)
			{
				for (int j = 0; j < playercard[i,0].Length; j++)
				{
					playercard[i,j] = arr[i,j];
				}
			}
			return playercard;
		}
		private static void cardInsert(String[,] arr)
		{
			// TODO Auto-generated method stub
			String[] Suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
			String[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i,0].Length; j++)
				{
					arr[i,j] = Suits[i] + " " + Rank[j];
				}
			}
		}
		private static void cardShuffle(String[,] arr)
		{
			// TODO Auto-generated method stub
			Random r1 = new Random();
			for (int i = 0; i < 150; i++)
			{
				//int x1 = r1.nextInt(4);
				//int x2 = r1.nextInt(13);
				//int x3 = r1.nextInt(4);
				//int x4 = r1.nextInt(13);
				//swap(arr, x1, x2, x3, x4);

			}
		}
	}
}
