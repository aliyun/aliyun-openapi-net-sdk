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
    public class CreateSecretResponseUnmarshaller
    {
        public static CreateSecretResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSecretResponse createSecretResponse = new CreateSecretResponse();

			createSecretResponse.HttpResponse = _ctx.HttpResponse;
			createSecretResponse.RequestId = _ctx.StringValue("CreateSecret.RequestId");
			createSecretResponse.Arn = _ctx.StringValue("CreateSecret.Arn");
			createSecretResponse.VersionId = _ctx.StringValue("CreateSecret.VersionId");
			createSecretResponse.SecretName = _ctx.StringValue("CreateSecret.SecretName");
			createSecretResponse.SecretType = _ctx.StringValue("CreateSecret.SecretType");
			createSecretResponse.AutomaticRotation = _ctx.StringValue("CreateSecret.AutomaticRotation");
			createSecretResponse.RotationInterval = _ctx.StringValue("CreateSecret.RotationInterval");
			createSecretResponse.NextRotationDate = _ctx.StringValue("CreateSecret.NextRotationDate");
			createSecretResponse.ExtendedConfig = _ctx.StringValue("CreateSecret.ExtendedConfig");
        
			return createSecretResponse;
        }
    }
}
