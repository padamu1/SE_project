using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEProject.Data.Model
{
    internal class MethodModel : AssemblyPresenter, IModel
    {
        private Action _action;

        public MethodModel()
        {
        }

        public void Set<T>(T o)
        {
            if (o is Action)
            {
                _action = o as Action;
            }
        }

        public void Check()
        {
            MemberInfo[] memberInfos = _action.GetType().GetMembers();
            foreach(var memberInfo in memberInfos)
            {
                Console.WriteLine(memberInfo.Name);
            }
        }
        public void Start(StringParser stringParser)
        {
        }

    }
}
