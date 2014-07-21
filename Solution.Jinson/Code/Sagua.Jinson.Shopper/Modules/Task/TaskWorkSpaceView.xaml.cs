﻿using System;
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
using Microsoft.Practices.Unity;

namespace Sagua.Jinson.Shopper.Modules.Task
{
    /// <summary>
    /// TaskWorkSpaceView.xaml 的交互逻辑
    /// </summary>
    public partial class TaskWorkSpaceView : UserControl
    {
        [Dependency]
        public TaskWorkSpaceViewModel ViewModel
        {
            get
            {
                return this.DataContext as TaskWorkSpaceViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public TaskWorkSpaceView()
        {
            InitializeComponent();
            
        }
    }
}
