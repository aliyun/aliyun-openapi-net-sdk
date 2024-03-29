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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeFieldStatisticsResponse : AcsResponse
	{

		private string requestId;

		private DescribeFieldStatistics_GroupedFields groupedFields;

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

		public DescribeFieldStatistics_GroupedFields GroupedFields
		{
			get
			{
				return groupedFields;
			}
			set	
			{
				groupedFields = value;
			}
		}

		public class DescribeFieldStatistics_GroupedFields
		{

			private int? offlineInstanceCount;

			private int? regionCount;

			private int? newInstanceCount;

			private int? exposedInstanceCount;

			private int? groupCount;

			private int? tencentInstanceCount;

			private int? generalAssetCount;

			private int? instanceSyncTaskCount;

			private int? unprotectedInstanceCount;

			private int? importantAssetCount;

			private int? testAssetCount;

			private int? vpcCount;

			private int? instanceCount;

			private int? pauseInstanceCount;

			private int? idcInstanceCount;

			private int? notRunningStatusCount;

			private int? aliYunInstanceCount;

			private int? riskInstanceCount;

			private int? huaweiInstanceCount;

			private int? awsInstanceCount;

			private int? outMachineInstanceCount;

			public int? OfflineInstanceCount
			{
				get
				{
					return offlineInstanceCount;
				}
				set	
				{
					offlineInstanceCount = value;
				}
			}

			public int? RegionCount
			{
				get
				{
					return regionCount;
				}
				set	
				{
					regionCount = value;
				}
			}

			public int? NewInstanceCount
			{
				get
				{
					return newInstanceCount;
				}
				set	
				{
					newInstanceCount = value;
				}
			}

			public int? ExposedInstanceCount
			{
				get
				{
					return exposedInstanceCount;
				}
				set	
				{
					exposedInstanceCount = value;
				}
			}

			public int? GroupCount
			{
				get
				{
					return groupCount;
				}
				set	
				{
					groupCount = value;
				}
			}

			public int? TencentInstanceCount
			{
				get
				{
					return tencentInstanceCount;
				}
				set	
				{
					tencentInstanceCount = value;
				}
			}

			public int? GeneralAssetCount
			{
				get
				{
					return generalAssetCount;
				}
				set	
				{
					generalAssetCount = value;
				}
			}

			public int? InstanceSyncTaskCount
			{
				get
				{
					return instanceSyncTaskCount;
				}
				set	
				{
					instanceSyncTaskCount = value;
				}
			}

			public int? UnprotectedInstanceCount
			{
				get
				{
					return unprotectedInstanceCount;
				}
				set	
				{
					unprotectedInstanceCount = value;
				}
			}

			public int? ImportantAssetCount
			{
				get
				{
					return importantAssetCount;
				}
				set	
				{
					importantAssetCount = value;
				}
			}

			public int? TestAssetCount
			{
				get
				{
					return testAssetCount;
				}
				set	
				{
					testAssetCount = value;
				}
			}

			public int? VpcCount
			{
				get
				{
					return vpcCount;
				}
				set	
				{
					vpcCount = value;
				}
			}

			public int? InstanceCount
			{
				get
				{
					return instanceCount;
				}
				set	
				{
					instanceCount = value;
				}
			}

			public int? PauseInstanceCount
			{
				get
				{
					return pauseInstanceCount;
				}
				set	
				{
					pauseInstanceCount = value;
				}
			}

			public int? IdcInstanceCount
			{
				get
				{
					return idcInstanceCount;
				}
				set	
				{
					idcInstanceCount = value;
				}
			}

			public int? NotRunningStatusCount
			{
				get
				{
					return notRunningStatusCount;
				}
				set	
				{
					notRunningStatusCount = value;
				}
			}

			public int? AliYunInstanceCount
			{
				get
				{
					return aliYunInstanceCount;
				}
				set	
				{
					aliYunInstanceCount = value;
				}
			}

			public int? RiskInstanceCount
			{
				get
				{
					return riskInstanceCount;
				}
				set	
				{
					riskInstanceCount = value;
				}
			}

			public int? HuaweiInstanceCount
			{
				get
				{
					return huaweiInstanceCount;
				}
				set	
				{
					huaweiInstanceCount = value;
				}
			}

			public int? AwsInstanceCount
			{
				get
				{
					return awsInstanceCount;
				}
				set	
				{
					awsInstanceCount = value;
				}
			}

			public int? OutMachineInstanceCount
			{
				get
				{
					return outMachineInstanceCount;
				}
				set	
				{
					outMachineInstanceCount = value;
				}
			}
		}
	}
}
