﻿using Xamarin.Forms;

namespace ElectionGuardCore.Ui.Forms
{
    public abstract class PageBase : ContentPage
    {
        public PageViewModelBase ViewModel { get; }

        protected PageBase(PageViewModelBase viewModel)
        {
            ViewModel = viewModel;
            BindingContext = ViewModel;

            NavigationPage.SetBackButtonTitle(this, "Back");
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.Load();
        }
    }
}