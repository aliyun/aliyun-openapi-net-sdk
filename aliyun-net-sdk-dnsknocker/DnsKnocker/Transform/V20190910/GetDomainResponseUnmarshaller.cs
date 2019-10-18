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
using Aliyun.Acs.DnsKnocker.Model.V20190910;

namespace Aliyun.Acs.DnsKnocker.Transform.V20190910
{
    public class GetDomainResponseUnmarshaller
    {
        public static GetDomainResponse Unmarshall(UnmarshallerContext context)
        {
			GetDomainResponse getDomainResponse = new GetDomainResponse();

			getDomainResponse.HttpResponse = context.HttpResponse;
			getDomainResponse.RequestId = context.StringValue("GetDomain.RequestId");
			getDomainResponse.ResultCode = context.StringValue("GetDomain.ResultCode");
			getDomainResponse.ResultMessage = context.StringValue("GetDomain.ResultMessage");
			getDomainResponse.Success = context.StringValue("GetDomain.Success");
			getDomainResponse.TransactionId = context.StringValue("GetDomain.TransactionId");

			List<GetDomainResponse.GetDomain_Data> getDomainResponse_domain = new List<GetDomainResponse.GetDomain_Data>();
			for (int i = 0; i < context.Length("GetDomain.Domain.Length"); i++) {
				GetDomainResponse.GetDomain_Data data = new GetDomainResponse.GetDomain_Data();
				data.DomainName = context.StringValue("GetDomain.Domain["+ i +"].DomainName");
				data.Exists = context.StringValue("GetDomain.Domain["+ i +"].Exists");
				data.Message = context.StringValue("GetDomain.Domain["+ i +"].Message");

				getDomainResponse_domain.Add(data);
			}
			getDomainResponse.Domain = getDomainResponse_domain;
        
			return getDomainResponse;
        }
    }
}
