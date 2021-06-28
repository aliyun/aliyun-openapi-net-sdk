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
	public class GetSQLReviewOptimizeDetailResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetSQLReviewOptimizeDetail_OptimizeDetail optimizeDetail;

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

		[JsonProperty(PropertyName = "OptimizeDetail")]
		public GetSQLReviewOptimizeDetail_OptimizeDetail OptimizeDetail
		{
			get
			{
				return optimizeDetail;
			}
			set	
			{
				optimizeDetail = value;
			}
		}

		public class GetSQLReviewOptimizeDetail_OptimizeDetail
		{

			private string queryKey;

			private int? instanceId;

			private int? dbId;

			private string sqlType;

			private GetSQLReviewOptimizeDetail_QualityResult qualityResult;

			[JsonProperty(PropertyName = "QueryKey")]
			public string QueryKey
			{
				get
				{
					return queryKey;
				}
				set	
				{
					queryKey = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
			public int? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			[JsonProperty(PropertyName = "DbId")]
			public int? DbId
			{
				get
				{
					return dbId;
				}
				set	
				{
					dbId = value;
				}
			}

			[JsonProperty(PropertyName = "SqlType")]
			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}

			[JsonProperty(PropertyName = "QualityResult")]
			public GetSQLReviewOptimizeDetail_QualityResult QualityResult
			{
				get
				{
					return qualityResult;
				}
				set	
				{
					qualityResult = value;
				}
			}

			public class GetSQLReviewOptimizeDetail_QualityResult
			{

				private string errorMessage;

				private bool? occurError;

				private List<GetSQLReviewOptimizeDetail_ResultsItem> results;

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

				[JsonProperty(PropertyName = "OccurError")]
				public bool? OccurError
				{
					get
					{
						return occurError;
					}
					set	
					{
						occurError = value;
					}
				}

				[JsonProperty(PropertyName = "Results")]
				public List<GetSQLReviewOptimizeDetail_ResultsItem> Results
				{
					get
					{
						return results;
					}
					set	
					{
						results = value;
					}
				}

				public class GetSQLReviewOptimizeDetail_ResultsItem
				{

					private string ruleName;

					private string feedback;

					private string comments;

					private string ruleType;

					private List<GetSQLReviewOptimizeDetail_ScriptsItem> scripts;

					private List<string> messages;

					[JsonProperty(PropertyName = "RuleName")]
					public string RuleName
					{
						get
						{
							return ruleName;
						}
						set	
						{
							ruleName = value;
						}
					}

					[JsonProperty(PropertyName = "Feedback")]
					public string Feedback
					{
						get
						{
							return feedback;
						}
						set	
						{
							feedback = value;
						}
					}

					[JsonProperty(PropertyName = "Comments")]
					public string Comments
					{
						get
						{
							return comments;
						}
						set	
						{
							comments = value;
						}
					}

					[JsonProperty(PropertyName = "RuleType")]
					public string RuleType
					{
						get
						{
							return ruleType;
						}
						set	
						{
							ruleType = value;
						}
					}

					[JsonProperty(PropertyName = "Scripts")]
					public List<GetSQLReviewOptimizeDetail_ScriptsItem> Scripts
					{
						get
						{
							return scripts;
						}
						set	
						{
							scripts = value;
						}
					}

					[JsonProperty(PropertyName = "Messages")]
					public List<string> Messages
					{
						get
						{
							return messages;
						}
						set	
						{
							messages = value;
						}
					}

					public class GetSQLReviewOptimizeDetail_ScriptsItem
					{

						private string opType;

						private string content;

						private string tableName;

						[JsonProperty(PropertyName = "OpType")]
						public string OpType
						{
							get
							{
								return opType;
							}
							set	
							{
								opType = value;
							}
						}

						[JsonProperty(PropertyName = "Content")]
						public string Content
						{
							get
							{
								return content;
							}
							set	
							{
								content = value;
							}
						}

						[JsonProperty(PropertyName = "TableName")]
						public string TableName
						{
							get
							{
								return tableName;
							}
							set	
							{
								tableName = value;
							}
						}
					}
				}
			}
		}
	}
}
