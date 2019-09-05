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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeInstances_InstanceItem> instanceItems;

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

		public List<DescribeInstances_InstanceItem> InstanceItems
		{
			get
			{
				return instanceItems;
			}
			set	
			{
				instanceItems = value;
			}
		}

		public class DescribeInstances_InstanceItem
		{

			private long? instanceId;

			private long? orderId;

			private string supplierName;

			private string productCode;

			private string productSkuCode;

			private string productName;

			private string productType;

			private string status;

			private long? beganOn;

			private long? endOn;

			private long? createdOn;

			private string extendJson;

			private string hostJson;

			private string appJson;

			private string apiJson;

			private string imageJson;

			private string idaasJson;

			public long? InstanceId
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

			public long? OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string ProductSkuCode
			{
				get
				{
					return productSkuCode;
				}
				set	
				{
					productSkuCode = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string ProductType
			{
				get
				{
					return productType;
				}
				set	
				{
					productType = value;
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

			public long? BeganOn
			{
				get
				{
					return beganOn;
				}
				set	
				{
					beganOn = value;
				}
			}

			public long? EndOn
			{
				get
				{
					return endOn;
				}
				set	
				{
					endOn = value;
				}
			}

			public long? CreatedOn
			{
				get
				{
					return createdOn;
				}
				set	
				{
					createdOn = value;
				}
			}

			public string ExtendJson
			{
				get
				{
					return extendJson;
				}
				set	
				{
					extendJson = value;
				}
			}

			public string HostJson
			{
				get
				{
					return hostJson;
				}
				set	
				{
					hostJson = value;
				}
			}

			public string AppJson
			{
				get
				{
					return appJson;
				}
				set	
				{
					appJson = value;
				}
			}

			public string ApiJson
			{
				get
				{
					return apiJson;
				}
				set	
				{
					apiJson = value;
				}
			}

			public string ImageJson
			{
				get
				{
					return imageJson;
				}
				set	
				{
					imageJson = value;
				}
			}

			public string IdaasJson
			{
				get
				{
					return idaasJson;
				}
				set	
				{
					idaasJson = value;
				}
			}
		}
	}
}
