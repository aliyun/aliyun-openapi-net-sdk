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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class CreateSAMLProviderResponseUnmarshaller
    {
        public static CreateSAMLProviderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSAMLProviderResponse createSAMLProviderResponse = new CreateSAMLProviderResponse();

			createSAMLProviderResponse.HttpResponse = _ctx.HttpResponse;
			createSAMLProviderResponse.RequestId = _ctx.StringValue("CreateSAMLProvider.RequestId");

			CreateSAMLProviderResponse.CreateSAMLProvider_SAMLProvider sAMLProvider = new CreateSAMLProviderResponse.CreateSAMLProvider_SAMLProvider();
			sAMLProvider.UpdateDate = _ctx.StringValue("CreateSAMLProvider.SAMLProvider.UpdateDate");
			sAMLProvider.Description = _ctx.StringValue("CreateSAMLProvider.SAMLProvider.Description");
			sAMLProvider.SAMLProviderName = _ctx.StringValue("CreateSAMLProvider.SAMLProvider.SAMLProviderName");
			sAMLProvider.CreateDate = _ctx.StringValue("CreateSAMLProvider.SAMLProvider.CreateDate");
			sAMLProvider.Arn = _ctx.StringValue("CreateSAMLProvider.SAMLProvider.Arn");
			createSAMLProviderResponse.SAMLProvider = sAMLProvider;
        
			return createSAMLProviderResponse;
        }
    }
}
