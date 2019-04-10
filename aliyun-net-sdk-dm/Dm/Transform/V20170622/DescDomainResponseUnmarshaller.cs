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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class DescDomainResponseUnmarshaller
    {
        public static DescDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescDomainResponse descDomainResponse = new DescDomainResponse();

			descDomainResponse.HttpResponse = context.HttpResponse;
			descDomainResponse.RequestId = context.StringValue("DescDomain.RequestId");
			descDomainResponse.DomainId = context.StringValue("DescDomain.DomainId");
			descDomainResponse.DomainName = context.StringValue("DescDomain.DomainName");
			descDomainResponse.DomainType = context.StringValue("DescDomain.DomainType");
			descDomainResponse.DomainStatus = context.StringValue("DescDomain.DomainStatus");
			descDomainResponse.CnameRecord = context.StringValue("DescDomain.CnameRecord");
			descDomainResponse.CnameConfirmStatus = context.StringValue("DescDomain.CnameConfirmStatus");
			descDomainResponse.SpfAuthStatus = context.StringValue("DescDomain.SpfAuthStatus");
			descDomainResponse.MxAuthStatus = context.StringValue("DescDomain.MxAuthStatus");
			descDomainResponse.DefaultDomain = context.StringValue("DescDomain.DefaultDomain");
			descDomainResponse.CreateTime = context.StringValue("DescDomain.CreateTime");
			descDomainResponse.CnameAuthStatus = context.StringValue("DescDomain.CnameAuthStatus");
			descDomainResponse.IcpStatus = context.StringValue("DescDomain.IcpStatus");
			descDomainResponse.SpfRecord = context.StringValue("DescDomain.SpfRecord");
			descDomainResponse.MxRecord = context.StringValue("DescDomain.MxRecord");
			descDomainResponse.TracefRecord = context.StringValue("DescDomain.TracefRecord");
        
			return descDomainResponse;
        }
    }
}
