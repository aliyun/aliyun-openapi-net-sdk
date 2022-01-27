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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class UnbindInstanceDomainsResponseUnmarshaller
    {
        public static UnbindInstanceDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnbindInstanceDomainsResponse unbindInstanceDomainsResponse = new UnbindInstanceDomainsResponse();

			unbindInstanceDomainsResponse.HttpResponse = _ctx.HttpResponse;
			unbindInstanceDomainsResponse.RequestId = _ctx.StringValue("UnbindInstanceDomains.RequestId");
			unbindInstanceDomainsResponse.SuccessCount = _ctx.IntegerValue("UnbindInstanceDomains.SuccessCount");
			unbindInstanceDomainsResponse.FailedCount = _ctx.IntegerValue("UnbindInstanceDomains.FailedCount");
        
			return unbindInstanceDomainsResponse;
        }
    }
}
