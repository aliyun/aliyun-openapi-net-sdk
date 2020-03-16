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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class ListQueuesResponseUnmarshaller
    {
        public static ListQueuesResponse Unmarshall(UnmarshallerContext context)
        {
			ListQueuesResponse listQueuesResponse = new ListQueuesResponse();

			listQueuesResponse.HttpResponse = context.HttpResponse;
			listQueuesResponse.RequestId = context.StringValue("ListQueues.RequestId");

			ListQueuesResponse.ListQueues_Data data = new ListQueuesResponse.ListQueues_Data();
			data.NextToken = context.StringValue("ListQueues.Data.NextToken");
			data.MaxResults = context.IntegerValue("ListQueues.Data.MaxResults");

			List<ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO> data_queues = new List<ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO>();
			for (int i = 0; i < context.Length("ListQueues.Data.Queues.Length"); i++) {
				ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO queueVO = new ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO();
				queueVO.Name = context.StringValue("ListQueues.Data.Queues["+ i +"].Name");
				queueVO.OwnerId = context.StringValue("ListQueues.Data.Queues["+ i +"].OwnerId");
				queueVO.VHostName = context.StringValue("ListQueues.Data.Queues["+ i +"].VHostName");
				queueVO.AutoDeleteState = context.BooleanValue("ListQueues.Data.Queues["+ i +"].AutoDeleteState");
				queueVO.ExclusiveState = context.BooleanValue("ListQueues.Data.Queues["+ i +"].ExclusiveState");
				queueVO.CreateTime = context.LongValue("ListQueues.Data.Queues["+ i +"].CreateTime");
				queueVO.LastConsumeTime = context.LongValue("ListQueues.Data.Queues["+ i +"].LastConsumeTime");
				queueVO.Attributes = context.StringValue("ListQueues.Data.Queues["+ i +"].Attributes");

				data_queues.Add(queueVO);
			}
			data.Queues = data_queues;
			listQueuesResponse.Data = data;
        
			return listQueuesResponse;
        }
    }
}
