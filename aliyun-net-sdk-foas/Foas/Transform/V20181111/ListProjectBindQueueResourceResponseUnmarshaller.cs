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
    public class ListProjectBindQueueResourceResponseUnmarshaller
    {
        public static ListProjectBindQueueResourceResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectBindQueueResourceResponse listProjectBindQueueResourceResponse = new ListProjectBindQueueResourceResponse();

			listProjectBindQueueResourceResponse.HttpResponse = context.HttpResponse;
			listProjectBindQueueResourceResponse.RequestId = context.StringValue("ListProjectBindQueueResource.RequestId");

			List<ListProjectBindQueueResourceResponse.ListProjectBindQueueResource_Queue> listProjectBindQueueResourceResponse_queues = new List<ListProjectBindQueueResourceResponse.ListProjectBindQueueResource_Queue>();
			for (int i = 0; i < context.Length("ListProjectBindQueueResource.Queues.Length"); i++) {
				ListProjectBindQueueResourceResponse.ListProjectBindQueueResource_Queue queue = new ListProjectBindQueueResourceResponse.ListProjectBindQueueResource_Queue();
				queue.ClusterId = context.StringValue("ListProjectBindQueueResource.Queues["+ i +"].ClusterId");
				queue.QueueName = context.StringValue("ListProjectBindQueueResource.Queues["+ i +"].QueueName");
				queue.MinGpu = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].MinGpu");
				queue.MaxGpu = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].MaxGpu");
				queue.MinMem = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].MinMem");
				queue.MaxMem = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].MaxMem");
				queue.MinVCore = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].MinVCore");
				queue.MaxVCore = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].MaxVCore");
				queue.UsedVCore = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].UsedVCore");
				queue.UsedGpu = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].UsedGpu");
				queue.UsedMem = context.IntegerValue("ListProjectBindQueueResource.Queues["+ i +"].UsedMem");

				listProjectBindQueueResourceResponse_queues.Add(queue);
			}
			listProjectBindQueueResourceResponse.Queues = listProjectBindQueueResourceResponse_queues;
        
			return listProjectBindQueueResourceResponse;
        }
    }
}
