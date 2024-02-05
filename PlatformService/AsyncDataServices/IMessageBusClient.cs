using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platformservice.Dtos;

namespace Platformservice.AsyncDataServices
{
    public interface IMessageBusClient
    {
        void PublishNewPlatform(PlatformPublishDto platformPublishDto);
    }
}