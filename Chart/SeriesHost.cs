using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.DataVisualization.Charting;

namespace Chart
{
    public class SeriesHost : Notifier, ISeriesHost
    {
        public ObservableCollection<IAxis> Axes => throw new NotImplementedException();

        public ObservableCollection<ISeries> Series => throw new NotImplementedException();

        public ObservableCollection<UIElement> ForegroundElements => throw new NotImplementedException();

        public ObservableCollection<UIElement> BackgroundElements => throw new NotImplementedException();

        ISeriesHost IRequireSeriesHost.SeriesHost { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public event EventHandler ResourceDictionariesChanged;

        public IEnumerator<ResourceDictionary> GetResourceDictionariesWhere(Func<ResourceDictionary, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
