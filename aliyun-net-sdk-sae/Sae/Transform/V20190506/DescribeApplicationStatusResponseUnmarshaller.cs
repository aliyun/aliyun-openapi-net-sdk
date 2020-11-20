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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeApplicationStatusResponseUnmarshaller
    {
        public static DescribeApplicationStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApplicationStatusResponse describeApplicationStatusResponse = new DescribeApplicationStatusResponse();

			describeApplicationStatusResponse.HttpResponse = context.HttpResponse;
			describeApplicationStatusResponse.RequestId = context.StringValue("DescribeApplicationStatus.RequestId");
			describeApplicationStatusResponse.Code = context.StringValue("DescribeApplicationStatus.Code");
			describeApplicationStatusResponse.Message = context.StringValue("DescribeApplicationStatus.Message");
			describeApplicationStatusResponse.TraceId = context.StringValue("DescribeApplicationStatus.TraceId");
			describeApplicationStatusResponse.Success = context.BooleanValue("DescribeApplicationStatus.Success");
			describeApplicationStatusResponse.ErrorCode = context.StringValue("DescribeApplicationStatus.ErrorCode");

			DescribeApplicationStatusResponse.DescribeApplicationStatus_Data data = new DescribeApplicationStatusResponse.DescribeApplicationStatus_Data();
			data.AppId = context.StringValue("DescribeApplicationStatus.Data.AppId");
			data.LastChangeOrderId = context.StringValue("DescribeApplicationStatus.Data.LastChangeOrderId");
			data.LastChangeOrderStatus = context.StringValue("DescribeApplicationStatus.Data.LastChangeOrderStatus");
			data.LastChangeOrderRunning = context.BooleanValue("DescribeApplicationStatus.Data.LastChangeOrderRunning");
			data.CurrentStatus = context.StringValue("DescribeApplicationStatus.Data.CurrentStatus");
			data.ArmsApmInfo = context.StringValue("DescribeApplicationStatus.Data.ArmsApmInfo");
			data.RunningInstances = context.IntegerValue("DescribeApplicationStatus.Data.RunningInstances");
			data.ArmsAdvancedEnabled = context.StringValue("DescribeApplicationStatus.Data.ArmsAdvancedEnabled");
			data.CreateTime = context.StringValue("DescribeApplicationStatus.Data.CreateTime");
			describeApplicationStatusResponse.Data = data;
        
			return describeApplicationStatusResponse;
        }
    }
}
