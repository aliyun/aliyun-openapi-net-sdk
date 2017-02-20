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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiGroupsResponse : AcsResponse
	{
	    public int? TotalCount { get; set; }

	    public int? PageSize { get; set; }

	    public int? PageNumber { get; set; }

	    public List<ApiGroupAttribute> ApiGroupAttributes { get; set; }

	    public class ApiGroupAttribute{
	        public string GroupId { get; set; }

	        public string GroupName { get; set; }

	        public string SubDomain { get; set; }

	        public string Description { get; set; }

	        public string CreatedTime { get; set; }

	        public string ModifiedTime { get; set; }

	        public string RegionId { get; set; }

	        public int? TrafficLimit { get; set; }

	        public BillingStatusEnum? BillingStatus { get; set; }

	        public IllegalStatusEnum? IllegalStatus { get; set; }

	        public enum BillingStatusEnum {

					Normal,
					Locked,
}

public enum IllegalStatusEnum {

					Normal,
					Locked,
}
		}
	}
}