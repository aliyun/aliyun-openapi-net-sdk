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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetWorkFlowResponseUnmarshaller
    {
        public static GetWorkFlowResponse Unmarshall(UnmarshallerContext context)
        {
			GetWorkFlowResponse getWorkFlowResponse = new GetWorkFlowResponse();

			getWorkFlowResponse.HttpResponse = context.HttpResponse;
			getWorkFlowResponse.RequestId = context.StringValue("GetWorkFlow.RequestId");

			GetWorkFlowResponse.GetWorkFlow_WorkFlowInfo workFlowInfo = new GetWorkFlowResponse.GetWorkFlow_WorkFlowInfo();
			workFlowInfo.WorkFlowId = context.StringValue("GetWorkFlow.WorkFlowInfo.WorkFlowId");
			workFlowInfo.Name = context.StringValue("GetWorkFlow.WorkFlowInfo.Name");
			workFlowInfo.ActionList = context.StringValue("GetWorkFlow.WorkFlowInfo.ActionList");
			workFlowInfo.CreationTime = context.StringValue("GetWorkFlow.WorkFlowInfo.CreationTime");
			workFlowInfo.ModifyTime = context.StringValue("GetWorkFlow.WorkFlowInfo.ModifyTime");
			getWorkFlowResponse.WorkFlowInfo = workFlowInfo;
        
			return getWorkFlowResponse;
        }
    }
}