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
    public class GenerateOTAUploadURLResponseUnmarshaller
    {
        public static GenerateOTAUploadURLResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateOTAUploadURLResponse generateOTAUploadURLResponse = new GenerateOTAUploadURLResponse();

			generateOTAUploadURLResponse.HttpResponse = context.HttpResponse;
			generateOTAUploadURLResponse.RequestId = context.StringValue("GenerateOTAUploadURL.RequestId");
			generateOTAUploadURLResponse.Success = context.BooleanValue("GenerateOTAUploadURL.Success");
			generateOTAUploadURLResponse.Code = context.StringValue("GenerateOTAUploadURL.Code");
			generateOTAUploadURLResponse.ErrorMessage = context.StringValue("GenerateOTAUploadURL.ErrorMessage");

			GenerateOTAUploadURLResponse.GenerateOTAUploadURL_Data data = new GenerateOTAUploadURLResponse.GenerateOTAUploadURL_Data();
			data.Key = context.StringValue("GenerateOTAUploadURL.Data.Key");
			data.Host = context.StringValue("GenerateOTAUploadURL.Data.Host");
			data.Policy = context.StringValue("GenerateOTAUploadURL.Data.Policy");
			data.OSSAccessKeyId = context.StringValue("GenerateOTAUploadURL.Data.OSSAccessKeyId");
			data.Signature = context.StringValue("GenerateOTAUploadURL.Data.Signature");
			data.FirmwareUrl = context.StringValue("GenerateOTAUploadURL.Data.FirmwareUrl");
			data.UtcCreate = context.StringValue("GenerateOTAUploadURL.Data.UtcCreate");
			data.ObjectStorage = context.StringValue("GenerateOTAUploadURL.Data.ObjectStorage");
			generateOTAUploadURLResponse.Data = data;
        
			return generateOTAUploadURLResponse;
        }
    }
}
