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
	public class DescribeSecurityGroupAttributeResponse : AcsResponse
	{
	    public string RegionId { get; set; }

	    public string SecurityGroupId { get; set; }

	    public string Description { get; set; }

	    public string SecurityGroupName { get; set; }

	    public string VpcId { get; set; }

	    public List<Permission> Permissions { get; set; }

	    public class Permission{
	        public string IpProtocol { get; set; }

	        public string PortRange { get; set; }

	        public string SourceGroupId { get; set; }

	        public string SourceCidrIp { get; set; }

	        public string Policy { get; set; }

	        public string NicType { get; set; }

	        public string SourceGroupOwnerAccount { get; set; }

	        public string DestGroupId { get; set; }

	        public string DestCidrIp { get; set; }

	        public string DestGroupOwnerAccount { get; set; }

	        public string Priority { get; set; }

	        public string Direction { get; set; }
	    }
	}
}