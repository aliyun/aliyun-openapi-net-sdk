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
    public class GetRecordOssUploadParamResponseUnmarshaller
    {
        public static GetRecordOssUploadParamResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRecordOssUploadParamResponse getRecordOssUploadParamResponse = new GetRecordOssUploadParamResponse();

			getRecordOssUploadParamResponse.HttpResponse = _ctx.HttpResponse;
			getRecordOssUploadParamResponse.RequestId = _ctx.StringValue("GetRecordOssUploadParam.RequestId");
			getRecordOssUploadParamResponse.Success = _ctx.BooleanValue("GetRecordOssUploadParam.Success");
			getRecordOssUploadParamResponse.Code = _ctx.StringValue("GetRecordOssUploadParam.Code");
			getRecordOssUploadParamResponse.Message = _ctx.StringValue("GetRecordOssUploadParam.Message");
			getRecordOssUploadParamResponse.HttpStatusCode = _ctx.IntegerValue("GetRecordOssUploadParam.HttpStatusCode");
			getRecordOssUploadParamResponse.OssAccessKeyId = _ctx.StringValue("GetRecordOssUploadParam.OssAccessKeyId");
			getRecordOssUploadParamResponse.Policy = _ctx.StringValue("GetRecordOssUploadParam.Policy");
			getRecordOssUploadParamResponse.Signature = _ctx.StringValue("GetRecordOssUploadParam.Signature");
			getRecordOssUploadParamResponse.Expires = _ctx.StringValue("GetRecordOssUploadParam.Expires");
			getRecordOssUploadParamResponse.Dir = _ctx.StringValue("GetRecordOssUploadParam.Dir");
			getRecordOssUploadParamResponse.Host = _ctx.StringValue("GetRecordOssUploadParam.Host");
			getRecordOssUploadParamResponse.OssFileName = _ctx.StringValue("GetRecordOssUploadParam.OssFileName");
        
			return getRecordOssUploadParamResponse;
        }
    }
}
