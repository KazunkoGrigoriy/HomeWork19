using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    
    public partial class MainWindow : Window
    {
        RepositoryAnimal repositoryAnimal = new RepositoryAnimal();
        DataFile dataFile = new DataFile();
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add("Млекопитающие");
            comboBox.Items.Add("Птицы");
            comboBox.Items.Add("Земноводные");
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //dataGrid.ItemsSource = repositoryAnimal.bd.Where(t => t.Type == comboBox.SelectedItem.ToString());
            repositoryAnimal.bd = dataFile.ReadFromFile();
            //if (dataFile.ReadFromFile() != null) 
                dataGrid.ItemsSource = repositoryAnimal.bd.Where(t => t.Type == comboBox.SelectedItem.ToString());//dataFile.ReadFromFile().Where(t => t.Type == comboBox.SelectedItem.ToString());
        }
      
        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddAnimsl addAnimsl = new AddAnimsl();
            addAnimsl.Owner = this;
            addAnimsl.ShowDialog();
            if ((bool)addAnimsl.DialogResult)
            {
                repositoryAnimal.Add(
                    AnimalFactory.GetAnimal(
                        comboBox.Text,
                        addAnimsl.tbView.Text,
                        addAnimsl.tbBreed.Text,
                        addAnimsl.tbHabitat.Text));
            }
            dataGrid.ItemsSource = repositoryAnimal.bd.Where(t => t.Type == comboBox.Text);
            dataFile.WriteToFile(repositoryAnimal);
        }
    }
}
