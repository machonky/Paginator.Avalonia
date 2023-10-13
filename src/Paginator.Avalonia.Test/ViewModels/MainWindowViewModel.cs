using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace Paginator.Avalonia.Test.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            i = 1;
        }

        private int i;
        public int I
        {
            set => this.RaiseAndSetIfChanged(ref i, value);
            get => i;
        }

        public int D => 7;

        public int PageCount { get { return 10; } }
    }
}