﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SegmentedControl.Netstandard.Event;
using Xamarin.Forms;

namespace Test.SegmentedControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SegControl_OnValueChanged(object sender, SegmentSelectEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}