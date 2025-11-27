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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeInstanceForIsvResponse : AcsResponse
	{

		private string status;

		private string productName;

		private long? instanceId;

		private string extendJson;

		private bool? isTrial;

		private long? beganOn;

		private string componentJson;

		private string productType;

		private string productSkuCode;

		private long? createdOn;

		private long? endOn;

		private long? orderId;

		private string productCode;

		private string supplierName;

		private string requestId;

		private DescribeInstanceForIsv_RelationalData relationalData;

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

		[JsonProperty(PropertyName = "ProductName")]
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

		[JsonProperty(PropertyName = "InstanceId")]
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

		[JsonProperty(PropertyName = "ExtendJson")]
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

		[JsonProperty(PropertyName = "IsTrial")]
		public bool? IsTrial
		{
			get
			{
				return isTrial;
			}
			set	
			{
				isTrial = value;
			}
		}

		[JsonProperty(PropertyName = "BeganOn")]
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

		[JsonProperty(PropertyName = "ComponentJson")]
		public string ComponentJson
		{
			get
			{
				return componentJson;
			}
			set	
			{
				componentJson = value;
			}
		}

		[JsonProperty(PropertyName = "ProductType")]
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

		[JsonProperty(PropertyName = "ProductSkuCode")]
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

		[JsonProperty(PropertyName = "CreatedOn")]
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

		[JsonProperty(PropertyName = "EndOn")]
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

		[JsonProperty(PropertyName = "OrderId")]
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

		[JsonProperty(PropertyName = "ProductCode")]
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

		[JsonProperty(PropertyName = "SupplierName")]
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

		[JsonProperty(PropertyName = "RelationalData")]
		public DescribeInstanceForIsv_RelationalData RelationalData
		{
			get
			{
				return relationalData;
			}
			set	
			{
				relationalData = value;
			}
		}

		public class DescribeInstanceForIsv_RelationalData
		{

			private string serviceStatus;

			[JsonProperty(PropertyName = "ServiceStatus")]
			public string ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
				}
			}
		}
	}
}
