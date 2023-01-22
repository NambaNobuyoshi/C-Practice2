using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CPractice.Task1
{
    /// <summary>
    /// タスク１のバインディングを設定する
    /// </summary>
    internal class Task1Event
    {
        Task1Model task1Model;

        internal Task1Event(Task1View view)
        {
            this.task1Model = view.task1Model;

            this.AttatchEvent(view);
        }

        /// <summary>
        /// 画面とのバインディングを設定する
        /// </summary>
        /// <param name="window"></param>
        public void AttatchEvent(Task1View view)
        {

            TextBox num1 = view.FindName("Num1Text") as TextBox;
            if(num1 != null)
            {
                num1.PreviewTextInput += new TextCompositionEventHandler(this.CheckInputIsNum);
                
            }

            TextBox num2 = view.FindName("Num2Text") as TextBox;
            if(num1 != null)
            {
                num2.PreviewTextInput += new TextCompositionEventHandler(this.CheckInputIsNum);
            }

            // "計算"ボタン
            Button culcButton = view.FindName("Task1Culc") as Button;
            if (culcButton != null)
            {
                culcButton.Click += new RoutedEventHandler(this.DoCulculation);
            }

            // リセットボタン
            Button resetButton = view.FindName("Task1Reset") as Button;
            if (resetButton != null)
            {
                resetButton.Click += new RoutedEventHandler(this.DoReset);
            }
        }

        /// <summary>
        /// 入力テキストが数字ではない場合、イベントを終了する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckInputIsNum(object sender, TextCompositionEventArgs e)
        {
            bool finishEvent = false;

            // 0~9が入力されたときのみイベントを継続させる
            e.Handled = !new Regex("[0-9]").IsMatch(e.Text);
        }
        /// <summary>
        /// コピペできないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckPasteIsNum(object sender, ExecutedRoutedEventArgs e)
        {
            if(e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 計算ボタン押下後のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoCulculation(object sender, RoutedEventArgs e)
        {
            this.task1Model.AddNumber();
            this.task1Model.MinusNumber();
            this.task1Model.MultipleNumber();
            this.task1Model.DivideNumber();
        }

        /// <summary>
        /// リセットボタン押下後のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoReset(object sender, RoutedEventArgs e)
        {
            this.task1Model.AllReset();
        }
    }
}
