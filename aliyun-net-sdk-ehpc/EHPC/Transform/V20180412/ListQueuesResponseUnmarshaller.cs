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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListQueuesResponseUnmarshaller
    {
        public static ListQueuesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQueuesResponse listQueuesResponse = new ListQueuesResponse();

			listQueuesResponse.HttpResponse = _ctx.HttpResponse;
			listQueuesResponse.RequestId = _ctx.StringValue("ListQueues.RequestId");

			List<ListQueuesResponse.ListQueues_QueueInfo> listQueuesResponse_queues = new List<ListQueuesResponse.ListQueues_QueueInfo>();
			for (int i = 0; i < _ctx.Length("ListQueues.Queues.Length"); i++) {
				ListQueuesResponse.ListQueues_QueueInfo queueInfo = new ListQueuesResponse.ListQueues_QueueInfo();
				queueInfo.QueueName = _ctx.StringValue("ListQueues.Queues["+ i +"].QueueName");
				queueInfo.Type = _ctx.StringValue("ListQueues.Queues["+ i +"].Type");
				queueInfo.ResourceGroupId = _ctx.StringValue("ListQueues.Queues["+ i +"].ResourceGroupId");
				queueInfo.ComputeInstanceType = _ctx.StringValue("ListQueues.Queues["+ i +"].ComputeInstanceType");

				listQueuesResponse_queues.Add(queueInfo);
			}
			listQueuesResponse.Queues = listQueuesResponse_queues;
        
			return listQueuesResponse;
        }
    }
}
