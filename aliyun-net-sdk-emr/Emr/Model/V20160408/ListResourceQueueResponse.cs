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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListResourceQueueResponse : AcsResponse
	{

		private List<ListResourceQueue_Queue> queueList;

		public List<ListResourceQueue_Queue> QueueList
		{
			get
			{
				return queueList;
			}
			set	
			{
				queueList = value;
			}
		}

		public class ListResourceQueue_Queue
		{

			private ListResourceQueue_EcmResourceQueue ecmResourceQueue;

			public ListResourceQueue_EcmResourceQueue EcmResourceQueue
			{
				get
				{
					return ecmResourceQueue;
				}
				set	
				{
					ecmResourceQueue = value;
				}
			}

			public class ListResourceQueue_EcmResourceQueue
			{

				private long? id;

				private string name;

				private string qualifiedName;

				private string queueType;

				private long? parentQueueId;

				private bool? leaf;

				private string status;

				private string userId;

				private long? resourcePoolId;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string QualifiedName
				{
					get
					{
						return qualifiedName;
					}
					set	
					{
						qualifiedName = value;
					}
				}

				public string QueueType
				{
					get
					{
						return queueType;
					}
					set	
					{
						queueType = value;
					}
				}

				public long? ParentQueueId
				{
					get
					{
						return parentQueueId;
					}
					set	
					{
						parentQueueId = value;
					}
				}

				public bool? Leaf
				{
					get
					{
						return leaf;
					}
					set	
					{
						leaf = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public long? ResourcePoolId
				{
					get
					{
						return resourcePoolId;
					}
					set	
					{
						resourcePoolId = value;
					}
				}
			}
		}
	}
}
