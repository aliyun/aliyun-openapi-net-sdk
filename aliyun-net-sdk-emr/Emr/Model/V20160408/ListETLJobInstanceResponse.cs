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
	public class ListETLJobInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private int? pageSize;

		private int? pageNumber;

		private List<ListETLJobInstance_Instance> instanceList;

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

		public List<ListETLJobInstance_Instance> InstanceList
		{
			get
			{
				return instanceList;
			}
			set	
			{
				instanceList = value;
			}
		}

		public class ListETLJobInstance_Instance
		{

			private string id;

			private string name;

			private string etlJobId;

			private string instanceStatus;

			private string triggerType;

			private string triggerUser;

			private long? startTime;

			private long? endTime;

			private List<ListETLJobInstance_FlowRelation> flowRelationList;

			private List<ListETLJobInstance_StageInstance> stageInstanceList;

			private ListETLJobInstance_Arguments arguments;

			private ListETLJobInstance_Metrics metrics;

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

			public List<ListETLJobInstance_FlowRelation> FlowRelationList
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

			public List<ListETLJobInstance_StageInstance> StageInstanceList
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

			public ListETLJobInstance_Arguments Arguments
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

			public ListETLJobInstance_Metrics Metrics
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

			public class ListETLJobInstance_FlowRelation
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

			public class ListETLJobInstance_StageInstance
			{

				private string id;

				private string name;

				private long? startTime;

				private long? endTime;

				private ListETLJobInstance_Metrics1 metrics1;

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

				public ListETLJobInstance_Metrics1 Metrics1
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

				public class ListETLJobInstance_Metrics1
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

			public class ListETLJobInstance_Arguments
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

			public class ListETLJobInstance_Metrics
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
}
