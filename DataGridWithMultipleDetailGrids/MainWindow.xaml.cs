using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DataGridWithMultipleDetailGrids
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Company> companies = new List<Company>();

        public MainWindow()
        {
            InitializeComponent();

            // Populate our imaginary data set
            LoadData();
            exampleGrid.ItemsSource = companies;

        }

        /// <summary>
        /// Populate the list of companies with some test data
        /// </summary>
        private void LoadData()
        {
            // create Bob's hardware company
            var bobsHardware = new Company("Bob's Hardware Store");
            this.companies.Add(bobsHardware);

            // Bob's hardware staff
            bobsHardware.Staff.Add(new Person("Mr", "Bob", "Cheruncle"));
            bobsHardware.Staff.Add(new Person("Mr", "Michael", "Goss"));
            
            // Bob's hardware locations
            bobsHardware.Locations.Add(new Address("43 Upper Brook St", "London", string.Empty, "WC2H 9PA"));
            bobsHardware.Locations.Add(new Address("78 Neal Street", "London", string.Empty, "SE1 2QN"));

            // create the greasy spoon cafe
            var greasySpoonCafe = new Company("Greasy Spoon Cafe");
            this.companies.Add(greasySpoonCafe);

            // greasy spoon staff
            greasySpoonCafe.Staff.Add(new Person("Mrs", "Karen A.", "Foster"));
            greasySpoonCafe.Staff.Add(new Person("Mrs", "Shirley J.", "Reutlinger"));
            greasySpoonCafe.Staff.Add(new Person("Mr", "Kevin S. T.", "McMann"));

            // greasy spoon location
            greasySpoonCafe.Locations.Add(new Address("389 Kings Rd", "Manchester", "Lancsashire", "SW1X 9NR"));

            // create he little newsagent company
            var littleNewsagent = new Company("The little newsagent company");
            this.companies.Add(littleNewsagent);

            // little newsagent staff
            littleNewsagent.Staff.Add(new Person("Ms", "Tracey", "White"));
            littleNewsagent.Staff.Add(new Person("Mr", "Phillip", "Smith"));
            littleNewsagent.Staff.Add(new Person("Miss", "Francine", "Littleworth"));

            // little newsagent locations
            littleNewsagent.Locations.Add(new Address("56 Lower Darwin Street", "Thingleworth", "Cumbria", "CM21 5TR"));
            littleNewsagent.Locations.Add(new Address("The corner shop", "DingleFord", "West Yorkshire", "WY1 7TY"));
            littleNewsagent.Locations.Add(new Address("19b Medlock Avenue", "Newton Varley", "Lancashire", "PB2 4ZQ"));

        }

        private void ExampleGrid_OnRowDetailsVisibilityChanged(object sender, DataGridRowDetailsEventArgs e)
        {
            // get the object that the user has selected and cast it as a Company object
            var selectedCompany = this.exampleGrid.SelectedItem as Company;

            // if the selected item is a company and the company has some location records
            if (selectedCompany != null)
            {
                // get the details element of the main DataGrid and cast it to a StackPanel
                var panel = e.DetailsElement as StackPanel;
                if (panel != null)
                {
                    // just be sure that the panel does have two children that are datagrids...
                    if (panel.Children.Count >= 2)
                    {
                        DataGrid innerGrid = panel.Children[0] as DataGrid;
                       
                        if ((innerGrid != null) && (selectedCompany.Locations != null))
                        {
                            innerGrid.ItemsSource = selectedCompany.Locations;
                        }

                        DataGrid staffGrid = panel.Children[1] as DataGrid;
                        if ((staffGrid != null) && (selectedCompany.Staff != null))
                        {
                            staffGrid.ItemsSource = selectedCompany.Staff;
                        } 
                    }
                }
            }
        }
    }
}
