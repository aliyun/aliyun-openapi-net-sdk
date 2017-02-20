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
	public class DescribeRouterInterfacesResponse : AcsResponse
	{
	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public int? TotalCount { get; set; }

	    public List<RouterInterfaceType> RouterInterfaceSet { get; set; }

	    public class RouterInterfaceType{
	        public string RouterInterfaceId { get; set; }

	        public string OppositeRegionId { get; set; }

	        public string Role { get; set; }

	        public string Spec { get; set; }

	        public string Name { get; set; }

	        public string Description { get; set; }

	        public string RouterId { get; set; }

	        public string RouterType { get; set; }

	        public string CreationTime { get; set; }

	        public string Status { get; set; }

	        public string BusinessStatus { get; set; }

	        public string ConnectedTime { get; set; }

	        public string OppositeInterfaceId { get; set; }

	        public string OppositeInterfaceSpec { get; set; }

	        public string OppositeInterfaceStatus { get; set; }

	        public string OppositeInterfaceBusinessStatus { get; set; }

	        public string OppositeRouterId { get; set; }

	        public string OppositeRouterType { get; set; }

	        public string OppositeInterfaceOwnerId { get; set; }

	        public string AccessPointId { get; set; }

	        public string OppositeAccessPointId { get; set; }

	        public string HealthCheckSourceIp { get; set; }

	        public string HealthCheckTargetIp { get; set; }
	    }
	}
}