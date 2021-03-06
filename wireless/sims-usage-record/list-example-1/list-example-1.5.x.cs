// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Wireless.V1.Sim;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var usageRecords = UsageRecordResource.Read("DEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

        foreach (var usageRecord in usageRecords)
        {
            Console.WriteLine(usageRecord.Commands);
        }
    }
}
