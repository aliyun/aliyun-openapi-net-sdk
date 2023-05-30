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
    public class CreateKeyResponseUnmarshaller
    {
        public static CreateKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateKeyResponse createKeyResponse = new CreateKeyResponse();

			createKeyResponse.HttpResponse = _ctx.HttpResponse;
			createKeyResponse.RequestId = _ctx.StringValue("CreateKey.RequestId");

			CreateKeyResponse.CreateKey_KeyMetadata keyMetadata = new CreateKeyResponse.CreateKey_KeyMetadata();
			keyMetadata.KeyId = _ctx.StringValue("CreateKey.KeyMetadata.KeyId");
			keyMetadata.NextRotationDate = _ctx.StringValue("CreateKey.KeyMetadata.NextRotationDate");
			keyMetadata.KeyState = _ctx.StringValue("CreateKey.KeyMetadata.KeyState");
			keyMetadata.RotationInterval = _ctx.StringValue("CreateKey.KeyMetadata.RotationInterval");
			keyMetadata.Arn = _ctx.StringValue("CreateKey.KeyMetadata.Arn");
			keyMetadata.Creator = _ctx.StringValue("CreateKey.KeyMetadata.Creator");
			keyMetadata.LastRotationDate = _ctx.StringValue("CreateKey.KeyMetadata.LastRotationDate");
			keyMetadata.DeleteDate = _ctx.StringValue("CreateKey.KeyMetadata.DeleteDate");
			keyMetadata.PrimaryKeyVersion = _ctx.StringValue("CreateKey.KeyMetadata.PrimaryKeyVersion");
			keyMetadata.Description = _ctx.StringValue("CreateKey.KeyMetadata.Description");
			keyMetadata.KeySpec = _ctx.StringValue("CreateKey.KeyMetadata.KeySpec");
			keyMetadata.Origin = _ctx.StringValue("CreateKey.KeyMetadata.Origin");
			keyMetadata.MaterialExpireTime = _ctx.StringValue("CreateKey.KeyMetadata.MaterialExpireTime");
			keyMetadata.AutomaticRotation = _ctx.StringValue("CreateKey.KeyMetadata.AutomaticRotation");
			keyMetadata.ProtectionLevel = _ctx.StringValue("CreateKey.KeyMetadata.ProtectionLevel");
			keyMetadata.KeyUsage = _ctx.StringValue("CreateKey.KeyMetadata.KeyUsage");
			keyMetadata.CreationDate = _ctx.StringValue("CreateKey.KeyMetadata.CreationDate");
			keyMetadata.DKMSInstanceId = _ctx.StringValue("CreateKey.KeyMetadata.DKMSInstanceId");
			createKeyResponse.KeyMetadata = keyMetadata;
        
			return createKeyResponse;
        }
    }
}
