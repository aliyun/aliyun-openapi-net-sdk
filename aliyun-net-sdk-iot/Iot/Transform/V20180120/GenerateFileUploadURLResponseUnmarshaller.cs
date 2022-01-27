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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GenerateFileUploadURLResponseUnmarshaller
    {
        public static GenerateFileUploadURLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateFileUploadURLResponse generateFileUploadURLResponse = new GenerateFileUploadURLResponse();

			generateFileUploadURLResponse.HttpResponse = _ctx.HttpResponse;
			generateFileUploadURLResponse.RequestId = _ctx.StringValue("GenerateFileUploadURL.RequestId");
			generateFileUploadURLResponse.Success = _ctx.BooleanValue("GenerateFileUploadURL.Success");
			generateFileUploadURLResponse.Code = _ctx.StringValue("GenerateFileUploadURL.Code");
			generateFileUploadURLResponse.ErrorMessage = _ctx.StringValue("GenerateFileUploadURL.ErrorMessage");

			GenerateFileUploadURLResponse.GenerateFileUploadURL_Data data = new GenerateFileUploadURLResponse.GenerateFileUploadURL_Data();
			data.Key = _ctx.StringValue("GenerateFileUploadURL.Data.Key");
			data.Host = _ctx.StringValue("GenerateFileUploadURL.Data.Host");
			data.Policy = _ctx.StringValue("GenerateFileUploadURL.Data.Policy");
			data.OssAccessKeyId = _ctx.StringValue("GenerateFileUploadURL.Data.OssAccessKeyId");
			data.Signature = _ctx.StringValue("GenerateFileUploadURL.Data.Signature");
			data.ObjectStorage = _ctx.StringValue("GenerateFileUploadURL.Data.ObjectStorage");
			generateFileUploadURLResponse.Data = data;
        
			return generateFileUploadURLResponse;
        }
    }
}
