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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeSmbAclResponseUnmarshaller
    {
        public static DescribeSmbAclResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSmbAclResponse describeSmbAclResponse = new DescribeSmbAclResponse();

			describeSmbAclResponse.HttpResponse = _ctx.HttpResponse;
			describeSmbAclResponse.RequestId = _ctx.StringValue("DescribeSmbAcl.RequestId");

			DescribeSmbAclResponse.DescribeSmbAcl_Acl acl = new DescribeSmbAclResponse.DescribeSmbAcl_Acl();
			acl.AuthMethod = _ctx.StringValue("DescribeSmbAcl.Acl.AuthMethod");
			acl.AuthCenter = _ctx.StringValue("DescribeSmbAcl.Acl.AuthCenter");
			acl.EnableAnonymousAccess = _ctx.BooleanValue("DescribeSmbAcl.Acl.EnableAnonymousAccess");
			acl.Enabled = _ctx.BooleanValue("DescribeSmbAcl.Acl.Enabled");
			acl.EncryptData = _ctx.BooleanValue("DescribeSmbAcl.Acl.EncryptData");
			acl.RejectUnencryptedAccess = _ctx.BooleanValue("DescribeSmbAcl.Acl.RejectUnencryptedAccess");
			acl.SuperAdminSid = _ctx.StringValue("DescribeSmbAcl.Acl.SuperAdminSid");
			acl.HomeDirPath = _ctx.StringValue("DescribeSmbAcl.Acl.HomeDirPath");
			describeSmbAclResponse.Acl = acl;
        
			return describeSmbAclResponse;
        }
    }
}
