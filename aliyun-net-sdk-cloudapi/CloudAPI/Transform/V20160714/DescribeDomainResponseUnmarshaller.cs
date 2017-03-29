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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeDomainResponseUnmarshaller
    {
        public static DescribeDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainResponse describeDomainResponse = new DescribeDomainResponse();

			describeDomainResponse.HttpResponse = context.HttpResponse;
			describeDomainResponse.RequestId = context.StringValue("DescribeDomain.RequestId");
			describeDomainResponse.GroupId = context.StringValue("DescribeDomain.GroupId");
			describeDomainResponse.DomainName = context.StringValue("DescribeDomain.DomainName");
			describeDomainResponse.SubDomain = context.StringValue("DescribeDomain.SubDomain");
			describeDomainResponse.CertificateId = context.StringValue("DescribeDomain.CertificateId");
			describeDomainResponse.CertificateName = context.StringValue("DescribeDomain.CertificateName");
			describeDomainResponse.CertificateBody = context.StringValue("DescribeDomain.CertificateBody");
			describeDomainResponse.CertificatePrivateKey = context.StringValue("DescribeDomain.CertificatePrivateKey");
			describeDomainResponse.DomainBindingStatus = context.StringValue("DescribeDomain.DomainBindingStatus");
			describeDomainResponse.DomainCNAMEStatus = context.StringValue("DescribeDomain.DomainCNAMEStatus");
			describeDomainResponse.DomainLegalStatus = context.StringValue("DescribeDomain.DomainLegalStatus");
			describeDomainResponse.DomainRemark = context.StringValue("DescribeDomain.DomainRemark");
        
			return describeDomainResponse;
        }
    }
}