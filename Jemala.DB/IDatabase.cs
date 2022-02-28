using System;

namespace Jemala.DB
{
    public interface IDatabase
    {
        public string NameToNumber(string name);
        public string NumberToName(string number);
    }
}
