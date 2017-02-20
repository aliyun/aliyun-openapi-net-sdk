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
	public class DescribeEipAddressesResponse : AcsResponse
	{
	    public int? TotalCount { get; set; }

	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public List<EipAddress> EipAddresses { get; set; }

	    public class EipAddress{
	        public string RegionId { get; set; }

	        public string IpAddress { get; set; }

	        public string AllocationId { get; set; }

	        public string Status { get; set; }

	        public string InstanceId { get; set; }

	        public string Bandwidth { get; set; }

	        public string InternetChargeType { get; set; }

	        public string AllocationTime { get; set; }

	        public string InstanceType { get; set; }

	        public List<LockReason> OperationLocks { get; set; }

	        public class LockReason{
	            public string LockReason_ { get; set; }
	        }
		}
	}
}