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
        public static DescribeFlowResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowResponse describeFlowResponse = new DescribeFlowResponse();

			describeFlowResponse.HttpResponse = context.HttpResponse;
			describeFlowResponse.RequestId = context.StringValue("DescribeFlow.RequestId");
			describeFlowResponse.Id = context.StringValue("DescribeFlow.Id");
			describeFlowResponse.GmtCreate = context.LongValue("DescribeFlow.GmtCreate");
			describeFlowResponse.GmtModified = context.LongValue("DescribeFlow.GmtModified");
			describeFlowResponse.Name = context.StringValue("DescribeFlow.Name");
			describeFlowResponse.Description = context.StringValue("DescribeFlow.Description");
			describeFlowResponse.Type = context.StringValue("DescribeFlow.Type");
			describeFlowResponse.Status = context.StringValue("DescribeFlow.Status");
			describeFlowResponse.Periodic = context.BooleanValue("DescribeFlow.Periodic");
			describeFlowResponse.StartSchedule = context.LongValue("DescribeFlow.StartSchedule");
			describeFlowResponse.EndSchedule = context.LongValue("DescribeFlow.EndSchedule");
			describeFlowResponse.CronExpr = context.StringValue("DescribeFlow.CronExpr");
			describeFlowResponse.CreateCluster = context.BooleanValue("DescribeFlow.CreateCluster");
			describeFlowResponse.ClusterId = context.StringValue("DescribeFlow.ClusterId");
			describeFlowResponse.HostName = context.StringValue("DescribeFlow.HostName");
			describeFlowResponse.Graph = context.StringValue("DescribeFlow.Graph");
			describeFlowResponse.CategoryId = context.StringValue("DescribeFlow.CategoryId");
			describeFlowResponse.AlertConf = context.StringValue("DescribeFlow.AlertConf");
			describeFlowResponse.AlertUserGroupBizId = context.StringValue("DescribeFlow.AlertUserGroupBizId");
			describeFlowResponse.AlertDingDingGroupBizId = context.StringValue("DescribeFlow.AlertDingDingGroupBizId");
			describeFlowResponse.Application = context.StringValue("DescribeFlow.Application");

			List<DescribeFlowResponse.DescribeFlow_ParentFlow> describeFlowResponse_parentFlowList = new List<DescribeFlowResponse.DescribeFlow_ParentFlow>();
			for (int i = 0; i < context.Length("DescribeFlow.ParentFlowList.Length"); i++) {
				DescribeFlowResponse.DescribeFlow_ParentFlow parentFlow = new DescribeFlowResponse.DescribeFlow_ParentFlow();
				parentFlow.ParentFlowId = context.StringValue("DescribeFlow.ParentFlowList["+ i +"].ParentFlowId");
				parentFlow.ParentFlowName = context.StringValue("DescribeFlow.ParentFlowList["+ i +"].ParentFlowName");
				parentFlow.ProjectId = context.StringValue("DescribeFlow.ParentFlowList["+ i +"].ProjectId");
				parentFlow.ProjectName = context.StringValue("DescribeFlow.ParentFlowList["+ i +"].ProjectName");

				describeFlowResponse_parentFlowList.Add(parentFlow);
			}
			describeFlowResponse.ParentFlowList = describeFlowResponse_parentFlowList;
        
			return describeFlowResponse;
        }
    }
}
