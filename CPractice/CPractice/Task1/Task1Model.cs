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
            this.AllReset();
        }

        // "数字１"と対応
        private string _num1;
        public string Num1
        {
            get { return this._num1; }
            set
            {
                this._num1 = value;
                OnPropertyChanged(nameof(Num1));
            }
        }
        // "数字２"と対応
        private string _num2;
        public string Num2
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
        private string _divideResult;
        public string DivideResult
        {
            get { return this._divideResult; }
            set
            {
                this._divideResult = value;
                OnPropertyChanged(nameof(DivideResult));
            }
        }

        /// <summary>
        /// task1内のすべての値をリセットする
        /// </summary>
        internal void AllReset()
        {
            this.Num1 = string.Empty;
            this.Num2 = string.Empty;

            this.PlusResult  =  (int)default;
            this.MinusResult = (int)default;
            this.MultiResult = (int)default;
            this.DivideResult = ((int)default).ToString();
        }

        internal void AddNumber()
        {
            this.PlusResult = int.Parse(this.Num1) + int.Parse(this.Num2) ;
        }
        internal void MinusNumber()
        {
            this.MinusResult = int.Parse(this.Num1) - int.Parse(this.Num2);
        }
        internal void MultipleNumber()
        {
            this.MultiResult = int.Parse(this.Num1) * int.Parse(this.Num2);
        }
        internal void DivideNumber()
        {
            this.DivideResult = (int.Parse(this.Num2) == 0) ? "-" : (int.Parse(this.Num1) / int.Parse(this.Num2)).ToString();
        }

        // MEMO : ViewModelの変更を画面に通知するための定型
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
