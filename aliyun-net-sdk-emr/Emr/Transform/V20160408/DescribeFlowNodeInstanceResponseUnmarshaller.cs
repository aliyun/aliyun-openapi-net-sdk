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
        public static DescribeFlowNodeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowNodeInstanceResponse describeFlowNodeInstanceResponse = new DescribeFlowNodeInstanceResponse();

			describeFlowNodeInstanceResponse.HttpResponse = context.HttpResponse;
			describeFlowNodeInstanceResponse.RequestId = context.StringValue("DescribeFlowNodeInstance.RequestId");
			describeFlowNodeInstanceResponse.Id = context.StringValue("DescribeFlowNodeInstance.Id");
			describeFlowNodeInstanceResponse.GmtCreate = context.LongValue("DescribeFlowNodeInstance.GmtCreate");
			describeFlowNodeInstanceResponse.GmtModified = context.LongValue("DescribeFlowNodeInstance.GmtModified");
			describeFlowNodeInstanceResponse.Type = context.StringValue("DescribeFlowNodeInstance.Type");
			describeFlowNodeInstanceResponse.Status = context.StringValue("DescribeFlowNodeInstance.Status");
			describeFlowNodeInstanceResponse.JobId = context.StringValue("DescribeFlowNodeInstance.JobId");
			describeFlowNodeInstanceResponse.JobName = context.StringValue("DescribeFlowNodeInstance.JobName");
			describeFlowNodeInstanceResponse.JobType = context.StringValue("DescribeFlowNodeInstance.JobType");
			describeFlowNodeInstanceResponse.JobParams = context.StringValue("DescribeFlowNodeInstance.JobParams");
			describeFlowNodeInstanceResponse.FailAct = context.StringValue("DescribeFlowNodeInstance.FailAct");
			describeFlowNodeInstanceResponse.MaxRetry = context.StringValue("DescribeFlowNodeInstance.MaxRetry");
			describeFlowNodeInstanceResponse.RetryInterval = context.StringValue("DescribeFlowNodeInstance.RetryInterval");
			describeFlowNodeInstanceResponse.NodeName = context.StringValue("DescribeFlowNodeInstance.NodeName");
			describeFlowNodeInstanceResponse.FlowId = context.StringValue("DescribeFlowNodeInstance.FlowId");
			describeFlowNodeInstanceResponse.FlowInstanceId = context.StringValue("DescribeFlowNodeInstance.FlowInstanceId");
			describeFlowNodeInstanceResponse.ClusterId = context.StringValue("DescribeFlowNodeInstance.ClusterId");
			describeFlowNodeInstanceResponse.HostName = context.StringValue("DescribeFlowNodeInstance.HostName");
			describeFlowNodeInstanceResponse.ProjectId = context.StringValue("DescribeFlowNodeInstance.ProjectId");
			describeFlowNodeInstanceResponse.Pending = context.BooleanValue("DescribeFlowNodeInstance.Pending");
			describeFlowNodeInstanceResponse.StartTime = context.LongValue("DescribeFlowNodeInstance.StartTime");
			describeFlowNodeInstanceResponse.EndTime = context.LongValue("DescribeFlowNodeInstance.EndTime");
			describeFlowNodeInstanceResponse.Duration = context.LongValue("DescribeFlowNodeInstance.Duration");
			describeFlowNodeInstanceResponse.Retries = context.IntegerValue("DescribeFlowNodeInstance.Retries");
			describeFlowNodeInstanceResponse.ExternalId = context.StringValue("DescribeFlowNodeInstance.ExternalId");
			describeFlowNodeInstanceResponse.ExternalSubId = context.StringValue("DescribeFlowNodeInstance.ExternalSubId");
			describeFlowNodeInstanceResponse.ExternalChildIds = context.StringValue("DescribeFlowNodeInstance.ExternalChildIds");
			describeFlowNodeInstanceResponse.ExternalStatus = context.StringValue("DescribeFlowNodeInstance.ExternalStatus");
			describeFlowNodeInstanceResponse.ExternalInfo = context.StringValue("DescribeFlowNodeInstance.ExternalInfo");
			describeFlowNodeInstanceResponse.ParamConf = context.StringValue("DescribeFlowNodeInstance.ParamConf");
			describeFlowNodeInstanceResponse.EnvConf = context.StringValue("DescribeFlowNodeInstance.EnvConf");
			describeFlowNodeInstanceResponse.RunConf = context.StringValue("DescribeFlowNodeInstance.RunConf");
			describeFlowNodeInstanceResponse.Adhoc = context.BooleanValue("DescribeFlowNodeInstance.Adhoc");
			describeFlowNodeInstanceResponse.MonitorConf = context.StringValue("DescribeFlowNodeInstance.MonitorConf");
			describeFlowNodeInstanceResponse.Mode = context.StringValue("DescribeFlowNodeInstance.Mode");
			describeFlowNodeInstanceResponse.ClusterName = context.StringValue("DescribeFlowNodeInstance.ClusterName");
        
			return describeFlowNodeInstanceResponse;
        }
    }
}
