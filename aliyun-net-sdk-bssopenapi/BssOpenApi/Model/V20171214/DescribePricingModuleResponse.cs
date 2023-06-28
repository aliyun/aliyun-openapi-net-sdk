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
	public class DescribePricingModuleResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private DescribePricingModule_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public DescribePricingModule_Data Data
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

		public class DescribePricingModule_Data
		{

			private List<DescribePricingModule_Module> moduleList;

			private List<DescribePricingModule_Attribute> attributeList;

			[JsonProperty(PropertyName = "ModuleList")]
			public List<DescribePricingModule_Module> ModuleList
			{
				get
				{
					return moduleList;
				}
				set	
				{
					moduleList = value;
				}
			}

			[JsonProperty(PropertyName = "AttributeList")]
			public List<DescribePricingModule_Attribute> AttributeList
			{
				get
				{
					return attributeList;
				}
				set	
				{
					attributeList = value;
				}
			}

			public class DescribePricingModule_Module
			{

				private string moduleName;

				private string priceType;

				private string currency;

				private string moduleCode;

				private List<string> configList;

				[JsonProperty(PropertyName = "ModuleName")]
				public string ModuleName
				{
					get
					{
						return moduleName;
					}
					set	
					{
						moduleName = value;
					}
				}

				[JsonProperty(PropertyName = "PriceType")]
				public string PriceType
				{
					get
					{
						return priceType;
					}
					set	
					{
						priceType = value;
					}
				}

				[JsonProperty(PropertyName = "Currency")]
				public string Currency
				{
					get
					{
						return currency;
					}
					set	
					{
						currency = value;
					}
				}

				[JsonProperty(PropertyName = "ModuleCode")]
				public string ModuleCode
				{
					get
					{
						return moduleCode;
					}
					set	
					{
						moduleCode = value;
					}
				}

				[JsonProperty(PropertyName = "ConfigList")]
				public List<string> ConfigList
				{
					get
					{
						return configList;
					}
					set	
					{
						configList = value;
					}
				}
			}

			public class DescribePricingModule_Attribute
			{

				private string code;

				private string name;

				private string unit;

				private List<DescribePricingModule_AttributeValue> values;

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

				[JsonProperty(PropertyName = "Unit")]
				public string Unit
				{
					get
					{
						return unit;
					}
					set	
					{
						unit = value;
					}
				}

				[JsonProperty(PropertyName = "Values")]
				public List<DescribePricingModule_AttributeValue> Values
				{
					get
					{
						return values;
					}
					set	
					{
						values = value;
					}
				}

				public class DescribePricingModule_AttributeValue
				{

					private string type;

					private string _value;

					private string remark;

					private string name;

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
				}
			}
		}
	}
}
