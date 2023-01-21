using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CPractice
{
    /// <summary>
    /// BasicCTask.xaml の相互作用ロジック
    /// </summary>
    public partial class BasicCTask : Window
    {
        public BasicCTask()
        {
            InitializeComponent();

            // 画面とデータの紐づけを設定する
            this.DataContext = new ViewModel(this);
        }
    }
}
