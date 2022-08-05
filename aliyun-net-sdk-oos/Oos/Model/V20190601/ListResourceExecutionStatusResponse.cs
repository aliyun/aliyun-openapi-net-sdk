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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListResourceExecutionStatusResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListResourceExecutionStatus_Status> resourceExecutionStatus;

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "ResourceExecutionStatus")]
		public List<ListResourceExecutionStatus_Status> ResourceExecutionStatus
		{
			get
			{
				return resourceExecutionStatus;
			}
			set	
			{
				resourceExecutionStatus = value;
			}
		}

		public class ListResourceExecutionStatus_Status
		{

			private string outputs;

			private string status;

			private string executionTime;

			private string resourceId;

			private string executionId;

			[JsonProperty(PropertyName = "Outputs")]
			public string Outputs
			{
				get
				{
					return outputs;
				}
				set	
				{
					outputs = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "ExecutionTime")]
			public string ExecutionTime
			{
				get
				{
					return executionTime;
				}
				set	
				{
					executionTime = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceId")]
			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			[JsonProperty(PropertyName = "ExecutionId")]
			public string ExecutionId
			{
				get
				{
					return executionId;
				}
				set	
				{
					executionId = value;
				}
			}
		}
	}
}
