﻿using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controls;

namespace Sagua.Jinson.Shopper.Modules.Mission
{
    /// <summary>
    /// MissionWorkSpaceView.xaml 的交互逻辑
    /// </summary>
    public partial class MissionWorkSpaceView
    {
        [Dependency]
        public MissionWorkSpaceViewModel ViewModel
        {
            get
            {
                return this.DataContext as MissionWorkSpaceViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public MissionWorkSpaceView()
        {
            InitializeComponent();
            this.IsVisibleChanged += MissionWorkSpaceView_IsVisibleChanged;
        }
  

        void MissionWorkSpaceView_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null && ((bool)e.NewValue) == true)
            {
                ViewModel.Init();
            }
        }
        
    }
}
