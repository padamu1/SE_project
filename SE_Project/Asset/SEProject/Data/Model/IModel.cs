using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProject.Data.Model
{
    public interface IModel
    {
        public void Set<T>(T o);

        public void Check();
    }
}
