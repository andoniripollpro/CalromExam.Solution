using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CalromExam.Web
{
    /// <summary>
    /// Probably an anti-pattern, but so far this is the best I can get
    /// </summary>
    public class IoCManager
    {
        public static T Resolve<T>()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            return kernel.Get<T>();
        }
    }
}