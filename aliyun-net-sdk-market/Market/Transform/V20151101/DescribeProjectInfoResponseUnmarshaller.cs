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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeProjectInfoResponseUnmarshaller
    {
        public static DescribeProjectInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProjectInfoResponse describeProjectInfoResponse = new DescribeProjectInfoResponse();

			describeProjectInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeProjectInfoResponse.Success = _ctx.BooleanValue("DescribeProjectInfo.Success");
			describeProjectInfoResponse.RequestId = _ctx.StringValue("DescribeProjectInfo.RequestId");

			DescribeProjectInfoResponse.DescribeProjectInfo_Result result = new DescribeProjectInfoResponse.DescribeProjectInfo_Result();
			result.ProductName = _ctx.StringValue("DescribeProjectInfo.Result.ProductName");
			result.ProjectStatus = _ctx.StringValue("DescribeProjectInfo.Result.ProjectStatus");
			result.CustomerAliUid = _ctx.LongValue("DescribeProjectInfo.Result.CustomerAliUid");
			result.TemplateType = _ctx.StringValue("DescribeProjectInfo.Result.TemplateType");
			result.InstanceId = _ctx.StringValue("DescribeProjectInfo.Result.InstanceId");
			result.ProductSkuName = _ctx.StringValue("DescribeProjectInfo.Result.ProductSkuName");
			result.FinalStepNo = _ctx.IntegerValue("DescribeProjectInfo.Result.FinalStepNo");
			result.CurrentStepNo = _ctx.IntegerValue("DescribeProjectInfo.Result.CurrentStepNo");
			result.GmtExpired = _ctx.LongValue("DescribeProjectInfo.Result.GmtExpired");
			result.GmtFinished = _ctx.LongValue("DescribeProjectInfo.Result.GmtFinished");
			result.ProductSkuCode = _ctx.StringValue("DescribeProjectInfo.Result.ProductSkuCode");
			result.GmtCreate = _ctx.LongValue("DescribeProjectInfo.Result.GmtCreate");
			result.SupplierAliUid = _ctx.LongValue("DescribeProjectInfo.Result.SupplierAliUid");
			result.FinishType = _ctx.StringValue("DescribeProjectInfo.Result.FinishType");
			result.TemplateId = _ctx.LongValue("DescribeProjectInfo.Result.TemplateId");
			result.OrderId = _ctx.LongValue("DescribeProjectInfo.Result.OrderId");
			result.ProductCode = _ctx.StringValue("DescribeProjectInfo.Result.ProductCode");
			describeProjectInfoResponse.Result = result;
        
			return describeProjectInfoResponse;
        }
    }
}
