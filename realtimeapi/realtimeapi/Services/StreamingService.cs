using Grpc.Core;
using realtimeapi.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace realtimeapi.Services
{
    public class StreamingService : streaming.streamingBase
    {
        public override async Task StreamingFromServer(streamrequest req, IServerStreamWriter<streamresponse> responseStream, ServerCallContext context)
        {
            streamresponse res = new streamresponse();
            while(true)
            {
                res.Response = "generate random strings";
                await responseStream.WriteAsync(res);
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
        }
    }
}
