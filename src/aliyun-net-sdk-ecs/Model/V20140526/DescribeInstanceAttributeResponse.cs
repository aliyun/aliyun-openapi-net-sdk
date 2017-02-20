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
	public class DescribeInstanceAttributeResponse : AcsResponse
	{
	    public string InstanceId { get; set; }

	    public string InstanceName { get; set; }

	    public string ImageId { get; set; }

	    public string RegionId { get; set; }

	    public string ZoneId { get; set; }

	    public string ClusterId { get; set; }

	    public string InstanceType { get; set; }

	    public int? Cpu { get; set; }

	    public int? Memory { get; set; }

	    public string HostName { get; set; }

	    public StatusEnum? Status { get; set; }

	    public string InternetChargeType { get; set; }

	    public int? InternetMaxBandwidthIn { get; set; }

	    public int? InternetMaxBandwidthOut { get; set; }

	    public string VlanId { get; set; }

	    public string SerialNumber { get; set; }

	    public string CreationTime { get; set; }

	    public string Description { get; set; }

	    public string InstanceNetworkType { get; set; }

	    public string IoOptimized { get; set; }

	    public string InstanceChargeType { get; set; }

	    public string ExpiredTime { get; set; }

	    public List<LockReason> OperationLocks { get; set; }

	    public List<string> SecurityGroupIds { get; set; }

	    public List<string> PublicIpAddress { get; set; }

	    public List<string> InnerIpAddress { get; set; }

	    public VpcAttributes_ VpcAttributes { get; set; }

	    public EipAddress_ EipAddress { get; set; }

	    public enum StatusEnum {
		
			Deleted,
			Stopped,
			Transferring,
			Running,
			Resetting,
			Starting,
			Stopping,
			Pending,
		}

		public class LockReason{
		    public string LockReason_ { get; set; }
		}

		public class VpcAttributes_{
		    public string VpcId { get; set; }

		    public string VSwitchId { get; set; }

		    public string NatIpAddress { get; set; }

		    public List<string> PrivateIpAddress { get; set; }
		}

		public class EipAddress_{
		    public string AllocationId { get; set; }

		    public string IpAddress { get; set; }

		    public int? Bandwidth { get; set; }

		    public string InternetChargeType { get; set; }
		}
	}
}