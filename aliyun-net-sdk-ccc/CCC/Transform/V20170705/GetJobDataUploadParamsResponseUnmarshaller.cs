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
        public static GetJobDataUploadParamsResponse Unmarshall(UnmarshallerContext context)
        {
			GetJobDataUploadParamsResponse getJobDataUploadParamsResponse = new GetJobDataUploadParamsResponse();

			getJobDataUploadParamsResponse.HttpResponse = context.HttpResponse;
			getJobDataUploadParamsResponse.RequestId = context.StringValue("GetJobDataUploadParams.RequestId");
			getJobDataUploadParamsResponse.Success = context.BooleanValue("GetJobDataUploadParams.Success");
			getJobDataUploadParamsResponse.Code = context.StringValue("GetJobDataUploadParams.Code");
			getJobDataUploadParamsResponse.Message = context.StringValue("GetJobDataUploadParams.Message");
			getJobDataUploadParamsResponse.HttpStatusCode = context.IntegerValue("GetJobDataUploadParams.HttpStatusCode");

			GetJobDataUploadParamsResponse.GetJobDataUploadParams_UploadParams uploadParams = new GetJobDataUploadParamsResponse.GetJobDataUploadParams_UploadParams();
			uploadParams.AccessId = context.StringValue("GetJobDataUploadParams.UploadParams.AccessId");
			uploadParams.Policy = context.StringValue("GetJobDataUploadParams.UploadParams.Policy");
			uploadParams.Signature = context.StringValue("GetJobDataUploadParams.UploadParams.Signature");
			uploadParams.Folder = context.StringValue("GetJobDataUploadParams.UploadParams.Folder");
			uploadParams.Host = context.StringValue("GetJobDataUploadParams.UploadParams.Host");
			uploadParams.Expire = context.IntegerValue("GetJobDataUploadParams.UploadParams.Expire");
			getJobDataUploadParamsResponse.UploadParams = uploadParams;
        
			return getJobDataUploadParamsResponse;
        }
    }
}
