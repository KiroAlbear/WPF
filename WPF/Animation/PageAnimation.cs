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

     public class PageAnimation : Page
    {
        private Page AnimatedPage=null;
        private Frame AnimatedFrame=null;

        public PageAnimation(Frame AnimatedFrame)
        {
            this.AnimatedFrame = AnimatedFrame;
        }

        //public PageAnimation(Page AnimatedPage)
        //{
        //    this.AnimatedPage = AnimatedPage;
        //}
     
        public void ActualAnimation(double Marginleft, double MarginTop, double MarginRight, double MarginDown, double MarginSpeed)
        {
            ////  Animate The Page
          //  if (AnimatedPage != null)
            //{

            
            //var sb = new Storyboard();

            //var slideAnimation = new ThicknessAnimation
            //{
            //    Duration = new Duration(TimeSpan.FromSeconds(MarginSpeed)),
            //    From = new Thickness(Marginleft, MarginTop, MarginRight, MarginDown),
            //    To = new Thickness(0),
            //    DecelerationRatio = 0.8
            //};
            //Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            //sb.Children.Add(slideAnimation);
            //sb.Begin(AnimatedPage);
            //}




            ///// Animate The Frame
            //else if (AnimatedFrame != null)
            {


                var sb = new Storyboard();

                var slideAnimation = new ThicknessAnimation
                {
                    Duration = new Duration(TimeSpan.FromSeconds(MarginSpeed)),
                    From = new Thickness(Marginleft, MarginTop, MarginRight, MarginDown),
                    To = new Thickness(0),
                    DecelerationRatio = 0.8
                };
                Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
                sb.Children.Add(slideAnimation);
                sb.Begin(AnimatedFrame);
            }
        }
    }

}
