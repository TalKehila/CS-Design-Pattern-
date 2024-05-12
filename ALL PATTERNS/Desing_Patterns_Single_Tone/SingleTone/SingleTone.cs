using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns_Single_Tone.SingleTone
{
    public class SingleTone
    {
        static SingleTone instance;
        public string setting { get; set; } = "color blue";   
        protected SingleTone()
        {
        
        
        }
        public static SingleTone Instance()
        {
            if(instance == null)
            {
                instance = new SingleTone();
            }
            return instance;

        }

    }

    // short way to do single tone
    //public class MyService
    //{
    //    private MyService() { }
    //    public static MyService Init { get; } = new MyService();
    //}
}
