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
    public class OnsInstanceInServiceListResponseUnmarshaller
    {
        public static OnsInstanceInServiceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsInstanceInServiceListResponse onsInstanceInServiceListResponse = new OnsInstanceInServiceListResponse();

			onsInstanceInServiceListResponse.HttpResponse = _ctx.HttpResponse;
			onsInstanceInServiceListResponse.RequestId = _ctx.StringValue("OnsInstanceInServiceList.RequestId");
			onsInstanceInServiceListResponse.HelpUrl = _ctx.StringValue("OnsInstanceInServiceList.HelpUrl");

			List<OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO> onsInstanceInServiceListResponse_data = new List<OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO>();
			for (int i = 0; i < _ctx.Length("OnsInstanceInServiceList.Data.Length"); i++) {
				OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO instanceVO = new OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO();
				instanceVO.InstanceId = _ctx.StringValue("OnsInstanceInServiceList.Data["+ i +"].InstanceId");
				instanceVO.InstanceStatus = _ctx.IntegerValue("OnsInstanceInServiceList.Data["+ i +"].InstanceStatus");
				instanceVO.ReleaseTime = _ctx.LongValue("OnsInstanceInServiceList.Data["+ i +"].ReleaseTime");
				instanceVO.InstanceType = _ctx.IntegerValue("OnsInstanceInServiceList.Data["+ i +"].InstanceType");
				instanceVO.InstanceName = _ctx.StringValue("OnsInstanceInServiceList.Data["+ i +"].InstanceName");
				instanceVO.IndependentNaming = _ctx.BooleanValue("OnsInstanceInServiceList.Data["+ i +"].IndependentNaming");

				List<OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO.OnsInstanceInServiceList_Tag> instanceVO_tags = new List<OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO.OnsInstanceInServiceList_Tag>();
				for (int j = 0; j < _ctx.Length("OnsInstanceInServiceList.Data["+ i +"].Tags.Length"); j++) {
					OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO.OnsInstanceInServiceList_Tag tag = new OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO.OnsInstanceInServiceList_Tag();
					tag.Key = _ctx.StringValue("OnsInstanceInServiceList.Data["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("OnsInstanceInServiceList.Data["+ i +"].Tags["+ j +"].Value");

					instanceVO_tags.Add(tag);
				}
				instanceVO.Tags = instanceVO_tags;

				onsInstanceInServiceListResponse_data.Add(instanceVO);
			}
			onsInstanceInServiceListResponse.Data = onsInstanceInServiceListResponse_data;
        
			return onsInstanceInServiceListResponse;
        }
    }
}
