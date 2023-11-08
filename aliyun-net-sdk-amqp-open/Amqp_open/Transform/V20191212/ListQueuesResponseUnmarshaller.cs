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
        public static ListQueuesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQueuesResponse listQueuesResponse = new ListQueuesResponse();

			listQueuesResponse.HttpResponse = _ctx.HttpResponse;
			listQueuesResponse.RequestId = _ctx.StringValue("ListQueues.RequestId");

			ListQueuesResponse.ListQueues_Data data = new ListQueuesResponse.ListQueues_Data();
			data.MaxResults = _ctx.IntegerValue("ListQueues.Data.MaxResults");
			data.NextToken = _ctx.StringValue("ListQueues.Data.NextToken");

			List<ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO> data_queues = new List<ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO>();
			for (int i = 0; i < _ctx.Length("ListQueues.Data.Queues.Length"); i++) {
				ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO queueVO = new ListQueuesResponse.ListQueues_Data.ListQueues_QueueVO();
				queueVO.ExclusiveState = _ctx.BooleanValue("ListQueues.Data.Queues["+ i +"].ExclusiveState");
				queueVO.AutoDeleteState = _ctx.BooleanValue("ListQueues.Data.Queues["+ i +"].AutoDeleteState");
				queueVO.CreateTime = _ctx.LongValue("ListQueues.Data.Queues["+ i +"].CreateTime");
				queueVO.Attributes = _ctx.StringValue("ListQueues.Data.Queues["+ i +"].Attributes");
				queueVO.VHostName = _ctx.StringValue("ListQueues.Data.Queues["+ i +"].VHostName");
				queueVO.Name = _ctx.StringValue("ListQueues.Data.Queues["+ i +"].Name");
				queueVO.OwnerId = _ctx.StringValue("ListQueues.Data.Queues["+ i +"].OwnerId");
				queueVO.LastConsumeTime = _ctx.LongValue("ListQueues.Data.Queues["+ i +"].LastConsumeTime");

				data_queues.Add(queueVO);
			}
			data.Queues = data_queues;
			listQueuesResponse.Data = data;
        
			return listQueuesResponse;
        }
    }
}
