﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Collections;

namespace ECMills.Controllers
{
    [RoutePrefix("Diary")]
    public class DiaryController : Controller
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        // GET: Diary
        [Route("")]
        public ActionResult Diary()
        {
            // THIS IS HERE AS IM NOT TESTING GOOGLE CALENDAR AT THE MOMENT
            return View();

            // GOOGLE CALENDAR DATA FOR WHEN CONFIGURING IT
            UserCredential credential;

            using (var stream =
                new FileStream("\\\\Mac\\Home\\Documents\\GitHub\\ECMills\\ECMills\\Content\\credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "\\\\Mac\\Home\\Documents\\GitHub\\ECMills\\ECMills\\Content\\token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            string[] teststring = { };
            Hashtable HashTable = new Hashtable();

            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }

                    //HashTable.Add(eventItem.Summary.ToString(), eventItem.Start.DateTime.ToString(), eventItem.Organizer.Email.ToString());

                    //return Content(when);
                }
            }
            else
            {
                return Content("No events..");
            }

            
            return View();
        }

    }
}





