using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Question_03
{
    internal interface INotificationService
    {
        void SendNotification(string message, string recipient);
    }
}
