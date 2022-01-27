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
        public static ListFlowNodeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowNodeInstanceResponse listFlowNodeInstanceResponse = new ListFlowNodeInstanceResponse();

			listFlowNodeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listFlowNodeInstanceResponse.RequestId = _ctx.StringValue("ListFlowNodeInstance.RequestId");
			listFlowNodeInstanceResponse.PageNumber = _ctx.IntegerValue("ListFlowNodeInstance.PageNumber");
			listFlowNodeInstanceResponse.PageSize = _ctx.IntegerValue("ListFlowNodeInstance.PageSize");
			listFlowNodeInstanceResponse.Total = _ctx.IntegerValue("ListFlowNodeInstance.Total");

			List<ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance> listFlowNodeInstanceResponse_flowNodeInstances = new List<ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance>();
			for (int i = 0; i < _ctx.Length("ListFlowNodeInstance.FlowNodeInstances.Length"); i++) {
				ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance flowNodeInstance = new ListFlowNodeInstanceResponse.ListFlowNodeInstance_FlowNodeInstance();
				flowNodeInstance.Id = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Id");
				flowNodeInstance.GmtCreate = _ctx.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].GmtCreate");
				flowNodeInstance.GmtModified = _ctx.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].GmtModified");
				flowNodeInstance.Type = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Type");
				flowNodeInstance.Status = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Status");
				flowNodeInstance.JobId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobId");
				flowNodeInstance.JobName = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobName");
				flowNodeInstance.JobType = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobType");
				flowNodeInstance.JobParams = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].JobParams");
				flowNodeInstance.FailAct = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].FailAct");
				flowNodeInstance.MaxRetry = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].MaxRetry");
				flowNodeInstance.RetryInterval = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].RetryInterval");
				flowNodeInstance.NodeName = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].NodeName");
				flowNodeInstance.FlowId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].FlowId");
				flowNodeInstance.FlowInstanceId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].FlowInstanceId");
				flowNodeInstance.ClusterId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ClusterId");
				flowNodeInstance.HostName = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].HostName");
				flowNodeInstance.ProjectId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ProjectId");
				flowNodeInstance.Pending = _ctx.BooleanValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Pending");
				flowNodeInstance.StartTime = _ctx.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].StartTime");
				flowNodeInstance.EndTime = _ctx.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].EndTime");
				flowNodeInstance.Duration = _ctx.LongValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Duration");
				flowNodeInstance.Retries = _ctx.IntegerValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].Retries");
				flowNodeInstance.ExternalId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalId");
				flowNodeInstance.ExternalSubId = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalSubId");
				flowNodeInstance.ExternalChildIds = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalChildIds");
				flowNodeInstance.ExternalStatus = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalStatus");
				flowNodeInstance.ExternalInfo = _ctx.StringValue("ListFlowNodeInstance.FlowNodeInstances["+ i +"].ExternalInfo");

				listFlowNodeInstanceResponse_flowNodeInstances.Add(flowNodeInstance);
			}
			listFlowNodeInstanceResponse.FlowNodeInstances = listFlowNodeInstanceResponse_flowNodeInstances;
        
			return listFlowNodeInstanceResponse;
        }
    }
}
