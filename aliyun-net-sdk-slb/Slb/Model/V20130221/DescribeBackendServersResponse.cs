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

namespace Aliyun.Acs.Slb.Model.V20130221
{
	public class DescribeBackendServersResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBackendServers_Listener> listeners;

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

		public List<DescribeBackendServers_Listener> Listeners
		{
			get
			{
				return listeners;
			}
			set	
			{
				listeners = value;
			}
		}

		public class DescribeBackendServers_Listener
		{

			private int? listenerPort;

			private List<DescribeBackendServers_BackendServer> backendServers;

			public int? ListenerPort
			{
				get
				{
					return listenerPort;
				}
				set	
				{
					listenerPort = value;
				}
			}

			public List<DescribeBackendServers_BackendServer> BackendServers
			{
				get
				{
					return backendServers;
				}
				set	
				{
					backendServers = value;
				}
			}

			public class DescribeBackendServers_BackendServer
			{

				private string serverHealthStatus;

				private string serverId;

				public string ServerHealthStatus
				{
					get
					{
						return serverHealthStatus;
					}
					set	
					{
						serverHealthStatus = value;
					}
				}

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
			}
		}
	}
}
