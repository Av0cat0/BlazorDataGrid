using System;
namespace UITable3.Shared
{
    public enum ActivityStatus
    {
        Draft = 0,
        Active = 1,
        Closed = 2,
        Cancelled = 3,
        Deleted = 4
    }
    public enum PriorityStates
    {
        Critical = 0,
        High = 1,
        Medium = 2,
        Low = 3
    }
    public class TableData
    {
        public string ActivityName { set; get; } = "name";
        public string? ActivityDescription { set; get; }
        public string? ActivityContext { set; get; }
        public string Status { set; get; } = "Draft";
        public Guid ServiceUserId { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime DueDate { set; get; }
        public string Priority { set; get; } = "Low";
        public string WorkFlowStep { set; get; } = "step";
        public string? Data1 { set; get; }
        public string? Data2 { set; get; }
        public string? Photo { set; get; }
    }

    public class RandomFeatures
    {
        private Random gen;
        private string[] first_names;
        private string[] last_names;
        public RandomFeatures()
        {
            this.gen = new Random();
            this.first_names = new string[]{"John",
                "Nick",
                "Thomas",
                "Mr Avocato",
                "Roni",
                "Michael",
                "Elior",
                "Amit",
                "Bibi",
                "Sarit",
                "Avigdor",
                "Miri",
                "Vladimir" };
            this.last_names = new string[]{"Regev",
                "Putin",
                "Meowlord",
                "Netanyau",
                "Golnik",
                "Roitbord",
                "Cohen",
                "Gabay",
                "Liberman",
                "Van Dam",
                "Obama",
                "Egg",
                "The Pope",
                "Hadad"};
        }

        public string RandomFirstName()
        {
            return first_names[RandomNumber(first_names.Length)];
        }
        public string RandomLastName()
        {
            return last_names[RandomNumber(last_names.Length)];
        }
        public int RandomNumber(int range)
        {
            return gen.Next(range);
        }
    }

}

