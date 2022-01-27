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
    public class QueryDeviceByStatusResponseUnmarshaller
    {
        public static QueryDeviceByStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceByStatusResponse queryDeviceByStatusResponse = new QueryDeviceByStatusResponse();

			queryDeviceByStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceByStatusResponse.RequestId = _ctx.StringValue("QueryDeviceByStatus.RequestId");
			queryDeviceByStatusResponse.Success = _ctx.BooleanValue("QueryDeviceByStatus.Success");
			queryDeviceByStatusResponse.Code = _ctx.StringValue("QueryDeviceByStatus.Code");
			queryDeviceByStatusResponse.ErrorMessage = _ctx.StringValue("QueryDeviceByStatus.ErrorMessage");
			queryDeviceByStatusResponse.Page = _ctx.IntegerValue("QueryDeviceByStatus.Page");
			queryDeviceByStatusResponse.PageSize = _ctx.IntegerValue("QueryDeviceByStatus.PageSize");
			queryDeviceByStatusResponse.PageCount = _ctx.IntegerValue("QueryDeviceByStatus.PageCount");
			queryDeviceByStatusResponse.Total = _ctx.IntegerValue("QueryDeviceByStatus.Total");

			List<QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo> queryDeviceByStatusResponse_data = new List<QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo>();
			for (int i = 0; i < _ctx.Length("QueryDeviceByStatus.Data.Length"); i++) {
				QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo simpleDeviceInfo = new QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo();
				simpleDeviceInfo.ProductKey = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].ProductKey");
				simpleDeviceInfo.DeviceName = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].DeviceName");
				simpleDeviceInfo.Status = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].Status");
				simpleDeviceInfo.IotId = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].IotId");
				simpleDeviceInfo.Nickname = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].Nickname");
				simpleDeviceInfo.GmtCreate = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].GmtCreate");
				simpleDeviceInfo.GmtModified = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].GmtModified");
				simpleDeviceInfo.UtcCreate = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].UtcCreate");
				simpleDeviceInfo.UtcModified = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].UtcModified");
				simpleDeviceInfo.DeviceSecret = _ctx.StringValue("QueryDeviceByStatus.Data["+ i +"].DeviceSecret");

				queryDeviceByStatusResponse_data.Add(simpleDeviceInfo);
			}
			queryDeviceByStatusResponse.Data = queryDeviceByStatusResponse_data;
        
			return queryDeviceByStatusResponse;
        }
    }
}
