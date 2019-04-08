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
        public static QuerySuperDeviceGroupResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySuperDeviceGroupResponse querySuperDeviceGroupResponse = new QuerySuperDeviceGroupResponse();

			querySuperDeviceGroupResponse.HttpResponse = context.HttpResponse;
			querySuperDeviceGroupResponse.RequestId = context.StringValue("QuerySuperDeviceGroup.RequestId");
			querySuperDeviceGroupResponse.Success = context.BooleanValue("QuerySuperDeviceGroup.Success");
			querySuperDeviceGroupResponse.Code = context.StringValue("QuerySuperDeviceGroup.Code");
			querySuperDeviceGroupResponse.ErrorMessage = context.StringValue("QuerySuperDeviceGroup.ErrorMessage");

			List<QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo> querySuperDeviceGroupResponse_data = new List<QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo>();
			for (int i = 0; i < context.Length("QuerySuperDeviceGroup.Data.Length"); i++) {
				QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo groupInfo = new QuerySuperDeviceGroupResponse.QuerySuperDeviceGroup_GroupInfo();
				groupInfo.GroupId = context.StringValue("QuerySuperDeviceGroup.Data["+ i +"].GroupId");
				groupInfo.GroupName = context.StringValue("QuerySuperDeviceGroup.Data["+ i +"].GroupName");
				groupInfo.GroupDesc = context.StringValue("QuerySuperDeviceGroup.Data["+ i +"].GroupDesc");

				querySuperDeviceGroupResponse_data.Add(groupInfo);
			}
			querySuperDeviceGroupResponse.Data = querySuperDeviceGroupResponse_data;
        
			return querySuperDeviceGroupResponse;
        }
    }
}
