using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrar
{
	class Program
	{
		static void Main(string[] args)
		{

			int n, m;
			n = Convert.ToInt32(Console.Read());
			m= Convert.ToInt32(Console.Read());
			List<int> lists = new List<int>();
			for(int i = 0; i < n; i++)
			{
				int temp;
				temp= Convert.ToInt32(Console.Read());
				lists.Add(temp);
			}
			for(int i = 0; i < n; i++)
			{
				Console.Write(lists[i]);
				Console.Write(" ");

			}
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
