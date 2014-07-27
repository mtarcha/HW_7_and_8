using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class BookNotes
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public List<Note> _booksNotes;

        public List<Note> booksNotes
        {
            get
            {
                return _booksNotes;
            }

        }

        public BookNotes()
        {
            _name = "";
            _booksNotes = new List<Note>();
        }

        public class Note
        {
            private int _page;
            private string _notes;

            public int Page
            {
                get
                {
                    return _page;
                }
                set
                {
                    _page = value;
                }
            }
            public string AddNote
            {
                get
                {
                    return _notes;
                }
                set
                {
                    _notes = value;
                }
            }

        }

        public override string ToString()
        {
            string result = "The book's name: " + _name.ToString() + "\n";
            foreach (Note item in _booksNotes)
            {
                result += "Page" + item.Page + ": \n" + item.AddNote + ";\n";
            }
            return result;
        }

    }
}
