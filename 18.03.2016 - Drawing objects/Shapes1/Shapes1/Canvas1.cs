using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Shapes1
{
   class helper
    {
        // variables:
        //plate
        Point origin = new Point(100, 100);
        static double width = 100;
        static double height = 600;
        Size size = new Size(width, height);
        //bolts
        int diameter = 20;
        Point bolt_origin = new Point(100, 100);




        void draw_plate(DrawingContext dc, Point origin, Size size)
        {
            dc.DrawRectangle(Brushes.Gray,
                new Pen(Brushes.Black, 2),
                new Rect(origin, size));

        }

        void draw_bolt(DrawingContext dc, Point bolt_origin, double diameter)
        {
            dc.DrawEllipse(Brushes.White,
                new Pen(Brushes.Black, 1),
                bolt_origin,
                diameter,
                diameter);


        }
    }
    
}
