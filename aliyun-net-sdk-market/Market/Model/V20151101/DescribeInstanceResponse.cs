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
	public class DescribeInstanceResponse : AcsResponse
	{

		private string status;

		private string appJson;

		private string productName;

		private long? instanceId;

		private string extendJson;

		private bool? isTrial;

		private long? beganOn;

		private string componentJson;

		private string constraints;

		private string productType;

		private string hostJson;

		private string productSkuCode;

		private long? createdOn;

		private long? endOn;

		private long? orderId;

		private string productCode;

		private string supplierName;

		private string autoRenewal;

		private string activeAddress;

		private string licenseCode;

		private List<DescribeInstance_Module> modules;

		private DescribeInstance_RelationalData relationalData;

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

		[JsonProperty(PropertyName = "AppJson")]
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

		[JsonProperty(PropertyName = "Constraints")]
		public string Constraints
		{
			get
			{
				return constraints;
			}
			set	
			{
				constraints = value;
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

		[JsonProperty(PropertyName = "HostJson")]
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

		[JsonProperty(PropertyName = "AutoRenewal")]
		public string AutoRenewal
		{
			get
			{
				return autoRenewal;
			}
			set	
			{
				autoRenewal = value;
			}
		}

		[JsonProperty(PropertyName = "ActiveAddress")]
		public string ActiveAddress
		{
			get
			{
				return activeAddress;
			}
			set	
			{
				activeAddress = value;
			}
		}

		[JsonProperty(PropertyName = "LicenseCode")]
		public string LicenseCode
		{
			get
			{
				return licenseCode;
			}
			set	
			{
				licenseCode = value;
			}
		}

		[JsonProperty(PropertyName = "Modules")]
		public List<DescribeInstance_Module> Modules
		{
			get
			{
				return modules;
			}
			set	
			{
				modules = value;
			}
		}

		[JsonProperty(PropertyName = "RelationalData")]
		public DescribeInstance_RelationalData RelationalData
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

		public class DescribeInstance_Module
		{

			private string code;

			private string name;

			private string id;

			private List<DescribeInstance_Property> properties;

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

			[JsonProperty(PropertyName = "Name")]
			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			[JsonProperty(PropertyName = "Id")]
			public string Id
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

			[JsonProperty(PropertyName = "Properties")]
			public List<DescribeInstance_Property> Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}

			public class DescribeInstance_Property
			{

				private string key;

				private string showType;

				private string name;

				private string displayUnit;

				private List<DescribeInstance_PropertyValue> propertyValues;

				[JsonProperty(PropertyName = "Key")]
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

				[JsonProperty(PropertyName = "ShowType")]
				public string ShowType
				{
					get
					{
						return showType;
					}
					set	
					{
						showType = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "DisplayUnit")]
				public string DisplayUnit
				{
					get
					{
						return displayUnit;
					}
					set	
					{
						displayUnit = value;
					}
				}

				[JsonProperty(PropertyName = "PropertyValues")]
				public List<DescribeInstance_PropertyValue> PropertyValues
				{
					get
					{
						return propertyValues;
					}
					set	
					{
						propertyValues = value;
					}
				}

				public class DescribeInstance_PropertyValue
				{

					private string displayName;

					private string type;

					private string step;

					private string _value;

					private string max;

					private string remark;

					private string min;

					[JsonProperty(PropertyName = "DisplayName")]
					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
						}
					}

					[JsonProperty(PropertyName = "Type")]
					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}

					[JsonProperty(PropertyName = "Step")]
					public string Step
					{
						get
						{
							return step;
						}
						set	
						{
							step = value;
						}
					}

					[JsonProperty(PropertyName = "_Value")]
					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}

					[JsonProperty(PropertyName = "Max")]
					public string Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
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

					[JsonProperty(PropertyName = "Min")]
					public string Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}
				}
			}
		}

		public class DescribeInstance_RelationalData
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
