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
	public class GetStructSyncJobAnalyzeResultResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult structSyncJobAnalyzeResult;

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

		[JsonProperty(PropertyName = "StructSyncJobAnalyzeResult")]
		public GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult StructSyncJobAnalyzeResult
		{
			get
			{
				return structSyncJobAnalyzeResult;
			}
			set	
			{
				structSyncJobAnalyzeResult = value;
			}
		}

		public class GetStructSyncJobAnalyzeResult_StructSyncJobAnalyzeResult
		{

			private List<GetStructSyncJobAnalyzeResult_Summary> summaryList;

			private List<GetStructSyncJobAnalyzeResult_Result> resultList;

			[JsonProperty(PropertyName = "SummaryList")]
			public List<GetStructSyncJobAnalyzeResult_Summary> SummaryList
			{
				get
				{
					return summaryList;
				}
				set	
				{
					summaryList = value;
				}
			}

			[JsonProperty(PropertyName = "ResultList")]
			public List<GetStructSyncJobAnalyzeResult_Result> ResultList
			{
				get
				{
					return resultList;
				}
				set	
				{
					resultList = value;
				}
			}

			public class GetStructSyncJobAnalyzeResult_Summary
			{

				private string compareType;

				private long? count;

				[JsonProperty(PropertyName = "CompareType")]
				public string CompareType
				{
					get
					{
						return compareType;
					}
					set	
					{
						compareType = value;
					}
				}

				[JsonProperty(PropertyName = "Count")]
				public long? Count
				{
					get
					{
						return count;
					}
					set	
					{
						count = value;
					}
				}
			}

			public class GetStructSyncJobAnalyzeResult_Result
			{

				private string sourceTableName;

				private string targetTableName;

				private string script;

				[JsonProperty(PropertyName = "SourceTableName")]
				public string SourceTableName
				{
					get
					{
						return sourceTableName;
					}
					set	
					{
						sourceTableName = value;
					}
				}

				[JsonProperty(PropertyName = "TargetTableName")]
				public string TargetTableName
				{
					get
					{
						return targetTableName;
					}
					set	
					{
						targetTableName = value;
					}
				}

				[JsonProperty(PropertyName = "Script")]
				public string Script
				{
					get
					{
						return script;
					}
					set	
					{
						script = value;
					}
				}
			}
		}
	}
}
