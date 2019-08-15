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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryResourcePackageInstancesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? page;

		private int? pageSize;

		private int? total;

		private QueryResourcePackageInstances_Data data;

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

			private string hostId;

			private string pageNum;

			private string pageSize;

			private string totalCount;

			private List<QueryResourcePackageInstances_Instance> instances;

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

				private string instanceId;

				private string region;

				private string totalAmount;

				private string totalAmountUnit;

				private string remainingAmount;

				private string remainingAmountUnit;

				private string effectiveTime;

				private string expiryTime;

				private string remark;

				private string packageType;

				private string status;

				private string deductType;

				private List<string> applicableProducts;

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
