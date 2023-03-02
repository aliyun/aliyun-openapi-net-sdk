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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class DescribeCapacityInfoResponseUnmarshaller
    {
        public static DescribeCapacityInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCapacityInfoResponse describeCapacityInfoResponse = new DescribeCapacityInfoResponse();

			describeCapacityInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeCapacityInfoResponse.Code = _ctx.IntegerValue("DescribeCapacityInfo.Code");
			describeCapacityInfoResponse.Message = _ctx.StringValue("DescribeCapacityInfo.Message");
			describeCapacityInfoResponse.RequestId = _ctx.StringValue("DescribeCapacityInfo.RequestId");
			describeCapacityInfoResponse.Success = _ctx.BooleanValue("DescribeCapacityInfo.Success");

			DescribeCapacityInfoResponse.DescribeCapacityInfo_Data data = new DescribeCapacityInfoResponse.DescribeCapacityInfo_Data();
			data.CountQuota = _ctx.LongValue("DescribeCapacityInfo.Data.CountQuota");
			data.CapacityQuota = _ctx.LongValue("DescribeCapacityInfo.Data.CapacityQuota");
			data.UsedCount = _ctx.LongValue("DescribeCapacityInfo.Data.UsedCount");
			data.UsedCapacity = _ctx.LongValue("DescribeCapacityInfo.Data.UsedCapacity");
			data.MemberUsedCapacity = _ctx.LongValue("DescribeCapacityInfo.Data.MemberUsedCapacity");
			data.MemberUsedCount = _ctx.LongValue("DescribeCapacityInfo.Data.MemberUsedCount");
			describeCapacityInfoResponse.Data = data;
        
			return describeCapacityInfoResponse;
        }
    }
}
