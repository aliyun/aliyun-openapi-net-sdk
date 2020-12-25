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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeFlowResponseUnmarshaller
    {
        public static DescribeFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowResponse describeFlowResponse = new DescribeFlowResponse();

			describeFlowResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowResponse.RequestId = _ctx.StringValue("DescribeFlow.RequestId");
			describeFlowResponse.Id = _ctx.StringValue("DescribeFlow.Id");
			describeFlowResponse.GmtCreate = _ctx.LongValue("DescribeFlow.GmtCreate");
			describeFlowResponse.GmtModified = _ctx.LongValue("DescribeFlow.GmtModified");
			describeFlowResponse.Name = _ctx.StringValue("DescribeFlow.Name");
			describeFlowResponse.Description = _ctx.StringValue("DescribeFlow.Description");
			describeFlowResponse.Type = _ctx.StringValue("DescribeFlow.Type");
			describeFlowResponse.Status = _ctx.StringValue("DescribeFlow.Status");
			describeFlowResponse.Periodic = _ctx.BooleanValue("DescribeFlow.Periodic");
			describeFlowResponse.StartSchedule = _ctx.LongValue("DescribeFlow.StartSchedule");
			describeFlowResponse.EndSchedule = _ctx.LongValue("DescribeFlow.EndSchedule");
			describeFlowResponse.CronExpr = _ctx.StringValue("DescribeFlow.CronExpr");
			describeFlowResponse.CreateCluster = _ctx.BooleanValue("DescribeFlow.CreateCluster");
			describeFlowResponse.ClusterId = _ctx.StringValue("DescribeFlow.ClusterId");
			describeFlowResponse.HostName = _ctx.StringValue("DescribeFlow.HostName");
			describeFlowResponse._Namespace = _ctx.StringValue("DescribeFlow.Namespace");
			describeFlowResponse.LogArchiveLocation = _ctx.StringValue("DescribeFlow.LogArchiveLocation");
			describeFlowResponse.Lifecycle = _ctx.StringValue("DescribeFlow.Lifecycle");
			describeFlowResponse.Graph = _ctx.StringValue("DescribeFlow.Graph");
			describeFlowResponse.CategoryId = _ctx.StringValue("DescribeFlow.CategoryId");
			describeFlowResponse.AlertConf = _ctx.StringValue("DescribeFlow.AlertConf");
			describeFlowResponse.AlertUserGroupBizId = _ctx.StringValue("DescribeFlow.AlertUserGroupBizId");
			describeFlowResponse.AlertDingDingGroupBizId = _ctx.StringValue("DescribeFlow.AlertDingDingGroupBizId");
			describeFlowResponse.Application = _ctx.StringValue("DescribeFlow.Application");
			describeFlowResponse.EditLockDetail = _ctx.StringValue("DescribeFlow.EditLockDetail");

			List<DescribeFlowResponse.DescribeFlow_ParentFlow> describeFlowResponse_parentFlowList = new List<DescribeFlowResponse.DescribeFlow_ParentFlow>();
			for (int i = 0; i < _ctx.Length("DescribeFlow.ParentFlowList.Length"); i++) {
				DescribeFlowResponse.DescribeFlow_ParentFlow parentFlow = new DescribeFlowResponse.DescribeFlow_ParentFlow();
				parentFlow.ParentFlowId = _ctx.StringValue("DescribeFlow.ParentFlowList["+ i +"].ParentFlowId");
				parentFlow.ParentFlowName = _ctx.StringValue("DescribeFlow.ParentFlowList["+ i +"].ParentFlowName");
				parentFlow.ProjectId = _ctx.StringValue("DescribeFlow.ParentFlowList["+ i +"].ProjectId");
				parentFlow.ProjectName = _ctx.StringValue("DescribeFlow.ParentFlowList["+ i +"].ProjectName");

				describeFlowResponse_parentFlowList.Add(parentFlow);
			}
			describeFlowResponse.ParentFlowList = describeFlowResponse_parentFlowList;
        
			return describeFlowResponse;
        }
    }
}
