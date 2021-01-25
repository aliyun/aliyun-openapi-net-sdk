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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBProxyResponse : AcsResponse
	{

		private string requestId;

		private string dBProxyServiceStatus;

		private string dBProxyInstanceType;

		private int? dBProxyInstanceNum;

		private string dBProxyInstanceStatus;

		private string dBProxyInstanceCurrentMinorVersion;

		private string dBProxyInstanceLatestMinorVersion;

		private string dBProxyInstanceName;

		private List<DescribeDBProxy_DBProxyConnectStringItemsItem> dBProxyConnectStringItems;

		private List<DescribeDBProxy_DbProxyEndpointItemsItem> dbProxyEndpointItems;

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

		public class DescribeDBProxy_DBProxyConnectStringItemsItem
		{

			private string dBProxyEndpointId;

			private string dBProxyConnectString;

			private string dBProxyConnectStringPort;

			private string dBProxyConnectStringNetType;

			private string dBProxyVpcInstanceId;

			private string dBProxyEndpointName;

			private string dBProxyConnectStringNetWorkType;

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
		}

		public class DescribeDBProxy_DbProxyEndpointItemsItem
		{

			private string dbProxyEndpointName;

			private string dbProxyEndpointType;

			private string dbProxyReadWriteMode;

			private string dbProxyEndpointAliases;

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
		}
	}
}
