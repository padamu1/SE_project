using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProject.Operator.Base
{
    public class Plus : IOperator
    {
        public string Name { get => "+";}

        public object Invoke(object[] param)
        {
            if(param.Length <= 1)
            {
                throw new NotImplementedException();
            }
            else
            {

            }
            return param[0];
        }
    }
}
