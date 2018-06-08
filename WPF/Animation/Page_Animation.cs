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
    public static class Page_Animation
    {



        public static async Task PageAnimation(this Page page ,double AnimationSpeed)
        {
            Storyboard storyboard = new Storyboard();
            storyboard.SlideAnimation(-page.WindowWidth/6, 0, page.WindowWidth, 0, AnimationSpeed);
            storyboard.FadeAnimation(AnimationSpeed*2);


            storyboard.Begin(page);
           // page.Visibility = Visibility.Visible;
            //await Task.Delay((int)AnimationSpeed * 1000);
        }

    }
}

