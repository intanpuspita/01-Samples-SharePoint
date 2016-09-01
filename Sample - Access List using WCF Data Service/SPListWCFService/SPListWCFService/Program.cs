using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPListWCFService.SPReference;
using SPListWCFService.SPTrainingReference;

namespace SPListWCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intan2DataContext dc = new Intan2DataContext(new Uri("http://sptraining/Intan2/_vti_bin/ListData.svc"));
            //dc.Credentials = System.Net.CredentialCache.DefaultCredentials;

            //var source = dc.CurrentProjects;

            //foreach (var dev in source)
            //{
            //    string devName = dev.Name + " " + dev.Actual + " " + dev.Resources;
            //    Console.WriteLine(devName);
            //}
            //Console.ReadLine();

            ProjectsDataContext dc = new ProjectsDataContext(new Uri("http://mtpc513:26583/projects/_vti_bin/ListData.svc"));
            dc.Credentials = System.Net.CredentialCache.DefaultCredentials;

            var source = dc.Resource_Level;

            foreach (var dev in source)
            {
                string devName = dev.Name + " " + dev.Allowance + " " + dev.Level;
                Console.WriteLine(devName);
            }
            Console.ReadLine();
        }
    }
}
