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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListDeviceGroupResponseUnmarshaller
    {
        public static ListDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceGroupResponse listDeviceGroupResponse = new ListDeviceGroupResponse();

			listDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceGroupResponse.Code = _ctx.StringValue("ListDeviceGroup.Code");
			listDeviceGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListDeviceGroup.HttpStatusCode");
			listDeviceGroupResponse.Message = _ctx.StringValue("ListDeviceGroup.Message");
			listDeviceGroupResponse.RequestId = _ctx.StringValue("ListDeviceGroup.RequestId");
			listDeviceGroupResponse.Success = _ctx.BooleanValue("ListDeviceGroup.Success");

			ListDeviceGroupResponse.ListDeviceGroup_Data data = new ListDeviceGroupResponse.ListDeviceGroup_Data();
			data.Num = _ctx.IntegerValue("ListDeviceGroup.Data.Num");
			data.Total = _ctx.IntegerValue("ListDeviceGroup.Data.Total");
			data.Size = _ctx.IntegerValue("ListDeviceGroup.Data.Size");

			List<ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_MemberInfo> data_pageData = new List<ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListDeviceGroup.Data.PageData.Length"); i++) {
				ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_MemberInfo memberInfo = new ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_MemberInfo();
				memberInfo.Status = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].Status");
				memberInfo.CurrentUser = _ctx.BooleanValue("ListDeviceGroup.Data.PageData["+ i +"].CurrentUser");
				memberInfo.DeviceGroupId = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].DeviceGroupId");
				memberInfo.ProductKey = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].ProductKey");
				memberInfo.MemberName = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].MemberName");
				memberInfo.Remark = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].Remark");
				memberInfo.Name = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].Name");
				memberInfo.DeviceCount = _ctx.LongValue("ListDeviceGroup.Data.PageData["+ i +"].DeviceCount");
				memberInfo.AuthorizedCount = _ctx.IntegerValue("ListDeviceGroup.Data.PageData["+ i +"].AuthorizedCount");

				data_pageData.Add(memberInfo);
			}
			data.PageData = data_pageData;
			listDeviceGroupResponse.Data = data;
        
			return listDeviceGroupResponse;
        }
    }
}
