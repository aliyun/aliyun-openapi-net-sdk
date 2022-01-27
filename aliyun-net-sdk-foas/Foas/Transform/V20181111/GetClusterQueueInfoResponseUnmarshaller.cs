/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class GetClusterQueueInfoResponseUnmarshaller
    {
        public static GetClusterQueueInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetClusterQueueInfoResponse getClusterQueueInfoResponse = new GetClusterQueueInfoResponse();

			getClusterQueueInfoResponse.HttpResponse = _ctx.HttpResponse;
			getClusterQueueInfoResponse.RequestId = _ctx.StringValue("GetClusterQueueInfo.RequestId");

			List<GetClusterQueueInfoResponse.GetClusterQueueInfo_Queue> getClusterQueueInfoResponse_queues = new List<GetClusterQueueInfoResponse.GetClusterQueueInfo_Queue>();
			for (int i = 0; i < _ctx.Length("GetClusterQueueInfo.Queues.Length"); i++) {
				GetClusterQueueInfoResponse.GetClusterQueueInfo_Queue queue = new GetClusterQueueInfoResponse.GetClusterQueueInfo_Queue();
				queue.ClusterId = _ctx.StringValue("GetClusterQueueInfo.Queues["+ i +"].ClusterId");
				queue.QueueName = _ctx.StringValue("GetClusterQueueInfo.Queues["+ i +"].QueueName");
				queue.MinGpu = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].MinGpu");
				queue.MaxGpu = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].MaxGpu");
				queue.MinMem = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].MinMem");
				queue.UsedVCore = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].UsedVCore");
				queue.UsedGpu = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].UsedGpu");
				queue.UsedMem = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].UsedMem");
				queue.MinVCore = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].MinVCore");
				queue.MaxVCore = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].MaxVCore");
				queue.MaxMem = _ctx.IntegerValue("GetClusterQueueInfo.Queues["+ i +"].MaxMem");
				queue.ExternalInfo = _ctx.StringValue("GetClusterQueueInfo.Queues["+ i +"].ExternalInfo");

				getClusterQueueInfoResponse_queues.Add(queue);
			}
			getClusterQueueInfoResponse.Queues = getClusterQueueInfoResponse_queues;
        
			return getClusterQueueInfoResponse;
        }
    }
}
