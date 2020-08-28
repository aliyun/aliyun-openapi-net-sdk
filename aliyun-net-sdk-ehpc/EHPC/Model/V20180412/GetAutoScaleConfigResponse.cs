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
	public class GetAutoScaleConfigResponse : AcsResponse
	{

		private string requestId;

		private string uid;

		private string clusterId;

		private string clusterType;

		private bool? enableAutoGrow;

		private bool? enableAutoShrink;

		private int? growIntervalInMinutes;

		private int? shrinkIntervalInMinutes;

		private int? shrinkIdleTimes;

		private int? growTimeoutInMinutes;

		private int? extraNodesGrowRatio;

		private int? growRatio;

		private int? maxNodesInCluster;

		private string excludeNodes;

		private string spotStrategy;

		private float? spotPriceLimit;

		private string imageId;

		private List<GetAutoScaleConfig_QueueInfo> queues;

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

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
			}
		}

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

		public string ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
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

		public bool? EnableAutoShrink
		{
			get
			{
				return enableAutoShrink;
			}
			set	
			{
				enableAutoShrink = value;
			}
		}

		public int? GrowIntervalInMinutes
		{
			get
			{
				return growIntervalInMinutes;
			}
			set	
			{
				growIntervalInMinutes = value;
			}
		}

		public int? ShrinkIntervalInMinutes
		{
			get
			{
				return shrinkIntervalInMinutes;
			}
			set	
			{
				shrinkIntervalInMinutes = value;
			}
		}

		public int? ShrinkIdleTimes
		{
			get
			{
				return shrinkIdleTimes;
			}
			set	
			{
				shrinkIdleTimes = value;
			}
		}

		public int? GrowTimeoutInMinutes
		{
			get
			{
				return growTimeoutInMinutes;
			}
			set	
			{
				growTimeoutInMinutes = value;
			}
		}

		public int? ExtraNodesGrowRatio
		{
			get
			{
				return extraNodesGrowRatio;
			}
			set	
			{
				extraNodesGrowRatio = value;
			}
		}

		public int? GrowRatio
		{
			get
			{
				return growRatio;
			}
			set	
			{
				growRatio = value;
			}
		}

		public int? MaxNodesInCluster
		{
			get
			{
				return maxNodesInCluster;
			}
			set	
			{
				maxNodesInCluster = value;
			}
		}

		public string ExcludeNodes
		{
			get
			{
				return excludeNodes;
			}
			set	
			{
				excludeNodes = value;
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

		public List<GetAutoScaleConfig_QueueInfo> Queues
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

		public class GetAutoScaleConfig_QueueInfo
		{

			private string queueName;

			private string resourceGroupId;

			private string instanceType;

			private string spotStrategy;

			private float? spotPriceLimit;

			private bool? enableAutoGrow;

			private bool? enableAutoShrink;

			private int? maxNodesInQueue;

			private int? minNodesInQueue;

			private string queueImageId;

			private List<GetAutoScaleConfig_InstanceTypeInfo> instanceTypes;

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

			public bool? EnableAutoShrink
			{
				get
				{
					return enableAutoShrink;
				}
				set	
				{
					enableAutoShrink = value;
				}
			}

			public int? MaxNodesInQueue
			{
				get
				{
					return maxNodesInQueue;
				}
				set	
				{
					maxNodesInQueue = value;
				}
			}

			public int? MinNodesInQueue
			{
				get
				{
					return minNodesInQueue;
				}
				set	
				{
					minNodesInQueue = value;
				}
			}

			public string QueueImageId
			{
				get
				{
					return queueImageId;
				}
				set	
				{
					queueImageId = value;
				}
			}

			public List<GetAutoScaleConfig_InstanceTypeInfo> InstanceTypes
			{
				get
				{
					return instanceTypes;
				}
				set	
				{
					instanceTypes = value;
				}
			}

			public class GetAutoScaleConfig_InstanceTypeInfo
			{

				private string instanceType;

				private string spotStrategy;

				private float? spotPriceLimit;

				private string zoneId;

				private string vSwitchId;

				private string hostNamePrefix;

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

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string VSwitchId
				{
					get
					{
						return vSwitchId;
					}
					set	
					{
						vSwitchId = value;
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
			}
		}
	}
}
