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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class ListProjectBindQueueResponse : AcsResponse
	{

		private string requestId;

		private List<ListProjectBindQueue_Queue> queues;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListProjectBindQueue_Queue> Queues
		{
			get
			{
				return queues;
			}
			set	
			{
				queues = value;
			}
		}

		public class ListProjectBindQueue_Queue
		{

			private string clusterId;

			private string queueName;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string QueueName
			{
				get
				{
					return queueName;
				}
				set	
				{
					queueName = value;
				}
			}
		}
	}
}
