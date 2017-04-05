using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimMeetLibrary
{
    public interface IClubsRepository
    {
        int Number { set; get; }
        void Add(Club aClub);
        void Load(string fileName, string delimeter);
        void Save(string fileName, string delimeter);
        Club GetByRegNum(int regNumber);

    }
}
