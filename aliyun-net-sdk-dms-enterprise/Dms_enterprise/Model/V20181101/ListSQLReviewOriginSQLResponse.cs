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
	public class ListSQLReviewOriginSQLResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private int? totalCount;

		private List<ListSQLReviewOriginSQL_OriginSQLListItem> originSQLList;

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

		[JsonProperty(PropertyName = "OriginSQLList")]
		public List<ListSQLReviewOriginSQL_OriginSQLListItem> OriginSQLList
		{
			get
			{
				return originSQLList;
			}
			set	
			{
				originSQLList = value;
			}
		}

		public class ListSQLReviewOriginSQL_OriginSQLListItem
		{

			private long? sQLId;

			private long? fileId;

			private string fileName;

			private string sQLContent;

			private string checkStatus;

			private string statusDesc;

			private string checkedTime;

			private string sqlHash;

			private string reviewSummary;

			private string sQLReviewQueryKey;

			[JsonProperty(PropertyName = "SQLId")]
			public long? SQLId
			{
				get
				{
					return sQLId;
				}
				set	
				{
					sQLId = value;
				}
			}

			[JsonProperty(PropertyName = "FileId")]
			public long? FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
				}
			}

			[JsonProperty(PropertyName = "FileName")]
			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			[JsonProperty(PropertyName = "SQLContent")]
			public string SQLContent
			{
				get
				{
					return sQLContent;
				}
				set	
				{
					sQLContent = value;
				}
			}

			[JsonProperty(PropertyName = "CheckStatus")]
			public string CheckStatus
			{
				get
				{
					return checkStatus;
				}
				set	
				{
					checkStatus = value;
				}
			}

			[JsonProperty(PropertyName = "StatusDesc")]
			public string StatusDesc
			{
				get
				{
					return statusDesc;
				}
				set	
				{
					statusDesc = value;
				}
			}

			[JsonProperty(PropertyName = "CheckedTime")]
			public string CheckedTime
			{
				get
				{
					return checkedTime;
				}
				set	
				{
					checkedTime = value;
				}
			}

			[JsonProperty(PropertyName = "SqlHash")]
			public string SqlHash
			{
				get
				{
					return sqlHash;
				}
				set	
				{
					sqlHash = value;
				}
			}

			[JsonProperty(PropertyName = "ReviewSummary")]
			public string ReviewSummary
			{
				get
				{
					return reviewSummary;
				}
				set	
				{
					reviewSummary = value;
				}
			}

			[JsonProperty(PropertyName = "SQLReviewQueryKey")]
			public string SQLReviewQueryKey
			{
				get
				{
					return sQLReviewQueryKey;
				}
				set	
				{
					sQLReviewQueryKey = value;
				}
			}
		}
	}
}
