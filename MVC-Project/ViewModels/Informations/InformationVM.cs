﻿namespace MVC_Project.ViewModels.Informations
{
    public class InformationVM
    {
        public int Id { get; set; }

        public string Title { get; set; }


        public string Description { get; set; }

        public string Image { get; set; }
        public string CreatedDate { get; internal set; }
    }
}
