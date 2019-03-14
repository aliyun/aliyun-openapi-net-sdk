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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeETLJobInstanceResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string etlJobId;

		private string instanceStatus;

		private string triggerUser;

		private long? startTime;

		private long? endTime;

		private List<DescribeETLJobInstance_FlowRelation> flowRelationList;

		private List<DescribeETLJobInstance_StageInstance> stageInstanceList;

		private DescribeETLJobInstance_TriggerHistory triggerHistory;

		private DescribeETLJobInstance_Arguments arguments;

		private DescribeETLJobInstance_Metrics metrics;

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

		public string EtlJobId
		{
			get
			{
				return etlJobId;
			}
			set	
			{
				etlJobId = value;
			}
		}

		public string InstanceStatus
		{
			get
			{
				return instanceStatus;
			}
			set	
			{
				instanceStatus = value;
			}
		}

		public string TriggerUser
		{
			get
			{
				return triggerUser;
			}
			set	
			{
				triggerUser = value;
			}
		}

		public long? StartTime
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

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public List<DescribeETLJobInstance_FlowRelation> FlowRelationList
		{
			get
			{
				return flowRelationList;
			}
			set	
			{
				flowRelationList = value;
			}
		}

		public List<DescribeETLJobInstance_StageInstance> StageInstanceList
		{
			get
			{
				return stageInstanceList;
			}
			set	
			{
				stageInstanceList = value;
			}
		}

		public DescribeETLJobInstance_TriggerHistory TriggerHistory
		{
			get
			{
				return triggerHistory;
			}
			set	
			{
				triggerHistory = value;
			}
		}

		public DescribeETLJobInstance_Arguments Arguments
		{
			get
			{
				return arguments;
			}
			set	
			{
				arguments = value;
			}
		}

		public DescribeETLJobInstance_Metrics Metrics
		{
			get
			{
				return metrics;
			}
			set	
			{
				metrics = value;
			}
		}

		public class DescribeETLJobInstance_FlowRelation
		{

			private string flowJobId;

			private string flowJobInstanceId;

			public string FlowJobId
			{
				get
				{
					return flowJobId;
				}
				set	
				{
					flowJobId = value;
				}
			}

			public string FlowJobInstanceId
			{
				get
				{
					return flowJobInstanceId;
				}
				set	
				{
					flowJobInstanceId = value;
				}
			}
		}

		public class DescribeETLJobInstance_StageInstance
		{

			private string id;

			private string name;

			private long? startTime;

			private long? endTime;

			private DescribeETLJobInstance_Metrics1 metrics1;

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

			public long? StartTime
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

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public DescribeETLJobInstance_Metrics1 Metrics1
			{
				get
				{
					return metrics1;
				}
				set	
				{
					metrics1 = value;
				}
			}

			public class DescribeETLJobInstance_Metrics1
			{

				private long? totalTime;

				private long? recordsIn;

				private long? recordsOut;

				private long? recordsError;

				private string recordsRate;

				private long? vcores;

				private long? memSize;

				public long? TotalTime
				{
					get
					{
						return totalTime;
					}
					set	
					{
						totalTime = value;
					}
				}

				public long? RecordsIn
				{
					get
					{
						return recordsIn;
					}
					set	
					{
						recordsIn = value;
					}
				}

				public long? RecordsOut
				{
					get
					{
						return recordsOut;
					}
					set	
					{
						recordsOut = value;
					}
				}

				public long? RecordsError
				{
					get
					{
						return recordsError;
					}
					set	
					{
						recordsError = value;
					}
				}

				public string RecordsRate
				{
					get
					{
						return recordsRate;
					}
					set	
					{
						recordsRate = value;
					}
				}

				public long? Vcores
				{
					get
					{
						return vcores;
					}
					set	
					{
						vcores = value;
					}
				}

				public long? MemSize
				{
					get
					{
						return memSize;
					}
					set	
					{
						memSize = value;
					}
				}
			}
		}

		public class DescribeETLJobInstance_TriggerHistory
		{

			private string historyId;

			private string triggerId;

			private string triggerType;

			private string fireState;

			private long? fireTime;

			public string HistoryId
			{
				get
				{
					return historyId;
				}
				set	
				{
					historyId = value;
				}
			}

			public string TriggerId
			{
				get
				{
					return triggerId;
				}
				set	
				{
					triggerId = value;
				}
			}

			public string TriggerType
			{
				get
				{
					return triggerType;
				}
				set	
				{
					triggerType = value;
				}
			}

			public string FireState
			{
				get
				{
					return fireState;
				}
				set	
				{
					fireState = value;
				}
			}

			public long? FireTime
			{
				get
				{
					return fireTime;
				}
				set	
				{
					fireTime = value;
				}
			}
		}

		public class DescribeETLJobInstance_Arguments
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class DescribeETLJobInstance_Metrics
		{

			private long? totalTime;

			private long? recordsIn;

			private long? recordsOut;

			private long? recordsError;

			private string recordsRate;

			private long? vcores;

			private long? memSize;

			public long? TotalTime
			{
				get
				{
					return totalTime;
				}
				set	
				{
					totalTime = value;
				}
			}

			public long? RecordsIn
			{
				get
				{
					return recordsIn;
				}
				set	
				{
					recordsIn = value;
				}
			}

			public long? RecordsOut
			{
				get
				{
					return recordsOut;
				}
				set	
				{
					recordsOut = value;
				}
			}

			public long? RecordsError
			{
				get
				{
					return recordsError;
				}
				set	
				{
					recordsError = value;
				}
			}

			public string RecordsRate
			{
				get
				{
					return recordsRate;
				}
				set	
				{
					recordsRate = value;
				}
			}

			public long? Vcores
			{
				get
				{
					return vcores;
				}
				set	
				{
					vcores = value;
				}
			}

			public long? MemSize
			{
				get
				{
					return memSize;
				}
				set	
				{
					memSize = value;
				}
			}
		}
	}
}
