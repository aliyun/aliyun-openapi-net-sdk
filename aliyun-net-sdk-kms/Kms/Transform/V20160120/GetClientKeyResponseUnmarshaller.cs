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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class GetClientKeyResponseUnmarshaller
    {
        public static GetClientKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetClientKeyResponse getClientKeyResponse = new GetClientKeyResponse();

			getClientKeyResponse.HttpResponse = _ctx.HttpResponse;
			getClientKeyResponse.RequestId = _ctx.StringValue("GetClientKey.RequestId");
			getClientKeyResponse.ClientKeyId = _ctx.StringValue("GetClientKey.ClientKeyId");
			getClientKeyResponse.CreateTime = _ctx.StringValue("GetClientKey.CreateTime");
			getClientKeyResponse.KeyAlgorithm = _ctx.StringValue("GetClientKey.KeyAlgorithm");
			getClientKeyResponse.KeyOrigin = _ctx.StringValue("GetClientKey.KeyOrigin");
			getClientKeyResponse.PublicKeyData = _ctx.StringValue("GetClientKey.PublicKeyData");
			getClientKeyResponse.NotAfter = _ctx.StringValue("GetClientKey.NotAfter");
			getClientKeyResponse.NotBefore = _ctx.StringValue("GetClientKey.NotBefore");
			getClientKeyResponse.AapName = _ctx.StringValue("GetClientKey.AapName");
        
			return getClientKeyResponse;
        }
    }
}
