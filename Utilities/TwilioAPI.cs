using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwilioWeb.Data;
using TwilioWeb.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioWeb.Utilities
{
    public class TwilioAPI
    {

        //This Class is for sending the Messages to the recipients using the Custom Phone number provided by Twilio
        private  MyContext _context;
        public sentmessages SendMessage(messages messages, MyContext Ctx)
        {
            try {
                _context = Ctx;
                sentmessages messageSent = new sentmessages();
                TwilioCredentials Credentials= new TwilioCredentials();
                Credentials = _context.twilioCredentials.FirstOrDefault();
                //Obteining the credentials from the Database
                string accountSid = Credentials.TSID;
                string authToken = Credentials.TTOKEN;

                TwilioClient.Init(accountSid, authToken);
                //Sending the message for each phone number
                String[] listOfPhones = messages.to_field.Split(",");
                string confirmationCodes="";
                foreach (var phone in listOfPhones) {
                    var message = MessageResource.Create(
                  body: messages.message,
                  from: new Twilio.Types.PhoneNumber("+12183095071"),
                  to: new Twilio.Types.PhoneNumber(phone)
              );
                    confirmationCodes += message.Sid + "|";
                }
              
                messageSent.messagesId = messages.id;
                messageSent.sentdate = DateTime.Now;
                messageSent.cofirmationcode = confirmationCodes;
                //returning the response from the API
                return messageSent;
            } catch (Exception e) 
            { return null; }
        }
    }
}
