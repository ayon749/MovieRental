using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Book> books = new List<Book>
			{
				new Book{Author="Humayan", name="Moyurakkhi", published=new DateTime(1995,1,12)},
				new Book{Author="Humayan", name="Himu", published=new DateTime(1997,1,12)},
				new Book{Author="Jafor", name="dfgfds", published=new DateTime(1999,1,12)}

			};
			var selected = books.Find(book => book.published > (new DateTime(1995, 1, 12)));
			Console.WriteLine(selected.Author);
			Console.ReadKey();
		}
	}
}
