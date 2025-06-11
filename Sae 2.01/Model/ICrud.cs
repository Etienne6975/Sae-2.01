using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sae_2._01.Model
{
    public interface ICrud<T>
    {
        public int Create();

        public void Read();

        public int Update();

        public int Delete();

        public List<T> FindAll();

        public List<T> FindBySelection(string criteres);
    }
}
