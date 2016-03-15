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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceNetInfoResponse : AcsResponse
	{

		private string instanceNetworkType;

		private List<DBInstanceNetInfo> dBInstanceNetInfos;

		public string InstanceNetworkType
		{
			get
			{
				return instanceNetworkType;
			}
			set	
			{
				instanceNetworkType = value;
			}
		}

		public List<DBInstanceNetInfo> DBInstanceNetInfos
		{
			get
			{
				return dBInstanceNetInfos;
			}
			set	
			{
				dBInstanceNetInfos = value;
			}
		}

		public class DBInstanceNetInfo{

			private string connectionString;

			private string iPAddress;

			private string iPType;

			private string port;

			private string vPCId;

			private string vSwitchId;

			private List<securityIPGroup> securityIPGroups;

			public string ConnectionString
			{
				get
				{
					return connectionString;
				}
				set	
				{
					connectionString = value;
				}
			}

			public string IPAddress
			{
				get
				{
					return iPAddress;
				}
				set	
				{
					iPAddress = value;
				}
			}

			public string IPType
			{
				get
				{
					return iPType;
				}
				set	
				{
					iPType = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string VPCId
			{
				get
				{
					return vPCId;
				}
				set	
				{
					vPCId = value;
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

			public List<securityIPGroup> SecurityIPGroups
			{
				get
				{
					return securityIPGroups;
				}
				set	
				{
					securityIPGroups = value;
				}
			}

			public class securityIPGroup{

				private string securityIPGroupName;

				private string securityIPs;

				public string SecurityIPGroupName
				{
					get
					{
						return securityIPGroupName;
					}
					set	
					{
						securityIPGroupName = value;
					}
				}

				public string SecurityIPs
				{
					get
					{
						return securityIPs;
					}
					set	
					{
						securityIPs = value;
					}
				}
			}
		}
	}
}