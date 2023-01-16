using static ServiceReference1.NumberConversionSoapTypeClient;

ServiceReference1.NumberConversionSoapTypeClient client = new ServiceReference1.NumberConversionSoapTypeClient(EndpointConfiguration.NumberConversionSoap);

string dolares=client.NumberToDollars(10);

Console.WriteLine(dolares);
