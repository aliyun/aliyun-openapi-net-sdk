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
    public class GetAuditResultResponseUnmarshaller
    {
        public static GetAuditResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetAuditResultResponse getAuditResultResponse = new GetAuditResultResponse();

			getAuditResultResponse.HttpResponse = context.HttpResponse;
			getAuditResultResponse.RequestId = context.StringValue("GetAuditResult.RequestId");

			GetAuditResultResponse.GetAuditResult_AIAuditResult aIAuditResult = new GetAuditResultResponse.GetAuditResult_AIAuditResult();
			aIAuditResult.AbnormalModules = context.StringValue("GetAuditResult.AIAuditResult.AbnormalModules");
			aIAuditResult.Label = context.StringValue("GetAuditResult.AIAuditResult.Label");
			aIAuditResult.PornResult = context.StringValue("GetAuditResult.AIAuditResult.PornResult");
			aIAuditResult.TerrorismResult = context.StringValue("GetAuditResult.AIAuditResult.TerrorismResult");
			aIAuditResult.TitleResult = context.StringValue("GetAuditResult.AIAuditResult.TitleResult");
			aIAuditResult.CoverResult = context.StringValue("GetAuditResult.AIAuditResult.CoverResult");
			getAuditResultResponse.AIAuditResult = aIAuditResult;
        
			return getAuditResultResponse;
        }
    }
}