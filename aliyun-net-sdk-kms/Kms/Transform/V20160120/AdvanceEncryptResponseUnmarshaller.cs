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
    public class AdvanceEncryptResponseUnmarshaller
    {
        public static AdvanceEncryptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AdvanceEncryptResponse advanceEncryptResponse = new AdvanceEncryptResponse();

			advanceEncryptResponse.HttpResponse = _ctx.HttpResponse;
			advanceEncryptResponse.RequestId = _ctx.StringValue("AdvanceEncrypt.RequestId");
			advanceEncryptResponse.CiphertextBlob = _ctx.StringValue("AdvanceEncrypt.CiphertextBlob");
			advanceEncryptResponse.Algorithm = _ctx.StringValue("AdvanceEncrypt.Algorithm");
			advanceEncryptResponse.KeyId = _ctx.StringValue("AdvanceEncrypt.KeyId");
			advanceEncryptResponse.KeyVersionId = _ctx.StringValue("AdvanceEncrypt.KeyVersionId");
			advanceEncryptResponse.Iv = _ctx.StringValue("AdvanceEncrypt.Iv");
			advanceEncryptResponse.PaddingMode = _ctx.StringValue("AdvanceEncrypt.PaddingMode");
        
			return advanceEncryptResponse;
        }
    }
}
