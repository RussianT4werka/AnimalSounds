using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalSounds
{
    public class Card
    {
        public int Id { get; set; }
        public string? ImagePath { get; set; }
        public string? Name { get; set; }
        public Command? Command { get; set; }
        public Command? CommandP { get; set; }
    }
}
