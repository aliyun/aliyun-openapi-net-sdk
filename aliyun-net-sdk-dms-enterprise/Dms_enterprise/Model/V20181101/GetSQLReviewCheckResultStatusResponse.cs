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
	public class GetSQLReviewCheckResultStatusResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetSQLReviewCheckResultStatus_CheckResultStatus checkResultStatus;

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

		[JsonProperty(PropertyName = "CheckResultStatus")]
		public GetSQLReviewCheckResultStatus_CheckResultStatus CheckResultStatus
		{
			get
			{
				return checkResultStatus;
			}
			set	
			{
				checkResultStatus = value;
			}
		}

		public class GetSQLReviewCheckResultStatus_CheckResultStatus
		{

			private long? totalSQLCount;

			private long? checkedCount;

			private GetSQLReviewCheckResultStatus_CheckStatusResult checkStatusResult;

			private GetSQLReviewCheckResultStatus_SQLReviewResult sQLReviewResult;

			[JsonProperty(PropertyName = "TotalSQLCount")]
			public long? TotalSQLCount
			{
				get
				{
					return totalSQLCount;
				}
				set	
				{
					totalSQLCount = value;
				}
			}

			[JsonProperty(PropertyName = "CheckedCount")]
			public long? CheckedCount
			{
				get
				{
					return checkedCount;
				}
				set	
				{
					checkedCount = value;
				}
			}

			[JsonProperty(PropertyName = "CheckStatusResult")]
			public GetSQLReviewCheckResultStatus_CheckStatusResult CheckStatusResult
			{
				get
				{
					return checkStatusResult;
				}
				set	
				{
					checkStatusResult = value;
				}
			}

			[JsonProperty(PropertyName = "SQLReviewResult")]
			public GetSQLReviewCheckResultStatus_SQLReviewResult SQLReviewResult
			{
				get
				{
					return sQLReviewResult;
				}
				set	
				{
					sQLReviewResult = value;
				}
			}

			public class GetSQLReviewCheckResultStatus_CheckStatusResult
			{

				private long? _new;

				private long? unknown;

				private long? checkNotPass;

				private long? checkPass;

				private long? forcePass;

				private long? forceNotPass;

				[JsonProperty(PropertyName = "_New")]
				public long? _New
				{
					get
					{
						return _new;
					}
					set	
					{
						_new = value;
					}
				}

				[JsonProperty(PropertyName = "Unknown")]
				public long? Unknown
				{
					get
					{
						return unknown;
					}
					set	
					{
						unknown = value;
					}
				}

				[JsonProperty(PropertyName = "CheckNotPass")]
				public long? CheckNotPass
				{
					get
					{
						return checkNotPass;
					}
					set	
					{
						checkNotPass = value;
					}
				}

				[JsonProperty(PropertyName = "CheckPass")]
				public long? CheckPass
				{
					get
					{
						return checkPass;
					}
					set	
					{
						checkPass = value;
					}
				}

				[JsonProperty(PropertyName = "ForcePass")]
				public long? ForcePass
				{
					get
					{
						return forcePass;
					}
					set	
					{
						forcePass = value;
					}
				}

				[JsonProperty(PropertyName = "ForceNotPass")]
				public long? ForceNotPass
				{
					get
					{
						return forceNotPass;
					}
					set	
					{
						forceNotPass = value;
					}
				}
			}

			public class GetSQLReviewCheckResultStatus_SQLReviewResult
			{

				private long? mustImprove;

				private long? potentialIssue;

				private long? suggestImprove;

				private long? useDmsToolkit;

				private long? useDmsDmlUnlock;

				private long? tableIndexSuggest;

				[JsonProperty(PropertyName = "MustImprove")]
				public long? MustImprove
				{
					get
					{
						return mustImprove;
					}
					set	
					{
						mustImprove = value;
					}
				}

				[JsonProperty(PropertyName = "PotentialIssue")]
				public long? PotentialIssue
				{
					get
					{
						return potentialIssue;
					}
					set	
					{
						potentialIssue = value;
					}
				}

				[JsonProperty(PropertyName = "SuggestImprove")]
				public long? SuggestImprove
				{
					get
					{
						return suggestImprove;
					}
					set	
					{
						suggestImprove = value;
					}
				}

				[JsonProperty(PropertyName = "UseDmsToolkit")]
				public long? UseDmsToolkit
				{
					get
					{
						return useDmsToolkit;
					}
					set	
					{
						useDmsToolkit = value;
					}
				}

				[JsonProperty(PropertyName = "UseDmsDmlUnlock")]
				public long? UseDmsDmlUnlock
				{
					get
					{
						return useDmsDmlUnlock;
					}
					set	
					{
						useDmsDmlUnlock = value;
					}
				}

				[JsonProperty(PropertyName = "TableIndexSuggest")]
				public long? TableIndexSuggest
				{
					get
					{
						return tableIndexSuggest;
					}
					set	
					{
						tableIndexSuggest = value;
					}
				}
			}
		}
	}
}
