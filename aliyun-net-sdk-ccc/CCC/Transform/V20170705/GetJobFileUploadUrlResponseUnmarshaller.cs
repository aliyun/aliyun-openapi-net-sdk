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
    public class GetJobFileUploadUrlResponseUnmarshaller
    {
        public static GetJobFileUploadUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobFileUploadUrlResponse getJobFileUploadUrlResponse = new GetJobFileUploadUrlResponse();

			getJobFileUploadUrlResponse.HttpResponse = _ctx.HttpResponse;
			getJobFileUploadUrlResponse.RequestId = _ctx.StringValue("GetJobFileUploadUrl.RequestId");
			getJobFileUploadUrlResponse.Success = _ctx.BooleanValue("GetJobFileUploadUrl.Success");
			getJobFileUploadUrlResponse.Code = _ctx.StringValue("GetJobFileUploadUrl.Code");
			getJobFileUploadUrlResponse.Message = _ctx.StringValue("GetJobFileUploadUrl.Message");
			getJobFileUploadUrlResponse.HttpStatusCode = _ctx.IntegerValue("GetJobFileUploadUrl.HttpStatusCode");
			getJobFileUploadUrlResponse.FilePath = _ctx.StringValue("GetJobFileUploadUrl.FilePath");
			getJobFileUploadUrlResponse.UploadUrl = _ctx.StringValue("GetJobFileUploadUrl.UploadUrl");
        
			return getJobFileUploadUrlResponse;
        }
    }
}
