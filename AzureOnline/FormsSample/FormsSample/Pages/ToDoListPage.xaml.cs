using System;
using System.Collections.Generic;
using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using FormsSample.ViewModels;
using Xamarin.Forms;

namespace FormsSample.Pages
{
    public partial class ToDoListPage : ContentPage
    {
        public ToDoListPage(IEasyMobileServiceClient client)
        {
            InitializeComponent();
            var viewModel = new ViewModels.ToDosViewModel(client);
            BindingContext = viewModel;
            listView.ItemsSource = viewModel.Items;
        }
    }
}

