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
	public class GetStructSyncJobDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetStructSyncJobDetail_StructSyncJobDetail structSyncJobDetail;

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

		[JsonProperty(PropertyName = "StructSyncJobDetail")]
		public GetStructSyncJobDetail_StructSyncJobDetail StructSyncJobDetail
		{
			get
			{
				return structSyncJobDetail;
			}
			set	
			{
				structSyncJobDetail = value;
			}
		}

		public class GetStructSyncJobDetail_StructSyncJobDetail
		{

			private string jobStatus;

			private string message;

			private long? tableAnalyzed;

			private long? tableCount;

			private long? sqlCount;

			private long? executeCount;

			private string securityRule;

			private long? dBTaskGroupId;

			[JsonProperty(PropertyName = "JobStatus")]
			public string JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
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

			[JsonProperty(PropertyName = "TableAnalyzed")]
			public long? TableAnalyzed
			{
				get
				{
					return tableAnalyzed;
				}
				set	
				{
					tableAnalyzed = value;
				}
			}

			[JsonProperty(PropertyName = "TableCount")]
			public long? TableCount
			{
				get
				{
					return tableCount;
				}
				set	
				{
					tableCount = value;
				}
			}

			[JsonProperty(PropertyName = "SqlCount")]
			public long? SqlCount
			{
				get
				{
					return sqlCount;
				}
				set	
				{
					sqlCount = value;
				}
			}

			[JsonProperty(PropertyName = "ExecuteCount")]
			public long? ExecuteCount
			{
				get
				{
					return executeCount;
				}
				set	
				{
					executeCount = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityRule")]
			public string SecurityRule
			{
				get
				{
					return securityRule;
				}
				set	
				{
					securityRule = value;
				}
			}

			[JsonProperty(PropertyName = "DBTaskGroupId")]
			public long? DBTaskGroupId
			{
				get
				{
					return dBTaskGroupId;
				}
				set	
				{
					dBTaskGroupId = value;
				}
			}
		}
	}
}
