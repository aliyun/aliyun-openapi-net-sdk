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
	public class DescribeOmsOpenAPIProjectStepsResponse : AcsResponse
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

		private List<DescribeOmsOpenAPIProjectSteps_DataItem> data;

		private DescribeOmsOpenAPIProjectSteps_ErrorDetail1 errorDetail1;

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
		public List<DescribeOmsOpenAPIProjectSteps_DataItem> Data
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
		public DescribeOmsOpenAPIProjectSteps_ErrorDetail1 ErrorDetail1
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

		public class DescribeOmsOpenAPIProjectSteps_DataItem
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

			private DescribeOmsOpenAPIProjectSteps_StepInfo stepInfo;

			private DescribeOmsOpenAPIProjectSteps_ExtraInfo extraInfo;

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
			public DescribeOmsOpenAPIProjectSteps_StepInfo StepInfo
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
			public DescribeOmsOpenAPIProjectSteps_ExtraInfo ExtraInfo
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

			public class DescribeOmsOpenAPIProjectSteps_StepInfo
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

				private DescribeOmsOpenAPIProjectSteps_ConnectorFullProgressOverview connectorFullProgressOverview;

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
				public DescribeOmsOpenAPIProjectSteps_ConnectorFullProgressOverview ConnectorFullProgressOverview
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

				public class DescribeOmsOpenAPIProjectSteps_ConnectorFullProgressOverview
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

			public class DescribeOmsOpenAPIProjectSteps_ExtraInfo
			{

				private string errorCode;

				private string errorMsg;

				private string errorParam;

				private string failedTime;

				private List<DescribeOmsOpenAPIProjectSteps_ErrorDetail> errorDetails;

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
				public List<DescribeOmsOpenAPIProjectSteps_ErrorDetail> ErrorDetails
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

				public class DescribeOmsOpenAPIProjectSteps_ErrorDetail
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

		public class DescribeOmsOpenAPIProjectSteps_ErrorDetail1
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
