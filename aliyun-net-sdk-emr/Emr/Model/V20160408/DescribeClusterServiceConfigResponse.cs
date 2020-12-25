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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeClusterServiceConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeClusterServiceConfig_Config config;

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

		public DescribeClusterServiceConfig_Config Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
			}
		}

		public class DescribeClusterServiceConfig_Config
		{

			private string serviceName;

			private string configVersion;

			private string applied;

			private string createTime;

			private string author;

			private string comment;

			private List<DescribeClusterServiceConfig_ConfigValue> configValueList;

			private List<DescribeClusterServiceConfig_PropertyInfo> propertyInfoList;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ConfigVersion
			{
				get
				{
					return configVersion;
				}
				set	
				{
					configVersion = value;
				}
			}

			public string Applied
			{
				get
				{
					return applied;
				}
				set	
				{
					applied = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string Author
			{
				get
				{
					return author;
				}
				set	
				{
					author = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public List<DescribeClusterServiceConfig_ConfigValue> ConfigValueList
			{
				get
				{
					return configValueList;
				}
				set	
				{
					configValueList = value;
				}
			}

			public List<DescribeClusterServiceConfig_PropertyInfo> PropertyInfoList
			{
				get
				{
					return propertyInfoList;
				}
				set	
				{
					propertyInfoList = value;
				}
			}

			public class DescribeClusterServiceConfig_ConfigValue
			{

				private string configName;

				private bool? allowCustom;

				private string scope;

				private long? scopeId;

				private List<DescribeClusterServiceConfig_ConfigItemValue> configItemValueList;

				public string ConfigName
				{
					get
					{
						return configName;
					}
					set	
					{
						configName = value;
					}
				}

				public bool? AllowCustom
				{
					get
					{
						return allowCustom;
					}
					set	
					{
						allowCustom = value;
					}
				}

				public string Scope
				{
					get
					{
						return scope;
					}
					set	
					{
						scope = value;
					}
				}

				public long? ScopeId
				{
					get
					{
						return scopeId;
					}
					set	
					{
						scopeId = value;
					}
				}

				public List<DescribeClusterServiceConfig_ConfigItemValue> ConfigItemValueList
				{
					get
					{
						return configItemValueList;
					}
					set	
					{
						configItemValueList = value;
					}
				}

				public class DescribeClusterServiceConfig_ConfigItemValue
				{

					private string itemName;

					private string _value;

					private bool? isCustom;

					private string description;

					public string ItemName
					{
						get
						{
							return itemName;
						}
						set	
						{
							itemName = value;
						}
					}

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

					public bool? IsCustom
					{
						get
						{
							return isCustom;
						}
						set	
						{
							isCustom = value;
						}
					}

					public string Description
					{
						get
						{
							return description;
						}
						set	
						{
							description = value;
						}
					}
				}
			}

			public class DescribeClusterServiceConfig_PropertyInfo
			{

				private string name;

				private string _value;

				private string description;

				private string fileName;

				private string displayName;

				private string serviceName;

				private string component;

				private List<string> propertyTypes;

				private DescribeClusterServiceConfig_PropertyValueAttributes propertyValueAttributes;

				private DescribeClusterServiceConfig_EffectWay effectWay;

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

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
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

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string Component
				{
					get
					{
						return component;
					}
					set	
					{
						component = value;
					}
				}

				public List<string> PropertyTypes
				{
					get
					{
						return propertyTypes;
					}
					set	
					{
						propertyTypes = value;
					}
				}

				public DescribeClusterServiceConfig_PropertyValueAttributes PropertyValueAttributes
				{
					get
					{
						return propertyValueAttributes;
					}
					set	
					{
						propertyValueAttributes = value;
					}
				}

				public DescribeClusterServiceConfig_EffectWay EffectWay
				{
					get
					{
						return effectWay;
					}
					set	
					{
						effectWay = value;
					}
				}

				public class DescribeClusterServiceConfig_PropertyValueAttributes
				{

					private string type;

					private string maximum;

					private string mimimum;

					private string unit;

					private bool? _readOnly;

					private bool? hidden;

					private string incrememtStep;

					private List<DescribeClusterServiceConfig_ValueEntryInfo> entries;

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

					public string Maximum
					{
						get
						{
							return maximum;
						}
						set	
						{
							maximum = value;
						}
					}

					public string Mimimum
					{
						get
						{
							return mimimum;
						}
						set	
						{
							mimimum = value;
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

					public bool? _ReadOnly
					{
						get
						{
							return _readOnly;
						}
						set	
						{
							_readOnly = value;
						}
					}

					public bool? Hidden
					{
						get
						{
							return hidden;
						}
						set	
						{
							hidden = value;
						}
					}

					public string IncrememtStep
					{
						get
						{
							return incrememtStep;
						}
						set	
						{
							incrememtStep = value;
						}
					}

					public List<DescribeClusterServiceConfig_ValueEntryInfo> Entries
					{
						get
						{
							return entries;
						}
						set	
						{
							entries = value;
						}
					}

					public class DescribeClusterServiceConfig_ValueEntryInfo
					{

						private string _value;

						private string label;

						private string description;

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string Description
						{
							get
							{
								return description;
							}
							set	
							{
								description = value;
							}
						}
					}
				}

				public class DescribeClusterServiceConfig_EffectWay
				{

					private string effectType;

					private string invokeServiceName;

					public string EffectType
					{
						get
						{
							return effectType;
						}
						set	
						{
							effectType = value;
						}
					}

					public string InvokeServiceName
					{
						get
						{
							return invokeServiceName;
						}
						set	
						{
							invokeServiceName = value;
						}
					}
				}
			}
		}
	}
}
