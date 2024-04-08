using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    /// <summary>
    /// Notification object, contains message that admin can send to the whole company
    /// </summary>
    public class Notification
    {
        private int id;
        private int have_read_id;
        private bool is_read;
        private string authorName;
        private string title;
        private string content;
        private DateTime dateOfDelivery;
        public Notification(int id, int have_read_id, bool is_read, string authorName, string title, string content, DateTime dateOfDelivery)
        {
            this.id = id;
            this.Have_read_id = have_read_id;
            this.Is_read = is_read;
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
        public int Have_read_id { get => have_read_id; set => have_read_id = value; }
        public bool Is_read { get => is_read; set => is_read = value; }
    }
}
