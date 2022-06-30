using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Magazyn.Model
{
    public class Rack : INotifyPropertyChanged
    {
        private int _id;
        private int _width;
        private int _height;
        private int _depth;
        private int _capacity;
        private int _maxLoad;
        private int _currentWeight;


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
        public int Width
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
        public int Height
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
        public int Depth
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
        public int Capacity
        {
            get
            {
                _capacity = Width + Height + Depth;
                return _capacity;
            }
            set
            {
                if (_capacity != value)
                {
                    _capacity = Width + Height + Depth;
                    OnPropertyChanged(nameof(Capacity));
                }
            }
        }
        public int CurrentWeight
        {
            get
            {
                var x = 0;
                foreach (Item element in ItemsList)
                {
                    x += (int)Math.Round(element.Weight);
                }
                return x;
            }
            set
            {
                if (_currentWeight != value)
                {
                    _currentWeight = value;
                    OnPropertyChanged(nameof(MaxLoad));
                }
            }
        }
        public int MaxLoad
        {
            get { return _maxLoad; }
            set
            {
                if (_maxLoad != value)
                {
                    _maxLoad = value;
                    OnPropertyChanged(nameof(MaxLoad));
                }
            }
        }
        public ObservableCollection<Item> ItemsList = new ObservableCollection<Item>();





        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }


        //private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    switch (e.PropertyName)
        //    {
        //        case "Weight":
        //            var x = 0;
        //            foreach (Item element in ItemsList)
        //            {
        //                x += Decimal.ToInt32(element.Weight);
        //            }
        //            CurrentWeight = x;
        //            break;
        //    }

    }
}
