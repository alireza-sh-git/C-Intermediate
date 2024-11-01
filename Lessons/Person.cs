namespace Lessons
{
    class Person
    {
        public string Name { get; set; }


        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }


    }
}