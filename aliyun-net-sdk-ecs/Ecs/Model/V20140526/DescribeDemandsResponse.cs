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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDemandsResponse : AcsResponse
	{

		private int? pageSize;

		private int? pageNumber;

		private string requestId;

		private int? totalCount;

		private string regionId;

		private List<DescribeDemands_Demand> demands;

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

		public List<DescribeDemands_Demand> Demands
		{
			get
			{
				return demands;
			}
			set	
			{
				demands = value;
			}
		}

		public class DescribeDemands_Demand
		{

			private string comment;

			private string demandDescription;

			private string demandId;

			private string demandTime;

			private string instanceType;

			private string demandName;

			private int? period;

			private string instanceChargeType;

			private int? availableAmount;

			private string endTime;

			private string startTime;

			private string periodUnit;

			private string zoneId;

			private int? usedAmount;

			private int? totalAmount;

			private int? deliveringAmount;

			private string instanceTypeFamily;

			private string demandStatus;

			private List<DescribeDemands_SupplyInfo> supplyInfos;

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string DemandDescription
			{
				get
				{
					return demandDescription;
				}
				set	
				{
					demandDescription = value;
				}
			}

			public string DemandId
			{
				get
				{
					return demandId;
				}
				set	
				{
					demandId = value;
				}
			}

			public string DemandTime
			{
				get
				{
					return demandTime;
				}
				set	
				{
					demandTime = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string DemandName
			{
				get
				{
					return demandName;
				}
				set	
				{
					demandName = value;
				}
			}

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public string InstanceChargeType
			{
				get
				{
					return instanceChargeType;
				}
				set	
				{
					instanceChargeType = value;
				}
			}

			public int? AvailableAmount
			{
				get
				{
					return availableAmount;
				}
				set	
				{
					availableAmount = value;
				}
			}

			public string EndTime
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

			public string StartTime
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

			public string PeriodUnit
			{
				get
				{
					return periodUnit;
				}
				set	
				{
					periodUnit = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public int? UsedAmount
			{
				get
				{
					return usedAmount;
				}
				set	
				{
					usedAmount = value;
				}
			}

			public int? TotalAmount
			{
				get
				{
					return totalAmount;
				}
				set	
				{
					totalAmount = value;
				}
			}

			public int? DeliveringAmount
			{
				get
				{
					return deliveringAmount;
				}
				set	
				{
					deliveringAmount = value;
				}
			}

			public string InstanceTypeFamily
			{
				get
				{
					return instanceTypeFamily;
				}
				set	
				{
					instanceTypeFamily = value;
				}
			}

			public string DemandStatus
			{
				get
				{
					return demandStatus;
				}
				set	
				{
					demandStatus = value;
				}
			}

			public List<DescribeDemands_SupplyInfo> SupplyInfos
			{
				get
				{
					return supplyInfos;
				}
				set	
				{
					supplyInfos = value;
				}
			}

			public class DescribeDemands_SupplyInfo
			{

				private int? amount;

				private string supplyStatus;

				private string supplyStartTime;

				private string supplyEndTime;

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string SupplyStatus
				{
					get
					{
						return supplyStatus;
					}
					set	
					{
						supplyStatus = value;
					}
				}

				public string SupplyStartTime
				{
					get
					{
						return supplyStartTime;
					}
					set	
					{
						supplyStartTime = value;
					}
				}

				public string SupplyEndTime
				{
					get
					{
						return supplyEndTime;
					}
					set	
					{
						supplyEndTime = value;
					}
				}
			}
		}
	}
}
