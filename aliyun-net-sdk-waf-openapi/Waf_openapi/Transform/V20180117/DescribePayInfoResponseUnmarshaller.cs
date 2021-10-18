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
using Aliyun.Acs.waf_openapi.Model.V20180117;

namespace Aliyun.Acs.waf_openapi.Transform.V20180117
{
    public class DescribePayInfoResponseUnmarshaller
    {
        public static DescribePayInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePayInfoResponse describePayInfoResponse = new DescribePayInfoResponse();

			describePayInfoResponse.HttpResponse = _ctx.HttpResponse;
			describePayInfoResponse.RequestId = _ctx.StringValue("DescribePayInfo.RequestId");

			DescribePayInfoResponse.DescribePayInfo_Result result = new DescribePayInfoResponse.DescribePayInfo_Result();
			result.InDebt = _ctx.IntegerValue("DescribePayInfo.Result.InDebt");
			result.InstanceId = _ctx.StringValue("DescribePayInfo.Result.InstanceId");
			result.PayType = _ctx.IntegerValue("DescribePayInfo.Result.PayType");
			result.EndDate = _ctx.LongValue("DescribePayInfo.Result.EndDate");
			result.RemainDay = _ctx.IntegerValue("DescribePayInfo.Result.RemainDay");
			result.Region = _ctx.StringValue("DescribePayInfo.Result.Region");
			result.Trial = _ctx.IntegerValue("DescribePayInfo.Result.Trial");
			result.Status = _ctx.IntegerValue("DescribePayInfo.Result.Status");
			describePayInfoResponse.Result = result;
        
			return describePayInfoResponse;
        }
    }
}
