﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMF.Core.Interfaces;
using PMF.Core.Models;

namespace PMF.LocalService
{
    public class LocalScheduleSource : IScheduleSource
    {
        public bool IsAvailable
        {
            get
            {
                return true;
            }
        }

        public bool RequireConnection
        {
            get
            {
                return false;
            }
        }

        public async Task<ScheduleList> Schedules(string langCode)
        {
            //simulate network delay for up to 3 seconds
            await Task.Delay((int)(3000 * new Random().NextDouble()));
            return LocalSchedules;
        }

        private ScheduleList LocalSchedules
        {
            get
            {
                var l = new ScheduleList()
                {
                    Schedules = new List<Schedule>()
                    {
                        new Schedule()
                        {
                            Id = 1,
                            Title = "Raspored časova - informatika 3. godina",
                            Time = DateTime.Now, Description = "Zimski semestar 2015/2016",
                            Days = new List<ScheduleDay>() {
                                new ScheduleDay() { DayOfTheWeek = (int) DayOfWeek.Monday },
                                new ScheduleDay() { DayOfTheWeek = (int) DayOfWeek.Tuesday },
                                new ScheduleDay() { DayOfTheWeek = (int) DayOfWeek.Wednesday, Items = new List<ScheduleItem>() {
                                    new ScheduleItem() {
                                        Color = "#3C404A", FromHour=14, FromMinute=15, ToHour=17, ToMinute=0, LocationId = 1, Location = "RC 59/3 - treći sprat", Type = (int) ScheduleItemType.Lecture, SubjectId = "IA221", SubjectTitle = "Baze podataka 1", TeacherNames = new List<string>() { "dr Miloš Racković" }
                                    },
                                    new ScheduleItem() {
                                        Color = "#995E57", FromHour=18, FromMinute=0, ToHour=19, ToMinute=30, LocationId = 2, Location = "RC 59/3 - treći sprat", Type = (int) ScheduleItemType.Lab, SubjectId = "IA222", SubjectTitle = "Operativni Sistemi 1", TeacherNames = new List<string>() { "dr Zoran Budimac" }
                                    },
                                    new ScheduleItem() {
                                        Color = "#4D464C", FromHour=18, FromMinute=0, ToHour=19, ToMinute=30, LocationId = 3, Location = "RC 10", Type = (int) ScheduleItemType.Pratice, SubjectId = "IA223", SubjectTitle = "Razvoj zasnovan na komponentama", TeacherNames = new List<string>() { "dr Srđan Škrbić" }
                                    }
                                } },
                                new ScheduleDay() { DayOfTheWeek = (int) DayOfWeek.Thursday },
                                new ScheduleDay() { DayOfTheWeek = (int) DayOfWeek.Friday },
                            }
                        },
                        new Schedule() { Id = 2, Title = "Raspored časova - matematika 1. godina", Time = DateTime.Now, Description = "Zimski semestar 2015/2016" },
                        new Schedule() { Id = 3, Title = "Raspored časova - informatika 1. godina master", Time = DateTime.Now, Description = "Zimski semestar 2015/2016" },
                        new Schedule() { Id = 4, Title = "Raspored časova - biologija 1. godina", Time = DateTime.Now, Description = "Letnji semestar 2016/2017" }
                    }
                    
                };
                return l;
            }
        }

        //simulate network errors
        //public bool IsDataValid => new Random().NextDouble() > 0.2 ? true : false;
        public bool IsDataValid => true;

    }
}
