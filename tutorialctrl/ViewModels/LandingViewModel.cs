using System;
using tutorialctrl.Models;

namespace tutorialctrl.ViewModels;

public class LandingViewModel:BaseViewModel
{
    public List<ItemsControl> Items => new List<ItemsControl>{
        new ItemsControl{Id=1, Name="Item 1"},
        new ItemsControl{Id=2, Name="Item 2"},
        new ItemsControl{Id=3, Name="Item 3"},
        new ItemsControl{Id=4, Name="Item 4"},
        new ItemsControl{Id=5, Name="Item 5"},
        new ItemsControl{Id=6, Name="Item 6"},
        new ItemsControl{Id=7, Name="Item 7"},
        new ItemsControl{Id=8, Name="Item 8"},
        new ItemsControl{Id=9, Name="Item 9"},
        new ItemsControl{Id=10, Name="Item 10"},
    };

}
