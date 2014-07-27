using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    class Article
    {
        private string _name;
        private string _baseStore;
        private double _price;

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
        public string BaseSrore
        {
            get
            {
                return _baseStore;
            }
            set
            {
                _baseStore = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public Article(string Name,string BaseStore,double Price)
        {
            _name = Name;
            _baseStore = BaseSrore;
            _price = Price;
        }


        public override string ToString()
        {
            return "Name: "+_name+"\nStore:"+_baseStore+"\nPrice: "+_price.ToString();
        }


    }

}
