﻿using System;

namespace OperatorsApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//int x = 5;
			//int y = 5;
			//int a = x++;
			//int b = ++y;
			/*r (int i = 1; i <= 5; i++) 
			{
				Console.WriteLine(i);
			}
			var c = 5 / 2;
			var d = 5.0 / 2;
			var e = 5 / 3;
			double f = 5 / 2;
			
			var a = 5 % 2;
			var daysInWeek = 7;
			var totalDaysToBirthday = 23;
			var weeksToBirthday = totalDaysToBirthday / daysInWeek;
			var days = totalDaysToBirthday % daysInWeek;
			var res = EvenOdd(23);
			*/
			const int NUM_ROWS = 2;
			const int NUM_COLS = 5;
			bool running = true;
			int row = 0;
			int col = 0;
			int spriteNo = -1;
			/*
			while (running)
			{
				spriteNo = ++spriteNo % (NUM_ROWS * NUM_COLS);
				row = spriteNo / NUM_COLS;
				col = spriteNo % NUM_COLS;
			}
			*/
			int mark = 86;
				var grade = mark >= 65 ? (mark>= 85 ? "Distinction" : "Pass") : "Fail";
			//shorthand way of creating an if statement
			var message = Priority(2);
		}
		public static bool EvenOdd(int num)
		{
			return num % 2 == 0;
		}
		public static string Priority(int level)
		{
			string priority = "Code";
			switch (level)
			{
				case 3:
					priority = priority + "Red";
					break;
				case 2:
				case 1:
					priority = priority + "Amber";
					break;
				case 0:
					priority = priority + "Green";
					break;
				default:
					priority = "Error";
					break;


			}
			return priority;
		}
	}
}
