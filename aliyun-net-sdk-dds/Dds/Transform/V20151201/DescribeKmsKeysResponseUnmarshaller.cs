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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeKmsKeysResponseUnmarshaller
    {
        public static DescribeKmsKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeKmsKeysResponse describeKmsKeysResponse = new DescribeKmsKeysResponse();

			describeKmsKeysResponse.HttpResponse = _ctx.HttpResponse;
			describeKmsKeysResponse.RequestId = _ctx.StringValue("DescribeKmsKeys.RequestId");

			List<DescribeKmsKeysResponse.DescribeKmsKeys_KmsKey> describeKmsKeysResponse_kmsKeys = new List<DescribeKmsKeysResponse.DescribeKmsKeys_KmsKey>();
			for (int i = 0; i < _ctx.Length("DescribeKmsKeys.KmsKeys.Length"); i++) {
				DescribeKmsKeysResponse.DescribeKmsKeys_KmsKey kmsKey = new DescribeKmsKeysResponse.DescribeKmsKeys_KmsKey();
				kmsKey.KeyAlias = _ctx.StringValue("DescribeKmsKeys.KmsKeys["+ i +"].KeyAlias");
				kmsKey.KeyId = _ctx.StringValue("DescribeKmsKeys.KmsKeys["+ i +"].KeyId");

				describeKmsKeysResponse_kmsKeys.Add(kmsKey);
			}
			describeKmsKeysResponse.KmsKeys = describeKmsKeysResponse_kmsKeys;
        
			return describeKmsKeysResponse;
        }
    }
}
