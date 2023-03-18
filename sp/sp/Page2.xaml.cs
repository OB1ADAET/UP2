using sp.mysql1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        chatsTableAdapter chats = new chatsTableAdapter();
        usersTableAdapter users = new usersTableAdapter();
        public Page2()
        {
            InitializeComponent();
            ChatsData.ItemsSource = chats.GetData();
            user1.ItemsSource = users.GetData();
            user1.DisplayMemberPath = "fname";
            user2.ItemsSource = users.GetData();
            user2.DisplayMemberPath = "fname";
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (user1.SelectedIndex != -1 && user2.SelectedIndex != -1)
            {
                var newId = chats.GetData();
                int User1 = users.GetData()[user1.SelectedIndex].id;

                int User2 = users.GetData()[user2.SelectedIndex].id;
                Debug.WriteLine(user2.SelectedIndex);
                chats.InsertQuery(newId[newId.Count - 1].id + 1, User1, User2);
                ChatsData.ItemsSource = chats.GetData();
            }
        }
    }
}
