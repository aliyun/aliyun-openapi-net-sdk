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
	public class DescribeLayer4RulePolicyResponse : AcsResponse
	{

		private int? frontendPort;

		private string bakMode;

		private string requestId;

		private int? currentIndex;

		private string forwardProtocol;

		private string instanceId;

		private int? backendPort;

		private List<DescribeLayer4RulePolicy_PriRealServersItem> priRealServers;

		private List<DescribeLayer4RulePolicy_SecRealServersItem> secRealServers;

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

		public string BakMode
		{
			get
			{
				return bakMode;
			}
			set	
			{
				bakMode = value;
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

		public int? CurrentIndex
		{
			get
			{
				return currentIndex;
			}
			set	
			{
				currentIndex = value;
			}
		}

		public string ForwardProtocol
		{
			get
			{
				return forwardProtocol;
			}
			set	
			{
				forwardProtocol = value;
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

		public List<DescribeLayer4RulePolicy_PriRealServersItem> PriRealServers
		{
			get
			{
				return priRealServers;
			}
			set	
			{
				priRealServers = value;
			}
		}

		public List<DescribeLayer4RulePolicy_SecRealServersItem> SecRealServers
		{
			get
			{
				return secRealServers;
			}
			set	
			{
				secRealServers = value;
			}
		}

		public class DescribeLayer4RulePolicy_PriRealServersItem
		{

			private int? frontendPort;

			private string eip;

			private string protocol;

			private int? currentIndex;

			private string instanceId;

			private string realServer;

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

			public string Eip
			{
				get
				{
					return eip;
				}
				set	
				{
					eip = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public int? CurrentIndex
			{
				get
				{
					return currentIndex;
				}
				set	
				{
					currentIndex = value;
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

			public string RealServer
			{
				get
				{
					return realServer;
				}
				set	
				{
					realServer = value;
				}
			}
		}

		public class DescribeLayer4RulePolicy_SecRealServersItem
		{

			private int? frontendPort;

			private string eip;

			private string protocol;

			private int? currentIndex;

			private string instanceId;

			private string realServer;

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

			public string Eip
			{
				get
				{
					return eip;
				}
				set	
				{
					eip = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public int? CurrentIndex
			{
				get
				{
					return currentIndex;
				}
				set	
				{
					currentIndex = value;
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

			public string RealServer
			{
				get
				{
					return realServer;
				}
				set	
				{
					realServer = value;
				}
			}
		}
	}
}
