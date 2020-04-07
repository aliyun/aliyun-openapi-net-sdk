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
	public class DescribeInstanceResponse : AcsResponse
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

		private string componentJson;

		private string constraints;

		private bool? isTrial;

		private List<DescribeInstance_Module> modules;

		private DescribeInstance_RelationalData relationalData;

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

			private string id;

			private string name;

			private string code;

			private List<DescribeInstance_Property> properties;

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

				private string name;

				private string key;

				private string showType;

				private string displayUnit;

				private List<DescribeInstance_PropertyValue> propertyValues;

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

					private string _value;

					private string displayName;

					private string type;

					private string min;

					private string max;

					private string step;

					private string remark;

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
				}
			}
		}

		public class DescribeInstance_RelationalData
		{

			private string serviceStatus;

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
