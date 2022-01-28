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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetCaseFileUploadUrlResponseUnmarshaller
    {
        public static GetCaseFileUploadUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCaseFileUploadUrlResponse getCaseFileUploadUrlResponse = new GetCaseFileUploadUrlResponse();

			getCaseFileUploadUrlResponse.HttpResponse = _ctx.HttpResponse;
			getCaseFileUploadUrlResponse.HttpStatusCode = _ctx.IntegerValue("GetCaseFileUploadUrl.HttpStatusCode");
			getCaseFileUploadUrlResponse.Code = _ctx.StringValue("GetCaseFileUploadUrl.Code");
			getCaseFileUploadUrlResponse.Message = _ctx.StringValue("GetCaseFileUploadUrl.Message");
			getCaseFileUploadUrlResponse.RequestId = _ctx.StringValue("GetCaseFileUploadUrl.RequestId");

			GetCaseFileUploadUrlResponse.GetCaseFileUploadUrl_Data data = new GetCaseFileUploadUrlResponse.GetCaseFileUploadUrl_Data();
			data.Url = _ctx.StringValue("GetCaseFileUploadUrl.Data.Url");
			data.CaseFileKey = _ctx.StringValue("GetCaseFileUploadUrl.Data.CaseFileKey");
			getCaseFileUploadUrlResponse.Data = data;
        
			return getCaseFileUploadUrlResponse;
        }
    }
}
