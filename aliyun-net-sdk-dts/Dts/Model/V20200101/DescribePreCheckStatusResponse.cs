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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribePreCheckStatusResponse : AcsResponse
	{

		private string code;

		private int? errorItem;

		private int? httpStatusCode;

		private string jobName;

		private string state;

		private bool? success;

		private int? total;

		private string requestId;

		private string jobId;

		private List<DescribePreCheckStatus_ProgressInfo> jobProgress;

		private List<DescribePreCheckStatus_SubDistributedJobStatusItem> subDistributedJobStatus;

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

		public int? ErrorItem
		{
			get
			{
				return errorItem;
			}
			set	
			{
				errorItem = value;
			}
		}

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

		public string JobName
		{
			get
			{
				return jobName;
			}
			set	
			{
				jobName = value;
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
			}
		}

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

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

		public List<DescribePreCheckStatus_ProgressInfo> JobProgress
		{
			get
			{
				return jobProgress;
			}
			set	
			{
				jobProgress = value;
			}
		}

		public List<DescribePreCheckStatus_SubDistributedJobStatusItem> SubDistributedJobStatus
		{
			get
			{
				return subDistributedJobStatus;
			}
			set	
			{
				subDistributedJobStatus = value;
			}
		}

		public class DescribePreCheckStatus_ProgressInfo
		{

			private bool? skip;

			private bool? canSkip;

			private string errMsg;

			private string bootTime;

			private int? delaySeconds;

			private string finishTime;

			private string ignoreFlag;

			private string item;

			private string jobId;

			private string names;

			private int? orderNum;

			private string state;

			private string sub;

			private string repairMethod;

			private string targetNames;

			private int? total;

			private string sourceSchema;

			private string parentObj;

			private long? diffRow;

			private string destSchema;

			private string errDetail;

			private string ddlSql;

			private List<DescribePreCheckStatus_JobLog> logs;

			public bool? Skip
			{
				get
				{
					return skip;
				}
				set	
				{
					skip = value;
				}
			}

			public bool? CanSkip
			{
				get
				{
					return canSkip;
				}
				set	
				{
					canSkip = value;
				}
			}

			public string ErrMsg
			{
				get
				{
					return errMsg;
				}
				set	
				{
					errMsg = value;
				}
			}

			public string BootTime
			{
				get
				{
					return bootTime;
				}
				set	
				{
					bootTime = value;
				}
			}

			public int? DelaySeconds
			{
				get
				{
					return delaySeconds;
				}
				set	
				{
					delaySeconds = value;
				}
			}

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

			public string IgnoreFlag
			{
				get
				{
					return ignoreFlag;
				}
				set	
				{
					ignoreFlag = value;
				}
			}

			public string Item
			{
				get
				{
					return item;
				}
				set	
				{
					item = value;
				}
			}

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

			public string Names
			{
				get
				{
					return names;
				}
				set	
				{
					names = value;
				}
			}

			public int? OrderNum
			{
				get
				{
					return orderNum;
				}
				set	
				{
					orderNum = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string Sub
			{
				get
				{
					return sub;
				}
				set	
				{
					sub = value;
				}
			}

			public string RepairMethod
			{
				get
				{
					return repairMethod;
				}
				set	
				{
					repairMethod = value;
				}
			}

			public string TargetNames
			{
				get
				{
					return targetNames;
				}
				set	
				{
					targetNames = value;
				}
			}

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public string SourceSchema
			{
				get
				{
					return sourceSchema;
				}
				set	
				{
					sourceSchema = value;
				}
			}

			public string ParentObj
			{
				get
				{
					return parentObj;
				}
				set	
				{
					parentObj = value;
				}
			}

			public long? DiffRow
			{
				get
				{
					return diffRow;
				}
				set	
				{
					diffRow = value;
				}
			}

			public string DestSchema
			{
				get
				{
					return destSchema;
				}
				set	
				{
					destSchema = value;
				}
			}

			public string ErrDetail
			{
				get
				{
					return errDetail;
				}
				set	
				{
					errDetail = value;
				}
			}

			public string DdlSql
			{
				get
				{
					return ddlSql;
				}
				set	
				{
					ddlSql = value;
				}
			}

			public List<DescribePreCheckStatus_JobLog> Logs
			{
				get
				{
					return logs;
				}
				set	
				{
					logs = value;
				}
			}

			public class DescribePreCheckStatus_JobLog
			{

				private string errData;

				private string errMsg;

				private string errType;

				private string logLevel;

				public string ErrData
				{
					get
					{
						return errData;
					}
					set	
					{
						errData = value;
					}
				}

				public string ErrMsg
				{
					get
					{
						return errMsg;
					}
					set	
					{
						errMsg = value;
					}
				}

				public string ErrType
				{
					get
					{
						return errType;
					}
					set	
					{
						errType = value;
					}
				}

				public string LogLevel
				{
					get
					{
						return logLevel;
					}
					set	
					{
						logLevel = value;
					}
				}
			}
		}

		public class DescribePreCheckStatus_SubDistributedJobStatusItem
		{

			private string state;

			private int? errorItem;

			private string jobName;

			private string jobId;

			private string code;

			private int? total;

			private List<DescribePreCheckStatus_ProgressInfo2> jobProgress1;

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public int? ErrorItem
			{
				get
				{
					return errorItem;
				}
				set	
				{
					errorItem = value;
				}
			}

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
				}
			}

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

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public List<DescribePreCheckStatus_ProgressInfo2> JobProgress1
			{
				get
				{
					return jobProgress1;
				}
				set	
				{
					jobProgress1 = value;
				}
			}

			public class DescribePreCheckStatus_ProgressInfo2
			{

				private bool? skip;

				private bool? canSkip;

				private string errMsg;

				private string bootTime;

				private int? delaySeconds;

				private string finishTime;

				private string ignoreFlag;

				private string item;

				private string jobId;

				private string names;

				private int? orderNum;

				private string state;

				private string sub;

				private string repairMethod;

				private string targetNames;

				private int? total;

				private string sourceSchema;

				private string parentObj;

				private long? diffRow;

				private string destSchema;

				private string errDetail;

				private string ddlSql;

				private List<DescribePreCheckStatus_JobLog4> logs3;

				public bool? Skip
				{
					get
					{
						return skip;
					}
					set	
					{
						skip = value;
					}
				}

				public bool? CanSkip
				{
					get
					{
						return canSkip;
					}
					set	
					{
						canSkip = value;
					}
				}

				public string ErrMsg
				{
					get
					{
						return errMsg;
					}
					set	
					{
						errMsg = value;
					}
				}

				public string BootTime
				{
					get
					{
						return bootTime;
					}
					set	
					{
						bootTime = value;
					}
				}

				public int? DelaySeconds
				{
					get
					{
						return delaySeconds;
					}
					set	
					{
						delaySeconds = value;
					}
				}

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

				public string IgnoreFlag
				{
					get
					{
						return ignoreFlag;
					}
					set	
					{
						ignoreFlag = value;
					}
				}

				public string Item
				{
					get
					{
						return item;
					}
					set	
					{
						item = value;
					}
				}

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

				public string Names
				{
					get
					{
						return names;
					}
					set	
					{
						names = value;
					}
				}

				public int? OrderNum
				{
					get
					{
						return orderNum;
					}
					set	
					{
						orderNum = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string Sub
				{
					get
					{
						return sub;
					}
					set	
					{
						sub = value;
					}
				}

				public string RepairMethod
				{
					get
					{
						return repairMethod;
					}
					set	
					{
						repairMethod = value;
					}
				}

				public string TargetNames
				{
					get
					{
						return targetNames;
					}
					set	
					{
						targetNames = value;
					}
				}

				public int? Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}

				public string SourceSchema
				{
					get
					{
						return sourceSchema;
					}
					set	
					{
						sourceSchema = value;
					}
				}

				public string ParentObj
				{
					get
					{
						return parentObj;
					}
					set	
					{
						parentObj = value;
					}
				}

				public long? DiffRow
				{
					get
					{
						return diffRow;
					}
					set	
					{
						diffRow = value;
					}
				}

				public string DestSchema
				{
					get
					{
						return destSchema;
					}
					set	
					{
						destSchema = value;
					}
				}

				public string ErrDetail
				{
					get
					{
						return errDetail;
					}
					set	
					{
						errDetail = value;
					}
				}

				public string DdlSql
				{
					get
					{
						return ddlSql;
					}
					set	
					{
						ddlSql = value;
					}
				}

				public List<DescribePreCheckStatus_JobLog4> Logs3
				{
					get
					{
						return logs3;
					}
					set	
					{
						logs3 = value;
					}
				}

				public class DescribePreCheckStatus_JobLog4
				{

					private string errData;

					private string errMsg;

					private string errType;

					private string logLevel;

					public string ErrData
					{
						get
						{
							return errData;
						}
						set	
						{
							errData = value;
						}
					}

					public string ErrMsg
					{
						get
						{
							return errMsg;
						}
						set	
						{
							errMsg = value;
						}
					}

					public string ErrType
					{
						get
						{
							return errType;
						}
						set	
						{
							errType = value;
						}
					}

					public string LogLevel
					{
						get
						{
							return logLevel;
						}
						set	
						{
							logLevel = value;
						}
					}
				}
			}
		}
	}
}
