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
    public class OnsSubscriptionGetResponseUnmarshaller
    {
        public static OnsSubscriptionGetResponse Unmarshall(UnmarshallerContext context)
        {
			OnsSubscriptionGetResponse onsSubscriptionGetResponse = new OnsSubscriptionGetResponse();

			onsSubscriptionGetResponse.HttpResponse = context.HttpResponse;
			onsSubscriptionGetResponse.RequestId = context.StringValue("OnsSubscriptionGet.RequestId");
			onsSubscriptionGetResponse.HelpUrl = context.StringValue("OnsSubscriptionGet.HelpUrl");

			List<OnsSubscriptionGetResponse.OnsSubscriptionGet_SubscribeInfoDo> onsSubscriptionGetResponse_data = new List<OnsSubscriptionGetResponse.OnsSubscriptionGet_SubscribeInfoDo>();
			for (int i = 0; i < context.Length("OnsSubscriptionGet.Data.Length"); i++) {
				OnsSubscriptionGetResponse.OnsSubscriptionGet_SubscribeInfoDo subscribeInfoDo = new OnsSubscriptionGetResponse.OnsSubscriptionGet_SubscribeInfoDo();
				subscribeInfoDo.Id = context.LongValue("OnsSubscriptionGet.Data["+ i +"].Id");
				subscribeInfoDo.ChannelId = context.IntegerValue("OnsSubscriptionGet.Data["+ i +"].ChannelId");
				subscribeInfoDo.ChannelName = context.StringValue("OnsSubscriptionGet.Data["+ i +"].ChannelName");
				subscribeInfoDo.OnsRegionId = context.StringValue("OnsSubscriptionGet.Data["+ i +"].OnsRegionId");
				subscribeInfoDo.RegionName = context.StringValue("OnsSubscriptionGet.Data["+ i +"].RegionName");
				subscribeInfoDo.Owner = context.StringValue("OnsSubscriptionGet.Data["+ i +"].Owner");
				subscribeInfoDo.ConsumerId = context.StringValue("OnsSubscriptionGet.Data["+ i +"].ConsumerId");
				subscribeInfoDo.Topic = context.StringValue("OnsSubscriptionGet.Data["+ i +"].Topic");
				subscribeInfoDo.Status = context.IntegerValue("OnsSubscriptionGet.Data["+ i +"].Status");
				subscribeInfoDo.StatusName = context.StringValue("OnsSubscriptionGet.Data["+ i +"].StatusName");
				subscribeInfoDo.CreateTime = context.LongValue("OnsSubscriptionGet.Data["+ i +"].CreateTime");
				subscribeInfoDo.UpdateTime = context.LongValue("OnsSubscriptionGet.Data["+ i +"].UpdateTime");

				onsSubscriptionGetResponse_data.Add(subscribeInfoDo);
			}
			onsSubscriptionGetResponse.Data = onsSubscriptionGetResponse_data;
        
			return onsSubscriptionGetResponse;
        }
    }
}