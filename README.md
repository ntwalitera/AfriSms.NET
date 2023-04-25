# AfriSms .NET

[![NuGet](https://img.shields.io/nuget/v/AfriSms.svg)](https://www.nuget.org/packages/AfriSms/) 
[![NuGet](https://img.shields.io/nuget/dt/AfriSms.svg)](https://www.nuget.org/packages/AfriSms/)

### Installation

Install `AfriSms` from [NuGet](http://www.nuget.org/).

```
PM> Install-Package AfriSms
```

### Setup 

```c#
using System;
using System.Collections.Generic;

namespace AfriSmsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Phones = new List<string>{ "078xxxxxxx", "079xxxxxxx", "072xxxxxxx" };
            AfriSms.AfriSms sms = new AfriSms.AfriSms();
            var result = await sms.SendSms(SmsSetting.Email, SmsSetting.Password, SmsSetting.CompanySenderId, SmsSetting.UserId, SmsSetting.Message, Phones);
        }
    }
}
public class SmsSetting
{
    public const string Email = "";
    public const string Password = "";
    public const string CompanySenderId = "";
    public const string UserId = "";
    public const string Message = "";
}
```

That's it! 


# License

MIT


# Bugs and Feedback

For bugs, questions and discussions please use the [GitHub Issues](https://github.com/ntwalitera/AfriSms.NET/issues).

# Links

- NuGet Package: [https://www.nuget.org/packages/AfriSms](https://www.nuget.org/packages/AfriSms/)
- GitHub Repo: [ntwalitera/AfriSms.NET](https://github.com/ntwalitera/AfriSms.NET)
