using SEProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProject.Data
{
    public class StringExpression : IModel
    {
        private IModel model;
        public void Set<T>(T o)
        {
            if (o is object)
            {
                model = new ClassModel();
            }
            else if (o is Action)
            {
                model = new MethodModel();
            }
            else
            {
                throw new Exception("UnkownType Error");
            }
            model.Set(o);
        }

        public void Check()
        {
            model.Check();
        }
    }
}
