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
    public class OnsGroupSubDetailResponseUnmarshaller
    {
        public static OnsGroupSubDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsGroupSubDetailResponse onsGroupSubDetailResponse = new OnsGroupSubDetailResponse();

			onsGroupSubDetailResponse.HttpResponse = _ctx.HttpResponse;
			onsGroupSubDetailResponse.RequestId = _ctx.StringValue("OnsGroupSubDetail.RequestId");

			OnsGroupSubDetailResponse.OnsGroupSubDetail_Data data = new OnsGroupSubDetailResponse.OnsGroupSubDetail_Data();
			data.GroupId = _ctx.StringValue("OnsGroupSubDetail.Data.GroupId");
			data.Online = _ctx.BooleanValue("OnsGroupSubDetail.Data.Online");
			data.MessageModel = _ctx.StringValue("OnsGroupSubDetail.Data.MessageModel");

			List<OnsGroupSubDetailResponse.OnsGroupSubDetail_Data.OnsGroupSubDetail_SubscriptionDataListItem> data_subscriptionDataList = new List<OnsGroupSubDetailResponse.OnsGroupSubDetail_Data.OnsGroupSubDetail_SubscriptionDataListItem>();
			for (int i = 0; i < _ctx.Length("OnsGroupSubDetail.Data.SubscriptionDataList.Length"); i++) {
				OnsGroupSubDetailResponse.OnsGroupSubDetail_Data.OnsGroupSubDetail_SubscriptionDataListItem subscriptionDataListItem = new OnsGroupSubDetailResponse.OnsGroupSubDetail_Data.OnsGroupSubDetail_SubscriptionDataListItem();
				subscriptionDataListItem.Topic = _ctx.StringValue("OnsGroupSubDetail.Data.SubscriptionDataList["+ i +"].Topic");
				subscriptionDataListItem.SubString = _ctx.StringValue("OnsGroupSubDetail.Data.SubscriptionDataList["+ i +"].SubString");

				data_subscriptionDataList.Add(subscriptionDataListItem);
			}
			data.SubscriptionDataList = data_subscriptionDataList;
			onsGroupSubDetailResponse.Data = data;
        
			return onsGroupSubDetailResponse;
        }
    }
}
