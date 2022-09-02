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
	public class DescribeDBProxyEndpointResponse : AcsResponse
	{

		private string dBProxyConnectStringNetType;

		private string dBProxyFeatures;

		private string requestId;

		private string readOnlyInstanceWeight;

		private string readOnlyInstanceDistributionType;

		private string readOnlyInstanceMaxDelayTime;

		private string dbProxyEndpointReadWriteMode;

		private string dbProxyEndpointAliases;

		private string dBProxyEndpointId;

		private string dBProxyConnectStringPort;

		private string dBProxyConnectString;

		private string dBProxyEngineType;

		private List<DescribeDBProxyEndpoint_EndpointConnectItemsItem> endpointConnectItems;

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

		[JsonProperty(PropertyName = "DBProxyFeatures")]
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

		[JsonProperty(PropertyName = "ReadOnlyInstanceWeight")]
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

		[JsonProperty(PropertyName = "ReadOnlyInstanceDistributionType")]
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

		[JsonProperty(PropertyName = "ReadOnlyInstanceMaxDelayTime")]
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

		[JsonProperty(PropertyName = "DbProxyEndpointReadWriteMode")]
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

		[JsonProperty(PropertyName = "EndpointConnectItems")]
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

			private string dbProxyEndpointPort;

			private string dbProxyEndpointConnectString;

			private string dbProxyEndpointNetType;

			[JsonProperty(PropertyName = "DbProxyEndpointPort")]
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

			[JsonProperty(PropertyName = "DbProxyEndpointConnectString")]
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

			[JsonProperty(PropertyName = "DbProxyEndpointNetType")]
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
