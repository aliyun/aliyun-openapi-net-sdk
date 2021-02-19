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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeApDevicesResponseUnmarshaller
    {
        public static DescribeApDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApDevicesResponse describeApDevicesResponse = new DescribeApDevicesResponse();

			describeApDevicesResponse.HttpResponse = _ctx.HttpResponse;
			describeApDevicesResponse.ErrorMessage = _ctx.StringValue("DescribeApDevices.ErrorMessage");
			describeApDevicesResponse.ErrorCode = _ctx.StringValue("DescribeApDevices.ErrorCode");
			describeApDevicesResponse.TotalCount = _ctx.IntegerValue("DescribeApDevices.TotalCount");
			describeApDevicesResponse.Message = _ctx.StringValue("DescribeApDevices.Message");
			describeApDevicesResponse.PageSize = _ctx.IntegerValue("DescribeApDevices.PageSize");
			describeApDevicesResponse.DynamicCode = _ctx.StringValue("DescribeApDevices.DynamicCode");
			describeApDevicesResponse.Code = _ctx.StringValue("DescribeApDevices.Code");
			describeApDevicesResponse.DynamicMessage = _ctx.StringValue("DescribeApDevices.DynamicMessage");
			describeApDevicesResponse.RequestId = _ctx.StringValue("DescribeApDevices.RequestId");
			describeApDevicesResponse.Success = _ctx.BooleanValue("DescribeApDevices.Success");
			describeApDevicesResponse.PageNumber = _ctx.IntegerValue("DescribeApDevices.PageNumber");

			List<DescribeApDevicesResponse.DescribeApDevices_ApInfo> describeApDevicesResponse_apDevices = new List<DescribeApDevicesResponse.DescribeApDevices_ApInfo>();
			for (int i = 0; i < _ctx.Length("DescribeApDevices.ApDevices.Length"); i++) {
				DescribeApDevicesResponse.DescribeApDevices_ApInfo apInfo = new DescribeApDevicesResponse.DescribeApDevices_ApInfo();
				apInfo.Mac = _ctx.StringValue("DescribeApDevices.ApDevices["+ i +"].Mac");
				apInfo.Status = _ctx.BooleanValue("DescribeApDevices.ApDevices["+ i +"].Status");
				apInfo.Model = _ctx.StringValue("DescribeApDevices.ApDevices["+ i +"].Model");
				apInfo.Remark = _ctx.StringValue("DescribeApDevices.ApDevices["+ i +"].Remark");
				apInfo.StoreId = _ctx.StringValue("DescribeApDevices.ApDevices["+ i +"].StoreId");
				apInfo.BeActivate = _ctx.BooleanValue("DescribeApDevices.ApDevices["+ i +"].BeActivate");

				describeApDevicesResponse_apDevices.Add(apInfo);
			}
			describeApDevicesResponse.ApDevices = describeApDevicesResponse_apDevices;
        
			return describeApDevicesResponse;
        }
    }
}
