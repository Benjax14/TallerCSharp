using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerC_
{
    public class Exercises
    {

        public static Person AgedRut(List<Person> persons)
        {
            var query = persons.OrderBy(o => o.Rut).FirstOrDefault();

            return query;
        }

        //aqui agregan metodo


    }
}
