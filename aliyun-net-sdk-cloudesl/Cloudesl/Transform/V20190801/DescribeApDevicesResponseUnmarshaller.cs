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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class DescribeApDevicesResponseUnmarshaller
    {
        public static DescribeApDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApDevicesResponse describeApDevicesResponse = new DescribeApDevicesResponse();

			describeApDevicesResponse.HttpResponse = context.HttpResponse;
			describeApDevicesResponse.ErrorMessage = context.StringValue("DescribeApDevices.ErrorMessage");
			describeApDevicesResponse.ErrorCode = context.StringValue("DescribeApDevices.ErrorCode");
			describeApDevicesResponse.TotalCount = context.IntegerValue("DescribeApDevices.TotalCount");
			describeApDevicesResponse.Message = context.StringValue("DescribeApDevices.Message");
			describeApDevicesResponse.PageSize = context.IntegerValue("DescribeApDevices.PageSize");
			describeApDevicesResponse.DynamicCode = context.StringValue("DescribeApDevices.DynamicCode");
			describeApDevicesResponse.Code = context.StringValue("DescribeApDevices.Code");
			describeApDevicesResponse.DynamicMessage = context.StringValue("DescribeApDevices.DynamicMessage");
			describeApDevicesResponse.RequestId = context.StringValue("DescribeApDevices.RequestId");
			describeApDevicesResponse.Success = context.BooleanValue("DescribeApDevices.Success");
			describeApDevicesResponse.PageNumber = context.IntegerValue("DescribeApDevices.PageNumber");

			List<DescribeApDevicesResponse.DescribeApDevices_ApInfo> describeApDevicesResponse_apDevices = new List<DescribeApDevicesResponse.DescribeApDevices_ApInfo>();
			for (int i = 0; i < context.Length("DescribeApDevices.ApDevices.Length"); i++) {
				DescribeApDevicesResponse.DescribeApDevices_ApInfo apInfo = new DescribeApDevicesResponse.DescribeApDevices_ApInfo();
				apInfo.IsActivate = context.BooleanValue("DescribeApDevices.ApDevices["+ i +"].IsActivate");
				apInfo.Mac = context.StringValue("DescribeApDevices.ApDevices["+ i +"].Mac");
				apInfo.Status = context.BooleanValue("DescribeApDevices.ApDevices["+ i +"].Status");
				apInfo.Model = context.StringValue("DescribeApDevices.ApDevices["+ i +"].Model");

				describeApDevicesResponse_apDevices.Add(apInfo);
			}
			describeApDevicesResponse.ApDevices = describeApDevicesResponse_apDevices;
        
			return describeApDevicesResponse;
        }
    }
}
