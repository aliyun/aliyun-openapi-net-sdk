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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Alidns.Model.V20150109;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainGroupsResponseUnmarshaller
    {
        public static DescribeDomainGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainGroupsResponse describeDomainGroupsResponse = new DescribeDomainGroupsResponse();

			describeDomainGroupsResponse.HttpResponse = context.HttpResponse;
			describeDomainGroupsResponse.RequestId = context.StringValue("DescribeDomainGroups.RequestId");
			describeDomainGroupsResponse.TotalCount = context.LongValue("DescribeDomainGroups.TotalCount");
			describeDomainGroupsResponse.PageNumber = context.LongValue("DescribeDomainGroups.PageNumber");
			describeDomainGroupsResponse.PageSize = context.LongValue("DescribeDomainGroups.PageSize");

			List<DescribeDomainGroupsResponse.DomainGroup> domainGroups = new List<DescribeDomainGroupsResponse.DomainGroup>();
			for (int i = 0; i < context.Length("DescribeDomainGroups.DomainGroups.Length"); i++) {
				DescribeDomainGroupsResponse.DomainGroup domainGroup = new DescribeDomainGroupsResponse.DomainGroup();
				domainGroup.GroupId = context.StringValue("DescribeDomainGroups.DomainGroups["+ i +"].GroupId");
				domainGroup.GroupName = context.StringValue("DescribeDomainGroups.DomainGroups["+ i +"].GroupName");

				domainGroups.Add(domainGroup);
			}
			describeDomainGroupsResponse.DomainGroups = domainGroups;
        
			return describeDomainGroupsResponse;
        }
    }
}