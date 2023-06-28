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
    public class DescribeProjectNodesResponseUnmarshaller
    {
        public static DescribeProjectNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProjectNodesResponse describeProjectNodesResponse = new DescribeProjectNodesResponse();

			describeProjectNodesResponse.HttpResponse = _ctx.HttpResponse;
			describeProjectNodesResponse.Success = _ctx.BooleanValue("DescribeProjectNodes.Success");
			describeProjectNodesResponse.RequestId = _ctx.StringValue("DescribeProjectNodes.RequestId");

			List<DescribeProjectNodesResponse.DescribeProjectNodes_ProjectNode> describeProjectNodesResponse_result = new List<DescribeProjectNodesResponse.DescribeProjectNodes_ProjectNode>();
			for (int i = 0; i < _ctx.Length("DescribeProjectNodes.Result.Length"); i++) {
				DescribeProjectNodesResponse.DescribeProjectNodes_ProjectNode projectNode = new DescribeProjectNodesResponse.DescribeProjectNodes_ProjectNode();
				projectNode.NextNodeId = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].NextNodeId");
				projectNode.StepNo = _ctx.IntegerValue("DescribeProjectNodes.Result["+ i +"].StepNo");
				projectNode.AutoFinishNode = _ctx.BooleanValue("DescribeProjectNodes.Result["+ i +"].AutoFinishNode");
				projectNode.FinalStepNo = _ctx.IntegerValue("DescribeProjectNodes.Result["+ i +"].FinalStepNo");
				projectNode.PreviousNodeId = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].PreviousNodeId");
				projectNode.ParentNodeId = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].ParentNodeId");
				projectNode.GmtExpired = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].GmtExpired");
				projectNode.OperatorRole = _ctx.StringValue("DescribeProjectNodes.Result["+ i +"].OperatorRole");
				projectNode.GmtStart = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].GmtStart");
				projectNode.NodeStatus = _ctx.StringValue("DescribeProjectNodes.Result["+ i +"].NodeStatus");
				projectNode.NodeName = _ctx.StringValue("DescribeProjectNodes.Result["+ i +"].NodeName");
				projectNode.GmtFinished = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].GmtFinished");
				projectNode.AllowRollbackNode = _ctx.BooleanValue("DescribeProjectNodes.Result["+ i +"].AllowRollbackNode");
				projectNode.TemplateForm = _ctx.StringValue("DescribeProjectNodes.Result["+ i +"].TemplateForm");
				projectNode.NeedAttachment = _ctx.BooleanValue("DescribeProjectNodes.Result["+ i +"].NeedAttachment");
				projectNode.NodeId = _ctx.LongValue("DescribeProjectNodes.Result["+ i +"].NodeId");

				describeProjectNodesResponse_result.Add(projectNode);
			}
			describeProjectNodesResponse.Result = describeProjectNodesResponse_result;
        
			return describeProjectNodesResponse;
        }
    }
}
