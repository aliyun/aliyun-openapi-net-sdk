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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ram.Model.V20150501;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class GetPublicKeyResponseUnmarshaller
    {
        public static GetPublicKeyResponse Unmarshall(UnmarshallerContext context)
        {
			GetPublicKeyResponse getPublicKeyResponse = new GetPublicKeyResponse();

			getPublicKeyResponse.HttpResponse = context.HttpResponse;
			getPublicKeyResponse.RequestId = context.StringValue("GetPublicKey.RequestId");

			GetPublicKeyResponse.GetPublicKey_PublicKey publicKey = new GetPublicKeyResponse.GetPublicKey_PublicKey();
			publicKey.PublicKeyId = context.StringValue("GetPublicKey.PublicKey.PublicKeyId");
			publicKey.PublicKeySpec = context.StringValue("GetPublicKey.PublicKey.PublicKeySpec");
			publicKey.Status = context.StringValue("GetPublicKey.PublicKey.Status");
			publicKey.CreateDate = context.StringValue("GetPublicKey.PublicKey.CreateDate");
			getPublicKeyResponse.PublicKey = publicKey;
        
			return getPublicKeyResponse;
        }
    }
}