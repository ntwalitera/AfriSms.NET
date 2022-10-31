# AfriSms .NET

[![NuGet version (AfriSms)](https://img.shields.io/nuget/v/AfriSms.svg?style=flat-square)](https://www.nuget.org/packages/AfriSms)

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
            AfriSms.Core.AfriSms.SendSms(SmsSetting.Email, SmsSetting.Password, SmsSetting.CompanySenderId, SmsSetting.UserId, SmsSetting.Message, Phones);
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
