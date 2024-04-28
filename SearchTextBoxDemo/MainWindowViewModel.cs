using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTextBoxDemo
{
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// 自动完成提示集合
        /// </summary>
        public ObservableCollection<string> AutoCompleteItemsSourceCollection { get; set; }

        public MainWindowViewModel()
        {
            AutoCompleteItemsSourceCollection = new ObservableCollection<string>();
            AddCommand = new RelayCommand(AddCommandExecute);
        }

        private void AddCommandExecute()
        {
            if (!string.IsNullOrEmpty(SearchText))
            {
                AutoCompleteItemsSourceCollection.Add(SearchText);
            }
        }

        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set
            {
                Set(ref searchText, value);
            }
        }

        public RelayCommand AddCommand { get; set; }
    }
}