using SQLite;

namespace XamarinMonkeyViewer.Models
{
    public class Monkey
    {
        [PrimaryKey, AutoIncrement]
        public int MonkeyId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        //URL for our monkey image!
        public string Image { get; set; }

        public string NameSort => Name[0].ToString();
    }
}

