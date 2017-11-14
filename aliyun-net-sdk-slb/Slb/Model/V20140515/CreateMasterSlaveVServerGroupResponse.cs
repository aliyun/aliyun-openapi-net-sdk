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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class CreateMasterSlaveVServerGroupResponse : AcsResponse
	{

		private string requestId;

		private string masterSlaveVServerGroupId;

		private List<CreateMasterSlaveVServerGroup_MasterSlaveBackendServer> masterSlaveBackendServers;

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

		public string MasterSlaveVServerGroupId
		{
			get
			{
				return masterSlaveVServerGroupId;
			}
			set	
			{
				masterSlaveVServerGroupId = value;
			}
		}

		public List<CreateMasterSlaveVServerGroup_MasterSlaveBackendServer> MasterSlaveBackendServers
		{
			get
			{
				return masterSlaveBackendServers;
			}
			set	
			{
				masterSlaveBackendServers = value;
			}
		}

		public class CreateMasterSlaveVServerGroup_MasterSlaveBackendServer
		{

			private string serverId;

			private int? port;

			private int? weight;

			private int? isBackup;

			public string ServerId
			{
				get
				{
					return serverId;
				}
				set	
				{
					serverId = value;
				}
			}

			public int? Port
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

			public int? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}

			public int? IsBackup
			{
				get
				{
					return isBackup;
				}
				set	
				{
					isBackup = value;
				}
			}
		}
	}
}