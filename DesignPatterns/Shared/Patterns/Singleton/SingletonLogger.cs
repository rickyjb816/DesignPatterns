using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Singleton {
    public class SingletonLogger {
        static readonly Lazy<SingletonLogger> _lazy = new(new SingletonLogger());

        private SingletonLogger() { }

        public static SingletonLogger Instance => _lazy.Value;

        private List<string> _logs = new List<string>();

        public int LogCount() => _logs.Count;

        public void Log() => Log("This is the singleton class");
        

        public void Log(string message) {
            _logs.Add("[Logger]: {message}");
            Console.WriteLine($"[Logger]: {message}");
            Console.WriteLine($"[Logger]: Log count is: {_logs.Count()}");
        }

    }
}
