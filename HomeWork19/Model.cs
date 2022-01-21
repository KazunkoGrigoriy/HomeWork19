using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork19
{
    class Model:IModel
    {
        RepositoryAnimal repositoryAnimal = new RepositoryAnimal();
        DataFile dataFile = new DataFile();
        public void Add(MainWindow M)
        {
            AddAnimsl addAnimsl = new AddAnimsl();
            addAnimsl.ShowDialog();
            if ((bool)addAnimsl.DialogResult)
            {
                repositoryAnimal.Add(
                    AnimalFactory.GetAnimal(
                        M.comboBox.Text,
                        addAnimsl.tbView.Text,
                        addAnimsl.tbBreed.Text,
                        addAnimsl.tbHabitat.Text));
            }
            M.dataGrid.ItemsSource = repositoryAnimal.bd.Where(t => t.Type == M.comboBox.Text);
            dataFile.WriteToFile(repositoryAnimal);
        }

        public void ComboSelection(MainWindow M)
        {
            repositoryAnimal.bd = dataFile.ReadFromFile();
            M.dataGrid.ItemsSource = repositoryAnimal.bd.Where(t => t.Type == M.comboBox.SelectedItem.ToString());
        }
    }
}
