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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class SetAutoScaleConfigRequest : RpcAcsRequest<SetAutoScaleConfigResponse>
    {
        public SetAutoScaleConfigRequest()
            : base("EHPC", "2018-04-12", "SetAutoScaleConfig", "ehs", "openAPI")
        {
        }

		private int? shrinkIdleTimes;

		private int? growTimeoutInMinutes;

		private string clusterId;

		private bool? enableAutoGrow;

		private float? spotPriceLimit;

		private bool? enableAutoShrink;

		private string accessKeyId;

		private string spotStrategy;

		private int? maxNodesInCluster;

		private string excludeNodes;

		private int? shrinkIntervalInMinutes;

		private List<Queues> queuess;

		private string action;

		private int? extraNodesGrowRatio;

		private int? growIntervalInMinutes;

		private int? growRatio;

		public int? ShrinkIdleTimes
		{
			get
			{
				return shrinkIdleTimes;
			}
			set	
			{
				shrinkIdleTimes = value;
				DictionaryUtil.Add(QueryParameters, "ShrinkIdleTimes", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "GrowTimeoutInMinutes", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
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
				DictionaryUtil.Add(QueryParameters, "EnableAutoGrow", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SpotPriceLimit", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "EnableAutoShrink", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
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
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
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
				DictionaryUtil.Add(QueryParameters, "MaxNodesInCluster", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ExcludeNodes", value);
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
				DictionaryUtil.Add(QueryParameters, "ShrinkIntervalInMinutes", value.ToString());
			}
		}

		public List<Queues> Queuess
		{
			get
			{
				return queuess;
			}

			set
			{
				queuess = value;
				for (int i = 0; i < queuess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Queues." + (i + 1) + ".SpotStrategy", queuess[i].SpotStrategy);
					DictionaryUtil.Add(QueryParameters,"Queues." + (i + 1) + ".QueueName", queuess[i].QueueName);
					DictionaryUtil.Add(QueryParameters,"Queues." + (i + 1) + ".InstanceType", queuess[i].InstanceType);
					DictionaryUtil.Add(QueryParameters,"Queues." + (i + 1) + ".SpotPriceLimit", queuess[i].SpotPriceLimit);
				}
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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
				DictionaryUtil.Add(QueryParameters, "ExtraNodesGrowRatio", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "GrowIntervalInMinutes", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "GrowRatio", value.ToString());
			}
		}

		public class Queues
		{

			private string spotStrategy;

			private string queueName;

			private string instanceType;

			private float? spotPriceLimit;

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

        public override SetAutoScaleConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetAutoScaleConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}