
using Microsoft.EntityFrameworkCore;
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
using TestTaskDeeplayWpf.DbModels;

namespace TestTaskDeeplayWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbTestContext db = new DbTestContext();

        public MainWindow()
        {
            InitializeComponent();
            db.staff.Load();//Подгрузка бд
            StaffGrid.ItemsSource = db.staff.Local.ToBindingList();//Вывод бд в DataGrid
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)//Удаление работника
        {
            if (StaffGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < StaffGrid.SelectedItems.Count; i++)
                {
                    Staff staff = StaffGrid.SelectedItems[i] as Staff;
                    if (staff != null)
                    {
                        db.staff.Remove(staff);
                    }
                }
            }
            db.SaveChanges();
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)//добавление работника
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            Staff staff = new Staff {FIO = addWindow.fio, DateOfBirth= addWindow.dateOfBirth, Gender = addWindow.gender, UniqueInfo = addWindow.uniqueInfo, Post = addWindow.post };
            db.staff.Add(staff);
            db.SaveChanges();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)//Кнопка обноаления бд
        {
            db.staff.Load();
            StaffGrid.ItemsSource = db.staff.Local.ToBindingList();
            db.SaveChanges();
        }

        private void BoostButton_Click(object sender, RoutedEventArgs e)//Повышение работника
        {
            if (StaffGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < StaffGrid.SelectedItems.Count; i++)
                {
                    Staff staff = StaffGrid.SelectedItems[i] as Staff;
                    if (staff != null && staff.Post.ToString()== "Рабочий")
                    {
                        staff.Post = "Контролёр";
                        break;
                    }
                    if (staff != null && staff.Post.ToString() == "Контролёр")
                    {
                        staff.Post = "Руководитель отдела";
                        break;
                    }
                    if (staff != null && staff.Post.ToString() == "Руководитель отдела")
                    {
                        staff.Post = "Директор";
                        break;
                    }
                    if (staff != null && staff.Post.ToString() == "Директор")
                    {
                        MessageBox.Show("А выше некуда");
                        break;
                    }
                }
            }
            db.SaveChanges();
        }
    }
}
