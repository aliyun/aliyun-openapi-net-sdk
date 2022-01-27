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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeSubscriptionMetaResponseUnmarshaller
    {
        public static DescribeSubscriptionMetaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSubscriptionMetaResponse describeSubscriptionMetaResponse = new DescribeSubscriptionMetaResponse();

			describeSubscriptionMetaResponse.HttpResponse = _ctx.HttpResponse;
			describeSubscriptionMetaResponse.ErrCode = _ctx.StringValue("DescribeSubscriptionMeta.ErrCode");
			describeSubscriptionMetaResponse.ErrMessage = _ctx.StringValue("DescribeSubscriptionMeta.ErrMessage");
			describeSubscriptionMetaResponse.HttpStatusCode = _ctx.StringValue("DescribeSubscriptionMeta.HttpStatusCode");
			describeSubscriptionMetaResponse.RequestId = _ctx.StringValue("DescribeSubscriptionMeta.RequestId");
			describeSubscriptionMetaResponse.Success = _ctx.StringValue("DescribeSubscriptionMeta.Success");

			List<DescribeSubscriptionMetaResponse.DescribeSubscriptionMeta_SubscriptionMetaListItem> describeSubscriptionMetaResponse_subscriptionMetaList = new List<DescribeSubscriptionMetaResponse.DescribeSubscriptionMeta_SubscriptionMetaListItem>();
			for (int i = 0; i < _ctx.Length("DescribeSubscriptionMeta.SubscriptionMetaList.Length"); i++) {
				DescribeSubscriptionMetaResponse.DescribeSubscriptionMeta_SubscriptionMetaListItem subscriptionMetaListItem = new DescribeSubscriptionMetaResponse.DescribeSubscriptionMeta_SubscriptionMetaListItem();
				subscriptionMetaListItem.DProxyUrl = _ctx.StringValue("DescribeSubscriptionMeta.SubscriptionMetaList["+ i +"].DProxyUrl");
				subscriptionMetaListItem.Topic = _ctx.StringValue("DescribeSubscriptionMeta.SubscriptionMetaList["+ i +"].Topic");
				subscriptionMetaListItem.Sid = _ctx.StringValue("DescribeSubscriptionMeta.SubscriptionMetaList["+ i +"].Sid");
				subscriptionMetaListItem.Checkpoint = _ctx.LongValue("DescribeSubscriptionMeta.SubscriptionMetaList["+ i +"].Checkpoint");
				subscriptionMetaListItem.DBList = _ctx.StringValue("DescribeSubscriptionMeta.SubscriptionMetaList["+ i +"].DBList");

				describeSubscriptionMetaResponse_subscriptionMetaList.Add(subscriptionMetaListItem);
			}
			describeSubscriptionMetaResponse.SubscriptionMetaList = describeSubscriptionMetaResponse_subscriptionMetaList;
        
			return describeSubscriptionMetaResponse;
        }
    }
}
