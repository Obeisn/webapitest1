using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace webapitest1.Models
{
    public class Message<T>
    {
        public T data { get; set; }
        public statusEM status { get; set; }
        public string message { get; set; }



        public Tuple<bool, dynamic> getSomthings(bool flag,dynamic dd)
        {
            return Tuple.Create(flag, dd);
        }

        public Message(T data, statusEM status)
        {
            this.data = data;
            this.status = status;
            returnMesssage();
        }
        private void returnMesssage()
        {
            switch (this.status)
            {
                case 0:
                    this.message = "成功";
                    break;
            }
        }
    }

    public enum statusEM
    {
        sucess = 0,
    }


}