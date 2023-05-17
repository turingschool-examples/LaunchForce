namespace LaunchForce
{
    public class Spacecraft
    {
        public string Name;
        public int Fuel;
        public List<Person> Personnel;

        public Spacecraft(string name, int fuel)
        {
            Name = name;
            Fuel = fuel;
            Personnel = new List<Person>();
        }

        public void AddPersonnel(Person person)
        {
            Personnel.Add(person);
        }

        public List<string> Roster()
        {
            List<string> roster = new List<string>();
            foreach (Person person in Personnel)
            {
                roster.Add(person.Name);
            }
            return roster;
        }

        public int TotalExperience()
        {
            int totalExperience = 0;
            foreach (Person person in Personnel)
            {
                totalExperience += person.Experience;
            }
            return totalExperience;
        }

        //public double AverageExperience()
        //{

        //}
    }
}