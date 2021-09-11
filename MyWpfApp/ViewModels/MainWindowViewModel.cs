using MyWpfApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfApp.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private string _title = "Default Name";
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);

        }

        private int _progress = 90;
        /// <summary>
        /// Прогресс
        /// </summary>
        public int Progress
        {
            get => _progress;
            set => Set(ref _progress, value);

        }



    }
}
