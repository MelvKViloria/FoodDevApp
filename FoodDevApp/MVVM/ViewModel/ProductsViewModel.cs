using FoodDevApp.MVVM.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using FoodDevApp.MVVM.Data;
using FoodDevApp;
using FoodDevApp.MVVM.ViewModel;

namespace FoodDevApp.MVVM.ViewModel
{
    internal partial class ProductsViewModel : Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
    {
        private readonly DataBaseContext _context;

        public ProductsViewModel(DataBaseContext context)
        {
            _context = context;
        }

        [Microsoft.Toolkit.Mvvm.ComponentModel.ObservableProperty]
        private ObservableCollection<Product> _products;

        [Microsoft.Toolkit.Mvvm.ComponentModel.ObservableProperty]
        private Product _operatingProduct = new();

        [Microsoft.Toolkit.Mvvm.ComponentModel.ObservableProperty]
        private bool _isBusy;

        [Microsoft.Toolkit.Mvvm.ComponentModel.ObservableProperty]
        private string _busyText;

        [RelayCommand]
        private async Task LoadProductsAsync()
        {
            await ExecuteAsync(async () =>
            {
                var products = await _context.GetAllAsync<Product>();

                if (products is not null && products.Any())
                {
                    Products ??= new ObservableCollection<Product>();

                    foreach (var product in products)
                    {
                        Products.Add(product);
                    }
                }
            }, "fetching Products");
        }

        [RelayCommand]
        private void SetOperatingProducy(Product? product) => OperatingProduct = product ?? new();

        [RelayCommand]
        private async Task SaveProductAsync()
        {
            if (OperatingProduct is null)
                return;

            var busyText = OperatingProduct.Id == 0 ? "creating Product...." : "Updating product";

            await ExecuteAsync(async () =>
            {
                if (OperatingProduct.Id == 0)
                {
                    await _context.AdditemAsync<Product>(OperatingProduct);
                    Products.Add(OperatingProduct);
                }
                else
                {
                    await _context.UpdateitemAsync<Product>(OperatingProduct);

                    var ProductCopy = OperatingProduct.Clone();

                    var index = Products.IndexOf(OperatingProduct);
                    Products.RemoveAt(index);

                    Products.Insert(index, ProductCopy);
                }

                setOperatingProducyCommand.Execute(new());
            }, BusyText);
        }

        [RelayCommand]
        private async Task DeleteProductAsync(int Id)
        {
            await ExecuteAsync(async () =>
            {
                if (await _context.DeleteitemByKeyAsync<Product>(Id))
                {
                    var product = Products.FirstOrDefault(p => p.Id == Id);
                    Products.Remove(product);
                }
                else
                {
                    await Shell.Current.DisplayAlert("Delete Errorr", "Product not deleted", "Ok");
                }
            }, "Deleting Product");
        }

        private async Task ExecuteAsync(Func<Task> operation, string? busytext = null)
        {
            IsBusy = true;
            BusyText = busytext ?? "Processing ..........";
            try
            {
                await operation?.Invoke();
            }
            finally
            {
                IsBusy = false;
                BusyText = "Processing ..........";
            }
        }
    }
}
