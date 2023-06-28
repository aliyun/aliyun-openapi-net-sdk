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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryResourcePackageInstancesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageSize;

		private int? total;

		private int? page;

		private QueryResourcePackageInstances_Data data;

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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "Total")]
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

		[JsonProperty(PropertyName = "Page")]
		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public QueryResourcePackageInstances_Data Data
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

		public class QueryResourcePackageInstances_Data
		{

			private string pageNum;

			private string pageSize;

			private string totalCount;

			private string hostId;

			private List<QueryResourcePackageInstances_Instance> instances;

			[JsonProperty(PropertyName = "PageNum")]
			public string PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
			public string PageSize
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

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "HostId")]
			public string HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
				}
			}

			[JsonProperty(PropertyName = "Instances")]
			public List<QueryResourcePackageInstances_Instance> Instances
			{
				get
				{
					return instances;
				}
				set	
				{
					instances = value;
				}
			}

			public class QueryResourcePackageInstances_Instance
			{

				private string expiryTime;

				private string status;

				private string remark;

				private string remainingAmountUnit;

				private string instanceId;

				private string packageType;

				private string effectiveTime;

				private string region;

				private string totalAmount;

				private string deductType;

				private string totalAmountUnit;

				private string remainingAmount;

				private string commodityCode;

				private List<string> applicableProducts;

				[JsonProperty(PropertyName = "ExpiryTime")]
				public string ExpiryTime
				{
					get
					{
						return expiryTime;
					}
					set	
					{
						expiryTime = value;
					}
				}

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "Remark")]
				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmountUnit")]
				public string RemainingAmountUnit
				{
					get
					{
						return remainingAmountUnit;
					}
					set	
					{
						remainingAmountUnit = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceId")]
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

				[JsonProperty(PropertyName = "PackageType")]
				public string PackageType
				{
					get
					{
						return packageType;
					}
					set	
					{
						packageType = value;
					}
				}

				[JsonProperty(PropertyName = "EffectiveTime")]
				public string EffectiveTime
				{
					get
					{
						return effectiveTime;
					}
					set	
					{
						effectiveTime = value;
					}
				}

				[JsonProperty(PropertyName = "Region")]
				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				[JsonProperty(PropertyName = "TotalAmount")]
				public string TotalAmount
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

				[JsonProperty(PropertyName = "DeductType")]
				public string DeductType
				{
					get
					{
						return deductType;
					}
					set	
					{
						deductType = value;
					}
				}

				[JsonProperty(PropertyName = "TotalAmountUnit")]
				public string TotalAmountUnit
				{
					get
					{
						return totalAmountUnit;
					}
					set	
					{
						totalAmountUnit = value;
					}
				}

				[JsonProperty(PropertyName = "RemainingAmount")]
				public string RemainingAmount
				{
					get
					{
						return remainingAmount;
					}
					set	
					{
						remainingAmount = value;
					}
				}

				[JsonProperty(PropertyName = "CommodityCode")]
				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				[JsonProperty(PropertyName = "ApplicableProducts")]
				public List<string> ApplicableProducts
				{
					get
					{
						return applicableProducts;
					}
					set	
					{
						applicableProducts = value;
					}
				}
			}
		}
	}
}
