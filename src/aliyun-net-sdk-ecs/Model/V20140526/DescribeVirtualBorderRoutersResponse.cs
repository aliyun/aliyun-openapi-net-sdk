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
	public class DescribeVirtualBorderRoutersResponse : AcsResponse
	{
	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public int? TotalCount { get; set; }

	    public List<VirtualBorderRouterType> VirtualBorderRouterSet { get; set; }

	    public class VirtualBorderRouterType{
	        public string VbrId { get; set; }

	        public string CreationTime { get; set; }

	        public string ActivationTime { get; set; }

	        public string TerminationTime { get; set; }

	        public string RecoveryTime { get; set; }

	        public string Status { get; set; }

	        public int? VlanId { get; set; }

	        public string CircuitCode { get; set; }

	        public string RouteTableId { get; set; }

	        public string VlanInterfaceId { get; set; }

	        public string LocalGatewayIp { get; set; }

	        public string PeerGatewayIp { get; set; }

	        public string PeeringSubnetMask { get; set; }

	        public string PhysicalConnectionId { get; set; }

	        public string PhysicalConnectionStatus { get; set; }

	        public string PhysicalConnectionBusinessStatus { get; set; }

	        public string PhysicalConnectionOwnerUid { get; set; }

	        public string AccessPointId { get; set; }

	        public string Name { get; set; }

	        public string Description { get; set; }
	    }
	}
}