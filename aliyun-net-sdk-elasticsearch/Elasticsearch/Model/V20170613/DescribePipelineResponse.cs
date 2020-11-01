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

			private string config;

			private string pipelineStatus;

			private string gmtCreatedTime;

			private string gmtUpdateTime;

			private int? workers;

			private int? batchSize;

			private int? batchDelay;

			private string description;

			private string queueType;

			private int? queueMaxBytes;

			private int? queueCheckPointWrites;

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
		}
	}
}
