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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryBillToOSSSubscriptionResponseUnmarshaller
    {
        public static QueryBillToOSSSubscriptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBillToOSSSubscriptionResponse queryBillToOSSSubscriptionResponse = new QueryBillToOSSSubscriptionResponse();

			queryBillToOSSSubscriptionResponse.HttpResponse = _ctx.HttpResponse;
			queryBillToOSSSubscriptionResponse.RequestId = _ctx.StringValue("QueryBillToOSSSubscription.RequestId");
			queryBillToOSSSubscriptionResponse.Success = _ctx.BooleanValue("QueryBillToOSSSubscription.Success");
			queryBillToOSSSubscriptionResponse.Code = _ctx.StringValue("QueryBillToOSSSubscription.Code");
			queryBillToOSSSubscriptionResponse.Message = _ctx.StringValue("QueryBillToOSSSubscription.Message");

			QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data data = new QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data();
			data.AccountID = _ctx.StringValue("QueryBillToOSSSubscription.Data.AccountID");
			data.AccountName = _ctx.StringValue("QueryBillToOSSSubscription.Data.AccountName");

			List<QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item> data_items = new List<QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item>();
			for (int i = 0; i < _ctx.Length("QueryBillToOSSSubscription.Data.Items.Length"); i++) {
				QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item item = new QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item();
				item.SubscribeType = _ctx.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeType");
				item.SubscribeBucket = _ctx.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeBucket");
				item.BucketOwnerId = _ctx.LongValue("QueryBillToOSSSubscription.Data.Items["+ i +"].BucketOwnerId");
				item.SubscribeTime = _ctx.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeTime");
				item.SubscribeLanguage = _ctx.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeLanguage");
				item.MultAccountRelSubscribe = _ctx.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].MultAccountRelSubscribe");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillToOSSSubscriptionResponse.Data = data;
        
			return queryBillToOSSSubscriptionResponse;
        }
    }
}
