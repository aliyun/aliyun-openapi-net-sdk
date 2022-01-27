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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeWebAccessLogDispatchStatusResponseUnmarshaller
    {
        public static DescribeWebAccessLogDispatchStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebAccessLogDispatchStatusResponse describeWebAccessLogDispatchStatusResponse = new DescribeWebAccessLogDispatchStatusResponse();

			describeWebAccessLogDispatchStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeWebAccessLogDispatchStatusResponse.RequestId = _ctx.StringValue("DescribeWebAccessLogDispatchStatus.RequestId");
			describeWebAccessLogDispatchStatusResponse.TotalCount = _ctx.IntegerValue("DescribeWebAccessLogDispatchStatus.TotalCount");

			List<DescribeWebAccessLogDispatchStatusResponse.DescribeWebAccessLogDispatchStatus_SlsConfigStatusItem> describeWebAccessLogDispatchStatusResponse_slsConfigStatus = new List<DescribeWebAccessLogDispatchStatusResponse.DescribeWebAccessLogDispatchStatus_SlsConfigStatusItem>();
			for (int i = 0; i < _ctx.Length("DescribeWebAccessLogDispatchStatus.SlsConfigStatus.Length"); i++) {
				DescribeWebAccessLogDispatchStatusResponse.DescribeWebAccessLogDispatchStatus_SlsConfigStatusItem slsConfigStatusItem = new DescribeWebAccessLogDispatchStatusResponse.DescribeWebAccessLogDispatchStatus_SlsConfigStatusItem();
				slsConfigStatusItem.Enable = _ctx.BooleanValue("DescribeWebAccessLogDispatchStatus.SlsConfigStatus["+ i +"].Enable");
				slsConfigStatusItem.Domain = _ctx.StringValue("DescribeWebAccessLogDispatchStatus.SlsConfigStatus["+ i +"].Domain");

				describeWebAccessLogDispatchStatusResponse_slsConfigStatus.Add(slsConfigStatusItem);
			}
			describeWebAccessLogDispatchStatusResponse.SlsConfigStatus = describeWebAccessLogDispatchStatusResponse_slsConfigStatus;
        
			return describeWebAccessLogDispatchStatusResponse;
        }
    }
}
