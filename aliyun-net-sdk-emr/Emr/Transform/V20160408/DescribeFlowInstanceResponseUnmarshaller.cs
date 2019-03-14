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
        public static DescribeFlowInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowInstanceResponse describeFlowInstanceResponse = new DescribeFlowInstanceResponse();

			describeFlowInstanceResponse.HttpResponse = context.HttpResponse;
			describeFlowInstanceResponse.RequestId = context.StringValue("DescribeFlowInstance.RequestId");
			describeFlowInstanceResponse.Id = context.StringValue("DescribeFlowInstance.Id");
			describeFlowInstanceResponse.GmtCreate = context.LongValue("DescribeFlowInstance.GmtCreate");
			describeFlowInstanceResponse.GmtModified = context.LongValue("DescribeFlowInstance.GmtModified");
			describeFlowInstanceResponse.FlowId = context.StringValue("DescribeFlowInstance.FlowId");
			describeFlowInstanceResponse.FlowName = context.StringValue("DescribeFlowInstance.FlowName");
			describeFlowInstanceResponse.ProjectId = context.StringValue("DescribeFlowInstance.ProjectId");
			describeFlowInstanceResponse.Status = context.StringValue("DescribeFlowInstance.Status");
			describeFlowInstanceResponse.ClusterId = context.StringValue("DescribeFlowInstance.ClusterId");
			describeFlowInstanceResponse.StartTime = context.LongValue("DescribeFlowInstance.StartTime");
			describeFlowInstanceResponse.EndTime = context.LongValue("DescribeFlowInstance.EndTime");
			describeFlowInstanceResponse.Duration = context.LongValue("DescribeFlowInstance.Duration");
			describeFlowInstanceResponse.ScheduleTime = context.LongValue("DescribeFlowInstance.ScheduleTime");
			describeFlowInstanceResponse.Graph = context.StringValue("DescribeFlowInstance.Graph");
			describeFlowInstanceResponse.CronExpression = context.StringValue("DescribeFlowInstance.CronExpression");
			describeFlowInstanceResponse.HasNodeFailed = context.BooleanValue("DescribeFlowInstance.HasNodeFailed");

			List<DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow> describeFlowInstanceResponse_dependencyFlowList = new List<DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow>();
			for (int i = 0; i < context.Length("DescribeFlowInstance.DependencyFlowList.Length"); i++) {
				DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow parentFlow = new DescribeFlowInstanceResponse.DescribeFlowInstance_ParentFlow();
				parentFlow.ProjectId = context.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].ProjectId");
				parentFlow.FlowId = context.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].FlowId");
				parentFlow.DependencyFlowId = context.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].DependencyFlowId");
				parentFlow.FlowInstanceId = context.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].FlowInstanceId");
				parentFlow.DependencyInstanceId = context.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].DependencyInstanceId");
				parentFlow.ScheduleKey = context.StringValue("DescribeFlowInstance.DependencyFlowList["+ i +"].ScheduleKey");
				parentFlow.BizDate = context.LongValue("DescribeFlowInstance.DependencyFlowList["+ i +"].BizDate");

				describeFlowInstanceResponse_dependencyFlowList.Add(parentFlow);
			}
			describeFlowInstanceResponse.DependencyFlowList = describeFlowInstanceResponse_dependencyFlowList;

			List<DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem> describeFlowInstanceResponse_nodeInstance = new List<DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem>();
			for (int i = 0; i < context.Length("DescribeFlowInstance.NodeInstance.Length"); i++) {
				DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem nodeInstanceItem = new DescribeFlowInstanceResponse.DescribeFlowInstance_NodeInstanceItem();
				nodeInstanceItem.Id = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].Id");
				nodeInstanceItem.GmtCreate = context.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].GmtCreate");
				nodeInstanceItem.GmtModified = context.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].GmtModified");
				nodeInstanceItem.Type = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].Type");
				nodeInstanceItem.Status = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].Status");
				nodeInstanceItem.JobId = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].JobId");
				nodeInstanceItem.JobName = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].JobName");
				nodeInstanceItem.JobType = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].JobType");
				nodeInstanceItem.FailAct = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].FailAct");
				nodeInstanceItem.MaxRetry = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].MaxRetry");
				nodeInstanceItem.RetryInterval = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].RetryInterval");
				nodeInstanceItem.NodeName = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].NodeName");
				nodeInstanceItem.ClusterId = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ClusterId");
				nodeInstanceItem.HostName = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].HostName");
				nodeInstanceItem.ProjectId = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ProjectId");
				nodeInstanceItem.Pending = context.BooleanValue("DescribeFlowInstance.NodeInstance["+ i +"].Pending");
				nodeInstanceItem.StartTime = context.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].StartTime");
				nodeInstanceItem.EndTime = context.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].EndTime");
				nodeInstanceItem.Duration = context.LongValue("DescribeFlowInstance.NodeInstance["+ i +"].Duration");
				nodeInstanceItem.Retries = context.IntegerValue("DescribeFlowInstance.NodeInstance["+ i +"].Retries");
				nodeInstanceItem.ExternalId = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ExternalId");
				nodeInstanceItem.ExternalStatus = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ExternalStatus");
				nodeInstanceItem.ExternalInfo = context.StringValue("DescribeFlowInstance.NodeInstance["+ i +"].ExternalInfo");

				describeFlowInstanceResponse_nodeInstance.Add(nodeInstanceItem);
			}
			describeFlowInstanceResponse.NodeInstance = describeFlowInstanceResponse_nodeInstance;
        
			return describeFlowInstanceResponse;
        }
    }
}
