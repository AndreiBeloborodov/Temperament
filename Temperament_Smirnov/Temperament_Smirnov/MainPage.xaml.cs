using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Temperament_Smirnov
{
    public partial class MainPage : CarouselPage
    {
        Label acr, air, arac, kino;
        public MainPage()
        {
            var AirophobiePage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Airophobie",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
        },
                        new Image
                        {
                            Source = "Airophobie.jpg",
                            VerticalOptions= LayoutOptions.CenterAndExpand,
                        }
                    }
                }
            };
            var acrophobiaPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "acrophobia",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "acrophobia.jpg",
                            VerticalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            var kinophobiaPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "kinophobia",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "kinophobia.jpg",
                            VerticalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            var ArachnophobiaPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Arachnophobia",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                        {
                            Source = "Arachnophobia.jpg",
                            VerticalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            Children.Add(AirophobiePage);
            Children.Add(acrophobiaPage);
            Children.Add(kinophobiaPage);
            Children.Add(ArachnophobiaPage);
            }
        }
    }
