// March 17,2018
// COlin Jones
// Finds power cube and draws square around it.
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

namespace canvasImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double t = 20;
        double l = 20;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, RoutedEventArgs e)
        {
            if (canvas.Children.Count > 0)
            {
                canvas.Children.RemoveAt(0);
            }
            Microsoft.Win32.OpenFileDialog openFileD = new Microsoft.Win32.OpenFileDialog();
            openFileD.ShowDialog();

            BitmapImage bi = new BitmapImage(new Uri(openFileD.FileName));
            System.Windows.Media.ImageBrush ib = new ImageBrush(bi);
            canvas.Background = ib;

            Rectangle r = new Rectangle();
            r.Stroke = System.Windows.Media.Brushes.GreenYellow;
            r.Width = 100;
            r.Height = 100;
            r.StrokeThickness = 2;

            canvas.Children.Add(r);
            Canvas.SetLeft(r, l);
            Canvas.SetTop(r, t);
            l += 20;
            t += 20;


            //get pixel
            int stride = bi.PixelWidth * 4;
            int size = bi.PixelHeight * stride;
            byte[] pixels = new byte[size];
            bi.CopyPixels(pixels, stride, 0);


            // Attempting to create maximum / minimun RGB values
            int ilowR = 0;
            int iHighR = 255;
            int iLowG = 0;
            int iHighG = 255;
            int iLowB = 0;
            int iHighB = 255;



            
            Random rand = new Random();
            //get random number
            int q = rand.Next(1,2);


            //Starting at pixel 1, and then moving all the way through every pixel
            for (int i = q; i < q + 5000; i++)
                
                // Start at pixel one and move down all the way to 500
                // 
            {
                //Also, if the picture has no box, there should be a messagebox that comes up with that message.
            }
            
            

            int x = q;
            int y = q;
            int index = y * stride + 4 * x;


            // assigning RGB values
            byte blue = pixels[index];
            byte green = pixels[index + 1];
            byte red = pixels[index + 2];
            byte alpha = pixels[index + 3];

                

            {


            }



            MessageBox.Show(red.ToString() + ", " + green.ToString() + ", " + blue.ToString());
          
        }
    }
}
