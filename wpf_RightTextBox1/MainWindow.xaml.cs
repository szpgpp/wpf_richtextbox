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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_RightTextBox1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            this.btnBold.Click += (sender, e) => { this.rtbText.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold); };
            this.btnItalic.Click += (sender, e) => { this.rtbText.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic); };
            this.btnUnderline.Click += (sender, e) => { this.rtbText.Selection.ApplyPropertyValue(Underline.TextDecorationsProperty, TextDecorations.Underline); };
            this.btnStrike.Click += (sender, e) => { this.rtbText.Selection.ApplyPropertyValue(Underline.TextDecorationsProperty, TextDecorations.Strikethrough); };
        }
    }
}
