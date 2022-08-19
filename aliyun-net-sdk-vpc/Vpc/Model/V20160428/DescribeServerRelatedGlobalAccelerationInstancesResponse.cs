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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeServerRelatedGlobalAccelerationInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeServerRelatedGlobalAccelerationInstances_GlobalAccelerationInstance> globalAccelerationInstances;

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

		public List<DescribeServerRelatedGlobalAccelerationInstances_GlobalAccelerationInstance> GlobalAccelerationInstances
		{
			get
			{
				return globalAccelerationInstances;
			}
			set	
			{
				globalAccelerationInstances = value;
			}
		}

		public class DescribeServerRelatedGlobalAccelerationInstances_GlobalAccelerationInstance
		{

			private string serverIpAddress;

			private string globalAccelerationInstanceId;

			private string ipAddress;

			private string regionId;

			public string ServerIpAddress
			{
				get
				{
					return serverIpAddress;
				}
				set	
				{
					serverIpAddress = value;
				}
			}

			public string GlobalAccelerationInstanceId
			{
				get
				{
					return globalAccelerationInstanceId;
				}
				set	
				{
					globalAccelerationInstanceId = value;
				}
			}

			public string IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}
		}
	}
}
