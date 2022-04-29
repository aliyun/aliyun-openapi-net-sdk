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
    public class DescribeLDAPConfigResponseUnmarshaller
    {
        public static DescribeLDAPConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLDAPConfigResponse describeLDAPConfigResponse = new DescribeLDAPConfigResponse();

			describeLDAPConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLDAPConfigResponse.RequestId = _ctx.StringValue("DescribeLDAPConfig.RequestId");

			DescribeLDAPConfigResponse.DescribeLDAPConfig_Ldap ldap = new DescribeLDAPConfigResponse.DescribeLDAPConfig_Ldap();
			ldap.BindDN = _ctx.StringValue("DescribeLDAPConfig.Ldap.BindDN");
			ldap.SearchBase = _ctx.StringValue("DescribeLDAPConfig.Ldap.SearchBase");
			ldap.URI = _ctx.StringValue("DescribeLDAPConfig.Ldap.URI");
			describeLDAPConfigResponse.Ldap = ldap;
        
			return describeLDAPConfigResponse;
        }
    }
}
