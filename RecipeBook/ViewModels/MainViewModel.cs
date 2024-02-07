using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
namespace RecipeBook.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        [ObservableProperty]
        private string title="Hello everyone";
    }
}
