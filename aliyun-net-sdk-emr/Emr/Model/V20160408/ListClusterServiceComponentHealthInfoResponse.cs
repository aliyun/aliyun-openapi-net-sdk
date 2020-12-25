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
	public class ListClusterServiceComponentHealthInfoResponse : AcsResponse
	{

		private string requestId;

		private string clusterId;

		private List<ListClusterServiceComponentHealthInfo_HealthInfo> healthInfoList;

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

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
			}
		}

		public List<ListClusterServiceComponentHealthInfo_HealthInfo> HealthInfoList
		{
			get
			{
				return healthInfoList;
			}
			set	
			{
				healthInfoList = value;
			}
		}

		public class ListClusterServiceComponentHealthInfo_HealthInfo
		{

			private string serviceName;

			private string componentName;

			private string healthLevel;

			private int? stoppedNum;

			private int? manualStoppedNum;

			private int? normalNum;

			private int? totalNum;

			private int? agentHeartBeatLostNum;

			private long? createdTime;

			private List<ListClusterServiceComponentHealthInfo_HealthDetail> healthDetailList;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ComponentName
			{
				get
				{
					return componentName;
				}
				set	
				{
					componentName = value;
				}
			}

			public string HealthLevel
			{
				get
				{
					return healthLevel;
				}
				set	
				{
					healthLevel = value;
				}
			}

			public int? StoppedNum
			{
				get
				{
					return stoppedNum;
				}
				set	
				{
					stoppedNum = value;
				}
			}

			public int? ManualStoppedNum
			{
				get
				{
					return manualStoppedNum;
				}
				set	
				{
					manualStoppedNum = value;
				}
			}

			public int? NormalNum
			{
				get
				{
					return normalNum;
				}
				set	
				{
					normalNum = value;
				}
			}

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? AgentHeartBeatLostNum
			{
				get
				{
					return agentHeartBeatLostNum;
				}
				set	
				{
					agentHeartBeatLostNum = value;
				}
			}

			public long? CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public List<ListClusterServiceComponentHealthInfo_HealthDetail> HealthDetailList
			{
				get
				{
					return healthDetailList;
				}
				set	
				{
					healthDetailList = value;
				}
			}

			public class ListClusterServiceComponentHealthInfo_HealthDetail
			{

				private string code;

				private ListClusterServiceComponentHealthInfo_HealthRuleParam healthRuleParam;

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

				public ListClusterServiceComponentHealthInfo_HealthRuleParam HealthRuleParam
				{
					get
					{
						return healthRuleParam;
					}
					set	
					{
						healthRuleParam = value;
					}
				}

				public class ListClusterServiceComponentHealthInfo_HealthRuleParam
				{

					private string service;

					private string component;

					private string ruleTitle;

					private string pass;

					private string ruleId;

					private string ruleDescription;

					private string hostNames;

					public string Service
					{
						get
						{
							return service;
						}
						set	
						{
							service = value;
						}
					}

					public string Component
					{
						get
						{
							return component;
						}
						set	
						{
							component = value;
						}
					}

					public string RuleTitle
					{
						get
						{
							return ruleTitle;
						}
						set	
						{
							ruleTitle = value;
						}
					}

					public string Pass
					{
						get
						{
							return pass;
						}
						set	
						{
							pass = value;
						}
					}

					public string RuleId
					{
						get
						{
							return ruleId;
						}
						set	
						{
							ruleId = value;
						}
					}

					public string RuleDescription
					{
						get
						{
							return ruleDescription;
						}
						set	
						{
							ruleDescription = value;
						}
					}

					public string HostNames
					{
						get
						{
							return hostNames;
						}
						set	
						{
							hostNames = value;
						}
					}
				}
			}
		}
	}
}
