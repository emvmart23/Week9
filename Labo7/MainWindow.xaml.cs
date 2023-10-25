using System;
using System.Collections.Generic;
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
using Business;
using Entity;

namespace Labo7
{
    public partial class MainWindow : Window
    {
        private Business.BProduct business;

        public MainWindow()
        {
            InitializeComponent();
            business = new Business.BProduct();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchName = txtName.Text;
            List<Product> products = business.GetByName(searchName);

            dataGrid.ItemsSource = products;
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
    
            Product selectedProduct = dataGrid.SelectedItem as Product;

            if (selectedProduct != null)
        {
           
            {
                business.UpdateProduct(selectedProduct);
                MessageBox.Show("Producto actualizado exitosamente.");
            }
            }
            else
            {
            MessageBox.Show("Selecciona un producto para actualizar.");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
    
            Product selectedProduct = dataGrid.SelectedItem as Product;

            if (selectedProduct != null)
            {
            business.deleteProduct(selectedProduct.Id);
            MessageBox.Show("Producto eliminado lógicamente.");
            }
            else
            {
            MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }
    }
}
