﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AMQG.UI.Views
{
    public class CustomerListView : UserControl
    {
        public CustomerListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
