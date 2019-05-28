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
    public class AssumeRoleResponseUnmarshaller
    {
        public static AssumeRoleResponse Unmarshall(UnmarshallerContext context)
        {
            var assumeRoleResponse = new AssumeRoleResponse();

            assumeRoleResponse.RequestId = context.StringValue("AssumeRole.RequestId");

            var credentials = new AssumeRoleResponse.AssumeRole_Credentials();
            credentials.SecurityToken = context.StringValue("AssumeRole.Credentials.SecurityToken");
            credentials.AccessKeySecret = context.StringValue("AssumeRole.Credentials.AccessKeySecret");
            credentials.AccessKeyId = context.StringValue("AssumeRole.Credentials.AccessKeyId");
            credentials.Expiration = context.StringValue("AssumeRole.Credentials.Expiration");
            assumeRoleResponse.Credentials = credentials;

            var assumedRoleUser =
                new AssumeRoleResponse.AssumeRole_AssumedRoleUser();
            assumedRoleUser.Arn = context.StringValue("AssumeRole.AssumedRoleUser.Arn");
            assumedRoleUser.AssumedRoleId = context.StringValue("AssumeRole.AssumedRoleUser.AssumedRoleId");
            assumeRoleResponse.AssumedRoleUser = assumedRoleUser;

            return assumeRoleResponse;
        }
    }
}
