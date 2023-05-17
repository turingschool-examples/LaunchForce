namespace LaunchForce
{
    public class Person
    {
        public string Name;
        public int Experience;
        public List<string> Specialties;

        public Person(string name, int experience)
        {
            Name = name;
            Experience = experience;
            Specialties = new List<string>();
        }

        public void AddSpecialty(string specialty)
        {
            Specialties.Add(specialty);
        }
    }
}
