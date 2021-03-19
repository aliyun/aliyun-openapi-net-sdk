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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsTopicSubDetailResponseUnmarshaller
    {
        public static OnsTopicSubDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsTopicSubDetailResponse onsTopicSubDetailResponse = new OnsTopicSubDetailResponse();

			onsTopicSubDetailResponse.HttpResponse = _ctx.HttpResponse;
			onsTopicSubDetailResponse.RequestId = _ctx.StringValue("OnsTopicSubDetail.RequestId");

			OnsTopicSubDetailResponse.OnsTopicSubDetail_Data data = new OnsTopicSubDetailResponse.OnsTopicSubDetail_Data();
			data.Topic = _ctx.StringValue("OnsTopicSubDetail.Data.Topic");

			List<OnsTopicSubDetailResponse.OnsTopicSubDetail_Data.OnsTopicSubDetail_SubscriptionDataListItem> data_subscriptionDataList = new List<OnsTopicSubDetailResponse.OnsTopicSubDetail_Data.OnsTopicSubDetail_SubscriptionDataListItem>();
			for (int i = 0; i < _ctx.Length("OnsTopicSubDetail.Data.SubscriptionDataList.Length"); i++) {
				OnsTopicSubDetailResponse.OnsTopicSubDetail_Data.OnsTopicSubDetail_SubscriptionDataListItem subscriptionDataListItem = new OnsTopicSubDetailResponse.OnsTopicSubDetail_Data.OnsTopicSubDetail_SubscriptionDataListItem();
				subscriptionDataListItem.GroupId = _ctx.StringValue("OnsTopicSubDetail.Data.SubscriptionDataList["+ i +"].GroupId");
				subscriptionDataListItem.SubString = _ctx.StringValue("OnsTopicSubDetail.Data.SubscriptionDataList["+ i +"].SubString");
				subscriptionDataListItem.MessageModel = _ctx.StringValue("OnsTopicSubDetail.Data.SubscriptionDataList["+ i +"].MessageModel");

				data_subscriptionDataList.Add(subscriptionDataListItem);
			}
			data.SubscriptionDataList = data_subscriptionDataList;
			onsTopicSubDetailResponse.Data = data;
        
			return onsTopicSubDetailResponse;
        }
    }
}
