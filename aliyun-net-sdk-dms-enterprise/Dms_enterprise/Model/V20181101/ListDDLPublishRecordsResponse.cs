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
	public class ListDDLPublishRecordsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private List<ListDDLPublishRecords_DDLPublishRecord> dDLPublishRecordList;

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

		[JsonProperty(PropertyName = "DDLPublishRecordList")]
		public List<ListDDLPublishRecords_DDLPublishRecord> DDLPublishRecordList
		{
			get
			{
				return dDLPublishRecordList;
			}
			set	
			{
				dDLPublishRecordList = value;
			}
		}

		public class ListDDLPublishRecords_DDLPublishRecord
		{

			private string auditStatus;

			private string auditExpireTime;

			private long? creatorId;

			private bool? finality;

			private string finalityReason;

			private string publishStatus;

			private string riskLevel;

			private string statusDesc;

			private long? workflowInstanceId;

			private List<ListDDLPublishRecords_PublishTaskInfo> publishTaskInfoList;

			[JsonProperty(PropertyName = "AuditStatus")]
			public string AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}

			[JsonProperty(PropertyName = "AuditExpireTime")]
			public string AuditExpireTime
			{
				get
				{
					return auditExpireTime;
				}
				set	
				{
					auditExpireTime = value;
				}
			}

			[JsonProperty(PropertyName = "CreatorId")]
			public long? CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			[JsonProperty(PropertyName = "Finality")]
			public bool? Finality
			{
				get
				{
					return finality;
				}
				set	
				{
					finality = value;
				}
			}

			[JsonProperty(PropertyName = "FinalityReason")]
			public string FinalityReason
			{
				get
				{
					return finalityReason;
				}
				set	
				{
					finalityReason = value;
				}
			}

			[JsonProperty(PropertyName = "PublishStatus")]
			public string PublishStatus
			{
				get
				{
					return publishStatus;
				}
				set	
				{
					publishStatus = value;
				}
			}

			[JsonProperty(PropertyName = "RiskLevel")]
			public string RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
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

			[JsonProperty(PropertyName = "WorkflowInstanceId")]
			public long? WorkflowInstanceId
			{
				get
				{
					return workflowInstanceId;
				}
				set	
				{
					workflowInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "PublishTaskInfoList")]
			public List<ListDDLPublishRecords_PublishTaskInfo> PublishTaskInfoList
			{
				get
				{
					return publishTaskInfoList;
				}
				set	
				{
					publishTaskInfoList = value;
				}
			}

			public class ListDDLPublishRecords_PublishTaskInfo
			{

				private long? dbId;

				private bool? logic;

				private string planTime;

				private string publishStrategy;

				private string statusDesc;

				private string taskJobStatus;

				private List<ListDDLPublishRecords_PublishJob> publishJobList;

				[JsonProperty(PropertyName = "DbId")]
				public long? DbId
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

				[JsonProperty(PropertyName = "Logic")]
				public bool? Logic
				{
					get
					{
						return logic;
					}
					set	
					{
						logic = value;
					}
				}

				[JsonProperty(PropertyName = "PlanTime")]
				public string PlanTime
				{
					get
					{
						return planTime;
					}
					set	
					{
						planTime = value;
					}
				}

				[JsonProperty(PropertyName = "PublishStrategy")]
				public string PublishStrategy
				{
					get
					{
						return publishStrategy;
					}
					set	
					{
						publishStrategy = value;
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

				[JsonProperty(PropertyName = "TaskJobStatus")]
				public string TaskJobStatus
				{
					get
					{
						return taskJobStatus;
					}
					set	
					{
						taskJobStatus = value;
					}
				}

				[JsonProperty(PropertyName = "PublishJobList")]
				public List<ListDDLPublishRecords_PublishJob> PublishJobList
				{
					get
					{
						return publishJobList;
					}
					set	
					{
						publishJobList = value;
					}
				}

				public class ListDDLPublishRecords_PublishJob
				{

					private long? executeCount;

					private string scripts;

					private string tableName;

					private string statusDesc;

					private string taskJobStatus;

					private long? dBTaskGroupId;

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

					[JsonProperty(PropertyName = "Scripts")]
					public string Scripts
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

					[JsonProperty(PropertyName = "TaskJobStatus")]
					public string TaskJobStatus
					{
						get
						{
							return taskJobStatus;
						}
						set	
						{
							taskJobStatus = value;
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
	}
}
