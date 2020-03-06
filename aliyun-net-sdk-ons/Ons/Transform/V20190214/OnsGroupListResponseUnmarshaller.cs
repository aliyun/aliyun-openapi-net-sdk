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
        public static OnsGroupListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsGroupListResponse onsGroupListResponse = new OnsGroupListResponse();

			onsGroupListResponse.HttpResponse = context.HttpResponse;
			onsGroupListResponse.RequestId = context.StringValue("OnsGroupList.RequestId");
			onsGroupListResponse.HelpUrl = context.StringValue("OnsGroupList.HelpUrl");

			List<OnsGroupListResponse.OnsGroupList_SubscribeInfoDo> onsGroupListResponse_data = new List<OnsGroupListResponse.OnsGroupList_SubscribeInfoDo>();
			for (int i = 0; i < context.Length("OnsGroupList.Data.Length"); i++) {
				OnsGroupListResponse.OnsGroupList_SubscribeInfoDo subscribeInfoDo = new OnsGroupListResponse.OnsGroupList_SubscribeInfoDo();
				subscribeInfoDo.Owner = context.StringValue("OnsGroupList.Data["+ i +"].Owner");
				subscribeInfoDo.GroupId = context.StringValue("OnsGroupList.Data["+ i +"].GroupId");
				subscribeInfoDo.UpdateTime = context.LongValue("OnsGroupList.Data["+ i +"].UpdateTime");
				subscribeInfoDo.Remark = context.StringValue("OnsGroupList.Data["+ i +"].Remark");
				subscribeInfoDo.InstanceId = context.StringValue("OnsGroupList.Data["+ i +"].InstanceId");
				subscribeInfoDo.IndependentNaming = context.BooleanValue("OnsGroupList.Data["+ i +"].IndependentNaming");
				subscribeInfoDo.CreateTime = context.LongValue("OnsGroupList.Data["+ i +"].CreateTime");
				subscribeInfoDo.GroupType = context.StringValue("OnsGroupList.Data["+ i +"].GroupType");

				onsGroupListResponse_data.Add(subscribeInfoDo);
			}
			onsGroupListResponse.Data = onsGroupListResponse_data;
        
			return onsGroupListResponse;
        }
    }
}
