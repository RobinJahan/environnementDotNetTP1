using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Book
    {
        private long id;
        private string name;
        private int nbPage;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NbPage { get => nbPage; set => nbPage = value; }
    }
}