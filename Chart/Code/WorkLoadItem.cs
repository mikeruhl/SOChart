using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Code
{
     public class WorkLoadItem: Notifier
     {
        private string _month;
        public string Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
                OnPropertyChanged("Month");
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
    }
}
