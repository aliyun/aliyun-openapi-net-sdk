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
using Aliyun.Acs.Sts.Model.V20150401;

namespace Aliyun.Acs.Sts.Transform.V20150401
{
    public class AssumeRoleResponseUnmarshaller
    {
        public static AssumeRoleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssumeRoleResponse assumeRoleResponse = new AssumeRoleResponse();

			assumeRoleResponse.HttpResponse = _ctx.HttpResponse;
			assumeRoleResponse.RequestId = _ctx.StringValue("AssumeRole.RequestId");

			AssumeRoleResponse.AssumeRole_AssumedRoleUser assumedRoleUser = new AssumeRoleResponse.AssumeRole_AssumedRoleUser();
			assumedRoleUser.AssumedRoleId = _ctx.StringValue("AssumeRole.AssumedRoleUser.AssumedRoleId");
			assumedRoleUser.Arn = _ctx.StringValue("AssumeRole.AssumedRoleUser.Arn");
			assumeRoleResponse.AssumedRoleUser = assumedRoleUser;

			AssumeRoleResponse.AssumeRole_Credentials credentials = new AssumeRoleResponse.AssumeRole_Credentials();
			credentials.SecurityToken = _ctx.StringValue("AssumeRole.Credentials.SecurityToken");
			credentials.Expiration = _ctx.StringValue("AssumeRole.Credentials.Expiration");
			credentials.AccessKeySecret = _ctx.StringValue("AssumeRole.Credentials.AccessKeySecret");
			credentials.AccessKeyId = _ctx.StringValue("AssumeRole.Credentials.AccessKeyId");
			assumeRoleResponse.Credentials = credentials;
        
			return assumeRoleResponse;
        }
    }
}
