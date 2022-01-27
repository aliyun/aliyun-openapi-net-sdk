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
    public class DescribeKeyResponseUnmarshaller
    {
        public static DescribeKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeKeyResponse describeKeyResponse = new DescribeKeyResponse();

			describeKeyResponse.HttpResponse = _ctx.HttpResponse;
			describeKeyResponse.RequestId = _ctx.StringValue("DescribeKey.RequestId");

			DescribeKeyResponse.DescribeKey_KeyMetadata keyMetadata = new DescribeKeyResponse.DescribeKey_KeyMetadata();
			keyMetadata.CreationDate = _ctx.StringValue("DescribeKey.KeyMetadata.CreationDate");
			keyMetadata.Description = _ctx.StringValue("DescribeKey.KeyMetadata.Description");
			keyMetadata.KeyId = _ctx.StringValue("DescribeKey.KeyMetadata.KeyId");
			keyMetadata.KeyState = _ctx.StringValue("DescribeKey.KeyMetadata.KeyState");
			keyMetadata.KeyUsage = _ctx.StringValue("DescribeKey.KeyMetadata.KeyUsage");
			keyMetadata.DeleteDate = _ctx.StringValue("DescribeKey.KeyMetadata.DeleteDate");
			keyMetadata.Creator = _ctx.StringValue("DescribeKey.KeyMetadata.Creator");
			keyMetadata.Arn = _ctx.StringValue("DescribeKey.KeyMetadata.Arn");
			keyMetadata.Origin = _ctx.StringValue("DescribeKey.KeyMetadata.Origin");
			keyMetadata.MaterialExpireTime = _ctx.StringValue("DescribeKey.KeyMetadata.MaterialExpireTime");
			keyMetadata.ProtectionLevel = _ctx.StringValue("DescribeKey.KeyMetadata.ProtectionLevel");
			keyMetadata.PrimaryKeyVersion = _ctx.StringValue("DescribeKey.KeyMetadata.PrimaryKeyVersion");
			keyMetadata.LastRotationDate = _ctx.StringValue("DescribeKey.KeyMetadata.LastRotationDate");
			keyMetadata.AutomaticRotation = _ctx.StringValue("DescribeKey.KeyMetadata.AutomaticRotation");
			keyMetadata.RotationInterval = _ctx.StringValue("DescribeKey.KeyMetadata.RotationInterval");
			keyMetadata.NextRotationDate = _ctx.StringValue("DescribeKey.KeyMetadata.NextRotationDate");
			keyMetadata.KeySpec = _ctx.StringValue("DescribeKey.KeyMetadata.KeySpec");
			keyMetadata.DeletionProtection = _ctx.StringValue("DescribeKey.KeyMetadata.DeletionProtection");
			keyMetadata.DeletionProtectionDescription = _ctx.StringValue("DescribeKey.KeyMetadata.DeletionProtectionDescription");
			describeKeyResponse.KeyMetadata = keyMetadata;
        
			return describeKeyResponse;
        }
    }
}
