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

namespace Aliyun.Acs.Core.Auth.Sts
{
    public class GetSessionAccessKeyResponseUnmarshaller
    {
        public static GetSessionAccessKeyResponse Unmarshall(UnmarshallerContext context)
        {
            var getSessionAccessKeyResponse = new GetSessionAccessKeyResponse();

            getSessionAccessKeyResponse.RequestId = context.StringValue("GetSessionAccessKey.RequestId");

            var credentials =
                new GetSessionAccessKeyResponse.GetSessionAccessKey_SessionAccesskey();
            credentials.SessionAccessKeyId =
                context.StringValue("GetSessionAccessKey.SessionAccessKey.SessionAccessKeyId");
            credentials.SessionAccessKeySecert =
                context.StringValue("GetSessionAccessKey.SessionAccessKey.SessionAccessKeySecret");
            credentials.Expiration = context.StringValue("GetSessionAccessKey.SessionAccessKey.Expiration");

            getSessionAccessKeyResponse.SessionAccesskey = credentials;
            return getSessionAccessKeyResponse;
        }
    }
}
