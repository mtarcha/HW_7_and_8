using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    class Store
    {
        private List<Article> _products;
        private Article _newProduct;
        public Store()
        {
            _products = new List<Article>();
        }
        public Article AddProduct
        {
            set
            {
                _newProduct = value;
                _products.Add(_newProduct);
            }
        }

        public string this[int i]
        {
            get
            {
                if (i < _products.Count)
                {
                    return _products[i].ToString();
                }
                else
                {
                    return "Here isn't this product";
                }
            }
        }
        public string this[string name]
        {
            get
            {

                for (int i = 0; i < _products.Count; i++)
                {
                    if (_products[i].Name == name)
                        return _products[i].ToString(); 
                }
                return "Here isn't this product";
            }
        }
    }
}
