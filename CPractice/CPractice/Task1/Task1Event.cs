using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CPractice.Task1
{
    /// <summary>
    /// タスク１のバインディングを設定する
    /// </summary>
    internal class Task1Event
    {
        Task1Model model;


        internal Task1Event(Task1View view)
        {
            //this.model = vm.task1Model;

            this.AttatchEvent(view);
        }

        /// <summary>
        /// 画面とのバインディングを設定する
        /// </summary>
        /// <param name="window"></param>
        public void AttatchEvent(Task1View view)
        {

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
        /// 計算ボタン押下後のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoCulculation(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// リセットボタン押下後のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoReset(object sender, RoutedEventArgs e)
        {

        }
    }
}
