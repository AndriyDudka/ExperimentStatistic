using ExperimentStatistic.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace ExperimentStatistic
{
    public static class Logic
    {
        static Models.Task task;
        public static List<ExperimentModel> sessions = new List<ExperimentModel>();

        public static void DeserializeXmlFile(string file)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Models.Task));
            
            using (StreamReader reader = new StreamReader(file))
            {
                task = (Models.Task) serializer.Deserialize(reader);
            }       
        }
        
        public static void CreateStatistic()
        {
            
            foreach(var session in task.Groups.Group.Sessions.Session)
            {
                var expModel = new ExperimentModel();
                try
                {
                    expModel.Date = DateTime.ParseExact(session.Sessiondate, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Data);
                }
                
                expModel.Show = true;

                double tumorSize = 0;
                foreach (var animal in session.Animals.Animal)
                {
                    tumorSize += animal.Data.Datum.Value;
                }
                tumorSize /= session.Animals.Animal.Count;

                expModel.TumorSize = tumorSize;

                sessions.Add(expModel);
            }           
        }
    }
}
