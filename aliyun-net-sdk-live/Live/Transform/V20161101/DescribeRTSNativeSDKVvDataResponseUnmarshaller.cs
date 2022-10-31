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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRTSNativeSDKVvDataResponseUnmarshaller
    {
        public static DescribeRTSNativeSDKVvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRTSNativeSDKVvDataResponse describeRTSNativeSDKVvDataResponse = new DescribeRTSNativeSDKVvDataResponse();

			describeRTSNativeSDKVvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeRTSNativeSDKVvDataResponse.RequestId = _ctx.StringValue("DescribeRTSNativeSDKVvData.RequestId");
			describeRTSNativeSDKVvDataResponse.DataInterval = _ctx.StringValue("DescribeRTSNativeSDKVvData.DataInterval");
			describeRTSNativeSDKVvDataResponse.StartTime = _ctx.StringValue("DescribeRTSNativeSDKVvData.StartTime");
			describeRTSNativeSDKVvDataResponse.EndTime = _ctx.StringValue("DescribeRTSNativeSDKVvData.EndTime");

			List<DescribeRTSNativeSDKVvDataResponse.DescribeRTSNativeSDKVvData_Data> describeRTSNativeSDKVvDataResponse_vvData = new List<DescribeRTSNativeSDKVvDataResponse.DescribeRTSNativeSDKVvData_Data>();
			for (int i = 0; i < _ctx.Length("DescribeRTSNativeSDKVvData.VvData.Length"); i++) {
				DescribeRTSNativeSDKVvDataResponse.DescribeRTSNativeSDKVvData_Data data = new DescribeRTSNativeSDKVvDataResponse.DescribeRTSNativeSDKVvData_Data();
				data.TimeStamp = _ctx.StringValue("DescribeRTSNativeSDKVvData.VvData["+ i +"].TimeStamp");
				data.VvTotal = _ctx.StringValue("DescribeRTSNativeSDKVvData.VvData["+ i +"].VvTotal");
				data.VvSuccess = _ctx.StringValue("DescribeRTSNativeSDKVvData.VvData["+ i +"].VvSuccess");

				describeRTSNativeSDKVvDataResponse_vvData.Add(data);
			}
			describeRTSNativeSDKVvDataResponse.VvData = describeRTSNativeSDKVvDataResponse_vvData;
        
			return describeRTSNativeSDKVvDataResponse;
        }
    }
}
