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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeDeploymentSetTopologyResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDeploymentSetTopology__Switch> switchs;

		private List<DescribeDeploymentSetTopology_Rack> racks;

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

		public List<DescribeDeploymentSetTopology__Switch> Switchs
		{
			get
			{
				return switchs;
			}
			set	
			{
				switchs = value;
			}
		}

		public List<DescribeDeploymentSetTopology_Rack> Racks
		{
			get
			{
				return racks;
			}
			set	
			{
				racks = value;
			}
		}

		public class DescribeDeploymentSetTopology__Switch
		{

			private string switchId;

			private List<DescribeDeploymentSetTopology_Host> hosts;

			public string SwitchId
			{
				get
				{
					return switchId;
				}
				set	
				{
					switchId = value;
				}
			}

			public List<DescribeDeploymentSetTopology_Host> Hosts
			{
				get
				{
					return hosts;
				}
				set	
				{
					hosts = value;
				}
			}

			public class DescribeDeploymentSetTopology_Host
			{

				private string hostId;

				private List<string> instanceIds;

				public string HostId
				{
					get
					{
						return hostId;
					}
					set	
					{
						hostId = value;
					}
				}

				public List<string> InstanceIds
				{
					get
					{
						return instanceIds;
					}
					set	
					{
						instanceIds = value;
					}
				}
			}
		}

		public class DescribeDeploymentSetTopology_Rack
		{

			private string rackId;

			private List<DescribeDeploymentSetTopology_Host2> hosts1;

			public string RackId
			{
				get
				{
					return rackId;
				}
				set	
				{
					rackId = value;
				}
			}

			public List<DescribeDeploymentSetTopology_Host2> Hosts1
			{
				get
				{
					return hosts1;
				}
				set	
				{
					hosts1 = value;
				}
			}

			public class DescribeDeploymentSetTopology_Host2
			{

				private string hostId3;

				private List<string> instanceIds4;

				public string HostId3
				{
					get
					{
						return hostId3;
					}
					set	
					{
						hostId3 = value;
					}
				}

				public List<string> InstanceIds4
				{
					get
					{
						return instanceIds4;
					}
					set	
					{
						instanceIds4 = value;
					}
				}
			}
		}
	}
}