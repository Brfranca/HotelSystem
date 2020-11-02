using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PresentationLayer.Load
{
    public class Loading
    {
        private static FormLoad _formLoad;
        private static Thread _thread;

        public static void Load(Action method)
        {
            StartLoad();
            method.Invoke();
            StopLoad();
        }

        public static void Load<T>(Action<T> method, T model)
        {
            StartLoad();
            method.Invoke(model);
            StopLoad();
        }

        public static void Load<T,T2>(Action<T,T2> method, T model, T2 model2)
        {
            StartLoad();
            method.Invoke(model, model2);
            StopLoad();
        }

        public static void Load<T, T2, T3>(Action<T, T2, T3> method, T model, T2 model2, T3 model3)
        {
            StartLoad();
            method.Invoke(model, model2, model3);
            StopLoad();
        }

        public static R Load<R>(Func<R> method)
        {
            StartLoad();
            var result = method.Invoke();
            StopLoad();
            return result;
        }

        public static R Load<T, R>(Func<T, R> method, T model)
        {
            StartLoad();
            var result = method.Invoke(model);
            StopLoad();
            return result;
        }

        public static R Load<T,T2, R>(Func<T,T2, R> method, T model, T2 model2)
        {
            StartLoad();
            var result = method.Invoke(model, model2);
            StopLoad();
            return result;
        }

        public static R Load<T, T2,T3, R>(Func<T, T2,T3, R> method, T model, T2 model2, T3 model3)
        {
            StartLoad();
            var result = method.Invoke(model, model2, model3);
            StopLoad();
            return result;
        }

        private static void StartLoad()
        {
            _formLoad = new FormLoad();
            ThreadStart threadStart = new ThreadStart(Show);
            _thread = new Thread(threadStart);
            _thread.Start();
            void Show() => _formLoad.ShowDialog();
        }

        private static void StopLoad()
        {
            _thread.Abort();
        }
    }
}
