using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            BookNotes myBook = new BookNotes();
            myBook.Name = "Cloud";

            BookNotes.Note cloudNote_1 = new BookNotes.Note();
            cloudNote_1.Page = 1;
            cloudNote_1.AddNote = "It is the first note";
            BookNotes.Note cloudNote_2 = new BookNotes.Note();
            cloudNote_2.Page = 2;
            cloudNote_2.AddNote = "It is the second note";
            
            myBook._booksNotes.Add(cloudNote_1);
            myBook._booksNotes.Add(cloudNote_2);

            Console.WriteLine(myBook);

            Console.ReadLine();
        }

    }
}
