﻿using DotNetCommunityToolkit.MVVM.Views;

namespace DotNetCommunityToolkit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoPage();
        }
    }
}
