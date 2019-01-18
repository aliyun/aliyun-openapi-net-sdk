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
	public class DescribeLoadBalancersRelatedEcsResponse : AcsResponse
	{

		private string message;

		private bool? success;

		private string requestId;

		private List<DescribeLoadBalancersRelatedEcs_LoadBalancer> loadBalancers;

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<DescribeLoadBalancersRelatedEcs_LoadBalancer> LoadBalancers
		{
			get
			{
				return loadBalancers;
			}
			set	
			{
				loadBalancers = value;
			}
		}

		public class DescribeLoadBalancersRelatedEcs_LoadBalancer
		{

			private string loadBalancerId;

			private int? count;

			private List<DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup> masterSlaveVServerGroups;

			private List<DescribeLoadBalancersRelatedEcs_VServerGroup> vServerGroups;

			private List<DescribeLoadBalancersRelatedEcs_BackendServer4> backendServers;

			public string LoadBalancerId
			{
				get
				{
					return loadBalancerId;
				}
				set	
				{
					loadBalancerId = value;
				}
			}

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public List<DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup> MasterSlaveVServerGroups
			{
				get
				{
					return masterSlaveVServerGroups;
				}
				set	
				{
					masterSlaveVServerGroups = value;
				}
			}

			public List<DescribeLoadBalancersRelatedEcs_VServerGroup> VServerGroups
			{
				get
				{
					return vServerGroups;
				}
				set	
				{
					vServerGroups = value;
				}
			}

			public List<DescribeLoadBalancersRelatedEcs_BackendServer4> BackendServers
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

			public class DescribeLoadBalancersRelatedEcs_MasterSlaveVServerGroup
			{

				private string groupId;

				private string groupName;

				private List<DescribeLoadBalancersRelatedEcs_BackendServer> backendServers1;

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public List<DescribeLoadBalancersRelatedEcs_BackendServer> BackendServers1
				{
					get
					{
						return backendServers1;
					}
					set	
					{
						backendServers1 = value;
					}
				}

				public class DescribeLoadBalancersRelatedEcs_BackendServer
				{

					private string vmName;

					private int? weight;

					private int? port;

					private string networkType;

					public string VmName
					{
						get
						{
							return vmName;
						}
						set	
						{
							vmName = value;
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

					public string NetworkType
					{
						get
						{
							return networkType;
						}
						set	
						{
							networkType = value;
						}
					}
				}
			}

			public class DescribeLoadBalancersRelatedEcs_VServerGroup
			{

				private string groupId;

				private string groupName;

				private List<DescribeLoadBalancersRelatedEcs_BackendServer3> backendServers2;

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
					}
				}

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public List<DescribeLoadBalancersRelatedEcs_BackendServer3> BackendServers2
				{
					get
					{
						return backendServers2;
					}
					set	
					{
						backendServers2 = value;
					}
				}

				public class DescribeLoadBalancersRelatedEcs_BackendServer3
				{

					private string vmName;

					private int? weight;

					private int? port;

					private string networkType;

					public string VmName
					{
						get
						{
							return vmName;
						}
						set	
						{
							vmName = value;
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

					public string NetworkType
					{
						get
						{
							return networkType;
						}
						set	
						{
							networkType = value;
						}
					}
				}
			}

			public class DescribeLoadBalancersRelatedEcs_BackendServer4
			{

				private string vmName;

				private int? weight;

				private int? port;

				private string networkType;

				public string VmName
				{
					get
					{
						return vmName;
					}
					set	
					{
						vmName = value;
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

				public string NetworkType
				{
					get
					{
						return networkType;
					}
					set	
					{
						networkType = value;
					}
				}
			}
		}
	}
}