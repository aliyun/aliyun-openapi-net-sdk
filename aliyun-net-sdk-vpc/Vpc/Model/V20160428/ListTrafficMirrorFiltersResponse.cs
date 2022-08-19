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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class ListTrafficMirrorFiltersResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string totalCount;

		private List<ListTrafficMirrorFilters_TrafficMirrorFilter> trafficMirrorFilters;

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

		public string TotalCount
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

		public List<ListTrafficMirrorFilters_TrafficMirrorFilter> TrafficMirrorFilters
		{
			get
			{
				return trafficMirrorFilters;
			}
			set	
			{
				trafficMirrorFilters = value;
			}
		}

		public class ListTrafficMirrorFilters_TrafficMirrorFilter
		{

			private string trafficMirrorFilterStatus;

			private string trafficMirrorFilterDescription;

			private string trafficMirrorFilterId;

			private string trafficMirrorFilterName;

			private List<ListTrafficMirrorFilters_TrafficMirrorRule> ingressRules;

			private List<ListTrafficMirrorFilters_TrafficMirrorRule> egressRules;

			public string TrafficMirrorFilterStatus
			{
				get
				{
					return trafficMirrorFilterStatus;
				}
				set	
				{
					trafficMirrorFilterStatus = value;
				}
			}

			public string TrafficMirrorFilterDescription
			{
				get
				{
					return trafficMirrorFilterDescription;
				}
				set	
				{
					trafficMirrorFilterDescription = value;
				}
			}

			public string TrafficMirrorFilterId
			{
				get
				{
					return trafficMirrorFilterId;
				}
				set	
				{
					trafficMirrorFilterId = value;
				}
			}

			public string TrafficMirrorFilterName
			{
				get
				{
					return trafficMirrorFilterName;
				}
				set	
				{
					trafficMirrorFilterName = value;
				}
			}

			public List<ListTrafficMirrorFilters_TrafficMirrorRule> IngressRules
			{
				get
				{
					return ingressRules;
				}
				set	
				{
					ingressRules = value;
				}
			}

			public List<ListTrafficMirrorFilters_TrafficMirrorRule> EgressRules
			{
				get
				{
					return egressRules;
				}
				set	
				{
					egressRules = value;
				}
			}

			public class ListTrafficMirrorFilters_TrafficMirrorRule
			{

				private string trafficMirrorFilterRuleStatus;

				private string action;

				private string sourceCidrBlock;

				private string trafficDirection;

				private string protocol;

				private string destinationPortRange;

				private string trafficMirrorFilterRuleId;

				private string destinationCidrBlock;

				private int? priority;

				private string trafficMirrorFilterId;

				private string sourcePortRange;

				public string TrafficMirrorFilterRuleStatus
				{
					get
					{
						return trafficMirrorFilterRuleStatus;
					}
					set	
					{
						trafficMirrorFilterRuleStatus = value;
					}
				}

				public string Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}

				public string SourceCidrBlock
				{
					get
					{
						return sourceCidrBlock;
					}
					set	
					{
						sourceCidrBlock = value;
					}
				}

				public string TrafficDirection
				{
					get
					{
						return trafficDirection;
					}
					set	
					{
						trafficDirection = value;
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

				public string DestinationPortRange
				{
					get
					{
						return destinationPortRange;
					}
					set	
					{
						destinationPortRange = value;
					}
				}

				public string TrafficMirrorFilterRuleId
				{
					get
					{
						return trafficMirrorFilterRuleId;
					}
					set	
					{
						trafficMirrorFilterRuleId = value;
					}
				}

				public string DestinationCidrBlock
				{
					get
					{
						return destinationCidrBlock;
					}
					set	
					{
						destinationCidrBlock = value;
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

				public string TrafficMirrorFilterId
				{
					get
					{
						return trafficMirrorFilterId;
					}
					set	
					{
						trafficMirrorFilterId = value;
					}
				}

				public string SourcePortRange
				{
					get
					{
						return sourcePortRange;
					}
					set	
					{
						sourcePortRange = value;
					}
				}
			}
		}
	}
}
