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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class DescribePipelineResponse : AcsResponse
	{

		private string requestId;

		private DescribePipeline_Result result;

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

		public DescribePipeline_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribePipeline_Result
		{

			private string pipelineId;

			private string gmtUpdateTime;

			private string queueType;

			private int? queueCheckPointWrites;

			private int? queueMaxBytes;

			private string config;

			private int? batchDelay;

			private int? workers;

			private string description;

			private string gmtCreatedTime;

			private int? batchSize;

			private string pipelineStatus;

			public string PipelineId
			{
				get
				{
					return pipelineId;
				}
				set	
				{
					pipelineId = value;
				}
			}

			public string GmtUpdateTime
			{
				get
				{
					return gmtUpdateTime;
				}
				set	
				{
					gmtUpdateTime = value;
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

			public int? QueueCheckPointWrites
			{
				get
				{
					return queueCheckPointWrites;
				}
				set	
				{
					queueCheckPointWrites = value;
				}
			}

			public int? QueueMaxBytes
			{
				get
				{
					return queueMaxBytes;
				}
				set	
				{
					queueMaxBytes = value;
				}
			}

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public int? BatchDelay
			{
				get
				{
					return batchDelay;
				}
				set	
				{
					batchDelay = value;
				}
			}

			public int? Workers
			{
				get
				{
					return workers;
				}
				set	
				{
					workers = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string GmtCreatedTime
			{
				get
				{
					return gmtCreatedTime;
				}
				set	
				{
					gmtCreatedTime = value;
				}
			}

			public int? BatchSize
			{
				get
				{
					return batchSize;
				}
				set	
				{
					batchSize = value;
				}
			}

			public string PipelineStatus
			{
				get
				{
					return pipelineStatus;
				}
				set	
				{
					pipelineStatus = value;
				}
			}
		}
	}
}
