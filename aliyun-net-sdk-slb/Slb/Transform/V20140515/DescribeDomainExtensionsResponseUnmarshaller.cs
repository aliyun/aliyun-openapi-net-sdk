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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeDomainExtensionsResponseUnmarshaller
    {
        public static DescribeDomainExtensionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainExtensionsResponse describeDomainExtensionsResponse = new DescribeDomainExtensionsResponse();

			describeDomainExtensionsResponse.HttpResponse = context.HttpResponse;
			describeDomainExtensionsResponse.RequestId = context.StringValue("DescribeDomainExtensions.RequestId");

			List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension> describeDomainExtensionsResponse_domainExtensions = new List<DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension>();
			for (int i = 0; i < context.Length("DescribeDomainExtensions.DomainExtensions.Length"); i++) {
				DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension domainExtension = new DescribeDomainExtensionsResponse.DescribeDomainExtensions_DomainExtension();
				domainExtension.DomainExtensionId = context.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].DomainExtensionId");
				domainExtension.Domain = context.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].Domain");
				domainExtension.ServerCertificateId = context.StringValue("DescribeDomainExtensions.DomainExtensions["+ i +"].ServerCertificateId");

				describeDomainExtensionsResponse_domainExtensions.Add(domainExtension);
			}
			describeDomainExtensionsResponse.DomainExtensions = describeDomainExtensionsResponse_domainExtensions;
        
			return describeDomainExtensionsResponse;
        }
    }
}
