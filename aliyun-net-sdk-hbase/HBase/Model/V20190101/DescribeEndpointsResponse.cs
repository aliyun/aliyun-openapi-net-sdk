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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeEndpointsResponse : AcsResponse
	{

		private string requestId;

		private string netType;

		private string vpcId;

		private string vSwitchId;

		private string engine;

		private List<DescribeEndpoints_ConnAddrInfo> connAddrs;

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

		public string NetType
		{
			get
			{
				return netType;
			}
			set	
			{
				netType = value;
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
			}
		}

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public List<DescribeEndpoints_ConnAddrInfo> ConnAddrs
		{
			get
			{
				return connAddrs;
			}
			set	
			{
				connAddrs = value;
			}
		}

		public class DescribeEndpoints_ConnAddrInfo
		{

			private string connType;

			private string connAddr;

			private string connAddrPort;

			private string netType;

			public string ConnType
			{
				get
				{
					return connType;
				}
				set	
				{
					connType = value;
				}
			}

			public string ConnAddr
			{
				get
				{
					return connAddr;
				}
				set	
				{
					connAddr = value;
				}
			}

			public string ConnAddrPort
			{
				get
				{
					return connAddrPort;
				}
				set	
				{
					connAddrPort = value;
				}
			}

			public string NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}
		}
	}
}
