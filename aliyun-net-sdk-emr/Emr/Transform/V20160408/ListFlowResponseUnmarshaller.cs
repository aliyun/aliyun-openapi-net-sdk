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
    public class ListFlowResponseUnmarshaller
    {
        public static ListFlowResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowResponse listFlowResponse = new ListFlowResponse();

			listFlowResponse.HttpResponse = context.HttpResponse;
			listFlowResponse.RequestId = context.StringValue("ListFlow.RequestId");
			listFlowResponse.PageNumber = context.IntegerValue("ListFlow.PageNumber");
			listFlowResponse.PageSize = context.IntegerValue("ListFlow.PageSize");
			listFlowResponse.Total = context.IntegerValue("ListFlow.Total");

			List<ListFlowResponse.ListFlow_FlowItem> listFlowResponse_flow = new List<ListFlowResponse.ListFlow_FlowItem>();
			for (int i = 0; i < context.Length("ListFlow.Flow.Length"); i++) {
				ListFlowResponse.ListFlow_FlowItem flowItem = new ListFlowResponse.ListFlow_FlowItem();
				flowItem.Id = context.StringValue("ListFlow.Flow["+ i +"].Id");
				flowItem.GmtCreate = context.LongValue("ListFlow.Flow["+ i +"].GmtCreate");
				flowItem.GmtModified = context.LongValue("ListFlow.Flow["+ i +"].GmtModified");
				flowItem.Name = context.StringValue("ListFlow.Flow["+ i +"].Name");
				flowItem.Description = context.StringValue("ListFlow.Flow["+ i +"].Description");
				flowItem.Type = context.StringValue("ListFlow.Flow["+ i +"].Type");
				flowItem.Status = context.StringValue("ListFlow.Flow["+ i +"].Status");
				flowItem.Periodic = context.BooleanValue("ListFlow.Flow["+ i +"].Periodic");
				flowItem.StartSchedule = context.LongValue("ListFlow.Flow["+ i +"].StartSchedule");
				flowItem.EndSchedule = context.LongValue("ListFlow.Flow["+ i +"].EndSchedule");
				flowItem.CronExpr = context.StringValue("ListFlow.Flow["+ i +"].CronExpr");
				flowItem.CreateCluster = context.BooleanValue("ListFlow.Flow["+ i +"].CreateCluster");
				flowItem.ClusterId = context.StringValue("ListFlow.Flow["+ i +"].ClusterId");
				flowItem.ProjectId = context.StringValue("ListFlow.Flow["+ i +"].ProjectId");
				flowItem.HostName = context.StringValue("ListFlow.Flow["+ i +"].HostName");
				flowItem.Graph = context.StringValue("ListFlow.Flow["+ i +"].Graph");
				flowItem.AlertUserGroupBizId = context.StringValue("ListFlow.Flow["+ i +"].AlertUserGroupBizId");
				flowItem.AlertDingDingGroupBizId = context.StringValue("ListFlow.Flow["+ i +"].AlertDingDingGroupBizId");
				flowItem.AlertConf = context.StringValue("ListFlow.Flow["+ i +"].AlertConf");
				flowItem.CategoryId = context.StringValue("ListFlow.Flow["+ i +"].CategoryId");

				listFlowResponse_flow.Add(flowItem);
			}
			listFlowResponse.Flow = listFlowResponse_flow;
        
			return listFlowResponse;
        }
    }
}
