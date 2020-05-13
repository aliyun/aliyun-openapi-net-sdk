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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeIpcLiveAddressResponseUnmarshaller
    {
        public static DescribeIpcLiveAddressResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpcLiveAddressResponse describeIpcLiveAddressResponse = new DescribeIpcLiveAddressResponse();

			describeIpcLiveAddressResponse.HttpResponse = context.HttpResponse;
			describeIpcLiveAddressResponse.RtmpUrl = context.StringValue("DescribeIpcLiveAddress.RtmpUrl");
			describeIpcLiveAddressResponse.ErrorCode = context.StringValue("DescribeIpcLiveAddress.ErrorCode");
			describeIpcLiveAddressResponse.ErrorMessage = context.StringValue("DescribeIpcLiveAddress.ErrorMessage");
			describeIpcLiveAddressResponse.Message = context.StringValue("DescribeIpcLiveAddress.Message");
			describeIpcLiveAddressResponse.Code = context.StringValue("DescribeIpcLiveAddress.Code");
			describeIpcLiveAddressResponse.ExpiredTime = context.StringValue("DescribeIpcLiveAddress.ExpiredTime");
			describeIpcLiveAddressResponse.DynamicCode = context.StringValue("DescribeIpcLiveAddress.DynamicCode");
			describeIpcLiveAddressResponse.RequestId = context.StringValue("DescribeIpcLiveAddress.RequestId");
			describeIpcLiveAddressResponse.Success = context.BooleanValue("DescribeIpcLiveAddress.Success");
			describeIpcLiveAddressResponse.IpcId = context.LongValue("DescribeIpcLiveAddress.IpcId");
			describeIpcLiveAddressResponse.DynamicMessage = context.StringValue("DescribeIpcLiveAddress.DynamicMessage");
        
			return describeIpcLiveAddressResponse;
        }
    }
}
