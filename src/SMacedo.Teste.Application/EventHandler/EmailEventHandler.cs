using MediatR;
using SMacedo.Teste.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Application.EventHandler
{
    public class EmailEventHandler : INotificationHandler<EmailNotification>
    {
        public Task Handle(EmailNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => { Console.WriteLine($"Email enviado para {notification.Email} | {notification.Description} | {notification.Subject} | {notification.Email}"); }, cancellationToken);
        }
    }
}
