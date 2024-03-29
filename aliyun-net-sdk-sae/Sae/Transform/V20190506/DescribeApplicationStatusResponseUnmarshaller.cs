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
        public static DescribeApplicationStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationStatusResponse describeApplicationStatusResponse = new DescribeApplicationStatusResponse();

			describeApplicationStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationStatusResponse.RequestId = _ctx.StringValue("DescribeApplicationStatus.RequestId");
			describeApplicationStatusResponse.Message = _ctx.StringValue("DescribeApplicationStatus.Message");
			describeApplicationStatusResponse.TraceId = _ctx.StringValue("DescribeApplicationStatus.TraceId");
			describeApplicationStatusResponse.ErrorCode = _ctx.StringValue("DescribeApplicationStatus.ErrorCode");
			describeApplicationStatusResponse.Code = _ctx.StringValue("DescribeApplicationStatus.Code");
			describeApplicationStatusResponse.Success = _ctx.BooleanValue("DescribeApplicationStatus.Success");

			DescribeApplicationStatusResponse.DescribeApplicationStatus_Data data = new DescribeApplicationStatusResponse.DescribeApplicationStatus_Data();
			data.ArmsAdvancedEnabled = _ctx.StringValue("DescribeApplicationStatus.Data.ArmsAdvancedEnabled");
			data.LastChangeOrderId = _ctx.StringValue("DescribeApplicationStatus.Data.LastChangeOrderId");
			data.ArmsApmInfo = _ctx.StringValue("DescribeApplicationStatus.Data.ArmsApmInfo");
			data.CreateTime = _ctx.StringValue("DescribeApplicationStatus.Data.CreateTime");
			data.CurrentStatus = _ctx.StringValue("DescribeApplicationStatus.Data.CurrentStatus");
			data.AppId = _ctx.StringValue("DescribeApplicationStatus.Data.AppId");
			data.LastChangeOrderRunning = _ctx.BooleanValue("DescribeApplicationStatus.Data.LastChangeOrderRunning");
			data.RunningInstances = _ctx.IntegerValue("DescribeApplicationStatus.Data.RunningInstances");
			data.LastChangeOrderStatus = _ctx.StringValue("DescribeApplicationStatus.Data.LastChangeOrderStatus");
			data.SubStatus = _ctx.StringValue("DescribeApplicationStatus.Data.SubStatus");
			data.EnableAgent = _ctx.BooleanValue("DescribeApplicationStatus.Data.EnableAgent");
			data.FileSizeLimit = _ctx.LongValue("DescribeApplicationStatus.Data.FileSizeLimit");
			describeApplicationStatusResponse.Data = data;
        
			return describeApplicationStatusResponse;
        }
    }
}
