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
using Aliyun.Acs.ComputeNestSupplier.Model.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Transform.V20210521
{
    public class GetUploadCredentialsResponseUnmarshaller
    {
        public static GetUploadCredentialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUploadCredentialsResponse getUploadCredentialsResponse = new GetUploadCredentialsResponse();

			getUploadCredentialsResponse.HttpResponse = _ctx.HttpResponse;
			getUploadCredentialsResponse.Success = _ctx.BooleanValue("GetUploadCredentials.Success");
			getUploadCredentialsResponse.Code = _ctx.StringValue("GetUploadCredentials.Code");
			getUploadCredentialsResponse.Message = _ctx.StringValue("GetUploadCredentials.Message");
			getUploadCredentialsResponse.HttpStatusCode = _ctx.IntegerValue("GetUploadCredentials.HttpStatusCode");
			getUploadCredentialsResponse.RequestId = _ctx.StringValue("GetUploadCredentials.RequestId");

			GetUploadCredentialsResponse.GetUploadCredentials_Data data = new GetUploadCredentialsResponse.GetUploadCredentials_Data();
			data.AccessKeyId = _ctx.StringValue("GetUploadCredentials.Data.AccessKeyId");
			data.AccessKeySecret = _ctx.StringValue("GetUploadCredentials.Data.AccessKeySecret");
			data.SecurityToken = _ctx.StringValue("GetUploadCredentials.Data.SecurityToken");
			data.ExpireDate = _ctx.StringValue("GetUploadCredentials.Data.ExpireDate");
			data.RegionId = _ctx.StringValue("GetUploadCredentials.Data.RegionId");
			data.BucketName = _ctx.StringValue("GetUploadCredentials.Data.BucketName");
			data.Key = _ctx.StringValue("GetUploadCredentials.Data.Key");
			getUploadCredentialsResponse.Data = data;
        
			return getUploadCredentialsResponse;
        }
    }
}
