using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart
{
    public class ChartDataMVVM: Notifier
    {
        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public ChartDataMVVM()
        {
            Items = new ObservableCollection<Item>();

            Item item = new Item { Col = "Col1", Value = 23033 };
            Item item2 = new Item { Col = "Col2", Value = 177004 };
            Item item3 = new Item { Col = "Col3", Value = 145332 };

            Items.Add(item);
            Items.Add(item2);
            Items.Add(item3);
        }
    }
}
