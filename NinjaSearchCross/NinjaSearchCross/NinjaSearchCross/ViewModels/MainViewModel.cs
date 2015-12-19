using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjaSearchCross.Models;
using ReactiveUI;
using NinjaSearchCross.Localization;

namespace NinjaSearchCross.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public string Title => Main.Title;

        public MainViewModel()
        {
            
        }
    }
}
