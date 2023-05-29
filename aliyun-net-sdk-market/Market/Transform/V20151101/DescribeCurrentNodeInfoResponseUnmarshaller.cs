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
    public class DescribeCurrentNodeInfoResponseUnmarshaller
    {
        public static DescribeCurrentNodeInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCurrentNodeInfoResponse describeCurrentNodeInfoResponse = new DescribeCurrentNodeInfoResponse();

			describeCurrentNodeInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeCurrentNodeInfoResponse.Success = _ctx.BooleanValue("DescribeCurrentNodeInfo.Success");
			describeCurrentNodeInfoResponse.RequestId = _ctx.StringValue("DescribeCurrentNodeInfo.RequestId");

			DescribeCurrentNodeInfoResponse.DescribeCurrentNodeInfo_Result result = new DescribeCurrentNodeInfoResponse.DescribeCurrentNodeInfo_Result();
			result.NextNodeId = _ctx.LongValue("DescribeCurrentNodeInfo.Result.NextNodeId");
			result.StepNo = _ctx.IntegerValue("DescribeCurrentNodeInfo.Result.StepNo");
			result.AutoFinishNode = _ctx.BooleanValue("DescribeCurrentNodeInfo.Result.AutoFinishNode");
			result.FinalStepNo = _ctx.IntegerValue("DescribeCurrentNodeInfo.Result.FinalStepNo");
			result.PreviousNodeId = _ctx.LongValue("DescribeCurrentNodeInfo.Result.PreviousNodeId");
			result.ParentNodeId = _ctx.LongValue("DescribeCurrentNodeInfo.Result.ParentNodeId");
			result.GmtExpired = _ctx.LongValue("DescribeCurrentNodeInfo.Result.GmtExpired");
			result.OperatorRole = _ctx.StringValue("DescribeCurrentNodeInfo.Result.OperatorRole");
			result.GmtStart = _ctx.LongValue("DescribeCurrentNodeInfo.Result.GmtStart");
			result.NodeStatus = _ctx.StringValue("DescribeCurrentNodeInfo.Result.NodeStatus");
			result.NodeName = _ctx.StringValue("DescribeCurrentNodeInfo.Result.NodeName");
			result.GmtFinished = _ctx.LongValue("DescribeCurrentNodeInfo.Result.GmtFinished");
			result.AllowRollbackNode = _ctx.BooleanValue("DescribeCurrentNodeInfo.Result.AllowRollbackNode");
			result.TemplateForm = _ctx.StringValue("DescribeCurrentNodeInfo.Result.TemplateForm");
			result.NeedAttachment = _ctx.BooleanValue("DescribeCurrentNodeInfo.Result.NeedAttachment");
			result.NodeId = _ctx.LongValue("DescribeCurrentNodeInfo.Result.NodeId");
			describeCurrentNodeInfoResponse.Result = result;
        
			return describeCurrentNodeInfoResponse;
        }
    }
}
