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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
	public class DescribeRiskListDetailResponse : AcsResponse
	{

		private string requestId;

		private string module;

		private List<DescribeRiskListDetail_Data> dataList;

		private DescribeRiskListDetail_PageInfo pageInfo;

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

		public string Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public List<DescribeRiskListDetail_Data> DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public DescribeRiskListDetail_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeRiskListDetail_Data
		{

			private int? riskId;

			private string updateTime;

			private string riskDescribe;

			private string riskType;

			private string riskInstance;

			private string product;

			private string regionId;

			private string tacticsName;

			private string status;

			private string ignoreTime;

			private List<DescribeRiskListDetail_EcsSecGroupRiskItem> ecsSecGroupRisk;

			private List<DescribeRiskListDetail_RdsWhitelistRiskItem> rdsWhitelistRisk;

			private List<string> instanceList;

			public int? RiskId
			{
				get
				{
					return riskId;
				}
				set	
				{
					riskId = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string RiskDescribe
			{
				get
				{
					return riskDescribe;
				}
				set	
				{
					riskDescribe = value;
				}
			}

			public string RiskType
			{
				get
				{
					return riskType;
				}
				set	
				{
					riskType = value;
				}
			}

			public string RiskInstance
			{
				get
				{
					return riskInstance;
				}
				set	
				{
					riskInstance = value;
				}
			}

			public string Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string TacticsName
			{
				get
				{
					return tacticsName;
				}
				set	
				{
					tacticsName = value;
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

			public string IgnoreTime
			{
				get
				{
					return ignoreTime;
				}
				set	
				{
					ignoreTime = value;
				}
			}

			public List<DescribeRiskListDetail_EcsSecGroupRiskItem> EcsSecGroupRisk
			{
				get
				{
					return ecsSecGroupRisk;
				}
				set	
				{
					ecsSecGroupRisk = value;
				}
			}

			public List<DescribeRiskListDetail_RdsWhitelistRiskItem> RdsWhitelistRisk
			{
				get
				{
					return rdsWhitelistRisk;
				}
				set	
				{
					rdsWhitelistRisk = value;
				}
			}

			public List<string> InstanceList
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

			public class DescribeRiskListDetail_EcsSecGroupRiskItem
			{

				private string netType;

				private string direction;

				private string dstPortRange;

				private string srcIpRange;

				public string NetType
				{
					get
					{
						return netType;
					}
					set	
					{
						netType = value;
					}
				}

				public string Direction
				{
					get
					{
						return direction;
					}
					set	
					{
						direction = value;
					}
				}

				public string DstPortRange
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

				public string SrcIpRange
				{
					get
					{
						return srcIpRange;
					}
					set	
					{
						srcIpRange = value;
					}
				}
			}

			public class DescribeRiskListDetail_RdsWhitelistRiskItem
			{

				private string rdsWhitelistGroup;

				private string riskDetail;

				public string RdsWhitelistGroup
				{
					get
					{
						return rdsWhitelistGroup;
					}
					set	
					{
						rdsWhitelistGroup = value;
					}
				}

				public string RiskDetail
				{
					get
					{
						return riskDetail;
					}
					set	
					{
						riskDetail = value;
					}
				}
			}
		}

		public class DescribeRiskListDetail_PageInfo
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}