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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class DescribeEdgeStatInfoResponseUnmarshaller
    {
        public static DescribeEdgeStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEdgeStatInfoResponse describeEdgeStatInfoResponse = new DescribeEdgeStatInfoResponse();

			describeEdgeStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeEdgeStatInfoResponse.Code = _ctx.StringValue("DescribeEdgeStatInfo.Code");
			describeEdgeStatInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeEdgeStatInfo.HttpStatusCode");
			describeEdgeStatInfoResponse.Message = _ctx.StringValue("DescribeEdgeStatInfo.Message");
			describeEdgeStatInfoResponse.RequestId = _ctx.StringValue("DescribeEdgeStatInfo.RequestId");
			describeEdgeStatInfoResponse.Success = _ctx.BooleanValue("DescribeEdgeStatInfo.Success");

			DescribeEdgeStatInfoResponse.DescribeEdgeStatInfo_Data data = new DescribeEdgeStatInfoResponse.DescribeEdgeStatInfo_Data();
			data.TotalDeviceLicenseCount = _ctx.LongValue("DescribeEdgeStatInfo.Data.TotalDeviceLicenseCount");
			data.UsedDeviceLicenseCount = _ctx.LongValue("DescribeEdgeStatInfo.Data.UsedDeviceLicenseCount");
			describeEdgeStatInfoResponse.Data = data;
        
			return describeEdgeStatInfoResponse;
        }
    }
}
