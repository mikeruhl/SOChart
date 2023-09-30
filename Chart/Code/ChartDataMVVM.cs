using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Code
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

        private ObservableCollection<WorkLoadItem> _realWorkloadItems;
        public ObservableCollection<WorkLoadItem> RealWorkloadItems
        {
            get
            {
                return _realWorkloadItems;
            }
            set
            {
                _realWorkloadItems = value;
                OnPropertyChanged("WorkloadItems");
            }
        }

        private ObservableCollection<WorkLoadItem> _plannedWorkloadItems;
        public ObservableCollection<WorkLoadItem> PlannedWorkloadItems
        {
            get
            {
                return _plannedWorkloadItems;
            }
            set
            {
                _plannedWorkloadItems = value;
                OnPropertyChanged("PlannedWorkloadItems");
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

            RealWorkloadItems = new ObservableCollection<WorkLoadItem>();

            WorkLoadItem january = new WorkLoadItem { Month = "January", Value = 34 };
            WorkLoadItem february = new WorkLoadItem { Month = "February", Value = 239 };
            WorkLoadItem march = new WorkLoadItem { Month = "March", Value = 120 };

            WorkLoadItem april = new WorkLoadItem { Month = "April", Value = 54 };
            WorkLoadItem may = new WorkLoadItem { Month = "May", Value = 277 };
            WorkLoadItem june = new WorkLoadItem { Month = "June", Value = 113 };

            WorkLoadItem july = new WorkLoadItem { Month = "July", Value = 87 };
            WorkLoadItem august = new WorkLoadItem { Month = "August", Value = 59 };
            WorkLoadItem september = new WorkLoadItem { Month = "September", Value = 124 };

            WorkLoadItem october = new WorkLoadItem { Month = "October", Value = 23 };
            WorkLoadItem november = new WorkLoadItem { Month = "November", Value = 47 };
            WorkLoadItem december = new WorkLoadItem { Month = "December", Value = 245 };

            RealWorkloadItems.Add(january);
            RealWorkloadItems.Add(february);
            RealWorkloadItems.Add(march);

            RealWorkloadItems.Add(april);
            RealWorkloadItems.Add(may);
            RealWorkloadItems.Add(june);

            RealWorkloadItems.Add(july);
            RealWorkloadItems.Add(august);
            RealWorkloadItems.Add(september);

            RealWorkloadItems.Add(october);
            RealWorkloadItems.Add(november);
            RealWorkloadItems.Add(december);

            PlannedWorkloadItems = new ObservableCollection<WorkLoadItem>();

            WorkLoadItem january2 = new WorkLoadItem { Month = "January", Value = 45 };
            WorkLoadItem february2 = new WorkLoadItem { Month = "February", Value = 239 };
            WorkLoadItem march2 = new WorkLoadItem { Month = "March", Value = 120 };

            WorkLoadItem april2 = new WorkLoadItem { Month = "April", Value = 66 };
            WorkLoadItem may2 = new WorkLoadItem { Month = "May", Value = 298 };
            WorkLoadItem june2 = new WorkLoadItem { Month = "June", Value = 125 };

            WorkLoadItem july2 = new WorkLoadItem { Month = "July", Value = 87 };
            WorkLoadItem august2 = new WorkLoadItem { Month = "August", Value = 160 };
            WorkLoadItem september2 = new WorkLoadItem { Month = "September", Value = 124 };

            WorkLoadItem october2 = new WorkLoadItem { Month = "October", Value = 66 };
            WorkLoadItem november2 = new WorkLoadItem { Month = "November", Value = 47 };
            WorkLoadItem december2 = new WorkLoadItem { Month = "December", Value = 245 };

            PlannedWorkloadItems.Add(january2);
            PlannedWorkloadItems.Add(february2);
            PlannedWorkloadItems.Add(march2);

            PlannedWorkloadItems.Add(april2);
            PlannedWorkloadItems.Add(may2);
            PlannedWorkloadItems.Add(june2);

            PlannedWorkloadItems.Add(july2);
            PlannedWorkloadItems.Add(august2);
            PlannedWorkloadItems.Add(september2);

            PlannedWorkloadItems.Add(october2);
            PlannedWorkloadItems.Add(november2);
            PlannedWorkloadItems.Add(december2);
        }
    }
}
