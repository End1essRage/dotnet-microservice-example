using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CommandService.Models;
using Grpc.Net.Client;
using PlatformService;

namespace CommandService.SyncDataServices.Grpc
{
    public class PlatformDataClient : IPlatformDataClient
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public PlatformDataClient(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }

        public IEnumerable<Platform> ReturnAllPlatforms()
        {
            Console.WriteLine($"--> Calling GRPC Service {_configuration.GetSection("GrpcPlatform").Value}");
            var channel = GrpcChannel.ForAddress(_configuration.GetSection("GrpcPlatform").Value);
            var client = new GrpcPlatform.GrpcPlatformClient(channel);
            var request = new GetAllRequest();

            try
            {
                var reply = client.GetAllPlatforms(request);

                return _mapper.Map<IEnumerable<Platform>>(reply.Platforms);
            }
            catch (Exception e)
            {
                Console.WriteLine($"--> Could Not call GRPC Server {e.Message}");
                return new List<Platform>();
            }
        }
    }
}