using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ExperimentStatistic.Models
{
    [XmlRoot(ElementName = "customvalue")]
    public class Customvalue
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "customvalues")]
    public class Customvalues
    {
        [XmlElement(ElementName = "customvalue")]
        public Customvalue Customvalue { get; set; }
    }

    [XmlRoot(ElementName = "datum")]
    public class Datum
    {
        [XmlElement(ElementName = "value")]
        public double Value { get; set; }
        [XmlElement(ElementName = "taskname")]
        public string Taskname { get; set; }
        [XmlElement(ElementName = "animalid")]
        public string Animalid { get; set; }
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "inputway")]
        public string Inputway { get; set; }
        [XmlElement(ElementName = "userinfo")]
        public string Userinfo { get; set; }
        [XmlElement(ElementName = "mortalityanotation")]
        public string Mortalityanotation { get; set; }
        [XmlElement(ElementName = "taskid")]
        public string Taskid { get; set; }
        [XmlElement(ElementName = "studyday")]
        public string Studyday { get; set; }
        [XmlElement(ElementName = "iscensored")]
        public string Iscensored { get; set; }
        [XmlElement(ElementName = "customvalues")]
        public Customvalues Customvalues { get; set; }
    }

    [XmlRoot(ElementName = "data")]
    public class Data
    {
        [XmlElement(ElementName = "datum")]
        public Datum Datum { get; set; }
    }

    [XmlRoot(ElementName = "animal")]
    public class Animal
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "studyanimalid")]
        public string Studyanimalid { get; set; }
        [XmlElement(ElementName = "groupid")]
        public string Groupid { get; set; }
        [XmlElement(ElementName = "group_x0020_name")]
        public string Group_x0020_name { get; set; }
        [XmlElement(ElementName = "animalorderid")]
        public string Animalorderid { get; set; }
        [XmlElement(ElementName = "animalordername")]
        public string Animalordername { get; set; }
        [XmlElement(ElementName = "fatedate")]
        public string Fatedate { get; set; }
        [XmlElement(ElementName = "fatecode")]
        public string Fatecode { get; set; }
        [XmlElement(ElementName = "fatedescription")]
        public string Fatedescription { get; set; }
        [XmlElement(ElementName = "iscensored")]
        public string Iscensored { get; set; }
        [XmlElement(ElementName = "sex")]
        public string Sex { get; set; }
        [XmlElement(ElementName = "temp_x0020_id")]
        public string Temp_x0020_id { get; set; }
        [XmlElement(ElementName = "animal_x0020_id")]
        public string Animal_x0020_id { get; set; }
        [XmlElement(ElementName = "date_x0020_of_x0020_birth")]
        public string Date_x0020_of_x0020_birth { get; set; }
        [XmlElement(ElementName = "mortality_x0020_code")]
        public string Mortality_x0020_code { get; set; }
        [XmlElement(ElementName = "mortality_x0020_classification_x0020_abbr")]
        public string Mortality_x0020_classification_x0020_abbr { get; set; }
        [XmlElement(ElementName = "mortality_x0020_description")]
        public string Mortality_x0020_description { get; set; }
        [XmlElement(ElementName = "mortality_x0020_date")]
        public string Mortality_x0020_date { get; set; }
        [XmlElement(ElementName = "staging_x0020_date")]
        public string Staging_x0020_date { get; set; }
        [XmlElement(ElementName = "mortality_x0020_classification")]
        public string Mortality_x0020_classification { get; set; }
        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }
    }

    [XmlRoot(ElementName = "animals")]
    public class Animals
    {
        [XmlElement(ElementName = "animal")]
        public List<Animal> Animal { get; set; }
    }

    [XmlRoot(ElementName = "session")]
    public class Session
    {
        [XmlElement(ElementName = "sessiondate")]
        public string Sessiondate { get; set; }
        [XmlElement(ElementName = "sessionnote")]
        public string Sessionnote { get; set; }
        [XmlElement(ElementName = "sessionday")]
        public string Sessionday { get; set; }
        [XmlElement(ElementName = "animals")]
        public Animals Animals { get; set; }
    }

    [XmlRoot(ElementName = "sessions")]
    public class Sessions
    {
        [XmlElement(ElementName = "session")]
        public List<Session> Session { get; set; }
    }

    [XmlRoot(ElementName = "group")]
    public class Group
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "requestedmales")]
        public string Requestedmales { get; set; }
        [XmlElement(ElementName = "requestedfemales")]
        public string Requestedfemales { get; set; }
        [XmlElement(ElementName = "males")]
        public string Males { get; set; }
        [XmlElement(ElementName = "females")]
        public string Females { get; set; }
        [XmlElement(ElementName = "articlescount")]
        public string Articlescount { get; set; }
        [XmlElement(ElementName = "diseasecount")]
        public string Diseasecount { get; set; }
        [XmlElement(ElementName = "sessions")]
        public Sessions Sessions { get; set; }
    }

    [XmlRoot(ElementName = "groups")]
    public class Groups
    {
        [XmlElement(ElementName = "group")]
        public Group Group { get; set; }
    }

    [XmlRoot(ElementName = "task")]
    public class Task
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "tasktype")]
        public string Tasktype { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "articleid")]
        public string Articleid { get; set; }
        [XmlElement(ElementName = "diseaseinductionid")]
        public string Diseaseinductionid { get; set; }
        [XmlElement(ElementName = "abbr")]
        public string Abbr { get; set; }
        [XmlElement(ElementName = "unitname")]
        public string Unitname { get; set; }
        [XmlElement(ElementName = "datatype")]
        public string Datatype { get; set; }
        [XmlElement(ElementName = "dose_x0020_volume")]
        public string Dose_x0020_volume { get; set; }
        [XmlElement(ElementName = "dose_x0020_rule")]
        public string Dose_x0020_rule { get; set; }
        [XmlElement(ElementName = "dose_x0020_volume_x0020_diff")]
        public string Dose_x0020_volume_x0020_diff { get; set; }
        [XmlElement(ElementName = "terminateat")]
        public string Terminateat { get; set; }
        [XmlElement(ElementName = "treatmentbegins")]
        public string Treatmentbegins { get; set; }
        [XmlElement(ElementName = "treatmentbegins2")]
        public string Treatmentbegins2 { get; set; }
        [XmlElement(ElementName = "groups")]
        public Groups Groups { get; set; }
    }

}
