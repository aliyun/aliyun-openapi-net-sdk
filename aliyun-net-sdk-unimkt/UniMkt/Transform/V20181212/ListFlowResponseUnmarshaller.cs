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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ListFlowResponseUnmarshaller
    {
        public static ListFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowResponse listFlowResponse = new ListFlowResponse();

			listFlowResponse.HttpResponse = _ctx.HttpResponse;
			listFlowResponse.Code = _ctx.StringValue("ListFlow.Code");
			listFlowResponse.Success = _ctx.BooleanValue("ListFlow.Success");
			listFlowResponse.Message = _ctx.StringValue("ListFlow.Message");
			listFlowResponse.RequestId = _ctx.StringValue("ListFlow.RequestId");
			listFlowResponse.Total = _ctx.LongValue("ListFlow.Total");
			listFlowResponse.PageNumber = _ctx.IntegerValue("ListFlow.PageNumber");
			listFlowResponse.PageSize = _ctx.IntegerValue("ListFlow.PageSize");

			List<ListFlowResponse.ListFlow_FlowDTOModel> listFlowResponse_model = new List<ListFlowResponse.ListFlow_FlowDTOModel>();
			for (int i = 0; i < _ctx.Length("ListFlow.Model.Length"); i++) {
				ListFlowResponse.ListFlow_FlowDTOModel flowDTOModel = new ListFlowResponse.ListFlow_FlowDTOModel();
				flowDTOModel.FlowId = _ctx.StringValue("ListFlow.Model["+ i +"].FlowId");
				flowDTOModel.GmtCreateTime = _ctx.LongValue("ListFlow.Model["+ i +"].GmtCreateTime");
				flowDTOModel.GmtModifiedTime = _ctx.LongValue("ListFlow.Model["+ i +"].GmtModifiedTime");
				flowDTOModel.TenantId = _ctx.StringValue("ListFlow.Model["+ i +"].TenantId");
				flowDTOModel.ExtInfo = _ctx.StringValue("ListFlow.Model["+ i +"].ExtInfo");
				flowDTOModel.Type = _ctx.StringValue("ListFlow.Model["+ i +"].Type");
				flowDTOModel.BusinessKey = _ctx.StringValue("ListFlow.Model["+ i +"].BusinessKey");
				flowDTOModel.ReasonType = _ctx.StringValue("ListFlow.Model["+ i +"].ReasonType");
				flowDTOModel.OldData = _ctx.StringValue("ListFlow.Model["+ i +"].OldData");
				flowDTOModel.NewData = _ctx.StringValue("ListFlow.Model["+ i +"].NewData");
				flowDTOModel.Status = _ctx.StringValue("ListFlow.Model["+ i +"].Status");
				flowDTOModel.ChildStatus = _ctx.StringValue("ListFlow.Model["+ i +"].ChildStatus");
				flowDTOModel.ApplyUserId = _ctx.StringValue("ListFlow.Model["+ i +"].ApplyUserId");
				flowDTOModel.ApproveUserId = _ctx.StringValue("ListFlow.Model["+ i +"].ApproveUserId");
				flowDTOModel.ApproveTime = _ctx.LongValue("ListFlow.Model["+ i +"].ApproveTime");

				listFlowResponse_model.Add(flowDTOModel);
			}
			listFlowResponse.Model = listFlowResponse_model;
        
			return listFlowResponse;
        }
    }
}
