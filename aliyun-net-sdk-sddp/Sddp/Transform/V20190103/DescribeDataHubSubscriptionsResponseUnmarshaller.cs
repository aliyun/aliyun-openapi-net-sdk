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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataHubSubscriptionsResponseUnmarshaller
    {
        public static DescribeDataHubSubscriptionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataHubSubscriptionsResponse describeDataHubSubscriptionsResponse = new DescribeDataHubSubscriptionsResponse();

			describeDataHubSubscriptionsResponse.HttpResponse = context.HttpResponse;
			describeDataHubSubscriptionsResponse.RequestId = context.StringValue("DescribeDataHubSubscriptions.RequestId");
			describeDataHubSubscriptionsResponse.PageSize = context.IntegerValue("DescribeDataHubSubscriptions.PageSize");
			describeDataHubSubscriptionsResponse.CurrentPage = context.IntegerValue("DescribeDataHubSubscriptions.CurrentPage");
			describeDataHubSubscriptionsResponse.TotalCount = context.IntegerValue("DescribeDataHubSubscriptions.TotalCount");

			List<DescribeDataHubSubscriptionsResponse.DescribeDataHubSubscriptions_Subscription> describeDataHubSubscriptionsResponse_items = new List<DescribeDataHubSubscriptionsResponse.DescribeDataHubSubscriptions_Subscription>();
			for (int i = 0; i < context.Length("DescribeDataHubSubscriptions.Items.Length"); i++) {
				DescribeDataHubSubscriptionsResponse.DescribeDataHubSubscriptions_Subscription subscription = new DescribeDataHubSubscriptionsResponse.DescribeDataHubSubscriptions_Subscription();
				subscription.Id = context.LongValue("DescribeDataHubSubscriptions.Items["+ i +"].Id");
				subscription.Name = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].Name");
				subscription.Description = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].Description");
				subscription.CreationTime = context.LongValue("DescribeDataHubSubscriptions.Items["+ i +"].CreationTime");
				subscription.State = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].State");
				subscription.ApplicationName = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].ApplicationName");
				subscription.UserId = context.LongValue("DescribeDataHubSubscriptions.Items["+ i +"].UserId");
				subscription.LoginName = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].LoginName");
				subscription.DisplayName = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].DisplayName");
				subscription.SubscriptionUserId = context.LongValue("DescribeDataHubSubscriptions.Items["+ i +"].SubscriptionUserId");
				subscription.SubscriptionUserName = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].SubscriptionUserName");
				subscription.SubscriptionDisplayName = context.StringValue("DescribeDataHubSubscriptions.Items["+ i +"].SubscriptionDisplayName");

				describeDataHubSubscriptionsResponse_items.Add(subscription);
			}
			describeDataHubSubscriptionsResponse.Items = describeDataHubSubscriptionsResponse_items;
        
			return describeDataHubSubscriptionsResponse;
        }
    }
}
