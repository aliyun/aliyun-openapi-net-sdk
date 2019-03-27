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

namespace Aliyun.Acs.HPC.Model.V20160603
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeInstances_Instance> instances;

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

		public List<DescribeInstances_Instance> Instances
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

		public class DescribeInstances_Instance
		{

			private string instanceId;

			private string instanceType;

			private string packageId;

			private string status;

			private string innerIpAddress;

			private string jumpserverStatus;

			private string jumpserverInnerIpAddress;

			private string jumpServerPublicIpAddress;

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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string PackageId
			{
				get
				{
					return packageId;
				}
				set	
				{
					packageId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string InnerIpAddress
			{
				get
				{
					return innerIpAddress;
				}
				set	
				{
					innerIpAddress = value;
				}
			}

			public string JumpserverStatus
			{
				get
				{
					return jumpserverStatus;
				}
				set	
				{
					jumpserverStatus = value;
				}
			}

			public string JumpserverInnerIpAddress
			{
				get
				{
					return jumpserverInnerIpAddress;
				}
				set	
				{
					jumpserverInnerIpAddress = value;
				}
			}

			public string JumpServerPublicIpAddress
			{
				get
				{
					return jumpServerPublicIpAddress;
				}
				set	
				{
					jumpServerPublicIpAddress = value;
				}
			}
		}
	}
}
