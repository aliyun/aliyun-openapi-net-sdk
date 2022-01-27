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
        public static ListFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowResponse listFlowResponse = new ListFlowResponse();

			listFlowResponse.HttpResponse = _ctx.HttpResponse;
			listFlowResponse.RequestId = _ctx.StringValue("ListFlow.RequestId");
			listFlowResponse.PageNumber = _ctx.IntegerValue("ListFlow.PageNumber");
			listFlowResponse.PageSize = _ctx.IntegerValue("ListFlow.PageSize");
			listFlowResponse.Total = _ctx.IntegerValue("ListFlow.Total");

			List<ListFlowResponse.ListFlow_FlowItem> listFlowResponse_flow = new List<ListFlowResponse.ListFlow_FlowItem>();
			for (int i = 0; i < _ctx.Length("ListFlow.Flow.Length"); i++) {
				ListFlowResponse.ListFlow_FlowItem flowItem = new ListFlowResponse.ListFlow_FlowItem();
				flowItem.Id = _ctx.StringValue("ListFlow.Flow["+ i +"].Id");
				flowItem.GmtCreate = _ctx.LongValue("ListFlow.Flow["+ i +"].GmtCreate");
				flowItem.GmtModified = _ctx.LongValue("ListFlow.Flow["+ i +"].GmtModified");
				flowItem.Name = _ctx.StringValue("ListFlow.Flow["+ i +"].Name");
				flowItem.Description = _ctx.StringValue("ListFlow.Flow["+ i +"].Description");
				flowItem.Type = _ctx.StringValue("ListFlow.Flow["+ i +"].Type");
				flowItem.Status = _ctx.StringValue("ListFlow.Flow["+ i +"].Status");
				flowItem.Periodic = _ctx.BooleanValue("ListFlow.Flow["+ i +"].Periodic");
				flowItem.StartSchedule = _ctx.LongValue("ListFlow.Flow["+ i +"].StartSchedule");
				flowItem.EndSchedule = _ctx.LongValue("ListFlow.Flow["+ i +"].EndSchedule");
				flowItem.CronExpr = _ctx.StringValue("ListFlow.Flow["+ i +"].CronExpr");
				flowItem.CreateCluster = _ctx.BooleanValue("ListFlow.Flow["+ i +"].CreateCluster");
				flowItem.ClusterId = _ctx.StringValue("ListFlow.Flow["+ i +"].ClusterId");
				flowItem.ProjectId = _ctx.StringValue("ListFlow.Flow["+ i +"].ProjectId");
				flowItem.HostName = _ctx.StringValue("ListFlow.Flow["+ i +"].HostName");
				flowItem.Graph = _ctx.StringValue("ListFlow.Flow["+ i +"].Graph");
				flowItem.AlertUserGroupBizId = _ctx.StringValue("ListFlow.Flow["+ i +"].AlertUserGroupBizId");
				flowItem.AlertDingDingGroupBizId = _ctx.StringValue("ListFlow.Flow["+ i +"].AlertDingDingGroupBizId");
				flowItem.AlertConf = _ctx.StringValue("ListFlow.Flow["+ i +"].AlertConf");
				flowItem.CategoryId = _ctx.StringValue("ListFlow.Flow["+ i +"].CategoryId");

				listFlowResponse_flow.Add(flowItem);
			}
			listFlowResponse.Flow = listFlowResponse_flow;
        
			return listFlowResponse;
        }
    }
}
