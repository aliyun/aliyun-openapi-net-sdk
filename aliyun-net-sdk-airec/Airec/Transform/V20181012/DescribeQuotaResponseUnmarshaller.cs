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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeQuotaResponseUnmarshaller
    {
        public static DescribeQuotaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeQuotaResponse describeQuotaResponse = new DescribeQuotaResponse();

			describeQuotaResponse.HttpResponse = context.HttpResponse;
			describeQuotaResponse.RequestId = context.StringValue("DescribeQuota.RequestId");
			describeQuotaResponse.Code = context.StringValue("DescribeQuota.Code");
			describeQuotaResponse.Message = context.StringValue("DescribeQuota.Message");

			DescribeQuotaResponse.DescribeQuota_Result result = new DescribeQuotaResponse.DescribeQuota_Result();
			result.UserCount = context.LongValue("DescribeQuota.Result.UserCount");
			result.UserCountUsed = context.LongValue("DescribeQuota.Result.UserCountUsed");
			result.ItemCount = context.LongValue("DescribeQuota.Result.ItemCount");
			result.ItemCountUsed = context.LongValue("DescribeQuota.Result.ItemCountUsed");
			result.Qps = context.IntegerValue("DescribeQuota.Result.Qps");
			result.CurrentQps = context.IntegerValue("DescribeQuota.Result.CurrentQps");
			describeQuotaResponse.Result = result;
        
			return describeQuotaResponse;
        }
    }
}
