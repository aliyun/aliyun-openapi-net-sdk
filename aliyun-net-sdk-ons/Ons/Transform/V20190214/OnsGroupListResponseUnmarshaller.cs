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
    public class OnsGroupListResponseUnmarshaller
    {
        public static OnsGroupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsGroupListResponse onsGroupListResponse = new OnsGroupListResponse();

			onsGroupListResponse.HttpResponse = _ctx.HttpResponse;
			onsGroupListResponse.RequestId = _ctx.StringValue("OnsGroupList.RequestId");
			onsGroupListResponse.HelpUrl = _ctx.StringValue("OnsGroupList.HelpUrl");

			List<OnsGroupListResponse.OnsGroupList_SubscribeInfoDo> onsGroupListResponse_data = new List<OnsGroupListResponse.OnsGroupList_SubscribeInfoDo>();
			for (int i = 0; i < _ctx.Length("OnsGroupList.Data.Length"); i++) {
				OnsGroupListResponse.OnsGroupList_SubscribeInfoDo subscribeInfoDo = new OnsGroupListResponse.OnsGroupList_SubscribeInfoDo();
				subscribeInfoDo.Owner = _ctx.StringValue("OnsGroupList.Data["+ i +"].Owner");
				subscribeInfoDo.GroupId = _ctx.StringValue("OnsGroupList.Data["+ i +"].GroupId");
				subscribeInfoDo.UpdateTime = _ctx.LongValue("OnsGroupList.Data["+ i +"].UpdateTime");
				subscribeInfoDo.Remark = _ctx.StringValue("OnsGroupList.Data["+ i +"].Remark");
				subscribeInfoDo.InstanceId = _ctx.StringValue("OnsGroupList.Data["+ i +"].InstanceId");
				subscribeInfoDo.IndependentNaming = _ctx.BooleanValue("OnsGroupList.Data["+ i +"].IndependentNaming");
				subscribeInfoDo.CreateTime = _ctx.LongValue("OnsGroupList.Data["+ i +"].CreateTime");
				subscribeInfoDo.GroupType = _ctx.StringValue("OnsGroupList.Data["+ i +"].GroupType");

				List<OnsGroupListResponse.OnsGroupList_SubscribeInfoDo.OnsGroupList_Tag> subscribeInfoDo_tags = new List<OnsGroupListResponse.OnsGroupList_SubscribeInfoDo.OnsGroupList_Tag>();
				for (int j = 0; j < _ctx.Length("OnsGroupList.Data["+ i +"].Tags.Length"); j++) {
					OnsGroupListResponse.OnsGroupList_SubscribeInfoDo.OnsGroupList_Tag tag = new OnsGroupListResponse.OnsGroupList_SubscribeInfoDo.OnsGroupList_Tag();
					tag.Key = _ctx.StringValue("OnsGroupList.Data["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("OnsGroupList.Data["+ i +"].Tags["+ j +"].Value");

					subscribeInfoDo_tags.Add(tag);
				}
				subscribeInfoDo.Tags = subscribeInfoDo_tags;

				onsGroupListResponse_data.Add(subscribeInfoDo);
			}
			onsGroupListResponse.Data = onsGroupListResponse_data;
        
			return onsGroupListResponse;
        }
    }
}
