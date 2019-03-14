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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListResourceQueueResponseUnmarshaller
    {
        public static ListResourceQueueResponse Unmarshall(UnmarshallerContext context)
        {
			ListResourceQueueResponse listResourceQueueResponse = new ListResourceQueueResponse();

			listResourceQueueResponse.HttpResponse = context.HttpResponse;

			List<ListResourceQueueResponse.ListResourceQueue_Queue> listResourceQueueResponse_queueList = new List<ListResourceQueueResponse.ListResourceQueue_Queue>();
			for (int i = 0; i < context.Length("ListResourceQueue.QueueList.Length"); i++) {
				ListResourceQueueResponse.ListResourceQueue_Queue queue = new ListResourceQueueResponse.ListResourceQueue_Queue();

				ListResourceQueueResponse.ListResourceQueue_Queue.ListResourceQueue_EcmResourceQueue ecmResourceQueue = new ListResourceQueueResponse.ListResourceQueue_Queue.ListResourceQueue_EcmResourceQueue();
				ecmResourceQueue.Id = context.LongValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.Id");
				ecmResourceQueue.Name = context.StringValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.Name");
				ecmResourceQueue.QualifiedName = context.StringValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.QualifiedName");
				ecmResourceQueue.QueueType = context.StringValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.QueueType");
				ecmResourceQueue.ParentQueueId = context.LongValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.ParentQueueId");
				ecmResourceQueue.Leaf = context.BooleanValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.Leaf");
				ecmResourceQueue.Status = context.StringValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.Status");
				ecmResourceQueue.UserId = context.StringValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.UserId");
				ecmResourceQueue.ResourcePoolId = context.LongValue("ListResourceQueue.QueueList["+ i +"].EcmResourceQueue.ResourcePoolId");
				queue.EcmResourceQueue = ecmResourceQueue;

				listResourceQueueResponse_queueList.Add(queue);
			}
			listResourceQueueResponse.QueueList = listResourceQueueResponse_queueList;
        
			return listResourceQueueResponse;
        }
    }
}
