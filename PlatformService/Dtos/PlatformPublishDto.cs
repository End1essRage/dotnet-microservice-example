using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platformservice.Dtos
{
    public class PlatformPublishDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
    }
}