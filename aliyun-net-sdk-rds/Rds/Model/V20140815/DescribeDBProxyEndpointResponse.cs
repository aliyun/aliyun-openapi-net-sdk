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
	public class DescribeDBProxyEndpointResponse : AcsResponse
	{

		private string requestId;

		private string dBProxyEndpointId;

		private string dBProxyConnectString;

		private string dBProxyConnectStringPort;

		private string dBProxyConnectStringNetType;

		private string dBProxyFeatures;

		private string readOnlyInstanceMaxDelayTime;

		private string readOnlyInstanceDistributionType;

		private string readOnlyInstanceWeight;

		private string dbProxyEndpointAliases;

		private string dbProxyEndpointReadWriteMode;

		private List<DescribeDBProxyEndpoint_EndpointConnectItemsItem> endpointConnectItems;

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

		public string DBProxyFeatures
		{
			get
			{
				return dBProxyFeatures;
			}
			set	
			{
				dBProxyFeatures = value;
			}
		}

		public string ReadOnlyInstanceMaxDelayTime
		{
			get
			{
				return readOnlyInstanceMaxDelayTime;
			}
			set	
			{
				readOnlyInstanceMaxDelayTime = value;
			}
		}

		public string ReadOnlyInstanceDistributionType
		{
			get
			{
				return readOnlyInstanceDistributionType;
			}
			set	
			{
				readOnlyInstanceDistributionType = value;
			}
		}

		public string ReadOnlyInstanceWeight
		{
			get
			{
				return readOnlyInstanceWeight;
			}
			set	
			{
				readOnlyInstanceWeight = value;
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

		public string DbProxyEndpointReadWriteMode
		{
			get
			{
				return dbProxyEndpointReadWriteMode;
			}
			set	
			{
				dbProxyEndpointReadWriteMode = value;
			}
		}

		public List<DescribeDBProxyEndpoint_EndpointConnectItemsItem> EndpointConnectItems
		{
			get
			{
				return endpointConnectItems;
			}
			set	
			{
				endpointConnectItems = value;
			}
		}

		public class DescribeDBProxyEndpoint_EndpointConnectItemsItem
		{

			private string dbProxyEndpointConnectString;

			private string dbProxyEndpointPort;

			private string dbProxyEndpointNetType;

			public string DbProxyEndpointConnectString
			{
				get
				{
					return dbProxyEndpointConnectString;
				}
				set	
				{
					dbProxyEndpointConnectString = value;
				}
			}

			public string DbProxyEndpointPort
			{
				get
				{
					return dbProxyEndpointPort;
				}
				set	
				{
					dbProxyEndpointPort = value;
				}
			}

			public string DbProxyEndpointNetType
			{
				get
				{
					return dbProxyEndpointNetType;
				}
				set	
				{
					dbProxyEndpointNetType = value;
				}
			}
		}
	}
}
