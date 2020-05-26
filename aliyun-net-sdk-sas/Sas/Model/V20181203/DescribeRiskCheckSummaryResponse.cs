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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeRiskCheckSummaryResponse : AcsResponse
	{

		private string requestId;

		private DescribeRiskCheckSummary_RiskCheckSummary riskCheckSummary;

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

		public DescribeRiskCheckSummary_RiskCheckSummary RiskCheckSummary
		{
			get
			{
				return riskCheckSummary;
			}
			set	
			{
				riskCheckSummary = value;
			}
		}

		public class DescribeRiskCheckSummary_RiskCheckSummary
		{

			private int? riskCount;

			private int? previousCount;

			private int? itemCount;

			private float? riskRate;

			private int? affectedAssetCount;

			private long? previousTime;

			private int? enabledRiskCount;

			private int? disabledRiskCount;

			private List<DescribeRiskCheckSummary_LevelCount> riskLevelCount;

			private List<DescribeRiskCheckSummary_Group> groups;

			public int? RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}

			public int? PreviousCount
			{
				get
				{
					return previousCount;
				}
				set	
				{
					previousCount = value;
				}
			}

			public int? ItemCount
			{
				get
				{
					return itemCount;
				}
				set	
				{
					itemCount = value;
				}
			}

			public float? RiskRate
			{
				get
				{
					return riskRate;
				}
				set	
				{
					riskRate = value;
				}
			}

			public int? AffectedAssetCount
			{
				get
				{
					return affectedAssetCount;
				}
				set	
				{
					affectedAssetCount = value;
				}
			}

			public long? PreviousTime
			{
				get
				{
					return previousTime;
				}
				set	
				{
					previousTime = value;
				}
			}

			public int? EnabledRiskCount
			{
				get
				{
					return enabledRiskCount;
				}
				set	
				{
					enabledRiskCount = value;
				}
			}

			public int? DisabledRiskCount
			{
				get
				{
					return disabledRiskCount;
				}
				set	
				{
					disabledRiskCount = value;
				}
			}

			public List<DescribeRiskCheckSummary_LevelCount> RiskLevelCount
			{
				get
				{
					return riskLevelCount;
				}
				set	
				{
					riskLevelCount = value;
				}
			}

			public List<DescribeRiskCheckSummary_Group> Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			public class DescribeRiskCheckSummary_LevelCount
			{

				private string key;

				private int? count;

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

			public class DescribeRiskCheckSummary_Group
			{

				private long? id;

				private string title;

				private string status;

				private int? remainingTime;

				private int? sort;

				private List<DescribeRiskCheckSummary_StatusCount> countByStatus;

				public long? Id
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

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public int? RemainingTime
				{
					get
					{
						return remainingTime;
					}
					set	
					{
						remainingTime = value;
					}
				}

				public int? Sort
				{
					get
					{
						return sort;
					}
					set	
					{
						sort = value;
					}
				}

				public List<DescribeRiskCheckSummary_StatusCount> CountByStatus
				{
					get
					{
						return countByStatus;
					}
					set	
					{
						countByStatus = value;
					}
				}

				public class DescribeRiskCheckSummary_StatusCount
				{

					private string status;

					private int? count;

					public string Status
					{
						get
						{
							return status;
						}
						set	
						{
							status = value;
						}
					}

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
			}
		}
	}
}
