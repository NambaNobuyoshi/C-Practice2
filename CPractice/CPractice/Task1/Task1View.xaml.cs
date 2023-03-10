using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPractice.Task1
{
    /// <summary>
    /// Task1View.xaml の相互作用ロジック
    /// </summary>
    public partial class Task1View : UserControl
    {
        Task1Event task1Event;
        internal Task1Model task1Model = new Task1Model();

        public Task1View()
        {
            InitializeComponent();

            this.DataContext = task1Model;

            task1Event = new Task1Event(this);
        }

        /// <summary>
        /// コピーペーストできないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CannotPaste(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = (e.Command == ApplicationCommands.Paste);
        }
    }

    
}
