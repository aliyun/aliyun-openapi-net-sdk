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
    public class DescribePurchasedApiGroupsResponseUnmarshaller
    {
        public static DescribePurchasedApiGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePurchasedApiGroupsResponse describePurchasedApiGroupsResponse = new DescribePurchasedApiGroupsResponse();

			describePurchasedApiGroupsResponse.HttpResponse = context.HttpResponse;
			describePurchasedApiGroupsResponse.RequestId = context.StringValue("DescribePurchasedApiGroups.RequestId");
			describePurchasedApiGroupsResponse.TotalCount = context.IntegerValue("DescribePurchasedApiGroups.TotalCount");
			describePurchasedApiGroupsResponse.PageSize = context.IntegerValue("DescribePurchasedApiGroups.PageSize");
			describePurchasedApiGroupsResponse.PageNumber = context.IntegerValue("DescribePurchasedApiGroups.PageNumber");

			List<DescribePurchasedApiGroupsResponse.DescribePurchasedApiGroups_PurchasedApiGroupAttribute> describePurchasedApiGroupsResponse_purchasedApiGroupAttributes = new List<DescribePurchasedApiGroupsResponse.DescribePurchasedApiGroups_PurchasedApiGroupAttribute>();
			for (int i = 0; i < context.Length("DescribePurchasedApiGroups.PurchasedApiGroupAttributes.Length"); i++) {
				DescribePurchasedApiGroupsResponse.DescribePurchasedApiGroups_PurchasedApiGroupAttribute purchasedApiGroupAttribute = new DescribePurchasedApiGroupsResponse.DescribePurchasedApiGroups_PurchasedApiGroupAttribute();
				purchasedApiGroupAttribute.GroupId = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].GroupId");
				purchasedApiGroupAttribute.GroupName = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].GroupName");
				purchasedApiGroupAttribute.Description = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].Description");
				purchasedApiGroupAttribute.PurchasedTime = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].PurchasedTime");
				purchasedApiGroupAttribute.ExpireTime = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].ExpireTime");
				purchasedApiGroupAttribute.RegionId = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].RegionId");
				purchasedApiGroupAttribute.BillingType = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].BillingType");
				purchasedApiGroupAttribute.InvokeTimesMax = context.LongValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].InvokeTimesMax");
				purchasedApiGroupAttribute.InvokeTimesNow = context.LongValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].InvokeTimesNow");
				purchasedApiGroupAttribute.Status = context.StringValue("DescribePurchasedApiGroups.PurchasedApiGroupAttributes["+ i +"].Status");

				describePurchasedApiGroupsResponse_purchasedApiGroupAttributes.Add(purchasedApiGroupAttribute);
			}
			describePurchasedApiGroupsResponse.PurchasedApiGroupAttributes = describePurchasedApiGroupsResponse_purchasedApiGroupAttributes;
        
			return describePurchasedApiGroupsResponse;
        }
    }
}
