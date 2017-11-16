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
	public class AddVideoSummaryPipelineResponse : AcsResponse
	{

		private string requestId;

		private AddVideoSummaryPipeline_Pipeline pipeline;

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

		public AddVideoSummaryPipeline_Pipeline Pipeline
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

		public class AddVideoSummaryPipeline_Pipeline
		{

			private string id;

			private string name;

			private int? priority;

			private string state;

			private AddVideoSummaryPipeline_NotifyConfig notifyConfig;

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

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
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

			public AddVideoSummaryPipeline_NotifyConfig NotifyConfig
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

			public class AddVideoSummaryPipeline_NotifyConfig
			{

				private string topic;

				private string queue;

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

				public string Queue
				{
					get
					{
						return queue;
					}
					set	
					{
						queue = value;
					}
				}
			}
		}
	}
}