using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PMF.Views
{
    public partial class StudentServicesPage : TabbedPage
    {
        public StudentServicesPage()
        {
            BindingContext = this;

            InitializeComponent();
        }

        public class DataPoint
        {
            public string Title { get; set; }
            public int Grade { get; set; }
            public int ESPB { get; set; }
        }

        public ObservableCollection<DataPoint> ExamsData => new ObservableCollection<DataPoint>()
            {
                new DataPoint() { Title = "Baze Podataka 1", Grade = 9, ESPB = 8 },
                new DataPoint() { Title = "Baze Podataka 2", Grade = 6, ESPB = 6 },
                new DataPoint() { Title = "OOP1", Grade = 10, ESPB = 10 },
                new DataPoint() { Title = "OOP2", Grade = 7, ESPB = 7 },
                new DataPoint() { Title = "SEDS", Grade = 9, ESPB = 7 },
                new DataPoint() { Title = "Informatički projekat", Grade = 9, ESPB = 8 },
                new DataPoint() { Title = "Veštačka inteligencija 1", Grade = 6, ESPB = 9 },
                new DataPoint() { Title = "Veštačka inteligencija 2", Grade = 10, ESPB = 8 },
                new DataPoint() { Title = "Seminarski rad A", Grade = 7, ESPB = 8 },
                new DataPoint() { Title = "Upravljanje softverskim projektima", Grade = 8, ESPB = 4 },
                new DataPoint() { Title = "Softversko inženjerstvo", Grade = 8, ESPB = 6 },
                new DataPoint() { Title = "RZK", Grade = 10 ,ESPB = 10},
                new DataPoint() { Title = "SPA2", Grade = 6 , ESPB = 9},
                new DataPoint() { Title = "Seminarski rad C", Grade = 8 , ESPB = 7},
                new DataPoint() { Title = "Konstrukcija kompajlera", Grade = 7 , ESPB = 8},
                new DataPoint() { Title = "Neuronske mreže", Grade = 8 , ESPB = 9},
            };

    }
}
