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
    public class DescribeFlowInstanceResponseUnmarshaller
    {
        public static DescribeFlowInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowInstanceResponse describeFlowInstanceResponse = new DescribeFlowInstanceResponse();

			describeFlowInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowInstanceResponse.RequestId = _ctx.StringValue("DescribeFlowInstance.RequestId");
			describeFlowInstanceResponse.Id = _ctx.StringValue("DescribeFlowInstance.Id");
			describeFlowInstanceResponse.GmtCreate = _ctx.LongValue("DescribeFlowInstance.GmtCreate");
			describeFlowInstanceResponse.GmtModified = _ctx.LongValue("DescribeFlowInstance.GmtModified");
			describeFlowInstanceResponse.FlowId = _ctx.StringValue("DescribeFlowInstance.FlowId");
			describeFlowInstanceResponse.FlowName = _ctx.StringValue("DescribeFlowInstance.FlowName");
			describeFlowInstanceResponse.ProjectId = _ctx.StringValue("DescribeFlowInstance.ProjectId");
			describeFlowInstanceResponse.Status = _ctx.StringValue("DescribeFlowInstance.Status");
			describeFlowInstanceResponse.ClusterId = _ctx.StringValue("DescribeFlowInstance.ClusterId");
			describeFlowInstanceResponse._Namespace = _ctx.StringValue("DescribeFlowInstance.Namespace");
			describeFlowInstanceResponse.LogArchiveLocation = _ctx.StringValue("DescribeFlowInstance.LogArchiveLocation");
			describeFlowInstanceResponse.Lifecycle = _ctx.StringValue("DescribeFlowInstance.Lifecycle");
			describeFlowInstanceResponse.StartTime = _ctx.LongValue("DescribeFlowInstance.StartTime");
			describeFlowInstanceResponse.EndTime = _ctx.LongValue("DescribeFlowInstance.EndTime");
			describeFlowInstanceResponse.Duration = _ctx.LongValue("DescribeFlowInstance.Duration");
			describeFlowInstanceResponse.ScheduleTime = _ctx.LongValue("DescribeFlowInstance.ScheduleTime");
			describeFlowInstanceResponse.Graph = _ctx.StringValue("DescribeFlowInstance.Graph");
			describeFlowInstanceResponse.CronExpression = _ctx.StringValue("DescribeFlowInstance.CronExpression");
			describeFlowInstanceResponse.HasNodeFailed = _ctx.BooleanValue("DescribeFlowInstance.HasNodeFailed");

			List<DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow> describeFlowInstanceResponse_dependencyFlowList = new List<DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow>();
			for (int i = 0; i < _ctx.Length("DescribeFlowInstance.DependencyFlowList.Length"); i++) {
				DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow parentFlow = new DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow();
				parentFlow.ProjectId = _ctx.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].ProjectId");
				parentFlow.FlowId = _ctx.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].FlowId");
				parentFlow.DependencyFlowId = _ctx.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].DependencyFlowId");
				parentFlow.FlowInstanceId = _ctx.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].FlowInstanceId");
				parentFlow.DependencyInstanceId = _ctx.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].DependencyInstanceId");
				parentFlow.ScheduleKey = _ctx.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].ScheduleKey");
				parentFlow.BizDate = _ctx.LongValue("DescribeFlowInstance.DependencyFlowList["+ i +"].BizDate");
				parentFlow.Meet = _ctx.BooleanValue("DescribeFlowInstance.DependencyFlowList["+ i +"].Meet");

				describeFlowInstanceResponse_dependencyFlowList.Add(parentFlow);
			}
			describeFlowInstanceResponse.DependencyFlowList = describeFlowInstanceResponse_dependencyFlowList;

			List<DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem> describeFlowInstanceResponse_nodeInstance = new List<DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem>();
			for (int i = 0; i < _ctx.Length("DescribeFlowInstance.NodeInstance.Length"); i++) {
				DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem nodeInstanceItem = new DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem();
				nodeInstanceItem.Id = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].Id");
				nodeInstanceItem.GmtCreate = _ctx.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].GmtCreate");
				nodeInstanceItem.GmtModified = _ctx.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].GmtModified");
				nodeInstanceItem.Type = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].Type");
				nodeInstanceItem.Status = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].Status");
				nodeInstanceItem.JobId = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].JobId");
				nodeInstanceItem.JobName = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].JobName");
				nodeInstanceItem.JobType = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].JobType");
				nodeInstanceItem.FailAct = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].FailAct");
				nodeInstanceItem.MaxRetry = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].MaxRetry");
				nodeInstanceItem.RetryInterval = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].RetryInterval");
				nodeInstanceItem.NodeName = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].NodeName");
				nodeInstanceItem.ClusterId = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ClusterId");
				nodeInstanceItem.HostName = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].HostName");
				nodeInstanceItem.ProjectId = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ProjectId");
				nodeInstanceItem.Pending = _ctx.BooleanValue("DescribeFlowInstance.NodeInstance["+ i +"].Pending");
				nodeInstanceItem.StartTime = _ctx.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].StartTime");
				nodeInstanceItem.EndTime = _ctx.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].EndTime");
				nodeInstanceItem.Duration = _ctx.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].Duration");
				nodeInstanceItem.Retries = _ctx.IntegerValue("DescribeFlowInstance.NodeInstance["+ i +"].Retries");
				nodeInstanceItem.ExternalId = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ExternalId");
				nodeInstanceItem.ExternalStatus = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ExternalStatus");
				nodeInstanceItem.ExternalInfo = _ctx.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ExternalInfo");

				describeFlowInstanceResponse_nodeInstance.Add(nodeInstanceItem);
			}
			describeFlowInstanceResponse.NodeInstance = describeFlowInstanceResponse_nodeInstance;
        
			return describeFlowInstanceResponse;
        }
    }
}
