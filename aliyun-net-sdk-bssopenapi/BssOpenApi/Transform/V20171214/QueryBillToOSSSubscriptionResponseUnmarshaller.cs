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
        public static QueryBillToOSSSubscriptionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBillToOSSSubscriptionResponse queryBillToOSSSubscriptionResponse = new QueryBillToOSSSubscriptionResponse();

			queryBillToOSSSubscriptionResponse.HttpResponse = context.HttpResponse;
			queryBillToOSSSubscriptionResponse.RequestId = context.StringValue("QueryBillToOSSSubscription.RequestId");
			queryBillToOSSSubscriptionResponse.Success = context.BooleanValue("QueryBillToOSSSubscription.Success");
			queryBillToOSSSubscriptionResponse.Code = context.StringValue("QueryBillToOSSSubscription.Code");
			queryBillToOSSSubscriptionResponse.Message = context.StringValue("QueryBillToOSSSubscription.Message");

			QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data data = new QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data();
			data.AccountID = context.StringValue("QueryBillToOSSSubscription.Data.AccountID");
			data.AccountName = context.StringValue("QueryBillToOSSSubscription.Data.AccountName");

			List<QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item> data_items = new List<QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item>();
			for (int i = 0; i < context.Length("QueryBillToOSSSubscription.Data.Items.Length"); i++) {
				QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item item = new QueryBillToOSSSubscriptionResponse.QueryBillToOSSSubscription_Data.QueryBillToOSSSubscription_Item();
				item.SubscribeType = context.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeType");
				item.SubscribeBucket = context.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeBucket");
				item.BucketOwnerId = context.LongValue("QueryBillToOSSSubscription.Data.Items["+ i +"].BucketOwnerId");
				item.SubscribeTime = context.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeTime");
				item.SubscribeLanguage = context.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].SubscribeLanguage");
				item.MultAccountRelSubscribe = context.StringValue("QueryBillToOSSSubscription.Data.Items["+ i +"].MultAccountRelSubscribe");

				data_items.Add(item);
			}
			data.Items = data_items;
			queryBillToOSSSubscriptionResponse.Data = data;
        
			return queryBillToOSSSubscriptionResponse;
        }
    }
}
