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
	public class DescribeClusterServiceConfigHistoryResponse : AcsResponse
	{

		private string requestId;

		private DescribeClusterServiceConfigHistory_Config config;

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

		public DescribeClusterServiceConfigHistory_Config Config
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

		public class DescribeClusterServiceConfigHistory_Config
		{

			private string serviceName;

			private string configVersion;

			private bool? applied;

			private string createTime;

			private string author;

			private string comment;

			private List<DescribeClusterServiceConfigHistory_ConfigValue> configValueList;

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

			public bool? Applied
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

			public List<DescribeClusterServiceConfigHistory_ConfigValue> ConfigValueList
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

			public class DescribeClusterServiceConfigHistory_ConfigValue
			{

				private string configName;

				private List<DescribeClusterServiceConfigHistory_ConfigItemValue> configItemValueList;

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

				public List<DescribeClusterServiceConfigHistory_ConfigItemValue> ConfigItemValueList
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

				public class DescribeClusterServiceConfigHistory_ConfigItemValue
				{

					private string itemName;

					private string _value;

					private string oldValue;

					private string changeType;

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

					public string OldValue
					{
						get
						{
							return oldValue;
						}
						set	
						{
							oldValue = value;
						}
					}

					public string ChangeType
					{
						get
						{
							return changeType;
						}
						set	
						{
							changeType = value;
						}
					}
				}
			}
		}
	}
}
