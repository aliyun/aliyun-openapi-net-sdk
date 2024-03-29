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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribePortResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<DescribePort_NetworkRule> networkRules;

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

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

		public List<DescribePort_NetworkRule> NetworkRules
		{
			get
			{
				return networkRules;
			}
			set	
			{
				networkRules = value;
			}
		}

		public class DescribePort_NetworkRule
		{

			private int? frontendPort;

			private bool? isAutoCreate;

			private string instanceId;

			private string frontendProtocol;

			private int? backendPort;

			private List<string> realServers;

			public int? FrontendPort
			{
				get
				{
					return frontendPort;
				}
				set	
				{
					frontendPort = value;
				}
			}

			public bool? IsAutoCreate
			{
				get
				{
					return isAutoCreate;
				}
				set	
				{
					isAutoCreate = value;
				}
			}

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

			public string FrontendProtocol
			{
				get
				{
					return frontendProtocol;
				}
				set	
				{
					frontendProtocol = value;
				}
			}

			public int? BackendPort
			{
				get
				{
					return backendPort;
				}
				set	
				{
					backendPort = value;
				}
			}

			public List<string> RealServers
			{
				get
				{
					return realServers;
				}
				set	
				{
					realServers = value;
				}
			}
		}
	}
}
