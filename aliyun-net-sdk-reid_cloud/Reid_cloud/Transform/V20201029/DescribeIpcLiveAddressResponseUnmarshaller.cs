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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeIpcLiveAddressResponseUnmarshaller
    {
        public static DescribeIpcLiveAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpcLiveAddressResponse describeIpcLiveAddressResponse = new DescribeIpcLiveAddressResponse();

			describeIpcLiveAddressResponse.HttpResponse = _ctx.HttpResponse;
			describeIpcLiveAddressResponse.ErrorCode = _ctx.StringValue("DescribeIpcLiveAddress.ErrorCode");
			describeIpcLiveAddressResponse.RtmpUrl = _ctx.StringValue("DescribeIpcLiveAddress.RtmpUrl");
			describeIpcLiveAddressResponse.ErrorMessage = _ctx.StringValue("DescribeIpcLiveAddress.ErrorMessage");
			describeIpcLiveAddressResponse.Message = _ctx.StringValue("DescribeIpcLiveAddress.Message");
			describeIpcLiveAddressResponse.Code = _ctx.StringValue("DescribeIpcLiveAddress.Code");
			describeIpcLiveAddressResponse.DynamicCode = _ctx.StringValue("DescribeIpcLiveAddress.DynamicCode");
			describeIpcLiveAddressResponse.ExpiredTime = _ctx.StringValue("DescribeIpcLiveAddress.ExpiredTime");
			describeIpcLiveAddressResponse.RequestId = _ctx.StringValue("DescribeIpcLiveAddress.RequestId");
			describeIpcLiveAddressResponse.Success = _ctx.BooleanValue("DescribeIpcLiveAddress.Success");
			describeIpcLiveAddressResponse.DynamicMessage = _ctx.StringValue("DescribeIpcLiveAddress.DynamicMessage");
			describeIpcLiveAddressResponse.IpcId = _ctx.LongValue("DescribeIpcLiveAddress.IpcId");
        
			return describeIpcLiveAddressResponse;
        }
    }
}
