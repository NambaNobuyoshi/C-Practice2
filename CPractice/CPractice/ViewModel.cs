
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

        private Task1Model _task1Model;
        internal Task1Model task1Model
        {
            get { return _task1Model; }
            set
            {
                _task1Model = value;
                OnPropertyChanged(nameof(task1Model));
            }
        }
        //Task1Event task1Event;

        // コンストラクタで画面情報を受け取る
        internal ViewModel(BasicCTask window)
        {
            this.window = window;

            //this.task1Event = new Task1Event(this);
        }

        // MEMO : ViewModelの変更を画面に通知するための定型
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
