using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jemala.DB
{
    public class LocalMemory : IDatabase
    {
        public List<Jemalik> jemals { get; set; } = new List<Jemalik>();

        public string NameToNumber(string name)
        {
            var result = jemals.FirstOrDefault(o => o.Username.ToLower() == name.ToLower());
            return result.Phonenumber;
        }

        public string NumberToName(string number)
        {
            var result = jemals.FirstOrDefault(o => o.Phonenumber == number);
            return result.Username;
        }
    }
}
