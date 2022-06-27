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
    public class QueryImportedDeviceByApplyIdResponseUnmarshaller
    {
        public static QueryImportedDeviceByApplyIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryImportedDeviceByApplyIdResponse queryImportedDeviceByApplyIdResponse = new QueryImportedDeviceByApplyIdResponse();

			queryImportedDeviceByApplyIdResponse.HttpResponse = _ctx.HttpResponse;
			queryImportedDeviceByApplyIdResponse.RequestId = _ctx.StringValue("QueryImportedDeviceByApplyId.RequestId");
			queryImportedDeviceByApplyIdResponse.Success = _ctx.BooleanValue("QueryImportedDeviceByApplyId.Success");
			queryImportedDeviceByApplyIdResponse.Code = _ctx.StringValue("QueryImportedDeviceByApplyId.Code");
			queryImportedDeviceByApplyIdResponse.ErrorMessage = _ctx.StringValue("QueryImportedDeviceByApplyId.ErrorMessage");
			queryImportedDeviceByApplyIdResponse.PageNo = _ctx.IntegerValue("QueryImportedDeviceByApplyId.PageNo");
			queryImportedDeviceByApplyIdResponse.PageSize = _ctx.IntegerValue("QueryImportedDeviceByApplyId.PageSize");
			queryImportedDeviceByApplyIdResponse.TotalPage = _ctx.IntegerValue("QueryImportedDeviceByApplyId.TotalPage");
			queryImportedDeviceByApplyIdResponse.ProductKey = _ctx.StringValue("QueryImportedDeviceByApplyId.ProductKey");

			List<QueryImportedDeviceByApplyIdResponse.QueryImportedDeviceByApplyId_Device> queryImportedDeviceByApplyIdResponse_deviceList = new List<QueryImportedDeviceByApplyIdResponse.QueryImportedDeviceByApplyId_Device>();
			for (int i = 0; i < _ctx.Length("QueryImportedDeviceByApplyId.DeviceList.Length"); i++) {
				QueryImportedDeviceByApplyIdResponse.QueryImportedDeviceByApplyId_Device device = new QueryImportedDeviceByApplyIdResponse.QueryImportedDeviceByApplyId_Device();
				device.ProductKey = _ctx.StringValue("QueryImportedDeviceByApplyId.DeviceList["+ i +"].ProductKey");
				device.DeviceName = _ctx.StringValue("QueryImportedDeviceByApplyId.DeviceList["+ i +"].DeviceName");
				device.DeviceSecret = _ctx.StringValue("QueryImportedDeviceByApplyId.DeviceList["+ i +"].DeviceSecret");
				device.Sn = _ctx.StringValue("QueryImportedDeviceByApplyId.DeviceList["+ i +"].Sn");

				queryImportedDeviceByApplyIdResponse_deviceList.Add(device);
			}
			queryImportedDeviceByApplyIdResponse.DeviceList = queryImportedDeviceByApplyIdResponse_deviceList;
        
			return queryImportedDeviceByApplyIdResponse;
        }
    }
}
