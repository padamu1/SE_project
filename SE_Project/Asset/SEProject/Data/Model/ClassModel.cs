using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEProject.Data.Model
{
    internal class ClassModel : AssemblyPresenter, IModel
    {
        private object _o;

        public ClassModel()
        {
            _o = new object();
        }


        public void Set<T>(T o)
        {
            if(o is object)
            {
                _o = o;
            }
        }
        public void Check()
        {
            MethodInfo? o = _o.GetType().GetMethod("SetUserName");
            Console.WriteLine(o.Name) ;
        }
        public void Start(StringParser stringParser)
        {
            MethodInfo? o = _o.GetType().GetMethod(stringParser.GetMethodName());

            var user = Activator.CreateInstance(o.DeclaringType);

            o.Invoke(user, stringParser.GetParameters());
        }
    }
}
