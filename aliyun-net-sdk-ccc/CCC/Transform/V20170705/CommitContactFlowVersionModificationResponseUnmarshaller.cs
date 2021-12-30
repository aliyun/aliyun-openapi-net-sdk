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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class CommitContactFlowVersionModificationResponseUnmarshaller
    {
        public static CommitContactFlowVersionModificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CommitContactFlowVersionModificationResponse commitContactFlowVersionModificationResponse = new CommitContactFlowVersionModificationResponse();

			commitContactFlowVersionModificationResponse.HttpResponse = _ctx.HttpResponse;
			commitContactFlowVersionModificationResponse.RequestId = _ctx.StringValue("CommitContactFlowVersionModification.RequestId");
			commitContactFlowVersionModificationResponse.Success = _ctx.BooleanValue("CommitContactFlowVersionModification.Success");
			commitContactFlowVersionModificationResponse.Code = _ctx.StringValue("CommitContactFlowVersionModification.Code");
			commitContactFlowVersionModificationResponse.Message = _ctx.StringValue("CommitContactFlowVersionModification.Message");
			commitContactFlowVersionModificationResponse.HttpStatusCode = _ctx.IntegerValue("CommitContactFlowVersionModification.HttpStatusCode");

			CommitContactFlowVersionModificationResponse.CommitContactFlowVersionModification_ContactFlowVersion contactFlowVersion = new CommitContactFlowVersionModificationResponse.CommitContactFlowVersionModification_ContactFlowVersion();
			contactFlowVersion.ContactFlowVersionId = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.ContactFlowVersionId");
			contactFlowVersion.Version = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Version");
			contactFlowVersion.ContactFlowVersionDescription = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.ContactFlowVersionDescription");
			contactFlowVersion.Canvas = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Canvas");
			contactFlowVersion.Content = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Content");
			contactFlowVersion.LastModified = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.LastModified");
			contactFlowVersion.LastModifiedBy = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.LastModifiedBy");
			contactFlowVersion.LockedBy = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.LockedBy");
			contactFlowVersion.Status = _ctx.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Status");
			commitContactFlowVersionModificationResponse.ContactFlowVersion = contactFlowVersion;
        
			return commitContactFlowVersionModificationResponse;
        }
    }
}
