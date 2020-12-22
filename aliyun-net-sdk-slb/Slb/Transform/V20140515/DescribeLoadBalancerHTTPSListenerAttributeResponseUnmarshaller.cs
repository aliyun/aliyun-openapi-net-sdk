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
    public class DescribeLoadBalancerHTTPSListenerAttributeResponseUnmarshaller
    {
        public static DescribeLoadBalancerHTTPSListenerAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerHTTPSListenerAttributeResponse describeLoadBalancerHTTPSListenerAttributeResponse = new DescribeLoadBalancerHTTPSListenerAttributeResponse();

			describeLoadBalancerHTTPSListenerAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerHTTPSListenerAttributeResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.RequestId");
			describeLoadBalancerHTTPSListenerAttributeResponse.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.ListenerPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.BackendServerPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.BackendProtocol = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.BackendProtocol");
			describeLoadBalancerHTTPSListenerAttributeResponse.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.Bandwidth");
			describeLoadBalancerHTTPSListenerAttributeResponse.Status = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Status");
			describeLoadBalancerHTTPSListenerAttributeResponse.SecurityStatus = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.SecurityStatus");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor");
			describeLoadBalancerHTTPSListenerAttributeResponse.Scheduler = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Scheduler");
			describeLoadBalancerHTTPSListenerAttributeResponse.StickySession = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySession");
			describeLoadBalancerHTTPSListenerAttributeResponse.StickySessionType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySessionType");
			describeLoadBalancerHTTPSListenerAttributeResponse.CookieTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.CookieTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.Cookie = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Cookie");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheck = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheck");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckType");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckDomain");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckURI");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthyThreshold");
			describeLoadBalancerHTTPSListenerAttributeResponse.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckInterval");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerHTTPSListenerAttributeResponse.ServerCertificateId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificateId");
			describeLoadBalancerHTTPSListenerAttributeResponse.CACertificateId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.CACertificateId");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckMethod");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckHttpVersion = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckHttpVersion");
			describeLoadBalancerHTTPSListenerAttributeResponse.MaxConnection = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.MaxConnection");
			describeLoadBalancerHTTPSListenerAttributeResponse.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.VServerGroupId");
			describeLoadBalancerHTTPSListenerAttributeResponse.Gzip = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Gzip");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBIP = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBIP");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBID = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBID");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_proto = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_proto");
			describeLoadBalancerHTTPSListenerAttributeResponse.AclId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclId");
			describeLoadBalancerHTTPSListenerAttributeResponse.AclType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclType");
			describeLoadBalancerHTTPSListenerAttributeResponse.AclStatus = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclStatus");
			describeLoadBalancerHTTPSListenerAttributeResponse.VpcIds = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.VpcIds");
			describeLoadBalancerHTTPSListenerAttributeResponse.RequestTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.RequestTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.IdleTimeout = _ctx.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.IdleTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.EnableHttp2 = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.EnableHttp2");
			describeLoadBalancerHTTPSListenerAttributeResponse.TLSCipherPolicy = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.TLSCipherPolicy");
			describeLoadBalancerHTTPSListenerAttributeResponse.Description = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Description");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBPORT = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBPORT");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientSrcPort = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientSrcPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertSubjectDN = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertSubjectDN");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertIssuerDN = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertIssuerDN");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertFingerprint = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertFingerprint");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertClientVerify = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertClientVerify");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertSubjectDNAlias = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertSubjectDNAlias");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertIssuerDNAlias = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertIssuerDNAlias");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertFingerprintAlias = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertFingerprintAlias");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_ClientCertClientVerifyAlias = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_ClientCertClientVerifyAlias");

			List<string> describeLoadBalancerHTTPSListenerAttributeResponse_aclIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerHTTPSListenerAttribute.AclIds.Length"); i++) {
				describeLoadBalancerHTTPSListenerAttributeResponse_aclIds.Add(_ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclIds["+ i +"]"));
			}
			describeLoadBalancerHTTPSListenerAttributeResponse.AclIds = describeLoadBalancerHTTPSListenerAttributeResponse_aclIds;

			List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule> describeLoadBalancerHTTPSListenerAttributeResponse_rules = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerHTTPSListenerAttribute.Rules.Length"); i++) {
				DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule rule = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule();
				rule.RuleId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].RuleId");
				rule.RuleName = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].RuleName");
				rule.Domain = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].Domain");
				rule.Url = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].Url");
				rule.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].VServerGroupId");

				describeLoadBalancerHTTPSListenerAttributeResponse_rules.Add(rule);
			}
			describeLoadBalancerHTTPSListenerAttributeResponse.Rules = describeLoadBalancerHTTPSListenerAttributeResponse_rules;

			List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension> describeLoadBalancerHTTPSListenerAttributeResponse_domainExtensions = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions.Length"); i++) {
				DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension domainExtension = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension();
				domainExtension.DomainExtensionId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].DomainExtensionId");
				domainExtension.Domain = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].Domain");
				domainExtension.ServerCertificateId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificateId");

				List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_Certificate> domainExtension_certificates = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_Certificate>();
				for (int j = 0; j < _ctx.Length("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].Certificates.Length"); j++) {
					DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_Certificate certificate = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_Certificate();
					certificate.CertificateId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].Certificates["+ j +"].CertificateId");
					certificate.EncryptionAlgorithm = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].Certificates["+ j +"].EncryptionAlgorithm");

					domainExtension_certificates.Add(certificate);
				}
				domainExtension.Certificates = domainExtension_certificates;

				List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate> domainExtension_serverCertificates1 = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate>();
				for (int j = 0; j < _ctx.Length("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificates.Length"); j++) {
					DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate serverCertificate = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate();
					serverCertificate.CertificateId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificates["+ j +"].CertificateId");
					serverCertificate.EncryptionAlgorithm = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificates["+ j +"].EncryptionAlgorithm");
					serverCertificate.StandardType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificates["+ j +"].StandardType");
					serverCertificate.BindingType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificates["+ j +"].BindingType");

					domainExtension_serverCertificates1.Add(serverCertificate);
				}
				domainExtension.ServerCertificates1 = domainExtension_serverCertificates1;

				describeLoadBalancerHTTPSListenerAttributeResponse_domainExtensions.Add(domainExtension);
			}
			describeLoadBalancerHTTPSListenerAttributeResponse.DomainExtensions = describeLoadBalancerHTTPSListenerAttributeResponse_domainExtensions;

			List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2> describeLoadBalancerHTTPSListenerAttributeResponse_serverCertificates = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificates.Length"); i++) {
				DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2 serverCertificate2 = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2();
				serverCertificate2.CertificateId = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificates["+ i +"].CertificateId");
				serverCertificate2.EncryptionAlgorithm = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificates["+ i +"].EncryptionAlgorithm");
				serverCertificate2.StandardType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificates["+ i +"].StandardType");
				serverCertificate2.BindingType = _ctx.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificates["+ i +"].BindingType");

				describeLoadBalancerHTTPSListenerAttributeResponse_serverCertificates.Add(serverCertificate2);
			}
			describeLoadBalancerHTTPSListenerAttributeResponse.ServerCertificates = describeLoadBalancerHTTPSListenerAttributeResponse_serverCertificates;
        
			return describeLoadBalancerHTTPSListenerAttributeResponse;
        }
    }
}
