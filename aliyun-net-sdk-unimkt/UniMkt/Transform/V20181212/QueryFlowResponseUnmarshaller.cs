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
    public class QueryFlowResponseUnmarshaller
    {
        public static QueryFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryFlowResponse queryFlowResponse = new QueryFlowResponse();

			queryFlowResponse.HttpResponse = _ctx.HttpResponse;
			queryFlowResponse.Code = _ctx.StringValue("QueryFlow.Code");
			queryFlowResponse.Success = _ctx.BooleanValue("QueryFlow.Success");
			queryFlowResponse.Message = _ctx.StringValue("QueryFlow.Message");
			queryFlowResponse.RequestId = _ctx.StringValue("QueryFlow.RequestId");

			QueryFlowResponse.QueryFlow_Model model = new QueryFlowResponse.QueryFlow_Model();
			model.FlowId = _ctx.StringValue("QueryFlow.Model.FlowId");
			model.GmtCreateTime = _ctx.LongValue("QueryFlow.Model.GmtCreateTime");
			model.GmtModifiedTime = _ctx.LongValue("QueryFlow.Model.GmtModifiedTime");
			model.TenantId = _ctx.StringValue("QueryFlow.Model.TenantId");
			model.ExtInfo = _ctx.StringValue("QueryFlow.Model.ExtInfo");
			model.Type = _ctx.StringValue("QueryFlow.Model.Type");
			model.BusinessKey = _ctx.StringValue("QueryFlow.Model.BusinessKey");
			model.ReasonType = _ctx.StringValue("QueryFlow.Model.ReasonType");
			model.OldData = _ctx.StringValue("QueryFlow.Model.OldData");
			model.NewData = _ctx.StringValue("QueryFlow.Model.NewData");
			model.Status = _ctx.StringValue("QueryFlow.Model.Status");
			model.ChildStatus = _ctx.StringValue("QueryFlow.Model.ChildStatus");
			model.ApplyUserId = _ctx.StringValue("QueryFlow.Model.ApplyUserId");
			model.ApproveUserId = _ctx.StringValue("QueryFlow.Model.ApproveUserId");
			model.ApproveTime = _ctx.LongValue("QueryFlow.Model.ApproveTime");
			queryFlowResponse.Model = model;
        
			return queryFlowResponse;
        }
    }
}
