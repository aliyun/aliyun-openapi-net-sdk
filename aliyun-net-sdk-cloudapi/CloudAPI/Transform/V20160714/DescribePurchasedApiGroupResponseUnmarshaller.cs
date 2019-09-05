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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribePurchasedApiGroupResponseUnmarshaller
    {
        public static DescribePurchasedApiGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePurchasedApiGroupResponse describePurchasedApiGroupResponse = new DescribePurchasedApiGroupResponse();

			describePurchasedApiGroupResponse.HttpResponse = context.HttpResponse;
			describePurchasedApiGroupResponse.RequestId = context.StringValue("DescribePurchasedApiGroup.RequestId");
			describePurchasedApiGroupResponse.GroupId = context.StringValue("DescribePurchasedApiGroup.GroupId");
			describePurchasedApiGroupResponse.GroupName = context.StringValue("DescribePurchasedApiGroup.GroupName");
			describePurchasedApiGroupResponse.Description = context.StringValue("DescribePurchasedApiGroup.Description");
			describePurchasedApiGroupResponse.PurchasedTime = context.StringValue("DescribePurchasedApiGroup.PurchasedTime");
			describePurchasedApiGroupResponse.RegionId = context.StringValue("DescribePurchasedApiGroup.RegionId");
			describePurchasedApiGroupResponse.Status = context.StringValue("DescribePurchasedApiGroup.Status");

			List<DescribePurchasedApiGroupResponse.DescribePurchasedApiGroup_DomainItem> describePurchasedApiGroupResponse_domains = new List<DescribePurchasedApiGroupResponse.DescribePurchasedApiGroup_DomainItem>();
			for (int i = 0; i < context.Length("DescribePurchasedApiGroup.Domains.Length"); i++) {
				DescribePurchasedApiGroupResponse.DescribePurchasedApiGroup_DomainItem domainItem = new DescribePurchasedApiGroupResponse.DescribePurchasedApiGroup_DomainItem();
				domainItem.DomainName = context.StringValue("DescribePurchasedApiGroup.Domains["+ i +"].DomainName");

				describePurchasedApiGroupResponse_domains.Add(domainItem);
			}
			describePurchasedApiGroupResponse.Domains = describePurchasedApiGroupResponse_domains;
        
			return describePurchasedApiGroupResponse;
        }
    }
}
