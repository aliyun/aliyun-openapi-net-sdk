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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListQueuesResponse : AcsResponse
	{

		private string requestId;

		private List<ListQueues_QueueInfo> queues;

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

		public List<ListQueues_QueueInfo> Queues
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

		public class ListQueues_QueueInfo
		{

			private string queueName;

			private string type;

			private string resourceGroupId;

			private string hostNamePrefix;

			private string hostNameSuffix;

			private string spotStrategy;

			private string imageId;

			private bool? enableAutoGrow;

			private List<ListQueues_Instance> spotInstanceTypes;

			private List<string> computeInstanceType;

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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string HostNamePrefix
			{
				get
				{
					return hostNamePrefix;
				}
				set	
				{
					hostNamePrefix = value;
				}
			}

			public string HostNameSuffix
			{
				get
				{
					return hostNameSuffix;
				}
				set	
				{
					hostNameSuffix = value;
				}
			}

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public bool? EnableAutoGrow
			{
				get
				{
					return enableAutoGrow;
				}
				set	
				{
					enableAutoGrow = value;
				}
			}

			public List<ListQueues_Instance> SpotInstanceTypes
			{
				get
				{
					return spotInstanceTypes;
				}
				set	
				{
					spotInstanceTypes = value;
				}
			}

			public List<string> ComputeInstanceType
			{
				get
				{
					return computeInstanceType;
				}
				set	
				{
					computeInstanceType = value;
				}
			}

			public class ListQueues_Instance
			{

				private string instanceType;

				private float? spotPriceLimit;

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public float? SpotPriceLimit
				{
					get
					{
						return spotPriceLimit;
					}
					set	
					{
						spotPriceLimit = value;
					}
				}
			}
		}
	}
}
