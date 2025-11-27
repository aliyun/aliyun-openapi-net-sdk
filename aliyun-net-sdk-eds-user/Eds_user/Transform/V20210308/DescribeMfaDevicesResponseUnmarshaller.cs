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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class DescribeMfaDevicesResponseUnmarshaller
    {
        public static DescribeMfaDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMfaDevicesResponse describeMfaDevicesResponse = new DescribeMfaDevicesResponse();

			describeMfaDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeMfaDevicesResponse.RequestId = _ctx.StringValue("DescribeMfaDevices.RequestId");
			describeMfaDevicesResponse.NextToken = _ctx.StringValue("DescribeMfaDevices.NextToken");

			List<DescribeMfaDevicesResponse.DescribeMfaDevices_Data> describeMfaDevicesResponse_mfaDevices = new List<DescribeMfaDevicesResponse.DescribeMfaDevices_Data>();
			for (int i = 0; i < _ctx.Length("DescribeMfaDevices.MfaDevices.Length"); i++) {
				DescribeMfaDevicesResponse.DescribeMfaDevices_Data data = new DescribeMfaDevicesResponse.DescribeMfaDevices_Data();
				data.Id = _ctx.LongValue("DescribeMfaDevices.MfaDevices["+ i +"].Id");
				data.EndUserId = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].EndUserId");
				data.Email = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].Email");
				data.GmtEnabled = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].GmtEnabled");
				data.GmtUnlock = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].GmtUnlock");
				data.ConsecutiveFails = _ctx.IntegerValue("DescribeMfaDevices.MfaDevices["+ i +"].ConsecutiveFails");
				data.SerialNumber = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].SerialNumber");
				data.Status = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].Status");
				data.DeviceType = _ctx.StringValue("DescribeMfaDevices.MfaDevices["+ i +"].DeviceType");

				describeMfaDevicesResponse_mfaDevices.Add(data);
			}
			describeMfaDevicesResponse.MfaDevices = describeMfaDevicesResponse_mfaDevices;
        
			return describeMfaDevicesResponse;
        }
    }
}
