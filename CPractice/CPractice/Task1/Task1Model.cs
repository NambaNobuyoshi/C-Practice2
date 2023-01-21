using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPractice.Task1
{
    internal class Task1Model : INotifyPropertyChanged
    {
        internal Task1Model()
        {
            Num1 = 1;
        }

        // "数字１"と対応
        private int _num1;
        public int Num1
        {
            get { return this._num1; }
            set
            {
                this._num1 = value;
                OnPropertyChanged(nameof(Num1));
            }
        }
        // "数字２"と対応
        private int _num2;
        public int Num2
        {
            get { return this._num2; }
            set
            {
                this._num2 = value;
                OnPropertyChanged(nameof(Num2));
            }
        }

        // "和"の計算結果と対応
        private int _plusResult;
        public int PlusResult
        {
            get { return this._plusResult; }
            set
            {
                this._plusResult = value;
                OnPropertyChanged(nameof(PlusResult));
            }
        }

        // "差"の計算結果と対応
        private int _minusResult;
        public int MinusResult
        {
            get { return this._minusResult; }
            set
            {
                this._minusResult = value;
                OnPropertyChanged(nameof(MinusResult));
            }
        }

        // "積"の計算結果と対応
        private int _multiResult;
        public int MultiResult
        {
            get { return this._multiResult; }
            set
            {
                this._multiResult = value;
                OnPropertyChanged(nameof(MultiResult));
            }
        }

        // "商"の計算結果と対応
        private int _divideResult;
        public int DivideResult
        {
            get { return this._divideResult; }
            set
            {
                this._divideResult = value;
                OnPropertyChanged(nameof(DivideResult));
            }
        }


        // MEMO : ViewModelの変更を画面に通知するための定型
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
