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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class ListTrafficMarkingPoliciesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<ListTrafficMarkingPolicies_TrafficMarkingPolicy> trafficMarkingPolicies;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public int? TotalCount
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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListTrafficMarkingPolicies_TrafficMarkingPolicy> TrafficMarkingPolicies
		{
			get
			{
				return trafficMarkingPolicies;
			}
			set	
			{
				trafficMarkingPolicies = value;
			}
		}

		public class ListTrafficMarkingPolicies_TrafficMarkingPolicy
		{

			private string trafficMarkingPolicyStatus;

			private string trafficMarkingPolicyId;

			private int? markingDscp;

			private string trafficMarkingPolicyName;

			private int? priority;

			private string trafficMarkingPolicyDescription;

			private List<ListTrafficMarkingPolicies_TrafficMatchRule> trafficMatchRules;

			public string TrafficMarkingPolicyStatus
			{
				get
				{
					return trafficMarkingPolicyStatus;
				}
				set	
				{
					trafficMarkingPolicyStatus = value;
				}
			}

			public string TrafficMarkingPolicyId
			{
				get
				{
					return trafficMarkingPolicyId;
				}
				set	
				{
					trafficMarkingPolicyId = value;
				}
			}

			public int? MarkingDscp
			{
				get
				{
					return markingDscp;
				}
				set	
				{
					markingDscp = value;
				}
			}

			public string TrafficMarkingPolicyName
			{
				get
				{
					return trafficMarkingPolicyName;
				}
				set	
				{
					trafficMarkingPolicyName = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string TrafficMarkingPolicyDescription
			{
				get
				{
					return trafficMarkingPolicyDescription;
				}
				set	
				{
					trafficMarkingPolicyDescription = value;
				}
			}

			public List<ListTrafficMarkingPolicies_TrafficMatchRule> TrafficMatchRules
			{
				get
				{
					return trafficMatchRules;
				}
				set	
				{
					trafficMatchRules = value;
				}
			}

			public class ListTrafficMarkingPolicies_TrafficMatchRule
			{

				private int? matchDscp;

				private string dstCidr;

				private string trafficMatchRuleDescription;

				private string protocol;

				private string trafficMatchRuleId;

				private string srcCidr;

				private string trafficMatchRuleName;

				private string trafficMatchRuleStatus;

				private List<string> dstPortRange;

				private List<string> srcPortRange;

				public int? MatchDscp
				{
					get
					{
						return matchDscp;
					}
					set	
					{
						matchDscp = value;
					}
				}

				public string DstCidr
				{
					get
					{
						return dstCidr;
					}
					set	
					{
						dstCidr = value;
					}
				}

				public string TrafficMatchRuleDescription
				{
					get
					{
						return trafficMatchRuleDescription;
					}
					set	
					{
						trafficMatchRuleDescription = value;
					}
				}

				public string Protocol
				{
					get
					{
						return protocol;
					}
					set	
					{
						protocol = value;
					}
				}

				public string TrafficMatchRuleId
				{
					get
					{
						return trafficMatchRuleId;
					}
					set	
					{
						trafficMatchRuleId = value;
					}
				}

				public string SrcCidr
				{
					get
					{
						return srcCidr;
					}
					set	
					{
						srcCidr = value;
					}
				}

				public string TrafficMatchRuleName
				{
					get
					{
						return trafficMatchRuleName;
					}
					set	
					{
						trafficMatchRuleName = value;
					}
				}

				public string TrafficMatchRuleStatus
				{
					get
					{
						return trafficMatchRuleStatus;
					}
					set	
					{
						trafficMatchRuleStatus = value;
					}
				}

				public List<string> DstPortRange
				{
					get
					{
						return dstPortRange;
					}
					set	
					{
						dstPortRange = value;
					}
				}

				public List<string> SrcPortRange
				{
					get
					{
						return srcPortRange;
					}
					set	
					{
						srcPortRange = value;
					}
				}
			}
		}
	}
}
