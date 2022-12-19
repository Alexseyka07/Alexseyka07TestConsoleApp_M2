using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_RenderingApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        private TimeSpan prevTime;
        private Stopwatch stopwatch = Stopwatch.StartNew();
        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += CompositionTarget_Rendering;
            prevTime = stopwatch.Elapsed;
        }

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            TimeSpan currentTime = stopwatch.Elapsed;
            double delta = (currentTime - prevTime).TotalSeconds;
            prevTime = currentTime;

            lbl.Content = delta;

            Figure figure1 = new Figure(0, 0, 100, 200, ball);
            UpdateBall(delta,figure1);
            
        }
       public void UpdateBall(double delta,Figure figure)
        {
            figure.x += figure.x + figure.speedX * delta;
            figure.y += figure.y + figure.speedY * delta;

            if (figure.x < 0)
            {
                figure.speedX = -figure.speedX;
                figure.x = 0;
            }
            else if (figure.x > MyCanvas.ActualWidth - ball.Width)
            {
                figure.speedX = -figure.speedX;
                figure.x = 0;
            }
            if (figure.y < 0)
            {
                figure.speedY = -figure.speedY;
                figure.y = 0;
            }
            else if (figure.y > MyCanvas.ActualHeight - ball.Height)
            {
                figure.speedY = -figure.speedY;
                figure.y = 0;
            }






            Canvas.SetLeft(ball, figure.x);
            Canvas.SetTop(ball, figure.y);
        }
    }

    public class Figure
    {
        public double x = 0;
        public double y = 0;
        public double speedX = 0.0001;
        public double speedY = 0.0001;
        public Ellipse ellipse;
        public Figure(double x, double y, 
            double speedX,double speedY,Ellipse ellipse)
        {
            this.x = x;
            this.y = y;
            this.speedX = speedX;
            this.speedY = speedY;
            this.ellipse = ellipse;
        }
    }
}
