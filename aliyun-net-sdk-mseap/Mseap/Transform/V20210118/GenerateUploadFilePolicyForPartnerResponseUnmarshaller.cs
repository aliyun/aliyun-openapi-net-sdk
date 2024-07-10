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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class GenerateUploadFilePolicyForPartnerResponseUnmarshaller
    {
        public static GenerateUploadFilePolicyForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateUploadFilePolicyForPartnerResponse generateUploadFilePolicyForPartnerResponse = new GenerateUploadFilePolicyForPartnerResponse();

			generateUploadFilePolicyForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			generateUploadFilePolicyForPartnerResponse.RequestId = _ctx.StringValue("GenerateUploadFilePolicyForPartner.RequestId");
			generateUploadFilePolicyForPartnerResponse.HttpStatusCode = _ctx.IntegerValue("GenerateUploadFilePolicyForPartner.HttpStatusCode");
			generateUploadFilePolicyForPartnerResponse.DynamicCode = _ctx.StringValue("GenerateUploadFilePolicyForPartner.DynamicCode");
			generateUploadFilePolicyForPartnerResponse.DynamicMessage = _ctx.StringValue("GenerateUploadFilePolicyForPartner.DynamicMessage");
			generateUploadFilePolicyForPartnerResponse.ErrorMsg = _ctx.StringValue("GenerateUploadFilePolicyForPartner.ErrorMsg");
			generateUploadFilePolicyForPartnerResponse.ErrorCode = _ctx.StringValue("GenerateUploadFilePolicyForPartner.ErrorCode");
			generateUploadFilePolicyForPartnerResponse.Success = _ctx.BooleanValue("GenerateUploadFilePolicyForPartner.Success");
			generateUploadFilePolicyForPartnerResponse.AllowRetry = _ctx.BooleanValue("GenerateUploadFilePolicyForPartner.AllowRetry");
			generateUploadFilePolicyForPartnerResponse.AppName = _ctx.StringValue("GenerateUploadFilePolicyForPartner.AppName");

			List<string> generateUploadFilePolicyForPartnerResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("GenerateUploadFilePolicyForPartner.ErrorArgs.Length"); i++) {
				generateUploadFilePolicyForPartnerResponse_errorArgs.Add(_ctx.StringValue("GenerateUploadFilePolicyForPartner.ErrorArgs["+ i +"]"));
			}
			generateUploadFilePolicyForPartnerResponse.ErrorArgs = generateUploadFilePolicyForPartnerResponse_errorArgs;

			GenerateUploadFilePolicyForPartnerResponse.GenerateUploadFilePolicyForPartner_Module module = new GenerateUploadFilePolicyForPartnerResponse.GenerateUploadFilePolicyForPartner_Module();
			module.AccessId = _ctx.StringValue("GenerateUploadFilePolicyForPartner.Module.AccessId");
			module.EncodedPolicy = _ctx.StringValue("GenerateUploadFilePolicyForPartner.Module.EncodedPolicy");
			module.Signature = _ctx.StringValue("GenerateUploadFilePolicyForPartner.Module.Signature");
			module.FileDir = _ctx.StringValue("GenerateUploadFilePolicyForPartner.Module.FileDir");
			module.Host = _ctx.StringValue("GenerateUploadFilePolicyForPartner.Module.Host");
			module.ExpireTime = _ctx.LongValue("GenerateUploadFilePolicyForPartner.Module.ExpireTime");
			module.OssUrl = _ctx.StringValue("GenerateUploadFilePolicyForPartner.Module.OssUrl");
			generateUploadFilePolicyForPartnerResponse.Module = module;
        
			return generateUploadFilePolicyForPartnerResponse;
        }
    }
}
