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

        public Task1View()
        {
            InitializeComponent();

            this.DataContext = new Task1Model();

            task1Event = new Task1Event(this);
        }
    }
}
