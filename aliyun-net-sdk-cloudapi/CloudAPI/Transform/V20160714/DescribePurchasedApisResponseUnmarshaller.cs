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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribePurchasedApisResponseUnmarshaller
    {
        public static DescribePurchasedApisResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePurchasedApisResponse describePurchasedApisResponse = new DescribePurchasedApisResponse();

			describePurchasedApisResponse.HttpResponse = context.HttpResponse;
			describePurchasedApisResponse.RequestId = context.StringValue("DescribePurchasedApis.RequestId");
			describePurchasedApisResponse.TotalCount = context.IntegerValue("DescribePurchasedApis.TotalCount");
			describePurchasedApisResponse.PageSize = context.IntegerValue("DescribePurchasedApis.PageSize");
			describePurchasedApisResponse.PageNumber = context.IntegerValue("DescribePurchasedApis.PageNumber");

			List<DescribePurchasedApisResponse.PurchasedApi> purchasedApis = new List<DescribePurchasedApisResponse.PurchasedApi>();
			for (int i = 0; i < context.Length("DescribePurchasedApis.PurchasedApis.Length"); i++) {
				DescribePurchasedApisResponse.PurchasedApi purchasedApi = new DescribePurchasedApisResponse.PurchasedApi();
				purchasedApi.RegionId = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].RegionId");
				purchasedApi.GroupId = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].GroupId");
				purchasedApi.GroupName = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].GroupName");
				purchasedApi.ApiId = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].ApiId");
				purchasedApi.ApiName = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].ApiName");
				purchasedApi.StageName = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].StageName");
				purchasedApi.Description = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].Description");
				purchasedApi.PurchasedTime = context.StringValue("DescribePurchasedApis.PurchasedApis["+ i +"].PurchasedTime");

				purchasedApis.Add(purchasedApi);
			}
			describePurchasedApisResponse.PurchasedApis = purchasedApis;
        
			return describePurchasedApisResponse;
        }
    }
}