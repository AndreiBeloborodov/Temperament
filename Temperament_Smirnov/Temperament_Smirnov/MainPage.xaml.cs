using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament_Smirnov
{
    public partial class MainPage : CarouselPage
    {
        public object Btn3_Clicked { get; }

        public MainPage()
        {
            ImageButton btn1;
            ImageButton btn2;
            ImageButton btn3;
            ImageButton btn4;
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Стартовая страница\n\nВиды фобий",
                            TextColor = Color.SkyBlue,
                            BackgroundColor = Color.Gray,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                    }
                }
            };
            btn1 = new ImageButton
            {
                Source = "acrophobia.jpg"
            };
            btn1.Clicked += Btn1_Clicked; ;
            var acrophobia = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "акрофобия",
                            TextColor = Color.Green,
                            BackgroundColor = Color.Gray,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        btn1
                    }
                }
            };
            btn2 = new ImageButton
            {
                Source = "Airophobie.jpg"
            };
            btn2.Clicked += Btn2_Clicked; ;
            var Airophobie = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Аерофобия",
                            TextColor = Color.Orange,
                            BackgroundColor = Color.Gray,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        btn2
                    }
                }
            };
            btn3 = new ImageButton
            {
                Source = "Arachnophobia.jpg"
            };
            btn3.Clicked += Btn3_Clicked1; ;
            var Arachnophobia = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Арахнофобия.jpg",
                            TextColor = Color.Purple,
                            BackgroundColor = Color.Gray,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        },
                        btn3
                    }
                }
            };
            btn4 = new ImageButton
            {
                Source = "kinophobia.jpg"
            };
            btn4.Clicked += Btn4_Clicked; ;
            var kinophobia = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Кинофобия",
                            TextColor = Color.Chocolate,
                            BackgroundColor = Color.Gray,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        btn4
                    }
                }
            };
            Children.Add(start);
            Children.Add(acrophobia);
            Children.Add(kinophobia);
            Children.Add(Arachnophobia);
            Children.Add(Airophobie);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%9A%D0%B8%D0%BD%D0%BE%D1%84%D0%BE%D0%B1%D0%B8%D1%8F", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn3_Clicked1(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%90%D1%80%D0%B0%D1%85%D0%BD%D0%BE%D1%84%D0%BE%D0%B1%D0%B8%D1%8F", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%90%D1%8D%D1%80%D0%BE%D1%84%D0%BE%D0%B1%D0%B8%D1%8F", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%90%D0%BA%D1%80%D0%BE%D1%84%D0%BE%D0%B1%D0%B8%D1%8F", BrowserLaunchMode.SystemPreferred);
        }
    }
}
