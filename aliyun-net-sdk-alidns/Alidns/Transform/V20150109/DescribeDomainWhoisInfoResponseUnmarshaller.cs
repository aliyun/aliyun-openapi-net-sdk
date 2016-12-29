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
using Aliyun.Acs.Alidns.Model.V20150109;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainWhoisInfoResponseUnmarshaller
    {
        public static DescribeDomainWhoisInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainWhoisInfoResponse describeDomainWhoisInfoResponse = new DescribeDomainWhoisInfoResponse();

			describeDomainWhoisInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainWhoisInfoResponse.RequestId = context.StringValue("DescribeDomainWhoisInfo.RequestId");
			describeDomainWhoisInfoResponse.RegistrantName = context.StringValue("DescribeDomainWhoisInfo.RegistrantName");
			describeDomainWhoisInfoResponse.RegistrantEmail = context.StringValue("DescribeDomainWhoisInfo.RegistrantEmail");
			describeDomainWhoisInfoResponse.Registrar = context.StringValue("DescribeDomainWhoisInfo.Registrar");
			describeDomainWhoisInfoResponse.RegistrationDate = context.StringValue("DescribeDomainWhoisInfo.RegistrationDate");
			describeDomainWhoisInfoResponse.ExpirationDate = context.StringValue("DescribeDomainWhoisInfo.ExpirationDate");

			List<string> statusList = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomainWhoisInfo.StatusList.Length"); i++) {
				statusList.Add(context.StringValue("DescribeDomainWhoisInfo.StatusList["+ i +"]"));
			}
			describeDomainWhoisInfoResponse.StatusList = statusList;

			List<string> dnsServers = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomainWhoisInfo.DnsServers.Length"); i++) {
				dnsServers.Add(context.StringValue("DescribeDomainWhoisInfo.DnsServers["+ i +"]"));
			}
			describeDomainWhoisInfoResponse.DnsServers = dnsServers;
        
			return describeDomainWhoisInfoResponse;
        }
    }
}