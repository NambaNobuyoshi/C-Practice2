
using CPractice.Task1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CPractice
{
    internal class ViewModel : INotifyPropertyChanged
    {
        internal BasicCTask window;

        // コンストラクタで画面情報を受け取る
        internal ViewModel(BasicCTask window)
        {
            this.window = window;
        }

        // MEMO : ViewModelの変更を画面に通知するための定型
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
