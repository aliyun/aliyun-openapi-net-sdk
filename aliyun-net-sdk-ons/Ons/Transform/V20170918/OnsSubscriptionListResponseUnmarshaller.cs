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
using Aliyun.Acs.Ons.Model.V20170918;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20170918
{
    public class OnsSubscriptionListResponseUnmarshaller
    {
        public static OnsSubscriptionListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsSubscriptionListResponse onsSubscriptionListResponse = new OnsSubscriptionListResponse();

			onsSubscriptionListResponse.HttpResponse = context.HttpResponse;
			onsSubscriptionListResponse.RequestId = context.StringValue("OnsSubscriptionList.RequestId");
			onsSubscriptionListResponse.HelpUrl = context.StringValue("OnsSubscriptionList.HelpUrl");

			List<OnsSubscriptionListResponse.OnsSubscriptionList_SubscribeInfoDo> onsSubscriptionListResponse_data = new List<OnsSubscriptionListResponse.OnsSubscriptionList_SubscribeInfoDo>();
			for (int i = 0; i < context.Length("OnsSubscriptionList.Data.Length"); i++) {
				OnsSubscriptionListResponse.OnsSubscriptionList_SubscribeInfoDo subscribeInfoDo = new OnsSubscriptionListResponse.OnsSubscriptionList_SubscribeInfoDo();
				subscribeInfoDo.Id = context.LongValue("OnsSubscriptionList.Data["+ i +"].Id");
				subscribeInfoDo.ChannelId = context.IntegerValue("OnsSubscriptionList.Data["+ i +"].ChannelId");
				subscribeInfoDo.ChannelName = context.StringValue("OnsSubscriptionList.Data["+ i +"].ChannelName");
				subscribeInfoDo.OnsRegionId = context.StringValue("OnsSubscriptionList.Data["+ i +"].OnsRegionId");
				subscribeInfoDo.RegionName = context.StringValue("OnsSubscriptionList.Data["+ i +"].RegionName");
				subscribeInfoDo.Owner = context.StringValue("OnsSubscriptionList.Data["+ i +"].Owner");
				subscribeInfoDo.ConsumerId = context.StringValue("OnsSubscriptionList.Data["+ i +"].ConsumerId");
				subscribeInfoDo.Topic = context.StringValue("OnsSubscriptionList.Data["+ i +"].Topic");
				subscribeInfoDo.Status = context.IntegerValue("OnsSubscriptionList.Data["+ i +"].Status");
				subscribeInfoDo.StatusName = context.StringValue("OnsSubscriptionList.Data["+ i +"].StatusName");
				subscribeInfoDo.CreateTime = context.LongValue("OnsSubscriptionList.Data["+ i +"].CreateTime");
				subscribeInfoDo.UpdateTime = context.LongValue("OnsSubscriptionList.Data["+ i +"].UpdateTime");

				onsSubscriptionListResponse_data.Add(subscribeInfoDo);
			}
			onsSubscriptionListResponse.Data = onsSubscriptionListResponse_data;
        
			return onsSubscriptionListResponse;
        }
    }
}