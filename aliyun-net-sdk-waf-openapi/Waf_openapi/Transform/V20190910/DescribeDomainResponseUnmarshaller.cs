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
        public static DescribeDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainResponse describeDomainResponse = new DescribeDomainResponse();

			describeDomainResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainResponse.RequestId = _ctx.StringValue("DescribeDomain.RequestId");

			DescribeDomainResponse.DescribeDomain_Domain domain = new DescribeDomainResponse.DescribeDomain_Domain();
			domain.IpFollowStatus = _ctx.IntegerValue("DescribeDomain.Domain.IpFollowStatus");
			domain.HttpToUserIp = _ctx.IntegerValue("DescribeDomain.Domain.HttpToUserIp");
			domain.HttpsRedirect = _ctx.IntegerValue("DescribeDomain.Domain.HttpsRedirect");
			domain.LoadBalancing = _ctx.IntegerValue("DescribeDomain.Domain.LoadBalancing");
			domain.Cname = _ctx.StringValue("DescribeDomain.Domain.Cname");
			domain.IsAccessProduct = _ctx.IntegerValue("DescribeDomain.Domain.IsAccessProduct");
			domain.AccessHeaderMode = _ctx.IntegerValue("DescribeDomain.Domain.AccessHeaderMode");
			domain.Version = _ctx.LongValue("DescribeDomain.Domain.Version");
			domain.ClusterType = _ctx.IntegerValue("DescribeDomain.Domain.ClusterType");
			domain.ConnectionTime = _ctx.IntegerValue("DescribeDomain.Domain.ConnectionTime");
			domain.ReadTime = _ctx.IntegerValue("DescribeDomain.Domain.ReadTime");
			domain.WriteTime = _ctx.IntegerValue("DescribeDomain.Domain.WriteTime");
			domain.ResourceGroupId = _ctx.StringValue("DescribeDomain.Domain.ResourceGroupId");
			domain.AccessType = _ctx.StringValue("DescribeDomain.Domain.AccessType");

			List<string> domain_sourceIps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.SourceIps.Length"); i++) {
				domain_sourceIps.Add(_ctx.StringValue("DescribeDomain.Domain.SourceIps["+ i +"]"));
			}
			domain.SourceIps = domain_sourceIps;

			List<string> domain_http2Port = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.Http2Port.Length"); i++) {
				domain_http2Port.Add(_ctx.StringValue("DescribeDomain.Domain.Http2Port["+ i +"]"));
			}
			domain.Http2Port = domain_http2Port;

			List<string> domain_httpPort = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.HttpPort.Length"); i++) {
				domain_httpPort.Add(_ctx.StringValue("DescribeDomain.Domain.HttpPort["+ i +"]"));
			}
			domain.HttpPort = domain_httpPort;

			List<string> domain_accessHeaders = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.AccessHeaders.Length"); i++) {
				domain_accessHeaders.Add(_ctx.StringValue("DescribeDomain.Domain.AccessHeaders["+ i +"]"));
			}
			domain.AccessHeaders = domain_accessHeaders;

			List<string> domain_httpsPort = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.HttpsPort.Length"); i++) {
				domain_httpsPort.Add(_ctx.StringValue("DescribeDomain.Domain.HttpsPort["+ i +"]"));
			}
			domain.HttpsPort = domain_httpsPort;

			List<DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_LogHeader> domain_logHeaders = new List<DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_LogHeader>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.LogHeaders.Length"); i++) {
				DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_LogHeader logHeader = new DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_LogHeader();
				logHeader.V = _ctx.StringValue("DescribeDomain.Domain.LogHeaders["+ i +"].v");
				logHeader.K = _ctx.StringValue("DescribeDomain.Domain.LogHeaders["+ i +"].k");

				domain_logHeaders.Add(logHeader);
			}
			domain.LogHeaders = domain_logHeaders;

			List<DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem> domain_cloudNativeInstances = new List<DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem>();
			for (int i = 0; i < _ctx.Length("DescribeDomain.Domain.CloudNativeInstances.Length"); i++) {
				DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem cloudNativeInstancesItem = new DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem();
				cloudNativeInstancesItem.CloudNativeProductName = _ctx.StringValue("DescribeDomain.Domain.CloudNativeInstances["+ i +"].CloudNativeProductName");
				cloudNativeInstancesItem.RedirectionTypeName = _ctx.StringValue("DescribeDomain.Domain.CloudNativeInstances["+ i +"].RedirectionTypeName");
				cloudNativeInstancesItem.InstanceId = _ctx.StringValue("DescribeDomain.Domain.CloudNativeInstances["+ i +"].InstanceId");
				cloudNativeInstancesItem.IPAddressList = _ctx.StringValue("DescribeDomain.Domain.CloudNativeInstances["+ i +"].IPAddressList");

				List<DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem.DescribeDomain_ProtocolPortConfigsItem> cloudNativeInstancesItem_protocolPortConfigs = new List<DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem.DescribeDomain_ProtocolPortConfigsItem>();
				for (int j = 0; j < _ctx.Length("DescribeDomain.Domain.CloudNativeInstances["+ i +"].ProtocolPortConfigs.Length"); j++) {
					DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem.DescribeDomain_ProtocolPortConfigsItem protocolPortConfigsItem = new DescribeDomainResponse.DescribeDomain_Domain.DescribeDomain_CloudNativeInstancesItem.DescribeDomain_ProtocolPortConfigsItem();
					protocolPortConfigsItem.Protocol = _ctx.StringValue("DescribeDomain.Domain.CloudNativeInstances["+ i +"].ProtocolPortConfigs["+ j +"].Protocol");
					protocolPortConfigsItem.Ports = _ctx.StringValue("DescribeDomain.Domain.CloudNativeInstances["+ i +"].ProtocolPortConfigs["+ j +"].Ports");

					cloudNativeInstancesItem_protocolPortConfigs.Add(protocolPortConfigsItem);
				}
				cloudNativeInstancesItem.ProtocolPortConfigs = cloudNativeInstancesItem_protocolPortConfigs;

				domain_cloudNativeInstances.Add(cloudNativeInstancesItem);
			}
			domain.CloudNativeInstances = domain_cloudNativeInstances;
			describeDomainResponse.Domain = domain;
        
			return describeDomainResponse;
        }
    }
}
