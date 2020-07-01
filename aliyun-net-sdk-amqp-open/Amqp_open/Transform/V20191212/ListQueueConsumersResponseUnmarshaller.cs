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
    public class ListQueueConsumersResponseUnmarshaller
    {
        public static ListQueueConsumersResponse Unmarshall(UnmarshallerContext context)
        {
			ListQueueConsumersResponse listQueueConsumersResponse = new ListQueueConsumersResponse();

			listQueueConsumersResponse.HttpResponse = context.HttpResponse;
			listQueueConsumersResponse.RequestId = context.StringValue("ListQueueConsumers.RequestId");

			ListQueueConsumersResponse.ListQueueConsumers_Data data = new ListQueueConsumersResponse.ListQueueConsumers_Data();
			data.NextToken = context.StringValue("ListQueueConsumers.Data.NextToken");
			data.MaxResults = context.IntegerValue("ListQueueConsumers.Data.MaxResults");

			List<ListQueueConsumersResponse.ListQueueConsumers_Data.ListQueueConsumers_QueueConsumerVO> data_consumers = new List<ListQueueConsumersResponse.ListQueueConsumers_Data.ListQueueConsumers_QueueConsumerVO>();
			for (int i = 0; i < context.Length("ListQueueConsumers.Data.Consumers.Length"); i++) {
				ListQueueConsumersResponse.ListQueueConsumers_Data.ListQueueConsumers_QueueConsumerVO queueConsumerVO = new ListQueueConsumersResponse.ListQueueConsumers_Data.ListQueueConsumers_QueueConsumerVO();
				queueConsumerVO.ConsumerTag = context.StringValue("ListQueueConsumers.Data.Consumers["+ i +"].ConsumerTag");

				data_consumers.Add(queueConsumerVO);
			}
			data.Consumers = data_consumers;
			listQueueConsumersResponse.Data = data;
        
			return listQueueConsumersResponse;
        }
    }
}
