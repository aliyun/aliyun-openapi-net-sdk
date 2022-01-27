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
    public class GetSecretValueResponseUnmarshaller
    {
        public static GetSecretValueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSecretValueResponse getSecretValueResponse = new GetSecretValueResponse();

			getSecretValueResponse.HttpResponse = _ctx.HttpResponse;
			getSecretValueResponse.RequestId = _ctx.StringValue("GetSecretValue.RequestId");
			getSecretValueResponse.SecretName = _ctx.StringValue("GetSecretValue.SecretName");
			getSecretValueResponse.VersionId = _ctx.StringValue("GetSecretValue.VersionId");
			getSecretValueResponse.CreateTime = _ctx.StringValue("GetSecretValue.CreateTime");
			getSecretValueResponse.SecretData = _ctx.StringValue("GetSecretValue.SecretData");
			getSecretValueResponse.SecretDataType = _ctx.StringValue("GetSecretValue.SecretDataType");
			getSecretValueResponse.AutomaticRotation = _ctx.StringValue("GetSecretValue.AutomaticRotation");
			getSecretValueResponse.RotationInterval = _ctx.StringValue("GetSecretValue.RotationInterval");
			getSecretValueResponse.NextRotationDate = _ctx.StringValue("GetSecretValue.NextRotationDate");
			getSecretValueResponse.ExtendedConfig = _ctx.StringValue("GetSecretValue.ExtendedConfig");
			getSecretValueResponse.LastRotationDate = _ctx.StringValue("GetSecretValue.LastRotationDate");
			getSecretValueResponse.SecretType = _ctx.StringValue("GetSecretValue.SecretType");

			List<string> getSecretValueResponse_versionStages = new List<string>();
			for (int i = 0; i < _ctx.Length("GetSecretValue.VersionStages.Length"); i++) {
				getSecretValueResponse_versionStages.Add(_ctx.StringValue("GetSecretValue.VersionStages["+ i +"]"));
			}
			getSecretValueResponse.VersionStages = getSecretValueResponse_versionStages;
        
			return getSecretValueResponse;
        }
    }
}
