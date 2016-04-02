using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Imagine_Music_Player
{
   public class RoundButton : UserControl
    {
       protected override void OnPaint(PaintEventArgs e)
       {
           Graphics g = e.Graphics;
           Pen mypen = new Pen(Color.Black);
           g.DrawEllipse(mypen, 0, 0, this.Width, this.Height);
           mypen.Dispose();
           base.OnPaint(e);
       }
    }
}
