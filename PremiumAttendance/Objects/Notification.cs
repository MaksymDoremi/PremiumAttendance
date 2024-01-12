using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    public class Notification
    {
        private int id;
        private string authorName;
        private string title;
        private string content;
        private DateTime dateOfDelivery;
        public Notification(int id, string authorName, string title, string content, DateTime dateOfDelivery)
        {
            this.id = id;
            this.AuthorName = authorName;
            this.Title = title;
            this.Content = content;
            this.DateOfDelivery = dateOfDelivery;
        }


        public int ID { get => id; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public DateTime DateOfDelivery { get => dateOfDelivery; set => dateOfDelivery = value; }
    }
}
