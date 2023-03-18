using sp.mysql1DataSetTableAdapters;
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

namespace sp
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        usersTableAdapter users = new usersTableAdapter();
        public Page1()
        {
            InitializeComponent();
            UsersData.ItemsSource = users.GetData();
        }

        private void ChangeBtn1_Click(object sender, RoutedEventArgs e)
        {
            var dataUsers = users.GetData();
            users.InsertQuery(dataUsers[dataUsers.Count - 1].id + 1, NewUser.Text, $"{NewUser.Text}@mail.com");
            UsersData.ItemsSource = users.GetData();
        }
    }
}
