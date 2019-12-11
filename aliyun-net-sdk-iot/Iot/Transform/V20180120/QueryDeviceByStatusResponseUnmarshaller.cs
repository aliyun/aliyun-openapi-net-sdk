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
        public static QueryDeviceByStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceByStatusResponse queryDeviceByStatusResponse = new QueryDeviceByStatusResponse();

			queryDeviceByStatusResponse.HttpResponse = context.HttpResponse;
			queryDeviceByStatusResponse.RequestId = context.StringValue("QueryDeviceByStatus.RequestId");
			queryDeviceByStatusResponse.Success = context.BooleanValue("QueryDeviceByStatus.Success");
			queryDeviceByStatusResponse.Code = context.StringValue("QueryDeviceByStatus.Code");
			queryDeviceByStatusResponse.ErrorMessage = context.StringValue("QueryDeviceByStatus.ErrorMessage");
			queryDeviceByStatusResponse.Page = context.IntegerValue("QueryDeviceByStatus.Page");
			queryDeviceByStatusResponse.PageSize = context.IntegerValue("QueryDeviceByStatus.PageSize");
			queryDeviceByStatusResponse.PageCount = context.IntegerValue("QueryDeviceByStatus.PageCount");
			queryDeviceByStatusResponse.Total = context.IntegerValue("QueryDeviceByStatus.Total");

			List<QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo> queryDeviceByStatusResponse_data = new List<QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo>();
			for (int i = 0; i < context.Length("QueryDeviceByStatus.Data.Length"); i++) {
				QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo simpleDeviceInfo = new QueryDeviceByStatusResponse.QueryDeviceByStatus_SimpleDeviceInfo();
				simpleDeviceInfo.ProductKey = context.StringValue("QueryDeviceByStatus.Data["+ i +"].ProductKey");
				simpleDeviceInfo.DeviceName = context.StringValue("QueryDeviceByStatus.Data["+ i +"].DeviceName");
				simpleDeviceInfo.Status = context.StringValue("QueryDeviceByStatus.Data["+ i +"].Status");
				simpleDeviceInfo.IotId = context.StringValue("QueryDeviceByStatus.Data["+ i +"].IotId");
				simpleDeviceInfo.Nickname = context.StringValue("QueryDeviceByStatus.Data["+ i +"].Nickname");
				simpleDeviceInfo.GmtCreate = context.StringValue("QueryDeviceByStatus.Data["+ i +"].GmtCreate");
				simpleDeviceInfo.GmtModified = context.StringValue("QueryDeviceByStatus.Data["+ i +"].GmtModified");
				simpleDeviceInfo.UtcCreate = context.StringValue("QueryDeviceByStatus.Data["+ i +"].UtcCreate");
				simpleDeviceInfo.UtcModified = context.StringValue("QueryDeviceByStatus.Data["+ i +"].UtcModified");
				simpleDeviceInfo.DeviceSecret = context.StringValue("QueryDeviceByStatus.Data["+ i +"].DeviceSecret");

				queryDeviceByStatusResponse_data.Add(simpleDeviceInfo);
			}
			queryDeviceByStatusResponse.Data = queryDeviceByStatusResponse_data;
        
			return queryDeviceByStatusResponse;
        }
    }
}
