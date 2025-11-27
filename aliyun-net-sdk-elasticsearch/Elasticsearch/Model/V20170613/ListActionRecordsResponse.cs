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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListActionRecordsResponse : AcsResponse
	{

		private string requestId;

		private List<ListActionRecords_ActionRecord> result;

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

		public List<ListActionRecords_ActionRecord> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListActionRecords_ActionRecord
		{

			private string actionName;

			private string actionParams;

			private long? endTime;

			private string instanceId;

			private string process;

			private string recordDiff;

			private string requestId;

			private long? startTime;

			private string stateType;

			private string userId;

			private string userType;

			private string ownerId;

			private string userInfo;

			private string metaNow;

			private string metaOld;

			private List<ListActionRecords_StatusInfoItem> statusInfo;

			private List<string> actionResultAccessList;

			private List<string> recordIds;

			public string ActionName
			{
				get
				{
					return actionName;
				}
				set	
				{
					actionName = value;
				}
			}

			public string ActionParams
			{
				get
				{
					return actionParams;
				}
				set	
				{
					actionParams = value;
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

			public string InstanceId
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

			public string Process
			{
				get
				{
					return process;
				}
				set	
				{
					process = value;
				}
			}

			public string RecordDiff
			{
				get
				{
					return recordDiff;
				}
				set	
				{
					recordDiff = value;
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

			public string StateType
			{
				get
				{
					return stateType;
				}
				set	
				{
					stateType = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			public string OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public string UserInfo
			{
				get
				{
					return userInfo;
				}
				set	
				{
					userInfo = value;
				}
			}

			public string MetaNow
			{
				get
				{
					return metaNow;
				}
				set	
				{
					metaNow = value;
				}
			}

			public string MetaOld
			{
				get
				{
					return metaOld;
				}
				set	
				{
					metaOld = value;
				}
			}

			public List<ListActionRecords_StatusInfoItem> StatusInfo
			{
				get
				{
					return statusInfo;
				}
				set	
				{
					statusInfo = value;
				}
			}

			public List<string> ActionResultAccessList
			{
				get
				{
					return actionResultAccessList;
				}
				set	
				{
					actionResultAccessList = value;
				}
			}

			public List<string> RecordIds
			{
				get
				{
					return recordIds;
				}
				set	
				{
					recordIds = value;
				}
			}

			public class ListActionRecords_StatusInfoItem
			{

				private string subState;

				private int? nodeCount;

				private int? completeNodeCount;

				private string exception;

				private long? latencyMills;

				private string process;

				private long? startTime;

				private long? endTime;

				private string stateType;

				private List<ListActionRecords_SubStatusInfoItem> subStatusInfo;

				public string SubState
				{
					get
					{
						return subState;
					}
					set	
					{
						subState = value;
					}
				}

				public int? NodeCount
				{
					get
					{
						return nodeCount;
					}
					set	
					{
						nodeCount = value;
					}
				}

				public int? CompleteNodeCount
				{
					get
					{
						return completeNodeCount;
					}
					set	
					{
						completeNodeCount = value;
					}
				}

				public string Exception
				{
					get
					{
						return exception;
					}
					set	
					{
						exception = value;
					}
				}

				public long? LatencyMills
				{
					get
					{
						return latencyMills;
					}
					set	
					{
						latencyMills = value;
					}
				}

				public string Process
				{
					get
					{
						return process;
					}
					set	
					{
						process = value;
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

				public string StateType
				{
					get
					{
						return stateType;
					}
					set	
					{
						stateType = value;
					}
				}

				public List<ListActionRecords_SubStatusInfoItem> SubStatusInfo
				{
					get
					{
						return subStatusInfo;
					}
					set	
					{
						subStatusInfo = value;
					}
				}

				public class ListActionRecords_SubStatusInfoItem
				{

					private string subState;

					private int? nodeCount;

					private int? completeNodeCount;

					private string exception;

					private long? latencyMills;

					private string process;

					private long? startTime;

					private long? endTime;

					private string stateType;

					public string SubState
					{
						get
						{
							return subState;
						}
						set	
						{
							subState = value;
						}
					}

					public int? NodeCount
					{
						get
						{
							return nodeCount;
						}
						set	
						{
							nodeCount = value;
						}
					}

					public int? CompleteNodeCount
					{
						get
						{
							return completeNodeCount;
						}
						set	
						{
							completeNodeCount = value;
						}
					}

					public string Exception
					{
						get
						{
							return exception;
						}
						set	
						{
							exception = value;
						}
					}

					public long? LatencyMills
					{
						get
						{
							return latencyMills;
						}
						set	
						{
							latencyMills = value;
						}
					}

					public string Process
					{
						get
						{
							return process;
						}
						set	
						{
							process = value;
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

					public string StateType
					{
						get
						{
							return stateType;
						}
						set	
						{
							stateType = value;
						}
					}
				}
			}
		}
	}
}
