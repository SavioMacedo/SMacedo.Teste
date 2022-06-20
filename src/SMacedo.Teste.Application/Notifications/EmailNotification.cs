using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.Notifications
{
    public class EmailNotification: INotification
    {
        public EmailNotification(string subject, string email, string description)
        {
            Subject = subject;
            Email = email;
            Description = description;
        }

        public string Subject { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
