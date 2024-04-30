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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeCustinsResourceInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCustinsResourceInfo_DataItem> data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public List<DescribeCustinsResourceInfo_DataItem> Data
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

		public class DescribeCustinsResourceInfo_DataItem
		{

			private string maxIopsIncreaseRatio;

			private string maxConnIncreaseRatioValue;

			private string memoryAdjustDeadline;

			private string memAdjustableMaxValue;

			private string iopsAdjustableMaxValue;

			private string cpuIncreaseRatio;

			private string maxIopsIncreaseRatioValue;

			private string originMaxConn;

			private string memoryIncreaseRatioValue;

			private string maxConnIncreaseRatio;

			private string cpuIncreaseRatioValue;

			private string originMaxIops;

			private string maxConnAdjustableMaxValue;

			private string maxConnAdjustDeadline;

			private string maxIopsAdjustDeadline;

			private string originMemory;

			private string memAdjustableMaxRatio;

			private string cpuAdjustableMaxValue;

			private string cpuAdjustableMaxRatio;

			private string cpuAdjustDeadline;

			private string memoryIncreaseRatio;

			private string originCpu;

			private string dBInstanceId;

			[JsonProperty(PropertyName = "MaxIopsIncreaseRatio")]
			public string MaxIopsIncreaseRatio
			{
				get
				{
					return maxIopsIncreaseRatio;
				}
				set	
				{
					maxIopsIncreaseRatio = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnIncreaseRatioValue")]
			public string MaxConnIncreaseRatioValue
			{
				get
				{
					return maxConnIncreaseRatioValue;
				}
				set	
				{
					maxConnIncreaseRatioValue = value;
				}
			}

			[JsonProperty(PropertyName = "MemoryAdjustDeadline")]
			public string MemoryAdjustDeadline
			{
				get
				{
					return memoryAdjustDeadline;
				}
				set	
				{
					memoryAdjustDeadline = value;
				}
			}

			[JsonProperty(PropertyName = "MemAdjustableMaxValue")]
			public string MemAdjustableMaxValue
			{
				get
				{
					return memAdjustableMaxValue;
				}
				set	
				{
					memAdjustableMaxValue = value;
				}
			}

			[JsonProperty(PropertyName = "IopsAdjustableMaxValue")]
			public string IopsAdjustableMaxValue
			{
				get
				{
					return iopsAdjustableMaxValue;
				}
				set	
				{
					iopsAdjustableMaxValue = value;
				}
			}

			[JsonProperty(PropertyName = "CpuIncreaseRatio")]
			public string CpuIncreaseRatio
			{
				get
				{
					return cpuIncreaseRatio;
				}
				set	
				{
					cpuIncreaseRatio = value;
				}
			}

			[JsonProperty(PropertyName = "MaxIopsIncreaseRatioValue")]
			public string MaxIopsIncreaseRatioValue
			{
				get
				{
					return maxIopsIncreaseRatioValue;
				}
				set	
				{
					maxIopsIncreaseRatioValue = value;
				}
			}

			[JsonProperty(PropertyName = "OriginMaxConn")]
			public string OriginMaxConn
			{
				get
				{
					return originMaxConn;
				}
				set	
				{
					originMaxConn = value;
				}
			}

			[JsonProperty(PropertyName = "MemoryIncreaseRatioValue")]
			public string MemoryIncreaseRatioValue
			{
				get
				{
					return memoryIncreaseRatioValue;
				}
				set	
				{
					memoryIncreaseRatioValue = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnIncreaseRatio")]
			public string MaxConnIncreaseRatio
			{
				get
				{
					return maxConnIncreaseRatio;
				}
				set	
				{
					maxConnIncreaseRatio = value;
				}
			}

			[JsonProperty(PropertyName = "CpuIncreaseRatioValue")]
			public string CpuIncreaseRatioValue
			{
				get
				{
					return cpuIncreaseRatioValue;
				}
				set	
				{
					cpuIncreaseRatioValue = value;
				}
			}

			[JsonProperty(PropertyName = "OriginMaxIops")]
			public string OriginMaxIops
			{
				get
				{
					return originMaxIops;
				}
				set	
				{
					originMaxIops = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnAdjustableMaxValue")]
			public string MaxConnAdjustableMaxValue
			{
				get
				{
					return maxConnAdjustableMaxValue;
				}
				set	
				{
					maxConnAdjustableMaxValue = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConnAdjustDeadline")]
			public string MaxConnAdjustDeadline
			{
				get
				{
					return maxConnAdjustDeadline;
				}
				set	
				{
					maxConnAdjustDeadline = value;
				}
			}

			[JsonProperty(PropertyName = "MaxIopsAdjustDeadline")]
			public string MaxIopsAdjustDeadline
			{
				get
				{
					return maxIopsAdjustDeadline;
				}
				set	
				{
					maxIopsAdjustDeadline = value;
				}
			}

			[JsonProperty(PropertyName = "OriginMemory")]
			public string OriginMemory
			{
				get
				{
					return originMemory;
				}
				set	
				{
					originMemory = value;
				}
			}

			[JsonProperty(PropertyName = "MemAdjustableMaxRatio")]
			public string MemAdjustableMaxRatio
			{
				get
				{
					return memAdjustableMaxRatio;
				}
				set	
				{
					memAdjustableMaxRatio = value;
				}
			}

			[JsonProperty(PropertyName = "CpuAdjustableMaxValue")]
			public string CpuAdjustableMaxValue
			{
				get
				{
					return cpuAdjustableMaxValue;
				}
				set	
				{
					cpuAdjustableMaxValue = value;
				}
			}

			[JsonProperty(PropertyName = "CpuAdjustableMaxRatio")]
			public string CpuAdjustableMaxRatio
			{
				get
				{
					return cpuAdjustableMaxRatio;
				}
				set	
				{
					cpuAdjustableMaxRatio = value;
				}
			}

			[JsonProperty(PropertyName = "CpuAdjustDeadline")]
			public string CpuAdjustDeadline
			{
				get
				{
					return cpuAdjustDeadline;
				}
				set	
				{
					cpuAdjustDeadline = value;
				}
			}

			[JsonProperty(PropertyName = "MemoryIncreaseRatio")]
			public string MemoryIncreaseRatio
			{
				get
				{
					return memoryIncreaseRatio;
				}
				set	
				{
					memoryIncreaseRatio = value;
				}
			}

			[JsonProperty(PropertyName = "OriginCpu")]
			public string OriginCpu
			{
				get
				{
					return originCpu;
				}
				set	
				{
					originCpu = value;
				}
			}

			[JsonProperty(PropertyName = "DBInstanceId")]
			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}
		}
	}
}
