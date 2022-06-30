using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Model
{
    public class Item : INotifyPropertyChanged
    {
        private string _name;
        private string _category;
        private float _width;
        private float _height;
        private float _depth;
        private float _weight;
        private int _quantity;
        private string _description;
        private int _id;
        private int _shelfID;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Category
        {
            get { return _category; }
            set
            {
                if (_category != value)
                {
                    _category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }
        public float Width
        {
            get { return _width; }
            set
            {
                if (_width != value)
                {
                    _width = value;
                    OnPropertyChanged(nameof(Width));
                }
            }
        }
        public float Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }
        public float Depth
        {
            get { return _depth; }
            set
            {
                if (_depth != value)
                {
                    _depth = value;
                    OnPropertyChanged(nameof(Depth));
                }
            }
        }
        public float Weight
        {
            get { return _weight; }
            set
            {
                if (_weight != value)
                {
                    _weight = value;

                    OnPropertyChanged(nameof(Weight));

                }
            }
        }
        public int Quantity { get { return _quantity; } set {if (_quantity != value)
                    _quantity = value;
                OnPropertyChanged(nameof(Quantity));
        
                    } }


        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }
        public int ShelfID
        {
            get { return _shelfID; }
            set
            {
                if (_shelfID != value)
                {
                    _shelfID = value;
                    OnPropertyChanged(nameof(ShelfID));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void ChangeName(string input)
        {
            Name = input;
        }
        public void ChangeCategory(string input)
        {
            Category = input;
        }
        public void ChangeWidth(float input)
        {
            Width = input;
        }
        public void ChangeHeight(float input)
        {
            Height = input;
        }
        public void ChangeDepth(float input)
        {
            Depth = input;
        }
        public void ChangeDesc(string input)
        {
            Description = input;
        }
        private void OnPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }

}
