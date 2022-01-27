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
				queueInfo.HostNamePrefix = _ctx.StringValue("ListQueues.Queues["+ i +"].HostNamePrefix");
				queueInfo.HostNameSuffix = _ctx.StringValue("ListQueues.Queues["+ i +"].HostNameSuffix");
				queueInfo.SpotStrategy = _ctx.StringValue("ListQueues.Queues["+ i +"].SpotStrategy");
				queueInfo.ImageId = _ctx.StringValue("ListQueues.Queues["+ i +"].ImageId");
				queueInfo.EnableAutoGrow = _ctx.BooleanValue("ListQueues.Queues["+ i +"].EnableAutoGrow");

				List<string> queueInfo_computeInstanceType = new List<string>();
				for (int j = 0; j < _ctx.Length("ListQueues.Queues["+ i +"].ComputeInstanceType.Length"); j++) {
					queueInfo_computeInstanceType.Add(_ctx.StringValue("ListQueues.Queues["+ i +"].ComputeInstanceType["+ j +"]"));
				}
				queueInfo.ComputeInstanceType = queueInfo_computeInstanceType;

				List<ListQueuesResponse.ListQueues_QueueInfo.ListQueues_Instance> queueInfo_spotInstanceTypes = new List<ListQueuesResponse.ListQueues_QueueInfo.ListQueues_Instance>();
				for (int j = 0; j < _ctx.Length("ListQueues.Queues["+ i +"].SpotInstanceTypes.Length"); j++) {
					ListQueuesResponse.ListQueues_QueueInfo.ListQueues_Instance instance = new ListQueuesResponse.ListQueues_QueueInfo.ListQueues_Instance();
					instance.InstanceType = _ctx.StringValue("ListQueues.Queues["+ i +"].SpotInstanceTypes["+ j +"].InstanceType");
					instance.SpotPriceLimit = _ctx.FloatValue("ListQueues.Queues["+ i +"].SpotInstanceTypes["+ j +"].SpotPriceLimit");

					queueInfo_spotInstanceTypes.Add(instance);
				}
				queueInfo.SpotInstanceTypes = queueInfo_spotInstanceTypes;

				listQueuesResponse_queues.Add(queueInfo);
			}
			listQueuesResponse.Queues = listQueuesResponse_queues;
        
			return listQueuesResponse;
        }
    }
}
