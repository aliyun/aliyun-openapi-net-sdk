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
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class AddPipelineResponse : AcsResponse
	{

		private string requestId;

		private AddPipeline_Pipeline pipeline;

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

		public AddPipeline_Pipeline Pipeline
		{
			get
			{
				return pipeline;
			}
			set	
			{
				pipeline = value;
			}
		}

		public class AddPipeline_Pipeline
		{

			private string id;

			private string name;

			private string state;

			private string speed;

			private long? speedLevel;

			private string role;

			private AddPipeline_NotifyConfig notifyConfig;

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

			public AddPipeline_NotifyConfig NotifyConfig
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

			public class AddPipeline_NotifyConfig
			{

				private string topic;

				private string queueName;

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
}