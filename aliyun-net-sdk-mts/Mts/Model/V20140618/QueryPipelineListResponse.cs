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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryPipelineListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryPipelineList_Pipeline> pipelineList;

		private List<string> nonExistPids;

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

		public List<QueryPipelineList_Pipeline> PipelineList
		{
			get
			{
				return pipelineList;
			}
			set	
			{
				pipelineList = value;
			}
		}

		public List<string> NonExistPids
		{
			get
			{
				return nonExistPids;
			}
			set	
			{
				nonExistPids = value;
			}
		}

		public class QueryPipelineList_Pipeline
		{

			private string speed;

			private string state;

			private long? speedLevel;

			private string role;

			private string name;

			private string id;

			private long? quotaAllocate;

			private QueryPipelineList_NotifyConfig notifyConfig;

			private QueryPipelineList_ExtendConfig extendConfig;

			public string Speed
			{
				get
				{
					return speed;
				}
				set	
				{
					speed = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public long? SpeedLevel
			{
				get
				{
					return speedLevel;
				}
				set	
				{
					speedLevel = value;
				}
			}

			public string Role
			{
				get
				{
					return role;
				}
				set	
				{
					role = value;
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

			public string Id
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

			public long? QuotaAllocate
			{
				get
				{
					return quotaAllocate;
				}
				set	
				{
					quotaAllocate = value;
				}
			}

			public QueryPipelineList_NotifyConfig NotifyConfig
			{
				get
				{
					return notifyConfig;
				}
				set	
				{
					notifyConfig = value;
				}
			}

			public QueryPipelineList_ExtendConfig ExtendConfig
			{
				get
				{
					return extendConfig;
				}
				set	
				{
					extendConfig = value;
				}
			}

			public class QueryPipelineList_NotifyConfig
			{

				private string mqTopic;

				private string queueName;

				private string mqTag;

				private string topic;

				public string MqTopic
				{
					get
					{
						return mqTopic;
					}
					set	
					{
						mqTopic = value;
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

				public string MqTag
				{
					get
					{
						return mqTag;
					}
					set	
					{
						mqTag = value;
					}
				}

				public string Topic
				{
					get
					{
						return topic;
					}
					set	
					{
						topic = value;
					}
				}
			}

			public class QueryPipelineList_ExtendConfig
			{

				private bool? isBoostNew;

				private int? maxMultiSpeed;

				private string multiSpeedDowngradePolicy;

				public bool? IsBoostNew
				{
					get
					{
						return isBoostNew;
					}
					set	
					{
						isBoostNew = value;
					}
				}

				public int? MaxMultiSpeed
				{
					get
					{
						return maxMultiSpeed;
					}
					set	
					{
						maxMultiSpeed = value;
					}
				}

				public string MultiSpeedDowngradePolicy
				{
					get
					{
						return multiSpeedDowngradePolicy;
					}
					set	
					{
						multiSpeedDowngradePolicy = value;
					}
				}
			}
		}
	}
}
