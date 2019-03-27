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
        public static CommitContactFlowVersionModificationResponse Unmarshall(UnmarshallerContext context)
        {
			CommitContactFlowVersionModificationResponse commitContactFlowVersionModificationResponse = new CommitContactFlowVersionModificationResponse();

			commitContactFlowVersionModificationResponse.HttpResponse = context.HttpResponse;
			commitContactFlowVersionModificationResponse.RequestId = context.StringValue("CommitContactFlowVersionModification.RequestId");
			commitContactFlowVersionModificationResponse.Success = context.BooleanValue("CommitContactFlowVersionModification.Success");
			commitContactFlowVersionModificationResponse.Code = context.StringValue("CommitContactFlowVersionModification.Code");
			commitContactFlowVersionModificationResponse.Message = context.StringValue("CommitContactFlowVersionModification.Message");
			commitContactFlowVersionModificationResponse.HttpStatusCode = context.IntegerValue("CommitContactFlowVersionModification.HttpStatusCode");

			CommitContactFlowVersionModificationResponse.CommitContactFlowVersionModification_ContactFlowVersion contactFlowVersion = new CommitContactFlowVersionModificationResponse.CommitContactFlowVersionModification_ContactFlowVersion();
			contactFlowVersion.ContactFlowVersionId = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.ContactFlowVersionId");
			contactFlowVersion.Version = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Version");
			contactFlowVersion.ContactFlowVersionDescription = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.ContactFlowVersionDescription");
			contactFlowVersion.Canvas = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Canvas");
			contactFlowVersion.Content = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Content");
			contactFlowVersion.LastModified = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.LastModified");
			contactFlowVersion.LastModifiedBy = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.LastModifiedBy");
			contactFlowVersion.LockedBy = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.LockedBy");
			contactFlowVersion.Status = context.StringValue("CommitContactFlowVersionModification.ContactFlowVersion.Status");
			commitContactFlowVersionModificationResponse.ContactFlowVersion = contactFlowVersion;
        
			return commitContactFlowVersionModificationResponse;
        }
    }
}
