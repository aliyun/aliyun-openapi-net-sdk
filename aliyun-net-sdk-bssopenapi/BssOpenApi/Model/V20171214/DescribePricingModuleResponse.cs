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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class DescribePricingModuleResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private DescribePricingModule_Data data;

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

				private string moduleCode;

				private string moduleName;

				private string priceType;

				private string currency;

				private List<string> configList;

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
			}
		}
	}
}