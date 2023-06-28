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
    public class QueryDeviceProvisioningResponseUnmarshaller
    {
        public static QueryDeviceProvisioningResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceProvisioningResponse queryDeviceProvisioningResponse = new QueryDeviceProvisioningResponse();

			queryDeviceProvisioningResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceProvisioningResponse.RequestId = _ctx.StringValue("QueryDeviceProvisioning.RequestId");
			queryDeviceProvisioningResponse.Success = _ctx.BooleanValue("QueryDeviceProvisioning.Success");
			queryDeviceProvisioningResponse.Code = _ctx.StringValue("QueryDeviceProvisioning.Code");
			queryDeviceProvisioningResponse.ErrorMessage = _ctx.StringValue("QueryDeviceProvisioning.ErrorMessage");

			QueryDeviceProvisioningResponse.QueryDeviceProvisioning_Data data = new QueryDeviceProvisioningResponse.QueryDeviceProvisioning_Data();
			data.GmtCreate = _ctx.LongValue("QueryDeviceProvisioning.Data.GmtCreate");
			data.GmtModified = _ctx.LongValue("QueryDeviceProvisioning.Data.GmtModified");
			data.AliyunUid = _ctx.StringValue("QueryDeviceProvisioning.Data.AliyunUid");
			data.ProductKey = _ctx.StringValue("QueryDeviceProvisioning.Data.ProductKey");
			data.DeviceName = _ctx.StringValue("QueryDeviceProvisioning.Data.DeviceName");
			data.SourceIotInstanceId = _ctx.StringValue("QueryDeviceProvisioning.Data.SourceIotInstanceId");
			data.TargetIotInstanceId = _ctx.StringValue("QueryDeviceProvisioning.Data.TargetIotInstanceId");
			data.SourceRegion = _ctx.StringValue("QueryDeviceProvisioning.Data.SourceRegion");
			data.TargetRegion = _ctx.StringValue("QueryDeviceProvisioning.Data.TargetRegion");
			queryDeviceProvisioningResponse.Data = data;
        
			return queryDeviceProvisioningResponse;
        }
    }
}
