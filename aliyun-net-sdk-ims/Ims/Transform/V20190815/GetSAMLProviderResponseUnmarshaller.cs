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
    public class GetSAMLProviderResponseUnmarshaller
    {
        public static GetSAMLProviderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSAMLProviderResponse getSAMLProviderResponse = new GetSAMLProviderResponse();

			getSAMLProviderResponse.HttpResponse = _ctx.HttpResponse;
			getSAMLProviderResponse.RequestId = _ctx.StringValue("GetSAMLProvider.RequestId");

			GetSAMLProviderResponse.GetSAMLProvider_SAMLProvider sAMLProvider = new GetSAMLProviderResponse.GetSAMLProvider_SAMLProvider();
			sAMLProvider.SAMLMetadataDocument = _ctx.StringValue("GetSAMLProvider.SAMLProvider.SAMLMetadataDocument");
			sAMLProvider.Description = _ctx.StringValue("GetSAMLProvider.SAMLProvider.Description");
			sAMLProvider.UpdateDate = _ctx.StringValue("GetSAMLProvider.SAMLProvider.UpdateDate");
			sAMLProvider.SAMLProviderName = _ctx.StringValue("GetSAMLProvider.SAMLProvider.SAMLProviderName");
			sAMLProvider.CreateDate = _ctx.StringValue("GetSAMLProvider.SAMLProvider.CreateDate");
			sAMLProvider.EncodedSAMLMetadataDocument = _ctx.StringValue("GetSAMLProvider.SAMLProvider.EncodedSAMLMetadataDocument");
			sAMLProvider.Arn = _ctx.StringValue("GetSAMLProvider.SAMLProvider.Arn");
			getSAMLProviderResponse.SAMLProvider = sAMLProvider;
        
			return getSAMLProviderResponse;
        }
    }
}
