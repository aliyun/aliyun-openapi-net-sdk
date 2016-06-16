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

namespace Aliyun.Acs.HPC.Model.V20160603
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private List<Instance> instances;

		public List<Instance> Instances
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

		public class Instance{

			private string instanceId;

			private InstanceTypeEnum? instanceType;

			private PackageIdEnum? packageId;

			private StatusEnum? status;

			private string innerIpAddress;

			private JumpserverStatusEnum? jumpserverStatus;

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

			public InstanceTypeEnum? InstanceType
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

			public PackageIdEnum? PackageId
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

			public StatusEnum? Status
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

			public JumpserverStatusEnum? JumpserverStatus
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

			public enum InstanceTypeEnum {
			
					PREPAY,
					POSTPAY,
			}

			public enum PackageIdEnum {
			
					G4,
					G2,
			}

			public enum StatusEnum {
			
					STOPPED,
					STOPPING,
					RUNNING,
					OFFLINE,
					STARTING,
			}

			public enum JumpserverStatusEnum {
			
					STOPPED,
					STOPPING,
					RUNNING,
					STARTING,
			}
		}
	}
}