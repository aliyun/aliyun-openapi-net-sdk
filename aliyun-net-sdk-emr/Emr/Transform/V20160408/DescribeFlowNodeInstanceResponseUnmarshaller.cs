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
    public class DescribeFlowNodeInstanceResponseUnmarshaller
    {
        public static DescribeFlowNodeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowNodeInstanceResponse describeFlowNodeInstanceResponse = new DescribeFlowNodeInstanceResponse();

			describeFlowNodeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowNodeInstanceResponse.RequestId = _ctx.StringValue("DescribeFlowNodeInstance.RequestId");
			describeFlowNodeInstanceResponse.Id = _ctx.StringValue("DescribeFlowNodeInstance.Id");
			describeFlowNodeInstanceResponse.GmtCreate = _ctx.LongValue("DescribeFlowNodeInstance.GmtCreate");
			describeFlowNodeInstanceResponse.GmtModified = _ctx.LongValue("DescribeFlowNodeInstance.GmtModified");
			describeFlowNodeInstanceResponse.Type = _ctx.StringValue("DescribeFlowNodeInstance.Type");
			describeFlowNodeInstanceResponse.Status = _ctx.StringValue("DescribeFlowNodeInstance.Status");
			describeFlowNodeInstanceResponse.JobId = _ctx.StringValue("DescribeFlowNodeInstance.JobId");
			describeFlowNodeInstanceResponse.JobName = _ctx.StringValue("DescribeFlowNodeInstance.JobName");
			describeFlowNodeInstanceResponse.JobType = _ctx.StringValue("DescribeFlowNodeInstance.JobType");
			describeFlowNodeInstanceResponse.JobParams = _ctx.StringValue("DescribeFlowNodeInstance.JobParams");
			describeFlowNodeInstanceResponse.FailAct = _ctx.StringValue("DescribeFlowNodeInstance.FailAct");
			describeFlowNodeInstanceResponse.MaxRetry = _ctx.StringValue("DescribeFlowNodeInstance.MaxRetry");
			describeFlowNodeInstanceResponse.RetryInterval = _ctx.StringValue("DescribeFlowNodeInstance.RetryInterval");
			describeFlowNodeInstanceResponse.RetryPolicy = _ctx.StringValue("DescribeFlowNodeInstance.RetryPolicy");
			describeFlowNodeInstanceResponse.NodeName = _ctx.StringValue("DescribeFlowNodeInstance.NodeName");
			describeFlowNodeInstanceResponse.FlowId = _ctx.StringValue("DescribeFlowNodeInstance.FlowId");
			describeFlowNodeInstanceResponse.FlowInstanceId = _ctx.StringValue("DescribeFlowNodeInstance.FlowInstanceId");
			describeFlowNodeInstanceResponse.ClusterId = _ctx.StringValue("DescribeFlowNodeInstance.ClusterId");
			describeFlowNodeInstanceResponse.HostName = _ctx.StringValue("DescribeFlowNodeInstance.HostName");
			describeFlowNodeInstanceResponse.ProjectId = _ctx.StringValue("DescribeFlowNodeInstance.ProjectId");
			describeFlowNodeInstanceResponse.Pending = _ctx.BooleanValue("DescribeFlowNodeInstance.Pending");
			describeFlowNodeInstanceResponse.StartTime = _ctx.LongValue("DescribeFlowNodeInstance.StartTime");
			describeFlowNodeInstanceResponse.EndTime = _ctx.LongValue("DescribeFlowNodeInstance.EndTime");
			describeFlowNodeInstanceResponse.Duration = _ctx.LongValue("DescribeFlowNodeInstance.Duration");
			describeFlowNodeInstanceResponse.Retries = _ctx.IntegerValue("DescribeFlowNodeInstance.Retries");
			describeFlowNodeInstanceResponse.ExternalId = _ctx.StringValue("DescribeFlowNodeInstance.ExternalId");
			describeFlowNodeInstanceResponse.ExternalSubId = _ctx.StringValue("DescribeFlowNodeInstance.ExternalSubId");
			describeFlowNodeInstanceResponse.ExternalChildIds = _ctx.StringValue("DescribeFlowNodeInstance.ExternalChildIds");
			describeFlowNodeInstanceResponse.ExternalStatus = _ctx.StringValue("DescribeFlowNodeInstance.ExternalStatus");
			describeFlowNodeInstanceResponse.ExternalInfo = _ctx.StringValue("DescribeFlowNodeInstance.ExternalInfo");
			describeFlowNodeInstanceResponse.ParamConf = _ctx.StringValue("DescribeFlowNodeInstance.ParamConf");
			describeFlowNodeInstanceResponse.EnvConf = _ctx.StringValue("DescribeFlowNodeInstance.EnvConf");
			describeFlowNodeInstanceResponse.RunConf = _ctx.StringValue("DescribeFlowNodeInstance.RunConf");
			describeFlowNodeInstanceResponse.Adhoc = _ctx.BooleanValue("DescribeFlowNodeInstance.Adhoc");
			describeFlowNodeInstanceResponse.MonitorConf = _ctx.StringValue("DescribeFlowNodeInstance.MonitorConf");
			describeFlowNodeInstanceResponse.Mode = _ctx.StringValue("DescribeFlowNodeInstance.Mode");
			describeFlowNodeInstanceResponse.ClusterName = _ctx.StringValue("DescribeFlowNodeInstance.ClusterName");
        
			return describeFlowNodeInstanceResponse;
        }
    }
}
