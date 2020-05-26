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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeModuleConfigResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? count;

		private int? httpStatusCode;

		private List<DescribeModuleConfig_ModuleConfig> moduleConfigList;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public List<DescribeModuleConfig_ModuleConfig> ModuleConfigList
		{
			get
			{
				return moduleConfigList;
			}
			set	
			{
				moduleConfigList = value;
			}
		}

		public class DescribeModuleConfig_ModuleConfig
		{

			private string configName;

			private string moduleName;

			private List<DescribeModuleConfig_Item> items;

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

			public List<DescribeModuleConfig_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class DescribeModuleConfig_Item
			{

				private string instanceId;

				private string instanceName;

				private int? groupId;

				private string ip;

				private string region;

				private string uuid;

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

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public int? GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
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

				public string Uuid
				{
					get
					{
						return uuid;
					}
					set	
					{
						uuid = value;
					}
				}
			}
		}
	}
}
