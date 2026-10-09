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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class GetSkillImportFileUrlResponseUnmarshaller
    {
        public static GetSkillImportFileUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSkillImportFileUrlResponse getSkillImportFileUrlResponse = new GetSkillImportFileUrlResponse();

			getSkillImportFileUrlResponse.HttpResponse = _ctx.HttpResponse;
			getSkillImportFileUrlResponse.RequestId = _ctx.StringValue("GetSkillImportFileUrl.RequestId");

			GetSkillImportFileUrlResponse.GetSkillImportFileUrl_Data data = new GetSkillImportFileUrlResponse.GetSkillImportFileUrl_Data();
			data.UploadUrl = _ctx.StringValue("GetSkillImportFileUrl.Data.UploadUrl");
			data.ContentType = _ctx.StringValue("GetSkillImportFileUrl.Data.ContentType");
			data.OssObjectName = _ctx.StringValue("GetSkillImportFileUrl.Data.OssObjectName");
			data.MaxSize = _ctx.StringValue("GetSkillImportFileUrl.Data.MaxSize");
			getSkillImportFileUrlResponse.Data = data;
        
			return getSkillImportFileUrlResponse;
        }
    }
}
