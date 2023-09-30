using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.DataVisualization.Charting;

namespace Chart.Code
{
    public class Item : Notifier, System.Windows.Controls.DataVisualization.Charting.ISeries
    {
        private ObservableCollection<object> _legendItems;
        public ObservableCollection<object> LegendItems
        {
            get
            {
                return _legendItems;
            }
            set
            {
                _legendItems = value;
                OnPropertyChanged("LegendItems");
            }
        }

        private ISeriesHost _seriesHost;
        public ISeriesHost SeriesHost {
            get {
                return _seriesHost;
            }
            set {
                _seriesHost = value;
                OnPropertyChanged("SeriesHost");
            }
        }

        private string _col;
        public string Col
        {
            get
            {
                return _col;
            }
            set
            {
                _col = value;
                OnPropertyChanged("Col");
            }
        }

        private int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public Item()
        {
            SeriesHost = new SeriesHost();
        }

        public Item(SeriesHost seriesHost)
        {
            this.SeriesHost = seriesHost;
        }
    }
}
