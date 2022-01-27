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
    public class ListFlowJobHistoryResponseUnmarshaller
    {
        public static ListFlowJobHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowJobHistoryResponse listFlowJobHistoryResponse = new ListFlowJobHistoryResponse();

			listFlowJobHistoryResponse.HttpResponse = _ctx.HttpResponse;
			listFlowJobHistoryResponse.RequestId = _ctx.StringValue("ListFlowJobHistory.RequestId");
			listFlowJobHistoryResponse.PageNumber = _ctx.IntegerValue("ListFlowJobHistory.PageNumber");
			listFlowJobHistoryResponse.PageSize = _ctx.IntegerValue("ListFlowJobHistory.PageSize");
			listFlowJobHistoryResponse.Total = _ctx.IntegerValue("ListFlowJobHistory.Total");

			List<ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance> listFlowJobHistoryResponse_nodeInstances = new List<ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance>();
			for (int i = 0; i < _ctx.Length("ListFlowJobHistory.NodeInstances.Length"); i++) {
				ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance nodeInstance = new ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance();
				nodeInstance.Id = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].Id");
				nodeInstance.GmtCreate = _ctx.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].GmtCreate");
				nodeInstance.GmtModified = _ctx.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].GmtModified");
				nodeInstance.Type = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].Type");
				nodeInstance.Status = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].Status");
				nodeInstance.JobId = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobId");
				nodeInstance.JobName = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobName");
				nodeInstance.JobType = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobType");
				nodeInstance.JobParams = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobParams");
				nodeInstance.FailAct = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].FailAct");
				nodeInstance.MaxRetry = _ctx.IntegerValue("ListFlowJobHistory.NodeInstances["+ i +"].MaxRetry");
				nodeInstance.RetryInterval = _ctx.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].RetryInterval");
				nodeInstance.NodeName = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].NodeName");
				nodeInstance.ClusterId = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ClusterId");
				nodeInstance.HostName = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].HostName");
				nodeInstance.ProjectId = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ProjectId");
				nodeInstance.StartTime = _ctx.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].StartTime");
				nodeInstance.EndTime = _ctx.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].EndTime");
				nodeInstance.Pending = _ctx.BooleanValue("ListFlowJobHistory.NodeInstances["+ i +"].pending");
				nodeInstance.Retries = _ctx.IntegerValue("ListFlowJobHistory.NodeInstances["+ i +"].Retries");
				nodeInstance.ExternalId = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ExternalId");
				nodeInstance.ExternalStatus = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ExternalStatus");
				nodeInstance.ExternalInfo = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ExternalInfo");
				nodeInstance.ParamConf = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ParamConf");
				nodeInstance.EnvConf = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].EnvConf");
				nodeInstance.RunConf = _ctx.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].RunConf");

				listFlowJobHistoryResponse_nodeInstances.Add(nodeInstance);
			}
			listFlowJobHistoryResponse.NodeInstances = listFlowJobHistoryResponse_nodeInstances;
        
			return listFlowJobHistoryResponse;
        }
    }
}
