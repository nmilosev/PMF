﻿using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMF.Views
{
    /// <summary>
    /// All views are singletons
    /// </summary>
    public class ViewLocator
    {
        public ViewLocator()
        {
            SimpleIoc.Default.Register<MainPage>();
            SimpleIoc.Default.Register<ContactPage>();
            SimpleIoc.Default.Register<AboutPage>();
            SimpleIoc.Default.Register<WelcomePage>();
            SimpleIoc.Default.Register<MenuPage>();

            SimpleIoc.Default.Register<NewsPage>();
            SimpleIoc.Default.Register<NewsArticlePage>();

            SimpleIoc.Default.Register<SchedulePage>();
            SimpleIoc.Default.Register<ScheduleDetailsPage>();
            
            SimpleIoc.Default.Register<SubjectPage>();
            
            SimpleIoc.Default.Register<FAQPage>();

            SimpleIoc.Default.Register<DepartmentsPage>();
            SimpleIoc.Default.Register<ProgramsPage>();
            SimpleIoc.Default.Register<ProgramDetailsPage>();

            SimpleIoc.Default.Register<WizardPage>();

            SimpleIoc.Default.Register<StudentServicesPage>();
        }

        public WelcomePage WelcomePage => ServiceLocator.Current.GetInstance<WelcomePage>();

        public MainPage MainPage => ServiceLocator.Current.GetInstance<MainPage>();
        public MenuPage MenuPage => ServiceLocator.Current.GetInstance<MenuPage>();        
        public ContactPage ContactPage => ServiceLocator.Current.GetInstance<ContactPage>();
        public AboutPage AboutPage => ServiceLocator.Current.GetInstance<AboutPage>();
        public NewsPage NewsPage => ServiceLocator.Current.GetInstance<NewsPage>();
        public NewsArticlePage NewsArticle => ServiceLocator.Current.GetInstance<NewsArticlePage>();

        public SchedulePage SchedulePage => ServiceLocator.Current.GetInstance<SchedulePage>();
        public ScheduleDetailsPage ScheduleDetailsPage => ServiceLocator.Current.GetInstance<ScheduleDetailsPage>();
        
        public SubjectPage SubjectPage => ServiceLocator.Current.GetInstance<SubjectPage>();

        public FAQPage FAQPage => ServiceLocator.Current.GetInstance<FAQPage>();

        public DepartmentsPage DepartmentsPage => ServiceLocator.Current.GetInstance<DepartmentsPage>();
        public ProgramsPage ProgramsPage => ServiceLocator.Current.GetInstance<ProgramsPage>();
        public ProgramDetailsPage ProgramDetailsPage => ServiceLocator.Current.GetInstance<ProgramDetailsPage>();

        public WizardPage Wizard => ServiceLocator.Current.GetInstance<WizardPage>();

        public StudentServicesPage StudentServices => ServiceLocator.Current.GetInstance<StudentServicesPage>();

    }
}
