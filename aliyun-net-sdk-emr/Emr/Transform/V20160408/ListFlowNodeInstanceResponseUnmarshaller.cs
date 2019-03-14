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
    public class ListFlowNodeInstanceResponseUnmarshaller
    {
        public static ListFlowNodeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowNodeInstanceResponse listFlowNodeInstanceResponse = new ListFlowNodeInstanceResponse();

			listFlowNodeInstanceResponse.HttpResponse = context.HttpResponse;
			listFlowNodeInstanceResponse.RequestId = context.StringValue("ListFlowNodeInstance.RequestId");
			listFlowNodeInstanceResponse.PageNumber = context.IntegerValue("ListFlowNodeInstance.PageNumber");
			listFlowNodeInstanceResponse.PageSize = context.IntegerValue("ListFlowNodeInstance.PageSize");
			listFlowNodeInstanceResponse.Total = context.IntegerValue("ListFlowNodeInstance.Total");

			List<ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance> listFlowNodeInstanceResponse_flowNodeInstances = new List<ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance>();
			for (int i = 0; i < context.Length("ListFlowNodeInstance.FlowNodeInstances.Length"); i++) {
				ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance flowNodeInstance = new ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance();
				flowNodeInstance.Id = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Id");
				flowNodeInstance.GmtCreate = context.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].GmtCreate");
				flowNodeInstance.GmtModified = context.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].GmtModified");
				flowNodeInstance.Type = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Type");
				flowNodeInstance.Status = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Status");
				flowNodeInstance.JobId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobId");
				flowNodeInstance.JobName = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobName");
				flowNodeInstance.JobType = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobType");
				flowNodeInstance.JobParams = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobParams");
				flowNodeInstance.FailAct = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].FailAct");
				flowNodeInstance.MaxRetry = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].MaxRetry");
				flowNodeInstance.RetryInterval = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].RetryInterval");
				flowNodeInstance.NodeName = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].NodeName");
				flowNodeInstance.FlowId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].FlowId");
				flowNodeInstance.FlowInstanceId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].FlowInstanceId");
				flowNodeInstance.ClusterId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ClusterId");
				flowNodeInstance.HostName = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].HostName");
				flowNodeInstance.ProjectId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ProjectId");
				flowNodeInstance.Pending = context.BooleanValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Pending");
				flowNodeInstance.StartTime = context.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].StartTime");
				flowNodeInstance.EndTime = context.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].EndTime");
				flowNodeInstance.Duration = context.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Duration");
				flowNodeInstance.Retries = context.IntegerValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Retries");
				flowNodeInstance.ExternalId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalId");
				flowNodeInstance.ExternalSubId = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalSubId");
				flowNodeInstance.ExternalChildIds = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalChildIds");
				flowNodeInstance.ExternalStatus = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalStatus");
				flowNodeInstance.ExternalInfo = context.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalInfo");

				listFlowNodeInstanceResponse_flowNodeInstances.Add(flowNodeInstance);
			}
			listFlowNodeInstanceResponse.FlowNodeInstances = listFlowNodeInstanceResponse_flowNodeInstances;
        
			return listFlowNodeInstanceResponse;
        }
    }
}
