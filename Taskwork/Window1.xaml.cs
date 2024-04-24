

namespace Taskwork;

using System.Windows;

    public partial class Window1 : Window
    {
        public Car SelectedCar { get; set; }

        public Window1(Car selectedCar)
        {
            InitializeComponent();
            SelectedCar = selectedCar;
            DataContext = this;
        }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        string make = txtMake.Text;
        string model = txtModel.Text;
        string vendor = txtVendor.Text;

        Car newCar = new Car
        {
            Make = make,
            Model = model,
            Vendor = vendor
        };

        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

        if (mainWindow != null && mainWindow.Cars != null)
        {
            mainWindow.Cars.Add(newCar);
        }

        Close();
    }

    private void Update_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
