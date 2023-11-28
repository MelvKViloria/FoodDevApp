using FoodDevApp.MVVM.Model;
using IntelliJ.Lang.Annotations;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using FoodDevApp.MVVM.Data;
using FoodDevApp.MVVM.Model;
using FoodDevApp.MVVM.ViewModel;

namespace FoodDevApp.MVVM.ViewModel
{ 
    internal partial class ProductsViewModel : ObservableObject
{
    private readonly DataBaseContext _context;

    public ProductsViewModel(DataBaseContext context)
    {
        _context = context;
    }
    [ObservableProperty]
    private ObservableCollection<Product> _products;

    [ObservableProperty]
    private Product _operatingProduct = new();

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
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