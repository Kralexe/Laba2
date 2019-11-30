using System;
using System.Collections.Generic;
using System.Text;

namespace WpfLABA.ViewModels
{
    class MainViewModel : ObservableObject
    {
        public FullViewModel FullView { get; private set; }

        public MainViewModel()
        {
            FullView = new FullViewModel();
        }

    }
}
