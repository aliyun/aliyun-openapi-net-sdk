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
    public class ListProjectBindQueueResponseUnmarshaller
    {
        public static ListProjectBindQueueResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectBindQueueResponse listProjectBindQueueResponse = new ListProjectBindQueueResponse();

			listProjectBindQueueResponse.HttpResponse = context.HttpResponse;
			listProjectBindQueueResponse.RequestId = context.StringValue("ListProjectBindQueue.RequestId");

			List<ListProjectBindQueueResponse.ListProjectBindQueue_Queue> listProjectBindQueueResponse_queues = new List<ListProjectBindQueueResponse.ListProjectBindQueue_Queue>();
			for (int i = 0; i < context.Length("ListProjectBindQueue.Queues.Length"); i++) {
				ListProjectBindQueueResponse.ListProjectBindQueue_Queue queue = new ListProjectBindQueueResponse.ListProjectBindQueue_Queue();
				queue.ClusterId = context.StringValue("ListProjectBindQueue.Queues["+ i +"].ClusterId");
				queue.QueueName = context.StringValue("ListProjectBindQueue.Queues["+ i +"].QueueName");

				listProjectBindQueueResponse_queues.Add(queue);
			}
			listProjectBindQueueResponse.Queues = listProjectBindQueueResponse_queues;
        
			return listProjectBindQueueResponse;
        }
    }
}
