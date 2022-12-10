﻿using personal_task.Core;
using personal_task.Model;
using System;
using System.Collections;
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

namespace personal_task.View.MainWindowPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindowPage.xaml
    /// </summary>
    public partial class MainWindowPage1 : Page
    {
        public MainWindowPage1()
        {
            InitializeComponent();
            /*            User userModel = FrameNavigate.DB.Users.FirstOrDefault(u => u.LastName == LastNameUser.lastName);
                        Role rolemodel = FrameNavigate.DB.Roles.FirstOrDefault(u => u.RoleID == userModel.RoleID);


                        TBRole.Text = rolemodel.RoleName;
                        TBID.Text = "@" + userModel.FirstName;
                        TBInfo.Text = Convert.ToString($"{userModel.Date.Day}.{userModel.Date.Month}.{userModel.Date.Year} {userModel.UsersCircles}");*/
            /*DataInfo.ItemsSource = FrameNavigate.DB.UserCircles.OrderBy(u => u.CircleID).ToList();*/
            /*DataInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.UserID).ToList();*/
            /*DataInfo.ItemsSource = FrameNavigate.DB.Users.Where(u => u.LastName == LastNameUser.lastName).ToList();*/
            /*DataCircle.ItemsSource = FrameNavigate.DB.UserCircles.Where(u => u.User.LastName == LastNameUser.lastName).ToList();
            DataRole.ItemsSource = FrameNavigate.DB.Users.Where(u => u.LastName == LastNameUser.lastName).ToList();*/
            ItemsControlInfo.ItemsSource = FrameNavigate.DB.Users.Where(u => u.LastName == LastNameUser.lastName).ToList();
            ItemsControlCircle.ItemsSource = FrameNavigate.DB.UserCircles.Where(u => u.User.LastName == LastNameUser.lastName).ToList();

            /*Role rolemodel = FrameNavigate.DB.Roles.FirstOrDefault(u => u.RoleID == userModel.RoleID); */

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ошибка данных",
                       "Системное сообщение",
                       MessageBoxButton.OK,
                       MessageBoxImage.Error);
        }
    }
}
