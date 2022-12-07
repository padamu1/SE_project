using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProject.Operator
{
    public class OperatorManager
    {
        private Dictionary<string, IOperator> operatorDic;
        public OperatorManager()
        {
            operatorDic = new Dictionary<string, IOperator>();
        }
        public void SetOperator(IOperator operation)
        {
            if (operatorDic.ContainsKey(operation.Name))
            {
                Console.WriteLine("{0} already added", operation.Name);
                return;
            }
            operatorDic[operation.Name] = operation;
        }
        public object Excute(string operatorName, object[] param)
        {
            if (operatorDic.ContainsKey(operatorName))
            {
                return operatorDic[operatorName].Invoke(param);
            }
            Console.WriteLine("{0} not exist", operatorName);
            return null;
        }
    }

}
