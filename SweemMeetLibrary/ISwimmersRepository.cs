using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public interface ISwimmersRepository
    {
        int Number { set; get; }
        void Add(Registrant aSwimmer);
        void Load(string fileName, string delimeter);
        void Save(string fileName, string delimeter);
        Registrant GetByRegNum(int regNumber);
    }
}
