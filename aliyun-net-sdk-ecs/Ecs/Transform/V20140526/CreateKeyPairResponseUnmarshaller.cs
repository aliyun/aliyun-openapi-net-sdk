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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class CreateKeyPairResponseUnmarshaller
    {
        public static CreateKeyPairResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateKeyPairResponse createKeyPairResponse = new CreateKeyPairResponse();

			createKeyPairResponse.HttpResponse = _ctx.HttpResponse;
			createKeyPairResponse.PrivateKeyBody = _ctx.StringValue("CreateKeyPair.PrivateKeyBody");
			createKeyPairResponse.KeyPairName = _ctx.StringValue("CreateKeyPair.KeyPairName");
			createKeyPairResponse.KeyPairId = _ctx.StringValue("CreateKeyPair.KeyPairId");
			createKeyPairResponse.RequestId = _ctx.StringValue("CreateKeyPair.RequestId");
			createKeyPairResponse.KeyPairFingerPrint = _ctx.StringValue("CreateKeyPair.KeyPairFingerPrint");
        
			return createKeyPairResponse;
        }
    }
}
