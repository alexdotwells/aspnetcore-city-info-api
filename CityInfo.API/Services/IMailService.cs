using System;
using System.Collections.Generic;

namespace CityInfo.API.Services
{
    public interface IMailService
    {
        void Send(string subject, string message);
    }
}
