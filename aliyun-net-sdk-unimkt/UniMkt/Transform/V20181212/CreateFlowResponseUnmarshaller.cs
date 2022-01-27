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
    public class CreateFlowResponseUnmarshaller
    {
        public static CreateFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateFlowResponse createFlowResponse = new CreateFlowResponse();

			createFlowResponse.HttpResponse = _ctx.HttpResponse;
			createFlowResponse.Code = _ctx.StringValue("CreateFlow.Code");
			createFlowResponse.Success = _ctx.BooleanValue("CreateFlow.Success");
			createFlowResponse.Message = _ctx.StringValue("CreateFlow.Message");
			createFlowResponse.RequestId = _ctx.StringValue("CreateFlow.RequestId");

			CreateFlowResponse.CreateFlow_Model model = new CreateFlowResponse.CreateFlow_Model();
			model.FlowId = _ctx.StringValue("CreateFlow.Model.FlowId");
			model.GmtCreateTime = _ctx.LongValue("CreateFlow.Model.GmtCreateTime");
			model.GmtModifiedTime = _ctx.LongValue("CreateFlow.Model.GmtModifiedTime");
			model.TenantId = _ctx.StringValue("CreateFlow.Model.TenantId");
			model.ExtInfo = _ctx.StringValue("CreateFlow.Model.ExtInfo");
			model.Type = _ctx.StringValue("CreateFlow.Model.Type");
			model.BusinessKey = _ctx.StringValue("CreateFlow.Model.BusinessKey");
			model.ReasonType = _ctx.StringValue("CreateFlow.Model.ReasonType");
			model.OldData = _ctx.StringValue("CreateFlow.Model.OldData");
			model.NewData = _ctx.StringValue("CreateFlow.Model.NewData");
			model.Status = _ctx.StringValue("CreateFlow.Model.Status");
			model.ChildStatus = _ctx.StringValue("CreateFlow.Model.ChildStatus");
			model.ApplyUserId = _ctx.StringValue("CreateFlow.Model.ApplyUserId");
			model.ApproveUserId = _ctx.StringValue("CreateFlow.Model.ApproveUserId");
			model.ApproveTime = _ctx.LongValue("CreateFlow.Model.ApproveTime");
			createFlowResponse.Model = model;
        
			return createFlowResponse;
        }
    }
}
