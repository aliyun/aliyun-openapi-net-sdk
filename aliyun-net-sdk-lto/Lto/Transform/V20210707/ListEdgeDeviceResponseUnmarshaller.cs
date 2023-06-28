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
    public class ListEdgeDeviceResponseUnmarshaller
    {
        public static ListEdgeDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEdgeDeviceResponse listEdgeDeviceResponse = new ListEdgeDeviceResponse();

			listEdgeDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listEdgeDeviceResponse.Code = _ctx.StringValue("ListEdgeDevice.Code");
			listEdgeDeviceResponse.HttpStatusCode = _ctx.IntegerValue("ListEdgeDevice.HttpStatusCode");
			listEdgeDeviceResponse.Message = _ctx.StringValue("ListEdgeDevice.Message");
			listEdgeDeviceResponse.RequestId = _ctx.StringValue("ListEdgeDevice.RequestId");
			listEdgeDeviceResponse.Success = _ctx.BooleanValue("ListEdgeDevice.Success");

			ListEdgeDeviceResponse.ListEdgeDevice_Data data = new ListEdgeDeviceResponse.ListEdgeDevice_Data();
			data.Num = _ctx.IntegerValue("ListEdgeDevice.Data.Num");
			data.Total = _ctx.IntegerValue("ListEdgeDevice.Data.Total");
			data.Size = _ctx.IntegerValue("ListEdgeDevice.Data.Size");

			List<ListEdgeDeviceResponse.ListEdgeDevice_Data.ListEdgeDevice_MemberInfo> data_pageData = new List<ListEdgeDeviceResponse.ListEdgeDevice_Data.ListEdgeDevice_MemberInfo>();
			for (int i = 0; i < _ctx.Length("ListEdgeDevice.Data.PageData.Length"); i++) {
				ListEdgeDeviceResponse.ListEdgeDevice_Data.ListEdgeDevice_MemberInfo memberInfo = new ListEdgeDeviceResponse.ListEdgeDevice_Data.ListEdgeDevice_MemberInfo();
				memberInfo.Status = _ctx.StringValue("ListEdgeDevice.Data.PageData["+ i +"].Status");
				memberInfo.LastOnchainTime = _ctx.StringValue("ListEdgeDevice.Data.PageData["+ i +"].LastOnchainTime");
				memberInfo.UsedOnchainCount = _ctx.LongValue("ListEdgeDevice.Data.PageData["+ i +"].UsedOnchainCount");
				memberInfo.Name = _ctx.StringValue("ListEdgeDevice.Data.PageData["+ i +"].Name");
				memberInfo.DeviceId = _ctx.StringValue("ListEdgeDevice.Data.PageData["+ i +"].DeviceId");

				data_pageData.Add(memberInfo);
			}
			data.PageData = data_pageData;
			listEdgeDeviceResponse.Data = data;
        
			return listEdgeDeviceResponse;
        }
    }
}
