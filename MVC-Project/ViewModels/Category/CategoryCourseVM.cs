﻿namespace MVC_Project.ViewModels.Category
{
    public class CategoryCourseVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public string CreatedDate { get; set; }
        public string? Image { get; set; }
        public int CourseCount { get; set; }
    }
}
