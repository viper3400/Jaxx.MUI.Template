using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Jaxx.MUI.Template.ViewModel
{
    public class View2ViewModel : ViewModelBase

    {
        private string _info;

        public View2ViewModel()

        {

            Info = "This is View 2";
            ButtonClicked = new RelayCommand<EventArgs>(ExecuteButtonClicked, CanExecuteButtonClicked);

        }

        private bool CanExecuteButtonClicked(EventArgs arg)
        {
            return _info != "ExecuteButtonClicked";
        }

        private void ExecuteButtonClicked(EventArgs obj)
        {
            Info = "ExecuteButtonClicked";
        }
        

        public ICommand ButtonClicked { get; private set; }
        public string Info
        {
            get { return _info; }
            set
            {
                if (_info == value)
                    return;
                _info = value;
                RaisePropertyChanged();
            }
        }

    }
}
