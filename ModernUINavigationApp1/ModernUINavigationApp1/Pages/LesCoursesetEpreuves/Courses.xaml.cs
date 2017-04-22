﻿using System;
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

namespace ModernUINavigationApp1.Pages
{
    /// <summary>
    /// Interaction logic for Courses.xaml
    /// </summary>
    public partial class Courses : UserControl
    {

        public Courses()
        {
            InitializeComponent();
            ListViewCourses.ItemsSource = null;
            LibArcachon.CourseDAO.List();
            List<LibArcachon.Course> lol = new List<LibArcachon.Course>();

            lol = LibArcachon.CourseDAO.List();
            ListViewCourses.ItemsSource = lol;
        }

        private void load(object sender, RoutedEventArgs e)
        {
            ListViewCourses.ItemsSource = null;
            LibArcachon.CourseDAO.List();
            List<LibArcachon.Course> lol = new List<LibArcachon.Course>();

            lol = LibArcachon.CourseDAO.List();
            ListViewCourses.ItemsSource = lol;
        }

    }
}
