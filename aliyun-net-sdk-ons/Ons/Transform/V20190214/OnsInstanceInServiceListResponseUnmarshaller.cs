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
using Aliyun.Acs.Ons.Model.V20190214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsInstanceInServiceListResponseUnmarshaller
    {
        public static OnsInstanceInServiceListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsInstanceInServiceListResponse onsInstanceInServiceListResponse = new OnsInstanceInServiceListResponse();

			onsInstanceInServiceListResponse.HttpResponse = context.HttpResponse;
			onsInstanceInServiceListResponse.RequestId = context.StringValue("OnsInstanceInServiceList.RequestId");
			onsInstanceInServiceListResponse.HelpUrl = context.StringValue("OnsInstanceInServiceList.HelpUrl");

			List<OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO> onsInstanceInServiceListResponse_data = new List<OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO>();
			for (int i = 0; i < context.Length("OnsInstanceInServiceList.Data.Length"); i++) {
				OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO instanceVO = new OnsInstanceInServiceListResponse.OnsInstanceInServiceList_InstanceVO();
				instanceVO.InstanceId = context.StringValue("OnsInstanceInServiceList.Data["+ i +"].InstanceId");
				instanceVO.InstanceStatus = context.IntegerValue("OnsInstanceInServiceList.Data["+ i +"].InstanceStatus");
				instanceVO.ReleaseTime = context.LongValue("OnsInstanceInServiceList.Data["+ i +"].ReleaseTime");
				instanceVO.InstanceType = context.IntegerValue("OnsInstanceInServiceList.Data["+ i +"].InstanceType");
				instanceVO.InstanceName = context.StringValue("OnsInstanceInServiceList.Data["+ i +"].InstanceName");

				onsInstanceInServiceListResponse_data.Add(instanceVO);
			}
			onsInstanceInServiceListResponse.Data = onsInstanceInServiceListResponse_data;
        
			return onsInstanceInServiceListResponse;
        }
    }
}