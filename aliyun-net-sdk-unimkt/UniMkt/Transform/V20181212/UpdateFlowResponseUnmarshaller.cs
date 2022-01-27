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
    public class UpdateFlowResponseUnmarshaller
    {
        public static UpdateFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateFlowResponse updateFlowResponse = new UpdateFlowResponse();

			updateFlowResponse.HttpResponse = _ctx.HttpResponse;
			updateFlowResponse.Code = _ctx.StringValue("UpdateFlow.Code");
			updateFlowResponse.Success = _ctx.BooleanValue("UpdateFlow.Success");
			updateFlowResponse.Message = _ctx.StringValue("UpdateFlow.Message");
			updateFlowResponse.RequestId = _ctx.StringValue("UpdateFlow.RequestId");

			UpdateFlowResponse.UpdateFlow_Model model = new UpdateFlowResponse.UpdateFlow_Model();
			model.FlowId = _ctx.StringValue("UpdateFlow.Model.FlowId");
			model.GmtCreateTime = _ctx.LongValue("UpdateFlow.Model.GmtCreateTime");
			model.GmtModifiedTime = _ctx.LongValue("UpdateFlow.Model.GmtModifiedTime");
			model.TenantId = _ctx.StringValue("UpdateFlow.Model.TenantId");
			model.ExtInfo = _ctx.StringValue("UpdateFlow.Model.ExtInfo");
			model.Type = _ctx.StringValue("UpdateFlow.Model.Type");
			model.BusinessKey = _ctx.StringValue("UpdateFlow.Model.BusinessKey");
			model.ReasonType = _ctx.StringValue("UpdateFlow.Model.ReasonType");
			model.OldData = _ctx.StringValue("UpdateFlow.Model.OldData");
			model.NewData = _ctx.StringValue("UpdateFlow.Model.NewData");
			model.Status = _ctx.StringValue("UpdateFlow.Model.Status");
			model.ChildStatus = _ctx.StringValue("UpdateFlow.Model.ChildStatus");
			model.ApplyUserId = _ctx.StringValue("UpdateFlow.Model.ApplyUserId");
			model.ApproveUserId = _ctx.StringValue("UpdateFlow.Model.ApproveUserId");
			model.ApproveTime = _ctx.LongValue("UpdateFlow.Model.ApproveTime");
			updateFlowResponse.Model = model;
        
			return updateFlowResponse;
        }
    }
}
