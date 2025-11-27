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

namespace Aliyun.Acs.eds_user.Model.V20210308
{
	public class QuerySyncStatusByAliUidResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private string requestId;

		private QuerySyncStatusByAliUid_Data data;

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

		[JsonProperty(PropertyName = "HttpStatusCode")]
		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		[JsonProperty(PropertyName = "Data")]
		public QuerySyncStatusByAliUid_Data Data
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

		public class QuerySyncStatusByAliUid_Data
		{

			private long? id;

			private string gmtCreated;

			private string gmtModified;

			private long? aliUid;

			private string status;

			private string corpId;

			private string latestBeginTime;

			private string latestEndTime;

			private string latestSuccessTime;

			[JsonProperty(PropertyName = "Id")]
			public long? Id
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

			[JsonProperty(PropertyName = "GmtCreated")]
			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}

			[JsonProperty(PropertyName = "GmtModified")]
			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			[JsonProperty(PropertyName = "AliUid")]
			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
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

			[JsonProperty(PropertyName = "CorpId")]
			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}

			[JsonProperty(PropertyName = "LatestBeginTime")]
			public string LatestBeginTime
			{
				get
				{
					return latestBeginTime;
				}
				set	
				{
					latestBeginTime = value;
				}
			}

			[JsonProperty(PropertyName = "LatestEndTime")]
			public string LatestEndTime
			{
				get
				{
					return latestEndTime;
				}
				set	
				{
					latestEndTime = value;
				}
			}

			[JsonProperty(PropertyName = "LatestSuccessTime")]
			public string LatestSuccessTime
			{
				get
				{
					return latestSuccessTime;
				}
				set	
				{
					latestSuccessTime = value;
				}
			}
		}
	}
}
