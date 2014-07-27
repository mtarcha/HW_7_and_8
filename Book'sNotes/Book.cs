using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksNotes_
{
    class Book
    {
        private string _name;
        private List<Note> _booksNotes;

        public override string ToString()
        {
            string result = "_name:\n";
            foreach (Note item in _booksNotes)
            {
                result += item.Page + "," + item.Notes + ";\n";
            }
            return result;
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name=value;
            }
        }
        public List<Note> BooksNotes
        {
            get
            {
                return _booksNotes;
            }
            set
            {
                _booksNotes.AddRange(value);
            }
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
            public string Notes
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

        
    }
}
