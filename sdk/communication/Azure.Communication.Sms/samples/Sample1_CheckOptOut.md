# Check if the recipient(s) opted-out from sender 

This sample demonstrates how to check if the individual or a group of recipients opted-out from the  sender.

To get started you'll need a Communication Service Resource.  See [README][README] for prerequisites and instructions.

## Creating an `SmsClient`

SMS clients can be authenticated using the connection string acquired from an Azure Communication Resource in the Azure Portal. Alternatively, SMS clients can also be authenticated using a valid token credential.

```C# Snippet:Azure_Communication_Sms_Tests_Samples_CreateSmsClientWithToken
string endpoint = "<endpoint_url>";
TokenCredential tokenCredential = new DefaultAzureCredential();
SmsClient client = new SmsClient(new Uri(endpoint), tokenCredential);
```

## Check if the individual or a group of recipients opted-out

To check, call the `Check` or `CheckAsync` function from the SmsClient's OptOuts object with a list of recipient's phone numbers. The returned value is a collection of `OptOutResponseItem` objects -- one for each of the receipients.

```C# Snippet:Azure_Communication_SmsClient_OptOuts_Check
var response = smsClient.OptOuts.Check(
    from: "<from-phone-number>", // Your E.164 formatted from phone number used to send SMS
    to: new string[] { "<to-phone-number-1>", "<to-phone-number-2>" }, // E.164 formatted recipient phone numbers
    );

foreach (OptOutResponseItem result in response.Value)
{
    Console.WriteLine($"Recipient: {result.To}");
    Console.WriteLine($"Result: {result.HttpStatusCode}");
    Console.WriteLine($"Is opted out: {result.IsOptedOut}");
}
```

[README]: https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/communication/Azure.Communication.Sms/README.md#getting-started
