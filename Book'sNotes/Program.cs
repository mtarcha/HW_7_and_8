using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksNotes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Name = "Cloud";
            Book.Note cloudNote_1 = new Book.Note();
            cloudNote_1.Page = 1;
            cloudNote_1.Notes = "it is first note";
            Book.Note cloudNote_2 = new Book.Note();
            cloudNote_2.Page = 2;
            cloudNote_2.Notes = "it is second note";
            List<Book.Note> cloudNotes=new List<Book.Note>();
            cloudNotes.Add(cloudNote_1);
            cloudNotes.Add(cloudNote_2);
            myBook.BooksNotes = cloudNotes;
            Console.WriteLine(myBook);
            
        }
    }
}
