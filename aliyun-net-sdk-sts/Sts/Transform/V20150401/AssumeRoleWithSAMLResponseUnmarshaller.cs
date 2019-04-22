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
        public static AssumeRoleWithSAMLResponse Unmarshall(UnmarshallerContext context)
        {
			AssumeRoleWithSAMLResponse assumeRoleWithSAMLResponse = new AssumeRoleWithSAMLResponse();

			assumeRoleWithSAMLResponse.HttpResponse = context.HttpResponse;
			assumeRoleWithSAMLResponse.RequestId = context.StringValue("AssumeRoleWithSAML.RequestId");

			AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_Credentials credentials = new AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_Credentials();
			credentials.SecurityToken = context.StringValue("AssumeRoleWithSAML.Credentials.SecurityToken");
			credentials.AccessKeySecret = context.StringValue("AssumeRoleWithSAML.Credentials.AccessKeySecret");
			credentials.AccessKeyId = context.StringValue("AssumeRoleWithSAML.Credentials.AccessKeyId");
			credentials.Expiration = context.StringValue("AssumeRoleWithSAML.Credentials.Expiration");
			assumeRoleWithSAMLResponse.Credentials = credentials;

			AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_AssumedRoleUser assumedRoleUser = new AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_AssumedRoleUser();
			assumedRoleUser.Arn = context.StringValue("AssumeRoleWithSAML.AssumedRoleUser.Arn");
			assumedRoleUser.AssumedRoleId = context.StringValue("AssumeRoleWithSAML.AssumedRoleUser.AssumedRoleId");
			assumeRoleWithSAMLResponse.AssumedRoleUser = assumedRoleUser;

			AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_SAMLAssertionInfo sAMLAssertionInfo = new AssumeRoleWithSAMLResponse.AssumeRoleWithSAML_SAMLAssertionInfo();
			sAMLAssertionInfo.SubjectType = context.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.SubjectType");
			sAMLAssertionInfo.Subject = context.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.Subject");
			sAMLAssertionInfo.Recipient = context.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.Recipient");
			sAMLAssertionInfo.Issuer = context.StringValue("AssumeRoleWithSAML.SAMLAssertionInfo.Issuer");
			assumeRoleWithSAMLResponse.SAMLAssertionInfo = sAMLAssertionInfo;
        
			return assumeRoleWithSAMLResponse;
        }
    }
}
