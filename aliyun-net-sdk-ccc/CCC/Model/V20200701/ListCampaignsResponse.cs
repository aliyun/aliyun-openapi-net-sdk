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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListCampaignsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private long? httpStatusCode;

		private string code;

		private bool? success;

		private ListCampaigns_Data data;

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

		public long? HttpStatusCode
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

		public ListCampaigns_Data Data
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

		public class ListCampaigns_Data
		{

			private long? pageNumber;

			private long? pageSize;

			private long? totalCount;

			private List<ListCampaigns_ListItem> list;

			public long? PageNumber
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

			public long? PageSize
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

			public List<ListCampaigns_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListCampaigns_ListItem
			{

				private long? actualEndTime;

				private long? actualStartTime;

				private long? casesAborted;

				private long? casesUncompleted;

				private long? casesConnected;

				private long? completedRate;

				private long? maxAttemptCount;

				private long? minAttemptInterval;

				private string name;

				private long? planedEndTime;

				private long? planedStartTime;

				private string queueName;

				private long? totalCases;

				private string state;

				private string campaignId;

				private string strategyType;

				private string strategyParameters;

				private string queueId;

				private bool? simulation;

				public long? ActualEndTime
				{
					get
					{
						return actualEndTime;
					}
					set	
					{
						actualEndTime = value;
					}
				}

				public long? ActualStartTime
				{
					get
					{
						return actualStartTime;
					}
					set	
					{
						actualStartTime = value;
					}
				}

				public long? CasesAborted
				{
					get
					{
						return casesAborted;
					}
					set	
					{
						casesAborted = value;
					}
				}

				public long? CasesUncompleted
				{
					get
					{
						return casesUncompleted;
					}
					set	
					{
						casesUncompleted = value;
					}
				}

				public long? CasesConnected
				{
					get
					{
						return casesConnected;
					}
					set	
					{
						casesConnected = value;
					}
				}

				public long? CompletedRate
				{
					get
					{
						return completedRate;
					}
					set	
					{
						completedRate = value;
					}
				}

				public long? MaxAttemptCount
				{
					get
					{
						return maxAttemptCount;
					}
					set	
					{
						maxAttemptCount = value;
					}
				}

				public long? MinAttemptInterval
				{
					get
					{
						return minAttemptInterval;
					}
					set	
					{
						minAttemptInterval = value;
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

				public long? PlanedEndTime
				{
					get
					{
						return planedEndTime;
					}
					set	
					{
						planedEndTime = value;
					}
				}

				public long? PlanedStartTime
				{
					get
					{
						return planedStartTime;
					}
					set	
					{
						planedStartTime = value;
					}
				}

				public string QueueName
				{
					get
					{
						return queueName;
					}
					set	
					{
						queueName = value;
					}
				}

				public long? TotalCases
				{
					get
					{
						return totalCases;
					}
					set	
					{
						totalCases = value;
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

				public string CampaignId
				{
					get
					{
						return campaignId;
					}
					set	
					{
						campaignId = value;
					}
				}

				public string StrategyType
				{
					get
					{
						return strategyType;
					}
					set	
					{
						strategyType = value;
					}
				}

				public string StrategyParameters
				{
					get
					{
						return strategyParameters;
					}
					set	
					{
						strategyParameters = value;
					}
				}

				public string QueueId
				{
					get
					{
						return queueId;
					}
					set	
					{
						queueId = value;
					}
				}

				public bool? Simulation
				{
					get
					{
						return simulation;
					}
					set	
					{
						simulation = value;
					}
				}
			}
		}
	}
}
