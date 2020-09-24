using Logit_Transport.Data.Models;
using Logit_Transport.DataProcessor.ImportDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Logit_Transport.Services;
using Logit_Transport.Data;
using System.Linq;
using System.Text;

namespace Logit_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var context = new LogitDbContext();
            context.Database.EnsureCreated();

            var participantService = new ParticipantService(context);

            while (true)
            {
                //Попълни ми данните на човека/фирмата, който ще изпраща стоката. Ако са му грешни въведените данни искай му ги пак
                string message = participantService.CreateParticipant();
                Console.WriteLine(message);

                if (message != "Invalid data")
                {
                    break;
                }
            }

            while (true)
            {
                //Попълни ми данните на получателя на стоката. Ако съ грешни се върни отначало да ги попълва
                string message = participantService.CreateParticipant();
                Console.WriteLine(message);

                if (message != "Invalid data")
                {
                    break;
                }

            }
           

        }




    }
}
