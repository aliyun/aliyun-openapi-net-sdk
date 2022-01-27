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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeQuotaResponseUnmarshaller
    {
        public static DescribeQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeQuotaResponse describeQuotaResponse = new DescribeQuotaResponse();

			describeQuotaResponse.HttpResponse = _ctx.HttpResponse;
			describeQuotaResponse.Code = _ctx.StringValue("DescribeQuota.code");
			describeQuotaResponse.Message = _ctx.StringValue("DescribeQuota.message");
			describeQuotaResponse.RequestId = _ctx.StringValue("DescribeQuota.requestId");

			DescribeQuotaResponse.DescribeQuota_Result result = new DescribeQuotaResponse.DescribeQuota_Result();
			result.CurrentQps = _ctx.IntegerValue("DescribeQuota.Result.currentQps");
			result.ItemCount = _ctx.LongValue("DescribeQuota.Result.itemCount");
			result.ItemCountUsed = _ctx.LongValue("DescribeQuota.Result.itemCountUsed");
			result.Qps = _ctx.IntegerValue("DescribeQuota.Result.qps");
			result.UserCount = _ctx.LongValue("DescribeQuota.Result.userCount");
			result.UserCountUsed = _ctx.LongValue("DescribeQuota.Result.userCountUsed");
			describeQuotaResponse.Result = result;
        
			return describeQuotaResponse;
        }
    }
}
