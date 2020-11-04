using System;
using Microsoft.Graph;
using System.Collections.Generic;

namespace autorest_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = GraphClientFactory.Create(new DelegateAuthenticationProvider(
                            async (requestMessage) =>
                            {
                                var token = "TODO";
                                requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", token);

                            }));
            var client = new Mail(httpClient, true);
            var createdMail = client.UsersmailFolders.CreateMessages(new Microsoft.Graph.Models.Microsoftgraphmessage() {Subject = "Test subject"}, "TODO", "inbox");
            var message = client.UsersmailFolders.GetMessages("userId", "inbox", "messageId", new List<string>() {"id", "subject"});
            var message2 = client.Users.CreateMessages(new Microsoft.Graph.Models.Microsoftgraphmessage() {Subject = "Test subject"}, "userId");
            //var groupmessage = client.Groups.CreateMessages(new Microsoft.Graph.Models.Microsoftgraphmessage() {Subject = "Test subject"}, "groupId");

            Console.WriteLine($"Hello World!\n Id: {createdMail.Subject} ");
        }
    }
}


