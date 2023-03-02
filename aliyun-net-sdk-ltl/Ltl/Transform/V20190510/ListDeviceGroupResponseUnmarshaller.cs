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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ListDeviceGroupResponseUnmarshaller
    {
        public static ListDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceGroupResponse listDeviceGroupResponse = new ListDeviceGroupResponse();

			listDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceGroupResponse.Code = _ctx.IntegerValue("ListDeviceGroup.Code");
			listDeviceGroupResponse.Message = _ctx.StringValue("ListDeviceGroup.Message");
			listDeviceGroupResponse.RequestId = _ctx.StringValue("ListDeviceGroup.RequestId");
			listDeviceGroupResponse.Success = _ctx.BooleanValue("ListDeviceGroup.Success");

			ListDeviceGroupResponse.ListDeviceGroup_Data data = new ListDeviceGroupResponse.ListDeviceGroup_Data();
			data.Num = _ctx.IntegerValue("ListDeviceGroup.Data.Num");
			data.Total = _ctx.IntegerValue("ListDeviceGroup.Data.Total");
			data.Size = _ctx.IntegerValue("ListDeviceGroup.Data.Size");

			List<ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_DeviceGroupInfo> data_pageData = new List<ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_DeviceGroupInfo>();
			for (int i = 0; i < _ctx.Length("ListDeviceGroup.Data.PageData.Length"); i++) {
				ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_DeviceGroupInfo deviceGroupInfo = new ListDeviceGroupResponse.ListDeviceGroup_Data.ListDeviceGroup_DeviceGroupInfo();
				deviceGroupInfo.Status = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].Status");
				deviceGroupInfo.DeviceGroupId = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].DeviceGroupId");
				deviceGroupInfo.ProductKey = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].ProductKey");
				deviceGroupInfo.Remark = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].Remark");
				deviceGroupInfo.AuthorizeType = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].AuthorizeType");
				deviceGroupInfo.OwnerName = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].OwnerName");
				deviceGroupInfo.OwnerUid = _ctx.StringValue("ListDeviceGroup.Data.PageData["+ i +"].OwnerUid");

				data_pageData.Add(deviceGroupInfo);
			}
			data.PageData = data_pageData;
			listDeviceGroupResponse.Data = data;
        
			return listDeviceGroupResponse;
        }
    }
}
