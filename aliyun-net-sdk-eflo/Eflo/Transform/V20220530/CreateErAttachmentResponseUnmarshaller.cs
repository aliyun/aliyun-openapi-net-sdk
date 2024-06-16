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
    public class CreateErAttachmentResponseUnmarshaller
    {
        public static CreateErAttachmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateErAttachmentResponse createErAttachmentResponse = new CreateErAttachmentResponse();

			createErAttachmentResponse.HttpResponse = _ctx.HttpResponse;
			createErAttachmentResponse.Code = _ctx.IntegerValue("CreateErAttachment.Code");
			createErAttachmentResponse.Message = _ctx.StringValue("CreateErAttachment.Message");
			createErAttachmentResponse.RequestId = _ctx.StringValue("CreateErAttachment.RequestId");

			CreateErAttachmentResponse.CreateErAttachment_Content content = new CreateErAttachmentResponse.CreateErAttachment_Content();
			content.ErAttachmentId = _ctx.StringValue("CreateErAttachment.Content.ErAttachmentId");
			createErAttachmentResponse.Content = content;
        
			return createErAttachmentResponse;
        }
    }
}
