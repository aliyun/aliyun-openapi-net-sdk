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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBProxyResponse : AcsResponse
	{

		private string dBProxyInstanceLatestMinorVersion;

		private string requestId;

		private string dBProxyInstanceCurrentMinorVersion;

		private int? dBProxyInstanceNum;

		private string dBProxyInstanceType;

		private string dBProxyPersistentConnectionStatus;

		private string dBProxyInstanceStatus;

		private string dBProxyServiceStatus;

		private string dBProxyInstanceName;

		private string dBProxyInstanceSize;

		private string dBProxyEngineType;

		private string accountName;

		private string resourceGroupId;

		private List<DescribeDBProxy_DBProxyConnectStringItemsItem> dBProxyConnectStringItems;

		private List<DescribeDBProxy_DbProxyEndpointItemsItem> dbProxyEndpointItems;

		private List<string> dBProxyAVZones;

		[JsonProperty(PropertyName = "DBProxyInstanceLatestMinorVersion")]
		public string DBProxyInstanceLatestMinorVersion
		{
			get
			{
				return dBProxyInstanceLatestMinorVersion;
			}
			set	
			{
				dBProxyInstanceLatestMinorVersion = value;
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

		[JsonProperty(PropertyName = "DBProxyInstanceCurrentMinorVersion")]
		public string DBProxyInstanceCurrentMinorVersion
		{
			get
			{
				return dBProxyInstanceCurrentMinorVersion;
			}
			set	
			{
				dBProxyInstanceCurrentMinorVersion = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyInstanceNum")]
		public int? DBProxyInstanceNum
		{
			get
			{
				return dBProxyInstanceNum;
			}
			set	
			{
				dBProxyInstanceNum = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyInstanceType")]
		public string DBProxyInstanceType
		{
			get
			{
				return dBProxyInstanceType;
			}
			set	
			{
				dBProxyInstanceType = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyPersistentConnectionStatus")]
		public string DBProxyPersistentConnectionStatus
		{
			get
			{
				return dBProxyPersistentConnectionStatus;
			}
			set	
			{
				dBProxyPersistentConnectionStatus = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyInstanceStatus")]
		public string DBProxyInstanceStatus
		{
			get
			{
				return dBProxyInstanceStatus;
			}
			set	
			{
				dBProxyInstanceStatus = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyServiceStatus")]
		public string DBProxyServiceStatus
		{
			get
			{
				return dBProxyServiceStatus;
			}
			set	
			{
				dBProxyServiceStatus = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyInstanceName")]
		public string DBProxyInstanceName
		{
			get
			{
				return dBProxyInstanceName;
			}
			set	
			{
				dBProxyInstanceName = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyInstanceSize")]
		public string DBProxyInstanceSize
		{
			get
			{
				return dBProxyInstanceSize;
			}
			set	
			{
				dBProxyInstanceSize = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyEngineType")]
		public string DBProxyEngineType
		{
			get
			{
				return dBProxyEngineType;
			}
			set	
			{
				dBProxyEngineType = value;
			}
		}

		[JsonProperty(PropertyName = "AccountName")]
		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
			}
		}

		[JsonProperty(PropertyName = "ResourceGroupId")]
		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyConnectStringItems")]
		public List<DescribeDBProxy_DBProxyConnectStringItemsItem> DBProxyConnectStringItems
		{
			get
			{
				return dBProxyConnectStringItems;
			}
			set	
			{
				dBProxyConnectStringItems = value;
			}
		}

		[JsonProperty(PropertyName = "DbProxyEndpointItems")]
		public List<DescribeDBProxy_DbProxyEndpointItemsItem> DbProxyEndpointItems
		{
			get
			{
				return dbProxyEndpointItems;
			}
			set	
			{
				dbProxyEndpointItems = value;
			}
		}

		[JsonProperty(PropertyName = "DBProxyAVZones")]
		public List<string> DBProxyAVZones
		{
			get
			{
				return dBProxyAVZones;
			}
			set	
			{
				dBProxyAVZones = value;
			}
		}

		public class DescribeDBProxy_DBProxyConnectStringItemsItem
		{

			private string dBProxyConnectStringNetWorkType;

			private string dBProxyConnectStringNetType;

			private string dBProxyVpcInstanceId;

			private string dBProxyEndpointName;

			private string dBProxyEndpointId;

			private string dBProxyConnectStringPort;

			private string dBProxyConnectString;

			private string dBProxyVpcId;

			private string dBProxyVswitchId;

			[JsonProperty(PropertyName = "DBProxyConnectStringNetWorkType")]
			public string DBProxyConnectStringNetWorkType
			{
				get
				{
					return dBProxyConnectStringNetWorkType;
				}
				set	
				{
					dBProxyConnectStringNetWorkType = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyConnectStringNetType")]
			public string DBProxyConnectStringNetType
			{
				get
				{
					return dBProxyConnectStringNetType;
				}
				set	
				{
					dBProxyConnectStringNetType = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyVpcInstanceId")]
			public string DBProxyVpcInstanceId
			{
				get
				{
					return dBProxyVpcInstanceId;
				}
				set	
				{
					dBProxyVpcInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyEndpointName")]
			public string DBProxyEndpointName
			{
				get
				{
					return dBProxyEndpointName;
				}
				set	
				{
					dBProxyEndpointName = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyEndpointId")]
			public string DBProxyEndpointId
			{
				get
				{
					return dBProxyEndpointId;
				}
				set	
				{
					dBProxyEndpointId = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyConnectStringPort")]
			public string DBProxyConnectStringPort
			{
				get
				{
					return dBProxyConnectStringPort;
				}
				set	
				{
					dBProxyConnectStringPort = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyConnectString")]
			public string DBProxyConnectString
			{
				get
				{
					return dBProxyConnectString;
				}
				set	
				{
					dBProxyConnectString = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyVpcId")]
			public string DBProxyVpcId
			{
				get
				{
					return dBProxyVpcId;
				}
				set	
				{
					dBProxyVpcId = value;
				}
			}

			[JsonProperty(PropertyName = "DBProxyVswitchId")]
			public string DBProxyVswitchId
			{
				get
				{
					return dBProxyVswitchId;
				}
				set	
				{
					dBProxyVswitchId = value;
				}
			}
		}

		public class DescribeDBProxy_DbProxyEndpointItemsItem
		{

			private string dbProxyEndpointAliases;

			private string dbProxyEndpointName;

			private string dbProxyEndpointType;

			private string dbProxyReadWriteMode;

			[JsonProperty(PropertyName = "DbProxyEndpointAliases")]
			public string DbProxyEndpointAliases
			{
				get
				{
					return dbProxyEndpointAliases;
				}
				set	
				{
					dbProxyEndpointAliases = value;
				}
			}

			[JsonProperty(PropertyName = "DbProxyEndpointName")]
			public string DbProxyEndpointName
			{
				get
				{
					return dbProxyEndpointName;
				}
				set	
				{
					dbProxyEndpointName = value;
				}
			}

			[JsonProperty(PropertyName = "DbProxyEndpointType")]
			public string DbProxyEndpointType
			{
				get
				{
					return dbProxyEndpointType;
				}
				set	
				{
					dbProxyEndpointType = value;
				}
			}

			[JsonProperty(PropertyName = "DbProxyReadWriteMode")]
			public string DbProxyReadWriteMode
			{
				get
				{
					return dbProxyReadWriteMode;
				}
				set	
				{
					dbProxyReadWriteMode = value;
				}
			}
		}
	}
}
