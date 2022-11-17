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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class ResetOmsOpenAPIProjectResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string advice;

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private long? totalCount;

		private string cost;

		private bool? data;

		private ResetOmsOpenAPIProject_ErrorDetail errorDetail;

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Code")]
		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		[JsonProperty(PropertyName = "Message")]
		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		[JsonProperty(PropertyName = "Advice")]
		public string Advice
		{
			get
			{
				return advice;
			}
			set	
			{
				advice = value;
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

		[JsonProperty(PropertyName = "TotalCount")]
		public long? TotalCount
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

		[JsonProperty(PropertyName = "Cost")]
		public string Cost
		{
			get
			{
				return cost;
			}
			set	
			{
				cost = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public bool? Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorDetail")]
		public ResetOmsOpenAPIProject_ErrorDetail ErrorDetail
		{
			get
			{
				return errorDetail;
			}
			set	
			{
				errorDetail = value;
			}
		}

		public class ResetOmsOpenAPIProject_ErrorDetail
		{

			private string code;

			private string level;

			private string message;

			private string proposal;

			[JsonProperty(PropertyName = "Code")]
			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			[JsonProperty(PropertyName = "Level")]
			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			[JsonProperty(PropertyName = "Message")]
			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			[JsonProperty(PropertyName = "Proposal")]
			public string Proposal
			{
				get
				{
					return proposal;
				}
				set	
				{
					proposal = value;
				}
			}
		}
	}
}
