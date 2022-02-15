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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class DescribeUserProduceResponseUnmarshaller
    {
        public static DescribeUserProduceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserProduceResponse describeUserProduceResponse = new DescribeUserProduceResponse();

			describeUserProduceResponse.HttpResponse = _ctx.HttpResponse;
			describeUserProduceResponse.BizId = _ctx.StringValue("DescribeUserProduce.BizId");
			describeUserProduceResponse.BizType = _ctx.StringValue("DescribeUserProduce.BizType");
			describeUserProduceResponse.EndTime = _ctx.StringValue("DescribeUserProduce.EndTime");
			describeUserProduceResponse.ErrorCode = _ctx.StringValue("DescribeUserProduce.ErrorCode");
			describeUserProduceResponse.ErrorMsg = _ctx.StringValue("DescribeUserProduce.ErrorMsg");
			describeUserProduceResponse.ExtInfo = _ctx.StringValue("DescribeUserProduce.ExtInfo");
			describeUserProduceResponse.IntentionBizId = _ctx.StringValue("DescribeUserProduce.IntentionBizId");
			describeUserProduceResponse.OrderId = _ctx.StringValue("DescribeUserProduce.OrderId");
			describeUserProduceResponse.OrderPrice = _ctx.StringValue("DescribeUserProduce.OrderPrice");
			describeUserProduceResponse.PartnerCode = _ctx.StringValue("DescribeUserProduce.PartnerCode");
			describeUserProduceResponse.RequestId = _ctx.StringValue("DescribeUserProduce.RequestId");
			describeUserProduceResponse.SolutionBizId = _ctx.StringValue("DescribeUserProduce.SolutionBizId");
			describeUserProduceResponse.StartTime = _ctx.StringValue("DescribeUserProduce.StartTime");
			describeUserProduceResponse.Status = _ctx.IntegerValue("DescribeUserProduce.Status");
			describeUserProduceResponse.Success = _ctx.BooleanValue("DescribeUserProduce.Success");
			describeUserProduceResponse.UserId = _ctx.StringValue("DescribeUserProduce.UserId");
        
			return describeUserProduceResponse;
        }
    }
}
