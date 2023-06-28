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
    public class ListEdgeDeviceGroupResponseUnmarshaller
    {
        public static ListEdgeDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEdgeDeviceGroupResponse listEdgeDeviceGroupResponse = new ListEdgeDeviceGroupResponse();

			listEdgeDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			listEdgeDeviceGroupResponse.Code = _ctx.StringValue("ListEdgeDeviceGroup.Code");
			listEdgeDeviceGroupResponse.HttpStatusCode = _ctx.IntegerValue("ListEdgeDeviceGroup.HttpStatusCode");
			listEdgeDeviceGroupResponse.Message = _ctx.StringValue("ListEdgeDeviceGroup.Message");
			listEdgeDeviceGroupResponse.RequestId = _ctx.StringValue("ListEdgeDeviceGroup.RequestId");
			listEdgeDeviceGroupResponse.Success = _ctx.BooleanValue("ListEdgeDeviceGroup.Success");

			ListEdgeDeviceGroupResponse.ListEdgeDeviceGroup_Data data = new ListEdgeDeviceGroupResponse.ListEdgeDeviceGroup_Data();
			data.Num = _ctx.IntegerValue("ListEdgeDeviceGroup.Data.Num");
			data.Total = _ctx.IntegerValue("ListEdgeDeviceGroup.Data.Total");
			data.Size = _ctx.IntegerValue("ListEdgeDeviceGroup.Data.Size");

			List<ListEdgeDeviceGroupResponse.ListEdgeDeviceGroup_Data.ListEdgeDeviceGroup_MemberInfo> data_pageData = new List<ListEdgeDeviceGroupResponse.ListEdgeDeviceGroup_Data.ListEdgeDeviceGroup_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListEdgeDeviceGroup.Data.PageData.Length"); i++) {
				ListEdgeDeviceGroupResponse.ListEdgeDeviceGroup_Data.ListEdgeDeviceGroup_MemberInfo memberInfo = new ListEdgeDeviceGroupResponse.ListEdgeDeviceGroup_Data.ListEdgeDeviceGroup_MemberInfo();
				memberInfo.Status = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].Status");
				memberInfo.CurrentUser = _ctx.BooleanValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].CurrentUser");
				memberInfo.DeviceGroupId = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].DeviceGroupId");
				memberInfo.ProductKey = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].ProductKey");
				memberInfo.MemberName = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].MemberName");
				memberInfo.Remark = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].Remark");
				memberInfo.Name = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].Name");
				memberInfo.DeviceCount = _ctx.LongValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].DeviceCount");
				memberInfo.AuthorizedCount = _ctx.IntegerValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].AuthorizedCount");
				memberInfo.EdgeName = _ctx.StringValue("ListEdgeDeviceGroup.Data.PageData["+ i +"].EdgeName");

				data_pageData.Add(memberInfo);
			}
			data.PageData = data_pageData;
			listEdgeDeviceGroupResponse.Data = data;
        
			return listEdgeDeviceGroupResponse;
        }
    }
}
