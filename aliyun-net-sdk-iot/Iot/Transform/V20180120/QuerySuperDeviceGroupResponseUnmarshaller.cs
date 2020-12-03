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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySuperDeviceGroupResponseUnmarshaller
    {
        public static QuerySuperDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySuperDeviceGroupResponse querySuperDeviceGroupResponse = new QuerySuperDeviceGroupResponse();

			querySuperDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			querySuperDeviceGroupResponse.RequestId = _ctx.StringValue("QuerySuperDeviceGroup.RequestId");
			querySuperDeviceGroupResponse.Success = _ctx.BooleanValue("QuerySuperDeviceGroup.Success");
			querySuperDeviceGroupResponse.Code = _ctx.StringValue("QuerySuperDeviceGroup.Code");
			querySuperDeviceGroupResponse.ErrorMessage = _ctx.StringValue("QuerySuperDeviceGroup.ErrorMessage");

			List<QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo> querySuperDeviceGroupResponse_data = new List<QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo>();
			for (int i = 0; i < _ctx.Length("QuerySuperDeviceGroup.Data.Length"); i++) {
				QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo groupInfo = new QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo();
				groupInfo.GroupId = _ctx.StringValue("QuerySuperDeviceGroup.Data["+ i +"].GroupId");
				groupInfo.GroupName = _ctx.StringValue("QuerySuperDeviceGroup.Data["+ i +"].GroupName");
				groupInfo.GroupDesc = _ctx.StringValue("QuerySuperDeviceGroup.Data["+ i +"].GroupDesc");

				querySuperDeviceGroupResponse_data.Add(groupInfo);
			}
			querySuperDeviceGroupResponse.Data = querySuperDeviceGroupResponse_data;
        
			return querySuperDeviceGroupResponse;
        }
    }
}
