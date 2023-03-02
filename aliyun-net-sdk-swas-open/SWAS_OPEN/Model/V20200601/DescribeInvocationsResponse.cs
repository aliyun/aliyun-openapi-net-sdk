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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class DescribeInvocationsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeInvocations_Invocation> invocations;

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

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "Invocations")]
		public List<DescribeInvocations_Invocation> Invocations
		{
			get
			{
				return invocations;
			}
			set	
			{
				invocations = value;
			}
		}

		public class DescribeInvocations_Invocation
		{

			private string creationTime;

			private string invocationStatus;

			private string commandType;

			private string commandContent;

			private string parameters;

			private string invokeStatus;

			private string invokeId;

			private string commandName;

			[JsonProperty(PropertyName = "CreationTime")]
			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			[JsonProperty(PropertyName = "InvocationStatus")]
			public string InvocationStatus
			{
				get
				{
					return invocationStatus;
				}
				set	
				{
					invocationStatus = value;
				}
			}

			[JsonProperty(PropertyName = "CommandType")]
			public string CommandType
			{
				get
				{
					return commandType;
				}
				set	
				{
					commandType = value;
				}
			}

			[JsonProperty(PropertyName = "CommandContent")]
			public string CommandContent
			{
				get
				{
					return commandContent;
				}
				set	
				{
					commandContent = value;
				}
			}

			[JsonProperty(PropertyName = "Parameters")]
			public string Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			[JsonProperty(PropertyName = "InvokeStatus")]
			public string InvokeStatus
			{
				get
				{
					return invokeStatus;
				}
				set	
				{
					invokeStatus = value;
				}
			}

			[JsonProperty(PropertyName = "InvokeId")]
			public string InvokeId
			{
				get
				{
					return invokeId;
				}
				set	
				{
					invokeId = value;
				}
			}

			[JsonProperty(PropertyName = "CommandName")]
			public string CommandName
			{
				get
				{
					return commandName;
				}
				set	
				{
					commandName = value;
				}
			}
		}
	}
}
