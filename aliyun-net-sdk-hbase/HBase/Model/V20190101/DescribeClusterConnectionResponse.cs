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
	public class DescribeClusterConnectionResponse : AcsResponse
	{

		private string requestId;

		private string netType;

		private string vpcId;

		private string vSwitchId;

		private string dbType;

		private string isMultimod;

		private List<DescribeClusterConnection_ZkConnAddr> zkConnAddrs;

		private List<DescribeClusterConnection_SlbConnAddr> slbConnAddrs;

		private List<DescribeClusterConnection_ServiceConnAddr> serviceConnAddrs;

		private DescribeClusterConnection_UiProxyConnAddrInfo uiProxyConnAddrInfo;

		private DescribeClusterConnection_ThriftConn thriftConn;

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

		public string DbType
		{
			get
			{
				return dbType;
			}
			set	
			{
				dbType = value;
			}
		}

		public string IsMultimod
		{
			get
			{
				return isMultimod;
			}
			set	
			{
				isMultimod = value;
			}
		}

		public List<DescribeClusterConnection_ZkConnAddr> ZkConnAddrs
		{
			get
			{
				return zkConnAddrs;
			}
			set	
			{
				zkConnAddrs = value;
			}
		}

		public List<DescribeClusterConnection_SlbConnAddr> SlbConnAddrs
		{
			get
			{
				return slbConnAddrs;
			}
			set	
			{
				slbConnAddrs = value;
			}
		}

		public List<DescribeClusterConnection_ServiceConnAddr> ServiceConnAddrs
		{
			get
			{
				return serviceConnAddrs;
			}
			set	
			{
				serviceConnAddrs = value;
			}
		}

		public DescribeClusterConnection_UiProxyConnAddrInfo UiProxyConnAddrInfo
		{
			get
			{
				return uiProxyConnAddrInfo;
			}
			set	
			{
				uiProxyConnAddrInfo = value;
			}
		}

		public DescribeClusterConnection_ThriftConn ThriftConn
		{
			get
			{
				return thriftConn;
			}
			set	
			{
				thriftConn = value;
			}
		}

		public class DescribeClusterConnection_ZkConnAddr
		{

			private string connAddr;

			private string connAddrPort;

			private string netType;

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

		public class DescribeClusterConnection_SlbConnAddr
		{

			private string slbType;

			private DescribeClusterConnection_ConnAddrInfo connAddrInfo;

			public string SlbType
			{
				get
				{
					return slbType;
				}
				set	
				{
					slbType = value;
				}
			}

			public DescribeClusterConnection_ConnAddrInfo ConnAddrInfo
			{
				get
				{
					return connAddrInfo;
				}
				set	
				{
					connAddrInfo = value;
				}
			}

			public class DescribeClusterConnection_ConnAddrInfo
			{

				private string connAddr;

				private string connAddrPort;

				private string netType;

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

		public class DescribeClusterConnection_ServiceConnAddr
		{

			private string connType;

			private DescribeClusterConnection_ConnAddrInfo1 connAddrInfo1;

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

			public DescribeClusterConnection_ConnAddrInfo1 ConnAddrInfo1
			{
				get
				{
					return connAddrInfo1;
				}
				set	
				{
					connAddrInfo1 = value;
				}
			}

			public class DescribeClusterConnection_ConnAddrInfo1
			{

				private string connAddr;

				private string connAddrPort;

				private string netType;

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

		public class DescribeClusterConnection_UiProxyConnAddrInfo
		{

			private string connAddr;

			private string connAddrPort;

			private string netType;

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

		public class DescribeClusterConnection_ThriftConn
		{

			private string connAddr;

			private string connAddrPort;

			private string netType;

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
