
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taskwork
{

    public partial class  MainWindow : Window
    {

        public static readonly DependencyProperty MessagesProperty =
           DependencyProperty.Register("Cars", typeof(ObservableCollection<Car>), typeof(MainWindow), new PropertyMetadata(null));

        public ObservableCollection<Car> Cars
        {
            get { return (ObservableCollection<Car>)GetValue(MessagesProperty); }
            set { SetValue(MessagesProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Cars = new ObservableCollection<Car>
            {
                new Car() {Make="1999" ,Model="kia", Vendor= "Y"},
                new Car() {Make="1899" ,Model="kia", Vendor= "Y"},
                new Car() {Make="1998" ,Model="Aston", Vendor= "Martin"},
                new Car() {Make="1997" ,Model="alpha", Vendor= "Romio"},
                new Car() {Make="1996" ,Model="opel", Vendor= "Y"}
            };
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            Car selectedCar = listbox.SelectedItem as Car;  


            Window1 window1 = new Window1(selectedCar);
            window1.Show(); 



        }

       
    }
}