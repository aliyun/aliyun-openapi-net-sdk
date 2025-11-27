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
    public class AssumeRoleWithSAMLResponseUnmarshaller
    {
        public static AssumeRoleWithSAMLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssumeRoleWithSAMLResponse assumeRoleWithSAMLResponse = new AssumeRoleWithSAMLResponse();

			assumeRoleWithSAMLResponse.HttpResponse = _ctx.HttpResponse;
			assumeRoleWithSAMLResponse.RequestId = _ctx.StringValue("AssumeRoleWithSAML.RequestId");
			assumeRoleWithSAMLResponse.SourceIdentity = _ctx.StringValue("AssumeRoleWithSAML.SourceIdentity");

			AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_SAMLAssertionInfo sAMLAssertionInfo = new AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_SAMLAssertionInfo();
			sAMLAssertionInfo.SubjectType = _ctx.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.SubjectType");
			sAMLAssertionInfo.Subject = _ctx.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.Subject");
			sAMLAssertionInfo.Issuer = _ctx.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.Issuer");
			sAMLAssertionInfo.Recipient = _ctx.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.Recipient");
			assumeRoleWithSAMLResponse.SAMLAssertionInfo = sAMLAssertionInfo;

			AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_AssumedRoleUser assumedRoleUser = new AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_AssumedRoleUser();
			assumedRoleUser.AssumedRoleId = _ctx.StringValue("AssumeRoleWithSAML.AssumedRoleUser.AssumedRoleId");
			assumedRoleUser.Arn = _ctx.StringValue("AssumeRoleWithSAML.AssumedRoleUser.Arn");
			assumeRoleWithSAMLResponse.AssumedRoleUser = assumedRoleUser;

			AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_Credentials credentials = new AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_Credentials();
			credentials.SecurityToken = _ctx.StringValue("AssumeRoleWithSAML.Credentials.SecurityToken");
			credentials.Expiration = _ctx.StringValue("AssumeRoleWithSAML.Credentials.Expiration");
			credentials.AccessKeySecret = _ctx.StringValue("AssumeRoleWithSAML.Credentials.AccessKeySecret");
			credentials.AccessKeyId = _ctx.StringValue("AssumeRoleWithSAML.Credentials.AccessKeyId");
			assumeRoleWithSAMLResponse.Credentials = credentials;
        
			return assumeRoleWithSAMLResponse;
        }
    }
}
