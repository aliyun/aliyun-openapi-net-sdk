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
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribePurchasedApisResponseUnmarshaller
    {
        public static DescribePurchasedApisResponse Unmarshall(UnmarshallerContext context)
        {
            DescribePurchasedApisResponse describePurchasedApisResponse = new DescribePurchasedApisResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribePurchasedApis.RequestId"),
                TotalCount = context.IntegerValue("DescribePurchasedApis.TotalCount"),
                PageSize = context.IntegerValue("DescribePurchasedApis.PageSize"),
                PageNumber = context.IntegerValue("DescribePurchasedApis.PageNumber")
            };
            List<DescribePurchasedApisResponse.PurchasedApi> purchasedApis = new List<DescribePurchasedApisResponse.PurchasedApi>();
			for (int i = 0; i < context.Length("DescribePurchasedApis.PurchasedApis.Length"); i++) {
                DescribePurchasedApisResponse.PurchasedApi purchasedApi = new DescribePurchasedApisResponse.PurchasedApi()
                {
                    RegionId = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].RegionId"),
                    GroupId = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].GroupId"),
                    GroupName = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].GroupName"),
                    ApiId = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].ApiId"),
                    ApiName = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].ApiName"),
                    StageName = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].StageName"),
                    Description = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].Description"),
                    PurchasedTime = context.StringValue($"DescribePurchasedApis.PurchasedApis[{i}].PurchasedTime")
                };
                purchasedApis.Add(purchasedApi);
			}
			describePurchasedApisResponse.PurchasedApis = purchasedApis;
        
			return describePurchasedApisResponse;
        }
    }
}