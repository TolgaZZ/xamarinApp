using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using tolgaExamen.Models;
using tolgaExamen.ViewModels;
using Xamarin.Forms.Maps;

namespace tolgaExamen.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;


            if (viewModel.Item.Image != null)
            {
                image.Source = ImageSource.FromStream(() =>
                {
                    var stream = viewModel.Item.Image.GetStream();
                    return stream;
                });
            }

            if (viewModel.Item.Location != null)
            {
                Position position = new Position(viewModel.Item.Location.Longitude, viewModel.Item.Location.Latitude);
                MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
                Map map = new Map(mapSpan);
                mapWrapper.Content = map;
            }
        }

        //public ItemDetailPage()
        //{
        //    InitializeComponent();

        //    var item = new Item
        //    {
        //        Text = "Item 1",
        //        Description = "This is an item description."
        //    };

        //    viewModel = new ItemDetailViewModel(item);
        //    BindingContext = viewModel;
        //}
    }
}