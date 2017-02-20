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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20160530;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class QueryDeviceResponseUnmarshaller
    {
        public static QueryDeviceResponse Unmarshall(UnmarshallerContext context)
        {
            QueryDeviceResponse queryDeviceResponse = new QueryDeviceResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryDevice.RequestId"),
                Success = context.BooleanValue("QueryDevice.Success"),
                ErrorMessage = context.StringValue("QueryDevice.ErrorMessage"),
                Total = context.IntegerValue("QueryDevice.Total"),
                PageSize = context.IntegerValue("QueryDevice.PageSize"),
                PageCount = context.IntegerValue("QueryDevice.PageCount"),
                Page = context.IntegerValue("QueryDevice.Page")
            };
            List<QueryDeviceResponse.DeviceInfo> data = new List<QueryDeviceResponse.DeviceInfo>();
			for (int i = 0; i < context.Length("QueryDevice.Data.Length"); i++) {
                QueryDeviceResponse.DeviceInfo deviceInfo = new QueryDeviceResponse.DeviceInfo()
                {
                    DeviceId = context.StringValue($"QueryDevice.Data[{i}].DeviceId"),
                    DeviceSecret = context.StringValue($"QueryDevice.Data[{i}].DeviceSecret"),
                    ProductKey = context.StringValue($"QueryDevice.Data[{i}].ProductKey"),
                    DeviceStatus = context.StringValue($"QueryDevice.Data[{i}].DeviceStatus"),
                    DeviceName = context.StringValue($"QueryDevice.Data[{i}].DeviceName"),
                    GmtCreate = context.StringValue($"QueryDevice.Data[{i}].GmtCreate"),
                    GmtModified = context.StringValue($"QueryDevice.Data[{i}].GmtModified")
                };
                data.Add(deviceInfo);
			}
			queryDeviceResponse.Data = data;
        
			return queryDeviceResponse;
        }
    }
}