using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProject
{
    public class StringParser
    {
        private string _methodName;
        private object[] _parameters;

        public void Parse(string context)
        {
            int parameterStartPos = context.IndexOf('(');
            int parameterEndPos = context.IndexOf(')');
            _methodName = context.Substring(0, parameterStartPos);
            //Console.WriteLine(_methodName);
            string param = context.Substring(parameterStartPos + 1,parameterEndPos-(parameterStartPos+1));
            //Console.WriteLine(param);
            List<object> _parameters = new List<object>();

            string[] parameters = param.Split(',');
            for(int count = 0; count < parameters.Length; count++)
            {
                _parameters.Add(parameters[count].Trim('"'));
                //Console.WriteLine(_parameters[count]);
            }
            this._parameters = parameters.ToArray();
        }
        public string GetMethodName()
        {
            return _methodName;
        }
        public object[] GetParameters()
        {
            return _parameters;
        }
    }
}
