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
    public class OnsPublishListResponseUnmarshaller
    {
        public static OnsPublishListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsPublishListResponse onsPublishListResponse = new OnsPublishListResponse();

			onsPublishListResponse.HttpResponse = context.HttpResponse;
			onsPublishListResponse.RequestId = context.StringValue("OnsPublishList.RequestId");
			onsPublishListResponse.HelpUrl = context.StringValue("OnsPublishList.HelpUrl");

			List<OnsPublishListResponse.OnsPublishList_PublishInfoDo> onsPublishListResponse_data = new List<OnsPublishListResponse.OnsPublishList_PublishInfoDo>();
			for (int i = 0; i < context.Length("OnsPublishList.Data.Length"); i++) {
				OnsPublishListResponse.OnsPublishList_PublishInfoDo publishInfoDo = new OnsPublishListResponse.OnsPublishList_PublishInfoDo();
				publishInfoDo.Id = context.LongValue("OnsPublishList.Data["+ i +"].Id");
				publishInfoDo.ChannelId = context.IntegerValue("OnsPublishList.Data["+ i +"].ChannelId");
				publishInfoDo.ChannelName = context.StringValue("OnsPublishList.Data["+ i +"].ChannelName");
				publishInfoDo.OnsRegionId = context.StringValue("OnsPublishList.Data["+ i +"].OnsRegionId");
				publishInfoDo.RegionName = context.StringValue("OnsPublishList.Data["+ i +"].RegionName");
				publishInfoDo.Owner = context.StringValue("OnsPublishList.Data["+ i +"].Owner");
				publishInfoDo.ProducerId = context.StringValue("OnsPublishList.Data["+ i +"].ProducerId");
				publishInfoDo.Topic = context.StringValue("OnsPublishList.Data["+ i +"].Topic");
				publishInfoDo.Status = context.IntegerValue("OnsPublishList.Data["+ i +"].Status");
				publishInfoDo.StatusName = context.StringValue("OnsPublishList.Data["+ i +"].StatusName");
				publishInfoDo.CreateTime = context.LongValue("OnsPublishList.Data["+ i +"].CreateTime");
				publishInfoDo.UpdateTime = context.LongValue("OnsPublishList.Data["+ i +"].UpdateTime");

				onsPublishListResponse_data.Add(publishInfoDo);
			}
			onsPublishListResponse.Data = onsPublishListResponse_data;
        
			return onsPublishListResponse;
        }
    }
}