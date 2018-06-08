using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WPF.Animation
{
    public static class StoryBoard_Detailes
    {
        public static void SlideAnimation(this Storyboard storyboard, double Marginleft, double MarginTop, double MarginRight, double MarginDown, double MarginSpeed)
        {

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(MarginSpeed)),
                From = new Thickness(Marginleft, MarginTop, MarginRight, MarginDown),
                To = new Thickness(0),
                DecelerationRatio = 1f
            };

            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            storyboard.Children.Add(slideAnimation);
           
        }

        public static void FadeAnimation(this Storyboard storyboard , double speed)
        {
            var fadeanimation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(speed)),
                From = 0,
                To = 1,
            };

            Storyboard.SetTargetProperty(fadeanimation, new PropertyPath("Opacity"));
            storyboard.Children.Add(fadeanimation);

        }

        

    }
}
