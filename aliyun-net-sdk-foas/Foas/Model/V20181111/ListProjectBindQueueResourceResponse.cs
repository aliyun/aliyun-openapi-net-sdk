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
	public class ListProjectBindQueueResourceResponse : AcsResponse
	{

		private string requestId;

		private List<ListProjectBindQueueResource_Queue> queues;

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

		public List<ListProjectBindQueueResource_Queue> Queues
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

		public class ListProjectBindQueueResource_Queue
		{

			private string clusterId;

			private string queueName;

			private int? minGpu;

			private int? maxGpu;

			private int? minMem;

			private int? maxMem;

			private int? minVCore;

			private int? maxVCore;

			private int? usedVCore;

			private int? usedGpu;

			private int? usedMem;

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

			public int? MinGpu
			{
				get
				{
					return minGpu;
				}
				set	
				{
					minGpu = value;
				}
			}

			public int? MaxGpu
			{
				get
				{
					return maxGpu;
				}
				set	
				{
					maxGpu = value;
				}
			}

			public int? MinMem
			{
				get
				{
					return minMem;
				}
				set	
				{
					minMem = value;
				}
			}

			public int? MaxMem
			{
				get
				{
					return maxMem;
				}
				set	
				{
					maxMem = value;
				}
			}

			public int? MinVCore
			{
				get
				{
					return minVCore;
				}
				set	
				{
					minVCore = value;
				}
			}

			public int? MaxVCore
			{
				get
				{
					return maxVCore;
				}
				set	
				{
					maxVCore = value;
				}
			}

			public int? UsedVCore
			{
				get
				{
					return usedVCore;
				}
				set	
				{
					usedVCore = value;
				}
			}

			public int? UsedGpu
			{
				get
				{
					return usedGpu;
				}
				set	
				{
					usedGpu = value;
				}
			}

			public int? UsedMem
			{
				get
				{
					return usedMem;
				}
				set	
				{
					usedMem = value;
				}
			}
		}
	}
}
