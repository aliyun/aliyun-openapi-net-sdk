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
        public static CreateKeyResponse Unmarshall(UnmarshallerContext context)
        {
			CreateKeyResponse createKeyResponse = new CreateKeyResponse();

			createKeyResponse.HttpResponse = context.HttpResponse;
			createKeyResponse.RequestId = context.StringValue("CreateKey.RequestId");

			CreateKeyResponse.CreateKey_KeyMetadata keyMetadata = new CreateKeyResponse.CreateKey_KeyMetadata();
			keyMetadata.CreationDate = context.StringValue("CreateKey.KeyMetadata.CreationDate");
			keyMetadata.Description = context.StringValue("CreateKey.KeyMetadata.Description");
			keyMetadata.KeyId = context.StringValue("CreateKey.KeyMetadata.KeyId");
			keyMetadata.KeyState = context.StringValue("CreateKey.KeyMetadata.KeyState");
			keyMetadata.KeyUsage = context.StringValue("CreateKey.KeyMetadata.KeyUsage");
			keyMetadata.DeleteDate = context.StringValue("CreateKey.KeyMetadata.DeleteDate");
			keyMetadata.Creator = context.StringValue("CreateKey.KeyMetadata.Creator");
			keyMetadata.Arn = context.StringValue("CreateKey.KeyMetadata.Arn");
			keyMetadata.Origin = context.StringValue("CreateKey.KeyMetadata.Origin");
			keyMetadata.MaterialExpireTime = context.StringValue("CreateKey.KeyMetadata.MaterialExpireTime");
			keyMetadata.ProtectionLevel = context.StringValue("CreateKey.KeyMetadata.ProtectionLevel");
			keyMetadata.PrimaryKeyVersion = context.StringValue("CreateKey.KeyMetadata.PrimaryKeyVersion");
			keyMetadata.LastRotationDate = context.StringValue("CreateKey.KeyMetadata.LastRotationDate");
			keyMetadata.AutomaticRotation = context.StringValue("CreateKey.KeyMetadata.AutomaticRotation");
			keyMetadata.RotationInterval = context.StringValue("CreateKey.KeyMetadata.RotationInterval");
			keyMetadata.NextRotationDate = context.StringValue("CreateKey.KeyMetadata.NextRotationDate");
			keyMetadata.KeySpec = context.StringValue("CreateKey.KeyMetadata.KeySpec");
			createKeyResponse.KeyMetadata = keyMetadata;
        
			return createKeyResponse;
        }
    }
}
