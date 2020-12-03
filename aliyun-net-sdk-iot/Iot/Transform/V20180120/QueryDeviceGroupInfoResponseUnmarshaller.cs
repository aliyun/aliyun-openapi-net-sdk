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
    public class QueryDeviceGroupInfoResponseUnmarshaller
    {
        public static QueryDeviceGroupInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceGroupInfoResponse queryDeviceGroupInfoResponse = new QueryDeviceGroupInfoResponse();

			queryDeviceGroupInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceGroupInfoResponse.RequestId = _ctx.StringValue("QueryDeviceGroupInfo.RequestId");
			queryDeviceGroupInfoResponse.Success = _ctx.BooleanValue("QueryDeviceGroupInfo.Success");
			queryDeviceGroupInfoResponse.Code = _ctx.StringValue("QueryDeviceGroupInfo.Code");
			queryDeviceGroupInfoResponse.ErrorMessage = _ctx.StringValue("QueryDeviceGroupInfo.ErrorMessage");

			QueryDeviceGroupInfoResponse.QueryDeviceGroupInfo_Data data = new QueryDeviceGroupInfoResponse.QueryDeviceGroupInfo_Data();
			data.GroupId = _ctx.StringValue("QueryDeviceGroupInfo.Data.GroupId");
			data.UtcCreate = _ctx.StringValue("QueryDeviceGroupInfo.Data.UtcCreate");
			data.GroupName = _ctx.StringValue("QueryDeviceGroupInfo.Data.GroupName");
			data.GroupDesc = _ctx.StringValue("QueryDeviceGroupInfo.Data.GroupDesc");
			data.DeviceCount = _ctx.IntegerValue("QueryDeviceGroupInfo.Data.DeviceCount");
			data.DeviceActive = _ctx.IntegerValue("QueryDeviceGroupInfo.Data.DeviceActive");
			data.DeviceOnline = _ctx.IntegerValue("QueryDeviceGroupInfo.Data.DeviceOnline");
			queryDeviceGroupInfoResponse.Data = data;
        
			return queryDeviceGroupInfoResponse;
        }
    }
}
