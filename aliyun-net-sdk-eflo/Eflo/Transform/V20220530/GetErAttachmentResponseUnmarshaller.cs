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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetErAttachmentResponseUnmarshaller
    {
        public static GetErAttachmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetErAttachmentResponse getErAttachmentResponse = new GetErAttachmentResponse();

			getErAttachmentResponse.HttpResponse = _ctx.HttpResponse;
			getErAttachmentResponse.Code = _ctx.IntegerValue("GetErAttachment.Code");
			getErAttachmentResponse.Message = _ctx.StringValue("GetErAttachment.Message");
			getErAttachmentResponse.RequestId = _ctx.StringValue("GetErAttachment.RequestId");

			GetErAttachmentResponse.GetErAttachment_Content content = new GetErAttachmentResponse.GetErAttachment_Content();
			content.CreateTime = _ctx.StringValue("GetErAttachment.Content.CreateTime");
			content.GmtModified = _ctx.StringValue("GetErAttachment.Content.GmtModified");
			content.Message = _ctx.StringValue("GetErAttachment.Content.Message");
			content.Status = _ctx.StringValue("GetErAttachment.Content.Status");
			content.RegionId = _ctx.StringValue("GetErAttachment.Content.RegionId");
			content.TenantId = _ctx.StringValue("GetErAttachment.Content.TenantId");
			content.ErAttachmentName = _ctx.StringValue("GetErAttachment.Content.ErAttachmentName");
			content.ErAttachmentId = _ctx.StringValue("GetErAttachment.Content.ErAttachmentId");
			content.ErId = _ctx.StringValue("GetErAttachment.Content.ErId");
			content.InstanceType = _ctx.StringValue("GetErAttachment.Content.InstanceType");
			content.InstanceId = _ctx.StringValue("GetErAttachment.Content.InstanceId");
			content.InstanceName = _ctx.StringValue("GetErAttachment.Content.InstanceName");
			content.AutoReceiveAllRoute = _ctx.BooleanValue("GetErAttachment.Content.AutoReceiveAllRoute");
			content.Across = _ctx.BooleanValue("GetErAttachment.Content.Across");
			content.ResourceTenantId = _ctx.StringValue("GetErAttachment.Content.ResourceTenantId");
			getErAttachmentResponse.Content = content;
        
			return getErAttachmentResponse;
        }
    }
}
