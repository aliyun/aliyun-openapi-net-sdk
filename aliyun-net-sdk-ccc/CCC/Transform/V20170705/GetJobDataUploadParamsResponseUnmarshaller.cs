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
    public class GetJobDataUploadParamsResponseUnmarshaller
    {
        public static GetJobDataUploadParamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJobDataUploadParamsResponse getJobDataUploadParamsResponse = new GetJobDataUploadParamsResponse();

			getJobDataUploadParamsResponse.HttpResponse = _ctx.HttpResponse;
			getJobDataUploadParamsResponse.RequestId = _ctx.StringValue("GetJobDataUploadParams.RequestId");
			getJobDataUploadParamsResponse.Success = _ctx.BooleanValue("GetJobDataUploadParams.Success");
			getJobDataUploadParamsResponse.Code = _ctx.StringValue("GetJobDataUploadParams.Code");
			getJobDataUploadParamsResponse.Message = _ctx.StringValue("GetJobDataUploadParams.Message");
			getJobDataUploadParamsResponse.HttpStatusCode = _ctx.IntegerValue("GetJobDataUploadParams.HttpStatusCode");

			GetJobDataUploadParamsResponse.GetJobDataUploadParams_UploadParams uploadParams = new GetJobDataUploadParamsResponse.GetJobDataUploadParams_UploadParams();
			uploadParams.AccessId = _ctx.StringValue("GetJobDataUploadParams.UploadParams.AccessId");
			uploadParams.Policy = _ctx.StringValue("GetJobDataUploadParams.UploadParams.Policy");
			uploadParams.Signature = _ctx.StringValue("GetJobDataUploadParams.UploadParams.Signature");
			uploadParams.Folder = _ctx.StringValue("GetJobDataUploadParams.UploadParams.Folder");
			uploadParams.Host = _ctx.StringValue("GetJobDataUploadParams.UploadParams.Host");
			uploadParams.Expire = _ctx.IntegerValue("GetJobDataUploadParams.UploadParams.Expire");
			getJobDataUploadParamsResponse.UploadParams = uploadParams;
        
			return getJobDataUploadParamsResponse;
        }
    }
}
