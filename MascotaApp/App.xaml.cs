﻿using MascotaApp.MVVM.ViewModel;

namespace MascotaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new HomePage()) {
                BarTextColor = Colors.Black,
                BarBackgroundColor = Colors.White});
        }
    }
}