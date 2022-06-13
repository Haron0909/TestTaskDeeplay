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
using System.Windows.Shapes;

namespace TestTaskDeeplayWpf
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public string fio;
        public DateTime dateOfBirth;
        public string post;
        public string uniqueInfo;
        public string gender;

        public AddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(FIO.Text != null && DateOfBirth.Text != null && Post.Text !=null && UniqueInfo.Text != null && Gender.Text != null)
            {
                fio = FIO.Text;
                dateOfBirth = DateOfBirth.DisplayDate;
                post = Post.Text;
                uniqueInfo = UniqueInfo.Text;
                gender = Gender.Text;
                Close();
            }
        }
    }
}
