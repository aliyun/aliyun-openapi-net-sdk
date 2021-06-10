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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetOpLogResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<GetOpLog_OpLogDetail> opLogDetails;

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

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

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

		[JsonProperty(PropertyName = "OpLogDetails")]
		public List<GetOpLog_OpLogDetail> OpLogDetails
		{
			get
			{
				return opLogDetails;
			}
			set	
			{
				opLogDetails = value;
			}
		}

		public class GetOpLog_OpLogDetail
		{

			private string module;

			private string database;

			private long? userId;

			private string opContent;

			private string userNick;

			private long? orderId;

			private string opTime;

			[JsonProperty(PropertyName = "Module")]
			public string Module
			{
				get
				{
					return module;
				}
				set	
				{
					module = value;
				}
			}

			[JsonProperty(PropertyName = "Database")]
			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			[JsonProperty(PropertyName = "UserId")]
			public long? UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			[JsonProperty(PropertyName = "OpContent")]
			public string OpContent
			{
				get
				{
					return opContent;
				}
				set	
				{
					opContent = value;
				}
			}

			[JsonProperty(PropertyName = "UserNick")]
			public string UserNick
			{
				get
				{
					return userNick;
				}
				set	
				{
					userNick = value;
				}
			}

			[JsonProperty(PropertyName = "OrderId")]
			public long? OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			[JsonProperty(PropertyName = "OpTime")]
			public string OpTime
			{
				get
				{
					return opTime;
				}
				set	
				{
					opTime = value;
				}
			}
		}
	}
}
