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

namespace Shapes1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyCanvas my_canvas = new MyCanvas();

        public MainWindow()
        {
            InitializeComponent();

            IMG_Display.Children.Add(my_canvas);
           
        }



    class MyCanvas : Canvas
    {
        public MyCanvas() : base()
        {

        }

        protected override void OnRender(DrawingContext dc)
        {
                helper.draw_plate(dc,origin, size);
                helper.draw_bolt(dc, bolt_origin,diameter);
        }


      
        }
    }
}
