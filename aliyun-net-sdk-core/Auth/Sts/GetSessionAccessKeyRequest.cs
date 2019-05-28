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

using System.Runtime.CompilerServices;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

[assembly: InternalsVisibleTo("aliyun-net-sdk-core.Tests")]

namespace Aliyun.Acs.Core.Auth.Sts
{
    internal class GetSessionAccessKeyRequest : RpcAcsRequest<GetSessionAccessKeyResponse>
    {
        private int durationSeconds = 3600;
        private string publicKeyId;

        public GetSessionAccessKeyRequest() : base("Sts", "2015-04-01", "GenerateSessionAccessKey")
        {
        }

        public int DurationSeconds
        {
            get { return durationSeconds; }
            set
            {
                durationSeconds = value;
                DictionaryUtil.Add(QueryParameters, "DurationSeconds", value);
            }
        }

        public string PublicKeyId
        {
            get { return publicKeyId; }
            set
            {
                publicKeyId = value;
                DictionaryUtil.Add(QueryParameters, "PublicKeyId", value);
            }
        }

        public override GetSessionAccessKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSessionAccessKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
