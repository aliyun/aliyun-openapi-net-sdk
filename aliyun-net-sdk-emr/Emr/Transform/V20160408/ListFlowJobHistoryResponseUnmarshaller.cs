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
        public static ListFlowJobHistoryResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowJobHistoryResponse listFlowJobHistoryResponse = new ListFlowJobHistoryResponse();

			listFlowJobHistoryResponse.HttpResponse = context.HttpResponse;
			listFlowJobHistoryResponse.RequestId = context.StringValue("ListFlowJobHistory.RequestId");
			listFlowJobHistoryResponse.PageNumber = context.IntegerValue("ListFlowJobHistory.PageNumber");
			listFlowJobHistoryResponse.PageSize = context.IntegerValue("ListFlowJobHistory.PageSize");
			listFlowJobHistoryResponse.Total = context.IntegerValue("ListFlowJobHistory.Total");

			List<ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance> listFlowJobHistoryResponse_nodeInstances = new List<ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance>();
			for (int i = 0; i < context.Length("ListFlowJobHistory.NodeInstances.Length"); i++) {
				ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance nodeInstance = new ListFlowJobHistoryResponse.ListFlowJobHistory_NodeInstance();
				nodeInstance.Id = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].Id");
				nodeInstance.GmtCreate = context.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].GmtCreate");
				nodeInstance.GmtModified = context.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].GmtModified");
				nodeInstance.Type = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].Type");
				nodeInstance.Status = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].Status");
				nodeInstance.JobId = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobId");
				nodeInstance.JobName = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobName");
				nodeInstance.JobType = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobType");
				nodeInstance.JobParams = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].JobParams");
				nodeInstance.FailAct = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].FailAct");
				nodeInstance.MaxRetry = context.IntegerValue("ListFlowJobHistory.NodeInstances["+ i +"].MaxRetry");
				nodeInstance.RetryInterval = context.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].RetryInterval");
				nodeInstance.NodeName = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].NodeName");
				nodeInstance.ClusterId = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ClusterId");
				nodeInstance.HostName = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].HostName");
				nodeInstance.ProjectId = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ProjectId");
				nodeInstance.StartTime = context.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].StartTime");
				nodeInstance.EndTime = context.LongValue("ListFlowJobHistory.NodeInstances["+ i +"].EndTime");
				nodeInstance.Pending = context.BooleanValue("ListFlowJobHistory.NodeInstances["+ i +"].Pending");
				nodeInstance.Retries = context.IntegerValue("ListFlowJobHistory.NodeInstances["+ i +"].Retries");
				nodeInstance.ExternalId = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ExternalId");
				nodeInstance.ExternalStatus = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ExternalStatus");
				nodeInstance.ExternalInfo = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ExternalInfo");
				nodeInstance.ParamConf = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].ParamConf");
				nodeInstance.EnvConf = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].EnvConf");
				nodeInstance.RunConf = context.StringValue("ListFlowJobHistory.NodeInstances["+ i +"].RunConf");

				listFlowJobHistoryResponse_nodeInstances.Add(nodeInstance);
			}
			listFlowJobHistoryResponse.NodeInstances = listFlowJobHistoryResponse_nodeInstances;
        
			return listFlowJobHistoryResponse;
        }
    }
}
