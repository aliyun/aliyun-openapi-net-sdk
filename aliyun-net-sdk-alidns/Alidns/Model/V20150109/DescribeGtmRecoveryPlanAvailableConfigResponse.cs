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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeGtmRecoveryPlanAvailableConfigResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGtmRecoveryPlanAvailableConfig_Instance> instances;

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

		public List<DescribeGtmRecoveryPlanAvailableConfig_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeGtmRecoveryPlanAvailableConfig_Instance
		{

			private string instanceId;

			private string instanceName;

			private List<DescribeGtmRecoveryPlanAvailableConfig_AddrPool> addrPools;

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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public List<DescribeGtmRecoveryPlanAvailableConfig_AddrPool> AddrPools
			{
				get
				{
					return addrPools;
				}
				set	
				{
					addrPools = value;
				}
			}

			public class DescribeGtmRecoveryPlanAvailableConfig_AddrPool
			{

				private string addrPoolId;

				private string name;

				public string AddrPoolId
				{
					get
					{
						return addrPoolId;
					}
					set	
					{
						addrPoolId = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}
			}
		}
	}
}
