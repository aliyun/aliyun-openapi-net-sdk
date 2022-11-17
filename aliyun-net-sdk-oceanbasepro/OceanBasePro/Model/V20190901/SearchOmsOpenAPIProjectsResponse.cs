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
	public class SearchOmsOpenAPIProjectsResponse : AcsResponse
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

		private List<SearchOmsOpenAPIProjects_DataItem> data;

		private SearchOmsOpenAPIProjects_ErrorDetail1 errorDetail1;

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
		public List<SearchOmsOpenAPIProjects_DataItem> Data
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

		[JsonProperty(PropertyName = "ErrorDetail1")]
		public SearchOmsOpenAPIProjects_ErrorDetail1 ErrorDetail1
		{
			get
			{
				return errorDetail1;
			}
			set	
			{
				errorDetail1 = value;
			}
		}

		public class SearchOmsOpenAPIProjects_DataItem
		{

			private string projectId;

			private string projectName;

			private string projectOwner;

			private string businessName;

			private List<SearchOmsOpenAPIProjects_Label> labels;

			private List<SearchOmsOpenAPIProjects_Step> steps;

			private SearchOmsOpenAPIProjects_SourceConfig sourceConfig;

			private SearchOmsOpenAPIProjects_DestConfig destConfig;

			private SearchOmsOpenAPIProjects_TransferMapping transferMapping;

			private SearchOmsOpenAPIProjects_TransferStepConfig transferStepConfig;

			[JsonProperty(PropertyName = "ProjectId")]
			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			[JsonProperty(PropertyName = "ProjectName")]
			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			[JsonProperty(PropertyName = "ProjectOwner")]
			public string ProjectOwner
			{
				get
				{
					return projectOwner;
				}
				set	
				{
					projectOwner = value;
				}
			}

			[JsonProperty(PropertyName = "BusinessName")]
			public string BusinessName
			{
				get
				{
					return businessName;
				}
				set	
				{
					businessName = value;
				}
			}

			[JsonProperty(PropertyName = "Labels")]
			public List<SearchOmsOpenAPIProjects_Label> Labels
			{
				get
				{
					return labels;
				}
				set	
				{
					labels = value;
				}
			}

			[JsonProperty(PropertyName = "Steps")]
			public List<SearchOmsOpenAPIProjects_Step> Steps
			{
				get
				{
					return steps;
				}
				set	
				{
					steps = value;
				}
			}

			[JsonProperty(PropertyName = "SourceConfig")]
			public SearchOmsOpenAPIProjects_SourceConfig SourceConfig
			{
				get
				{
					return sourceConfig;
				}
				set	
				{
					sourceConfig = value;
				}
			}

			[JsonProperty(PropertyName = "DestConfig")]
			public SearchOmsOpenAPIProjects_DestConfig DestConfig
			{
				get
				{
					return destConfig;
				}
				set	
				{
					destConfig = value;
				}
			}

			[JsonProperty(PropertyName = "TransferMapping")]
			public SearchOmsOpenAPIProjects_TransferMapping TransferMapping
			{
				get
				{
					return transferMapping;
				}
				set	
				{
					transferMapping = value;
				}
			}

			[JsonProperty(PropertyName = "TransferStepConfig")]
			public SearchOmsOpenAPIProjects_TransferStepConfig TransferStepConfig
			{
				get
				{
					return transferStepConfig;
				}
				set	
				{
					transferStepConfig = value;
				}
			}

			public class SearchOmsOpenAPIProjects_Label
			{

				private string id;

				private string name;

				private string creator;

				private int? count;

				[JsonProperty(PropertyName = "Id")]
				public string Id
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

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "Creator")]
				public string Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}

				[JsonProperty(PropertyName = "Count")]
				public int? Count
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

			public class SearchOmsOpenAPIProjects_Step
			{

				private int? stepOrder;

				private string stepName;

				private string stepDescription;

				private string stepStatus;

				private int? stepProgress;

				private string startTime;

				private long? estimatedRemainingSeconds;

				private string finishTime;

				private bool? interactive;

				private SearchOmsOpenAPIProjects_StepInfo stepInfo;

				private SearchOmsOpenAPIProjects_ExtraInfo extraInfo;

				[JsonProperty(PropertyName = "StepOrder")]
				public int? StepOrder
				{
					get
					{
						return stepOrder;
					}
					set	
					{
						stepOrder = value;
					}
				}

				[JsonProperty(PropertyName = "StepName")]
				public string StepName
				{
					get
					{
						return stepName;
					}
					set	
					{
						stepName = value;
					}
				}

				[JsonProperty(PropertyName = "StepDescription")]
				public string StepDescription
				{
					get
					{
						return stepDescription;
					}
					set	
					{
						stepDescription = value;
					}
				}

				[JsonProperty(PropertyName = "StepStatus")]
				public string StepStatus
				{
					get
					{
						return stepStatus;
					}
					set	
					{
						stepStatus = value;
					}
				}

				[JsonProperty(PropertyName = "StepProgress")]
				public int? StepProgress
				{
					get
					{
						return stepProgress;
					}
					set	
					{
						stepProgress = value;
					}
				}

				[JsonProperty(PropertyName = "StartTime")]
				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				[JsonProperty(PropertyName = "EstimatedRemainingSeconds")]
				public long? EstimatedRemainingSeconds
				{
					get
					{
						return estimatedRemainingSeconds;
					}
					set	
					{
						estimatedRemainingSeconds = value;
					}
				}

				[JsonProperty(PropertyName = "FinishTime")]
				public string FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
					}
				}

				[JsonProperty(PropertyName = "Interactive")]
				public bool? Interactive
				{
					get
					{
						return interactive;
					}
					set	
					{
						interactive = value;
					}
				}

				[JsonProperty(PropertyName = "StepInfo")]
				public SearchOmsOpenAPIProjects_StepInfo StepInfo
				{
					get
					{
						return stepInfo;
					}
					set	
					{
						stepInfo = value;
					}
				}

				[JsonProperty(PropertyName = "ExtraInfo")]
				public SearchOmsOpenAPIProjects_ExtraInfo ExtraInfo
				{
					get
					{
						return extraInfo;
					}
					set	
					{
						extraInfo = value;
					}
				}

				public class SearchOmsOpenAPIProjects_StepInfo
				{

					private string jobId;

					private long? incrTimestampCheckpoint;

					private string checkpoint;

					private long? gmt;

					private bool? validated;

					private bool? skipped;

					private long? inconsistencies;

					private string deployId;

					private long? processedRecords;

					private long? capacity;

					private long? srcRps;

					private long? srcRt;

					private long? srcIops;

					private long? dstRps;

					private long? dstRt;

					private long? dstIops;

					private long? srcRpsRef;

					private long? srcRtRef;

					private long? dstRpsRef;

					private long? dstRtRef;

					private long? srcIopsRef;

					private SearchOmsOpenAPIProjects_ConnectorFullProgressOverview connectorFullProgressOverview;

					[JsonProperty(PropertyName = "JobId")]
					public string JobId
					{
						get
						{
							return jobId;
						}
						set	
						{
							jobId = value;
						}
					}

					[JsonProperty(PropertyName = "IncrTimestampCheckpoint")]
					public long? IncrTimestampCheckpoint
					{
						get
						{
							return incrTimestampCheckpoint;
						}
						set	
						{
							incrTimestampCheckpoint = value;
						}
					}

					[JsonProperty(PropertyName = "Checkpoint")]
					public string Checkpoint
					{
						get
						{
							return checkpoint;
						}
						set	
						{
							checkpoint = value;
						}
					}

					[JsonProperty(PropertyName = "Gmt")]
					public long? Gmt
					{
						get
						{
							return gmt;
						}
						set	
						{
							gmt = value;
						}
					}

					[JsonProperty(PropertyName = "Validated")]
					public bool? Validated
					{
						get
						{
							return validated;
						}
						set	
						{
							validated = value;
						}
					}

					[JsonProperty(PropertyName = "Skipped")]
					public bool? Skipped
					{
						get
						{
							return skipped;
						}
						set	
						{
							skipped = value;
						}
					}

					[JsonProperty(PropertyName = "Inconsistencies")]
					public long? Inconsistencies
					{
						get
						{
							return inconsistencies;
						}
						set	
						{
							inconsistencies = value;
						}
					}

					[JsonProperty(PropertyName = "DeployId")]
					public string DeployId
					{
						get
						{
							return deployId;
						}
						set	
						{
							deployId = value;
						}
					}

					[JsonProperty(PropertyName = "ProcessedRecords")]
					public long? ProcessedRecords
					{
						get
						{
							return processedRecords;
						}
						set	
						{
							processedRecords = value;
						}
					}

					[JsonProperty(PropertyName = "Capacity")]
					public long? Capacity
					{
						get
						{
							return capacity;
						}
						set	
						{
							capacity = value;
						}
					}

					[JsonProperty(PropertyName = "SrcRps")]
					public long? SrcRps
					{
						get
						{
							return srcRps;
						}
						set	
						{
							srcRps = value;
						}
					}

					[JsonProperty(PropertyName = "SrcRt")]
					public long? SrcRt
					{
						get
						{
							return srcRt;
						}
						set	
						{
							srcRt = value;
						}
					}

					[JsonProperty(PropertyName = "SrcIops")]
					public long? SrcIops
					{
						get
						{
							return srcIops;
						}
						set	
						{
							srcIops = value;
						}
					}

					[JsonProperty(PropertyName = "DstRps")]
					public long? DstRps
					{
						get
						{
							return dstRps;
						}
						set	
						{
							dstRps = value;
						}
					}

					[JsonProperty(PropertyName = "DstRt")]
					public long? DstRt
					{
						get
						{
							return dstRt;
						}
						set	
						{
							dstRt = value;
						}
					}

					[JsonProperty(PropertyName = "DstIops")]
					public long? DstIops
					{
						get
						{
							return dstIops;
						}
						set	
						{
							dstIops = value;
						}
					}

					[JsonProperty(PropertyName = "SrcRpsRef")]
					public long? SrcRpsRef
					{
						get
						{
							return srcRpsRef;
						}
						set	
						{
							srcRpsRef = value;
						}
					}

					[JsonProperty(PropertyName = "SrcRtRef")]
					public long? SrcRtRef
					{
						get
						{
							return srcRtRef;
						}
						set	
						{
							srcRtRef = value;
						}
					}

					[JsonProperty(PropertyName = "DstRpsRef")]
					public long? DstRpsRef
					{
						get
						{
							return dstRpsRef;
						}
						set	
						{
							dstRpsRef = value;
						}
					}

					[JsonProperty(PropertyName = "DstRtRef")]
					public long? DstRtRef
					{
						get
						{
							return dstRtRef;
						}
						set	
						{
							dstRtRef = value;
						}
					}

					[JsonProperty(PropertyName = "SrcIopsRef")]
					public long? SrcIopsRef
					{
						get
						{
							return srcIopsRef;
						}
						set	
						{
							srcIopsRef = value;
						}
					}

					[JsonProperty(PropertyName = "ConnectorFullProgressOverview")]
					public SearchOmsOpenAPIProjects_ConnectorFullProgressOverview ConnectorFullProgressOverview
					{
						get
						{
							return connectorFullProgressOverview;
						}
						set	
						{
							connectorFullProgressOverview = value;
						}
					}

					public class SearchOmsOpenAPIProjects_ConnectorFullProgressOverview
					{

						private long? estimatedTotalCount;

						private long? finishedCount;

						private int? progress;

						private long? estimatedRemainingTimeOfSec;

						[JsonProperty(PropertyName = "EstimatedTotalCount")]
						public long? EstimatedTotalCount
						{
							get
							{
								return estimatedTotalCount;
							}
							set	
							{
								estimatedTotalCount = value;
							}
						}

						[JsonProperty(PropertyName = "FinishedCount")]
						public long? FinishedCount
						{
							get
							{
								return finishedCount;
							}
							set	
							{
								finishedCount = value;
							}
						}

						[JsonProperty(PropertyName = "Progress")]
						public int? Progress
						{
							get
							{
								return progress;
							}
							set	
							{
								progress = value;
							}
						}

						[JsonProperty(PropertyName = "EstimatedRemainingTimeOfSec")]
						public long? EstimatedRemainingTimeOfSec
						{
							get
							{
								return estimatedRemainingTimeOfSec;
							}
							set	
							{
								estimatedRemainingTimeOfSec = value;
							}
						}
					}
				}

				public class SearchOmsOpenAPIProjects_ExtraInfo
				{

					private string errorCode;

					private string errorMsg;

					private string errorParam;

					private string failedTime;

					private List<SearchOmsOpenAPIProjects_ErrorDetail> errorDetails;

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

					[JsonProperty(PropertyName = "ErrorMsg")]
					public string ErrorMsg
					{
						get
						{
							return errorMsg;
						}
						set	
						{
							errorMsg = value;
						}
					}

					[JsonProperty(PropertyName = "ErrorParam")]
					public string ErrorParam
					{
						get
						{
							return errorParam;
						}
						set	
						{
							errorParam = value;
						}
					}

					[JsonProperty(PropertyName = "FailedTime")]
					public string FailedTime
					{
						get
						{
							return failedTime;
						}
						set	
						{
							failedTime = value;
						}
					}

					[JsonProperty(PropertyName = "ErrorDetails")]
					public List<SearchOmsOpenAPIProjects_ErrorDetail> ErrorDetails
					{
						get
						{
							return errorDetails;
						}
						set	
						{
							errorDetails = value;
						}
					}

					public class SearchOmsOpenAPIProjects_ErrorDetail
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

			public class SearchOmsOpenAPIProjects_SourceConfig
			{

				private string endpointType;

				private string endpointId;

				private string partitionMode;

				private int? partition;

				private string serializerType;

				private string topicType;

				private bool? sequenceEnable;

				private long? sequenceStartTimestamp;

				private string producerGroup;

				private string msgTags;

				private bool? enableMsgTrace;

				private long? sendMsgTimeout;

				[JsonProperty(PropertyName = "EndpointType")]
				public string EndpointType
				{
					get
					{
						return endpointType;
					}
					set	
					{
						endpointType = value;
					}
				}

				[JsonProperty(PropertyName = "EndpointId")]
				public string EndpointId
				{
					get
					{
						return endpointId;
					}
					set	
					{
						endpointId = value;
					}
				}

				[JsonProperty(PropertyName = "PartitionMode")]
				public string PartitionMode
				{
					get
					{
						return partitionMode;
					}
					set	
					{
						partitionMode = value;
					}
				}

				[JsonProperty(PropertyName = "Partition")]
				public int? Partition
				{
					get
					{
						return partition;
					}
					set	
					{
						partition = value;
					}
				}

				[JsonProperty(PropertyName = "SerializerType")]
				public string SerializerType
				{
					get
					{
						return serializerType;
					}
					set	
					{
						serializerType = value;
					}
				}

				[JsonProperty(PropertyName = "TopicType")]
				public string TopicType
				{
					get
					{
						return topicType;
					}
					set	
					{
						topicType = value;
					}
				}

				[JsonProperty(PropertyName = "SequenceEnable")]
				public bool? SequenceEnable
				{
					get
					{
						return sequenceEnable;
					}
					set	
					{
						sequenceEnable = value;
					}
				}

				[JsonProperty(PropertyName = "SequenceStartTimestamp")]
				public long? SequenceStartTimestamp
				{
					get
					{
						return sequenceStartTimestamp;
					}
					set	
					{
						sequenceStartTimestamp = value;
					}
				}

				[JsonProperty(PropertyName = "ProducerGroup")]
				public string ProducerGroup
				{
					get
					{
						return producerGroup;
					}
					set	
					{
						producerGroup = value;
					}
				}

				[JsonProperty(PropertyName = "MsgTags")]
				public string MsgTags
				{
					get
					{
						return msgTags;
					}
					set	
					{
						msgTags = value;
					}
				}

				[JsonProperty(PropertyName = "EnableMsgTrace")]
				public bool? EnableMsgTrace
				{
					get
					{
						return enableMsgTrace;
					}
					set	
					{
						enableMsgTrace = value;
					}
				}

				[JsonProperty(PropertyName = "SendMsgTimeout")]
				public long? SendMsgTimeout
				{
					get
					{
						return sendMsgTimeout;
					}
					set	
					{
						sendMsgTimeout = value;
					}
				}
			}

			public class SearchOmsOpenAPIProjects_DestConfig
			{

				private string endpointType;

				private string endpointId;

				private string partitionMode;

				private int? partition;

				private string serializerType;

				private string topicType;

				private bool? sequenceEnable;

				private long? sequenceStartTimestamp;

				private string producerGroup;

				private string msgTags;

				private bool? enableMsgTrace;

				private long? sendMsgTimeout;

				[JsonProperty(PropertyName = "EndpointType")]
				public string EndpointType
				{
					get
					{
						return endpointType;
					}
					set	
					{
						endpointType = value;
					}
				}

				[JsonProperty(PropertyName = "EndpointId")]
				public string EndpointId
				{
					get
					{
						return endpointId;
					}
					set	
					{
						endpointId = value;
					}
				}

				[JsonProperty(PropertyName = "PartitionMode")]
				public string PartitionMode
				{
					get
					{
						return partitionMode;
					}
					set	
					{
						partitionMode = value;
					}
				}

				[JsonProperty(PropertyName = "Partition")]
				public int? Partition
				{
					get
					{
						return partition;
					}
					set	
					{
						partition = value;
					}
				}

				[JsonProperty(PropertyName = "SerializerType")]
				public string SerializerType
				{
					get
					{
						return serializerType;
					}
					set	
					{
						serializerType = value;
					}
				}

				[JsonProperty(PropertyName = "TopicType")]
				public string TopicType
				{
					get
					{
						return topicType;
					}
					set	
					{
						topicType = value;
					}
				}

				[JsonProperty(PropertyName = "SequenceEnable")]
				public bool? SequenceEnable
				{
					get
					{
						return sequenceEnable;
					}
					set	
					{
						sequenceEnable = value;
					}
				}

				[JsonProperty(PropertyName = "SequenceStartTimestamp")]
				public long? SequenceStartTimestamp
				{
					get
					{
						return sequenceStartTimestamp;
					}
					set	
					{
						sequenceStartTimestamp = value;
					}
				}

				[JsonProperty(PropertyName = "ProducerGroup")]
				public string ProducerGroup
				{
					get
					{
						return producerGroup;
					}
					set	
					{
						producerGroup = value;
					}
				}

				[JsonProperty(PropertyName = "MsgTags")]
				public string MsgTags
				{
					get
					{
						return msgTags;
					}
					set	
					{
						msgTags = value;
					}
				}

				[JsonProperty(PropertyName = "EnableMsgTrace")]
				public bool? EnableMsgTrace
				{
					get
					{
						return enableMsgTrace;
					}
					set	
					{
						enableMsgTrace = value;
					}
				}

				[JsonProperty(PropertyName = "SendMsgTimeout")]
				public long? SendMsgTimeout
				{
					get
					{
						return sendMsgTimeout;
					}
					set	
					{
						sendMsgTimeout = value;
					}
				}
			}

			public class SearchOmsOpenAPIProjects_TransferMapping
			{

				private string mode;

				private List<SearchOmsOpenAPIProjects_Database> databases;

				[JsonProperty(PropertyName = "Mode")]
				public string Mode
				{
					get
					{
						return mode;
					}
					set	
					{
						mode = value;
					}
				}

				[JsonProperty(PropertyName = "Databases")]
				public List<SearchOmsOpenAPIProjects_Database> Databases
				{
					get
					{
						return databases;
					}
					set	
					{
						databases = value;
					}
				}

				public class SearchOmsOpenAPIProjects_Database
				{

					private string tenantName;

					private string mappedName;

					private string databaseId;

					private string databaseName;

					private string type;

					private List<SearchOmsOpenAPIProjects_Table> tables;

					[JsonProperty(PropertyName = "TenantName")]
					public string TenantName
					{
						get
						{
							return tenantName;
						}
						set	
						{
							tenantName = value;
						}
					}

					[JsonProperty(PropertyName = "MappedName")]
					public string MappedName
					{
						get
						{
							return mappedName;
						}
						set	
						{
							mappedName = value;
						}
					}

					[JsonProperty(PropertyName = "DatabaseId")]
					public string DatabaseId
					{
						get
						{
							return databaseId;
						}
						set	
						{
							databaseId = value;
						}
					}

					[JsonProperty(PropertyName = "DatabaseName")]
					public string DatabaseName
					{
						get
						{
							return databaseName;
						}
						set	
						{
							databaseName = value;
						}
					}

					[JsonProperty(PropertyName = "Type")]
					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					[JsonProperty(PropertyName = "Tables")]
					public List<SearchOmsOpenAPIProjects_Table> Tables
					{
						get
						{
							return tables;
						}
						set	
						{
							tables = value;
						}
					}

					public class SearchOmsOpenAPIProjects_Table
					{

						private string mappedName;

						private string tableId;

						private string tableName;

						private string whereClause;

						private string type;

						private List<string> filterColumns;

						private List<string> shardColumns;

						private SearchOmsOpenAPIProjects_AdbTableSchema adbTableSchema;

						[JsonProperty(PropertyName = "MappedName")]
						public string MappedName
						{
							get
							{
								return mappedName;
							}
							set	
							{
								mappedName = value;
							}
						}

						[JsonProperty(PropertyName = "TableId")]
						public string TableId
						{
							get
							{
								return tableId;
							}
							set	
							{
								tableId = value;
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

						[JsonProperty(PropertyName = "WhereClause")]
						public string WhereClause
						{
							get
							{
								return whereClause;
							}
							set	
							{
								whereClause = value;
							}
						}

						[JsonProperty(PropertyName = "Type")]
						public string Type
						{
							get
							{
								return type;
							}
							set	
							{
								type = value;
							}
						}

						[JsonProperty(PropertyName = "FilterColumns")]
						public List<string> FilterColumns
						{
							get
							{
								return filterColumns;
							}
							set	
							{
								filterColumns = value;
							}
						}

						[JsonProperty(PropertyName = "ShardColumns")]
						public List<string> ShardColumns
						{
							get
							{
								return shardColumns;
							}
							set	
							{
								shardColumns = value;
							}
						}

						[JsonProperty(PropertyName = "AdbTableSchema")]
						public SearchOmsOpenAPIProjects_AdbTableSchema AdbTableSchema
						{
							get
							{
								return adbTableSchema;
							}
							set	
							{
								adbTableSchema = value;
							}
						}

						public class SearchOmsOpenAPIProjects_AdbTableSchema
						{

							private string partitionStatement;

							private int? partitionLifeCycle;

							private List<string> primaryKeys;

							private List<string> distributedKeys;

							[JsonProperty(PropertyName = "PartitionStatement")]
							public string PartitionStatement
							{
								get
								{
									return partitionStatement;
								}
								set	
								{
									partitionStatement = value;
								}
							}

							[JsonProperty(PropertyName = "PartitionLifeCycle")]
							public int? PartitionLifeCycle
							{
								get
								{
									return partitionLifeCycle;
								}
								set	
								{
									partitionLifeCycle = value;
								}
							}

							[JsonProperty(PropertyName = "PrimaryKeys")]
							public List<string> PrimaryKeys
							{
								get
								{
									return primaryKeys;
								}
								set	
								{
									primaryKeys = value;
								}
							}

							[JsonProperty(PropertyName = "DistributedKeys")]
							public List<string> DistributedKeys
							{
								get
								{
									return distributedKeys;
								}
								set	
								{
									distributedKeys = value;
								}
							}
						}
					}
				}
			}

			public class SearchOmsOpenAPIProjects_TransferStepConfig
			{

				private bool? enableStructSync;

				private bool? enableFullSync;

				private bool? enableIncrSync;

				private SearchOmsOpenAPIProjects_IncrSyncStepTransferConfig incrSyncStepTransferConfig;

				[JsonProperty(PropertyName = "EnableStructSync")]
				public bool? EnableStructSync
				{
					get
					{
						return enableStructSync;
					}
					set	
					{
						enableStructSync = value;
					}
				}

				[JsonProperty(PropertyName = "EnableFullSync")]
				public bool? EnableFullSync
				{
					get
					{
						return enableFullSync;
					}
					set	
					{
						enableFullSync = value;
					}
				}

				[JsonProperty(PropertyName = "EnableIncrSync")]
				public bool? EnableIncrSync
				{
					get
					{
						return enableIncrSync;
					}
					set	
					{
						enableIncrSync = value;
					}
				}

				[JsonProperty(PropertyName = "IncrSyncStepTransferConfig")]
				public SearchOmsOpenAPIProjects_IncrSyncStepTransferConfig IncrSyncStepTransferConfig
				{
					get
					{
						return incrSyncStepTransferConfig;
					}
					set	
					{
						incrSyncStepTransferConfig = value;
					}
				}

				public class SearchOmsOpenAPIProjects_IncrSyncStepTransferConfig
				{

					private long? startTimestamp;

					private long? storeLogKeptHour;

					private bool? storeTransactionEnabled;

					private string transferStepType;

					private List<string> recordTypeList;

					[JsonProperty(PropertyName = "StartTimestamp")]
					public long? StartTimestamp
					{
						get
						{
							return startTimestamp;
						}
						set	
						{
							startTimestamp = value;
						}
					}

					[JsonProperty(PropertyName = "StoreLogKeptHour")]
					public long? StoreLogKeptHour
					{
						get
						{
							return storeLogKeptHour;
						}
						set	
						{
							storeLogKeptHour = value;
						}
					}

					[JsonProperty(PropertyName = "StoreTransactionEnabled")]
					public bool? StoreTransactionEnabled
					{
						get
						{
							return storeTransactionEnabled;
						}
						set	
						{
							storeTransactionEnabled = value;
						}
					}

					[JsonProperty(PropertyName = "TransferStepType")]
					public string TransferStepType
					{
						get
						{
							return transferStepType;
						}
						set	
						{
							transferStepType = value;
						}
					}

					[JsonProperty(PropertyName = "RecordTypeList")]
					public List<string> RecordTypeList
					{
						get
						{
							return recordTypeList;
						}
						set	
						{
							recordTypeList = value;
						}
					}
				}
			}
		}

		public class SearchOmsOpenAPIProjects_ErrorDetail1
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
