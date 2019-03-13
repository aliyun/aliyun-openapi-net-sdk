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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeCdnSubscriptionResponseUnmarshaller
    {
        public static DescribeCdnSubscriptionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnSubscriptionResponse describeCdnSubscriptionResponse = new DescribeCdnSubscriptionResponse();

			describeCdnSubscriptionResponse.HttpResponse = context.HttpResponse;
			describeCdnSubscriptionResponse.RequestId = context.StringValue("DescribeCdnSubscription.RequestId");
			describeCdnSubscriptionResponse.Module = context.StringValue("DescribeCdnSubscription.Module");

			DescribeCdnSubscriptionResponse.DescribeCdnSubscription_PageInfo pageInfo = new DescribeCdnSubscriptionResponse.DescribeCdnSubscription_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeCdnSubscription.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeCdnSubscription.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeCdnSubscription.PageInfo.CurrentPage");
			describeCdnSubscriptionResponse.PageInfo = pageInfo;

			List<DescribeCdnSubscriptionResponse.DescribeCdnSubscription_Data> describeCdnSubscriptionResponse_dataList = new List<DescribeCdnSubscriptionResponse.DescribeCdnSubscription_Data>();
			for (int i = 0; i < context.Length("DescribeCdnSubscription.DataList.Length"); i++) {
				DescribeCdnSubscriptionResponse.DescribeCdnSubscription_Data data = new DescribeCdnSubscriptionResponse.DescribeCdnSubscription_Data();
				data.VendorAliuid = context.IntegerValue("DescribeCdnSubscription.DataList["+ i +"].VendorAliuid");
				data.VendorName = context.StringValue("DescribeCdnSubscription.DataList["+ i +"].VendorName");
				data.SafetyFactor = context.StringValue("DescribeCdnSubscription.DataList["+ i +"].SafetyFactor");
				data.SubscriptionState = context.IntegerValue("DescribeCdnSubscription.DataList["+ i +"].SubscriptionState");
				data.GmtCreate = context.StringValue("DescribeCdnSubscription.DataList["+ i +"].GmtCreate");
				data.UpdateTime = context.StringValue("DescribeCdnSubscription.DataList["+ i +"].UpdateTime");

				describeCdnSubscriptionResponse_dataList.Add(data);
			}
			describeCdnSubscriptionResponse.DataList = describeCdnSubscriptionResponse_dataList;
        
			return describeCdnSubscriptionResponse;
        }
    }
}
