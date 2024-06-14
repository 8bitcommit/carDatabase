using System;
namespace project291
{
    public class Branch
    {
        public string Name { get; set; } = "";
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
