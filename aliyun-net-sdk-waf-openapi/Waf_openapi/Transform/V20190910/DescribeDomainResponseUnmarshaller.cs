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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeDomainResponseUnmarshaller
    {
        public static DescribeDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainResponse describeDomainResponse = new DescribeDomainResponse();

			describeDomainResponse.HttpResponse = context.HttpResponse;
			describeDomainResponse.RequestId = context.StringValue("DescribeDomain.RequestId");

			DescribeDomainResponse.DescribeDomain_Domain domain = new DescribeDomainResponse.DescribeDomain_Domain();
			domain.HttpToUserIp = context.IntegerValue("DescribeDomain.Domain.HttpToUserIp");
			domain.HttpsRedirect = context.IntegerValue("DescribeDomain.Domain.HttpsRedirect");
			domain.LoadBalancing = context.IntegerValue("DescribeDomain.Domain.LoadBalancing");
			domain.Cname = context.StringValue("DescribeDomain.Domain.Cname");
			domain.IsAccessProduct = context.IntegerValue("DescribeDomain.Domain.IsAccessProduct");
			domain.Version = context.LongValue("DescribeDomain.Domain.Version");
			domain.LogHeaders = context.StringValue("DescribeDomain.Domain.LogHeaders");
			domain.ClusterType = context.IntegerValue("DescribeDomain.Domain.ClusterType");
			domain.ConnectionTime = context.IntegerValue("DescribeDomain.Domain.ConnectionTime");
			domain.ReadTime = context.IntegerValue("DescribeDomain.Domain.ReadTime");
			domain.WriteTime = context.IntegerValue("DescribeDomain.Domain.WriteTime");

			List<string> domain_sourceIps = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomain.Domain.SourceIps.Length"); i++) {
				domain_sourceIps.Add(context.StringValue("DescribeDomain.Domain.SourceIps["+ i +"]"));
			}
			domain.SourceIps = domain_sourceIps;

			List<string> domain_http2Port = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomain.Domain.Http2Port.Length"); i++) {
				domain_http2Port.Add(context.StringValue("DescribeDomain.Domain.Http2Port["+ i +"]"));
			}
			domain.Http2Port = domain_http2Port;

			List<string> domain_httpPort = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomain.Domain.HttpPort.Length"); i++) {
				domain_httpPort.Add(context.StringValue("DescribeDomain.Domain.HttpPort["+ i +"]"));
			}
			domain.HttpPort = domain_httpPort;

			List<string> domain_httpsPort = new List<string>();
			for (int i = 0; i < context.Length("DescribeDomain.Domain.HttpsPort.Length"); i++) {
				domain_httpsPort.Add(context.StringValue("DescribeDomain.Domain.HttpsPort["+ i +"]"));
			}
			domain.HttpsPort = domain_httpsPort;
			describeDomainResponse.Domain = domain;
        
			return describeDomainResponse;
        }
    }
}
