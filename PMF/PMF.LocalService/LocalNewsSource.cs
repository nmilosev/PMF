using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Models;
using PMF.Core.Interfaces;

namespace PMF.LocalService
{
    public class LocalNewsSource : INewsSource
    {
        public bool IsAvailable
        {
            get
            {
                return true;
            }
        }

        public async Task<News> News()
        {
            //simulate network delay for up to 3 seconds
            await Task.Delay((int)(3000 * new Random().NextDouble()));
            return NewsItems;
        }

        private News NewsItems
        {
            get
            {
                var news = new News()
                {
                    Refreshed = DateTime.Now,
                    //simulate network errors
                    //IsDataValid = new Random().NextDouble() > 0.5 ? true : false,
                    IsDataValid = true,
                    Items = new List<NewsItem>()
                    {
                        new NewsItem()
                        {
                            Id = 1,
                            Category = "News",
                            Link = "http://google.com",
                            Title = "Lorem ipsum",
                            Time = DateTime.Now,
                            Color = "#3C404A",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas efficitur lacus a metus congue fermentum. Duis dictum eu sem eget volutpat. Vestibulum nisl mauris, vestibulum in congue nec, euismod nec diam. Suspendisse congue lacus turpis, cursus molestie nisi malesuada in. Morbi elementum auctor neque sit amet egestas. Vivamus ac neque non ante pellentesque ultrices vitae ac erat. Nunc pellentesque, ex at tristique laoreet, libero orci pharetra sapien, eget vestibulum sapien justo non nunc. Maecenas eu massa at lacus convallis tincidunt cursus sit amet felis. Maecenas nec mauris enim. Sed id faucibus arcu.
Curabitur vel sapien facilisis, commodo neque eu, scelerisque odio. Fusce tempor massa ac arcu mollis, nec hendrerit odio lacinia. Vivamus pellentesque ornare quam, ut mattis lorem consectetur et. Fusce ligula magna, consectetur sit amet ultrices sed, volutpat quis lectus. Pellentesque lectus sapien, venenatis sed ultrices ut, consequat non nibh. Sed eget lorem vulputate, pretium tellus eu, semper diam. Curabitur tristique lectus lectus, eu viverra augue varius nec. Etiam diam nisi, rutrum vel finibus et, euismod at nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ultrices enim sapien, et hendrerit turpis egestas in. Integer non nunc vitae tortor gravida posuere a cursus ligula. Ut libero orci, eleifend vel tristique quis, pellentesque vel lorem. Phasellus ornare ante ac luctus cursus. Nullam placerat nunc elit, quis scelerisque arcu pulvinar quis.",
                            ImageURI = @"https://cdn0.iconfinder.com/data/icons/creative-business-and-development/512/email_mailing_newsletter_inbox_mail_marketing_business_letter_envelope_flat_design_icon-512.png"
                        },
                        new NewsItem()
                        {
                            Id = 2,
                            Category = "News",
                            Link = "http://google.com",
                            Title = "Fusce tempor",
                            Time = DateTime.Now,
                            Color = "#995E57",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas efficitur lacus a metus congue fermentum. Duis dictum eu sem eget volutpat. Vestibulum nisl mauris, vestibulum in congue nec, euismod nec diam. Suspendisse congue lacus turpis, cursus molestie nisi malesuada in. Morbi elementum auctor neque sit amet egestas. Vivamus ac neque non ante pellentesque ultrices vitae ac erat. Nunc pellentesque, ex at tristique laoreet, libero orci pharetra sapien, eget vestibulum sapien justo non nunc. Maecenas eu massa at lacus convallis tincidunt cursus sit amet felis. Maecenas nec mauris enim. Sed id faucibus arcu.
Curabitur vel sapien facilisis, commodo neque eu, scelerisque odio. Fusce tempor massa ac arcu mollis, nec hendrerit odio lacinia. Vivamus pellentesque ornare quam, ut mattis lorem consectetur et. Fusce ligula magna, consectetur sit amet ultrices sed, volutpat quis lectus. Pellentesque lectus sapien, venenatis sed ultrices ut, consequat non nibh. Sed eget lorem vulputate, pretium tellus eu, semper diam. Curabitur tristique lectus lectus, eu viverra augue varius nec. Etiam diam nisi, rutrum vel finibus et, euismod at nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ultrices enim sapien, et hendrerit turpis egestas in. Integer non nunc vitae tortor gravida posuere a cursus ligula. Ut libero orci, eleifend vel tristique quis, pellentesque vel lorem. Phasellus ornare ante ac luctus cursus. Nullam placerat nunc elit, quis scelerisque arcu pulvinar quis.",
                            ImageURI = @"https://cdn0.iconfinder.com/data/icons/creative-business-and-development/512/email_mailing_newsletter_inbox_mail_marketing_business_letter_envelope_flat_design_icon-512.png",
                        },
                        new NewsItem()
                        {
                            Id = 3,
                            Category = "News",

                            Link = "http://google.com",
                            Title = "Scelerisque odio",
                            Time = DateTime.Now,
                            Color = "#4D464C",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas efficitur lacus a metus congue fermentum. Duis dictum eu sem eget volutpat. Vestibulum nisl mauris, vestibulum in congue nec, euismod nec diam. Suspendisse congue lacus turpis, cursus molestie nisi malesuada in. Morbi elementum auctor neque sit amet egestas. Vivamus ac neque non ante pellentesque ultrices vitae ac erat. Nunc pellentesque, ex at tristique laoreet, libero orci pharetra sapien, eget vestibulum sapien justo non nunc. Maecenas eu massa at lacus convallis tincidunt cursus sit amet felis. Maecenas nec mauris enim. Sed id faucibus arcu.
Curabitur vel sapien facilisis, commodo neque eu, scelerisque odio. Fusce tempor massa ac arcu mollis, nec hendrerit odio lacinia. Vivamus pellentesque ornare quam, ut mattis lorem consectetur et. Fusce ligula magna, consectetur sit amet ultrices sed, volutpat quis lectus. Pellentesque lectus sapien, venenatis sed ultrices ut, consequat non nibh. Sed eget lorem vulputate, pretium tellus eu, semper diam. Curabitur tristique lectus lectus, eu viverra augue varius nec. Etiam diam nisi, rutrum vel finibus et, euismod at nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ultrices enim sapien, et hendrerit turpis egestas in. Integer non nunc vitae tortor gravida posuere a cursus ligula. Ut libero orci, eleifend vel tristique quis, pellentesque vel lorem. Phasellus ornare ante ac luctus cursus. Nullam placerat nunc elit, quis scelerisque arcu pulvinar quis.",
                            ImageURI = @"https://cdn0.iconfinder.com/data/icons/creative-business-and-development/512/email_mailing_newsletter_inbox_mail_marketing_business_letter_envelope_flat_design_icon-512.png",

                        },
                        new NewsItem()
                        {
                            Id = 4,
                            Category = "News",

                            Link = "http://google.com",
                            Title = "Vivamus pellentesque",
                            Time = DateTime.Now,
                            Color = "#90AD95",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas efficitur lacus a metus congue fermentum. Duis dictum eu sem eget volutpat. Vestibulum nisl mauris, vestibulum in congue nec, euismod nec diam. Suspendisse congue lacus turpis, cursus molestie nisi malesuada in. Morbi elementum auctor neque sit amet egestas. Vivamus ac neque non ante pellentesque ultrices vitae ac erat. Nunc pellentesque, ex at tristique laoreet, libero orci pharetra sapien, eget vestibulum sapien justo non nunc. Maecenas eu massa at lacus convallis tincidunt cursus sit amet felis. Maecenas nec mauris enim. Sed id faucibus arcu.
Curabitur vel sapien facilisis, commodo neque eu, scelerisque odio. Fusce tempor massa ac arcu mollis, nec hendrerit odio lacinia. Vivamus pellentesque ornare quam, ut mattis lorem consectetur et. Fusce ligula magna, consectetur sit amet ultrices sed, volutpat quis lectus. Pellentesque lectus sapien, venenatis sed ultrices ut, consequat non nibh. Sed eget lorem vulputate, pretium tellus eu, semper diam. Curabitur tristique lectus lectus, eu viverra augue varius nec. Etiam diam nisi, rutrum vel finibus et, euismod at nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ultrices enim sapien, et hendrerit turpis egestas in. Integer non nunc vitae tortor gravida posuere a cursus ligula. Ut libero orci, eleifend vel tristique quis, pellentesque vel lorem. Phasellus ornare ante ac luctus cursus. Nullam placerat nunc elit, quis scelerisque arcu pulvinar quis.",
                            ImageURI = @"https://cdn0.iconfinder.com/data/icons/creative-business-and-development/512/email_mailing_newsletter_inbox_mail_marketing_business_letter_envelope_flat_design_icon-512.png",

                        },
                        new NewsItem()
                        {
                            Id = 5,
                            Category = "News",

                            Link = "http://google.com",
                            Title = "Curabitur vel",
                            Time = DateTime.Now,
                            Color = "#A4BEBE",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas efficitur lacus a metus congue fermentum. Duis dictum eu sem eget volutpat. Vestibulum nisl mauris, vestibulum in congue nec, euismod nec diam. Suspendisse congue lacus turpis, cursus molestie nisi malesuada in. Morbi elementum auctor neque sit amet egestas. Vivamus ac neque non ante pellentesque ultrices vitae ac erat. Nunc pellentesque, ex at tristique laoreet, libero orci pharetra sapien, eget vestibulum sapien justo non nunc. Maecenas eu massa at lacus convallis tincidunt cursus sit amet felis. Maecenas nec mauris enim. Sed id faucibus arcu.
Curabitur vel sapien facilisis, commodo neque eu, scelerisque odio. Fusce tempor massa ac arcu mollis, nec hendrerit odio lacinia. Vivamus pellentesque ornare quam, ut mattis lorem consectetur et. Fusce ligula magna, consectetur sit amet ultrices sed, volutpat quis lectus. Pellentesque lectus sapien, venenatis sed ultrices ut, consequat non nibh. Sed eget lorem vulputate, pretium tellus eu, semper diam. Curabitur tristique lectus lectus, eu viverra augue varius nec. Etiam diam nisi, rutrum vel finibus et, euismod at nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ultrices enim sapien, et hendrerit turpis egestas in. Integer non nunc vitae tortor gravida posuere a cursus ligula. Ut libero orci, eleifend vel tristique quis, pellentesque vel lorem. Phasellus ornare ante ac luctus cursus. Nullam placerat nunc elit, quis scelerisque arcu pulvinar quis.",
                            ImageURI = @"https://cdn0.iconfinder.com/data/icons/creative-business-and-development/512/email_mailing_newsletter_inbox_mail_marketing_business_letter_envelope_flat_design_icon-512.png",
                        },
                        new NewsItem()
                        {
                            Id = 6,
                            Category = "News",
                            Link = "http://google.com",
                            Title = "Etiam diam",
                            Time = DateTime.Now,
                            Color = "#995E57",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas efficitur lacus a metus congue fermentum. Duis dictum eu sem eget volutpat. Vestibulum nisl mauris, vestibulum in congue nec, euismod nec diam. Suspendisse congue lacus turpis, cursus molestie nisi malesuada in. Morbi elementum auctor neque sit amet egestas. Vivamus ac neque non ante pellentesque ultrices vitae ac erat. Nunc pellentesque, ex at tristique laoreet, libero orci pharetra sapien, eget vestibulum sapien justo non nunc. Maecenas eu massa at lacus convallis tincidunt cursus sit amet felis. Maecenas nec mauris enim. Sed id faucibus arcu.
Curabitur vel sapien facilisis, commodo neque eu, scelerisque odio. Fusce tempor massa ac arcu mollis, nec hendrerit odio lacinia. Vivamus pellentesque ornare quam, ut mattis lorem consectetur et. Fusce ligula magna, consectetur sit amet ultrices sed, volutpat quis lectus. Pellentesque lectus sapien, venenatis sed ultrices ut, consequat non nibh. Sed eget lorem vulputate, pretium tellus eu, semper diam. Curabitur tristique lectus lectus, eu viverra augue varius nec. Etiam diam nisi, rutrum vel finibus et, euismod at nunc. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris ultrices enim sapien, et hendrerit turpis egestas in. Integer non nunc vitae tortor gravida posuere a cursus ligula. Ut libero orci, eleifend vel tristique quis, pellentesque vel lorem. Phasellus ornare ante ac luctus cursus. Nullam placerat nunc elit, quis scelerisque arcu pulvinar quis.",
                            ImageURI = @"https://cdn0.iconfinder.com/data/icons/creative-business-and-development/512/email_mailing_newsletter_inbox_mail_marketing_business_letter_envelope_flat_design_icon-512.png",
                        }
                    }
                };
                return news;
            }
        }

        public bool RequireConnection
        {
            get
            {
                return false;
            }
        }
        
    }
}
