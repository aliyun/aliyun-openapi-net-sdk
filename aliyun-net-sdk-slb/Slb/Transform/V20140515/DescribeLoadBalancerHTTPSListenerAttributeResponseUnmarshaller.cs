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
        public static DescribeLoadBalancerHTTPSListenerAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoadBalancerHTTPSListenerAttributeResponse describeLoadBalancerHTTPSListenerAttributeResponse = new DescribeLoadBalancerHTTPSListenerAttributeResponse();

			describeLoadBalancerHTTPSListenerAttributeResponse.HttpResponse = context.HttpResponse;
			describeLoadBalancerHTTPSListenerAttributeResponse.RequestId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.RequestId");
			describeLoadBalancerHTTPSListenerAttributeResponse.ListenerPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.ListenerPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.BackendServerPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.BackendServerPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.Bandwidth = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.Bandwidth");
			describeLoadBalancerHTTPSListenerAttributeResponse.Status = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Status");
			describeLoadBalancerHTTPSListenerAttributeResponse.SecurityStatus = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.SecurityStatus");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor");
			describeLoadBalancerHTTPSListenerAttributeResponse.Scheduler = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Scheduler");
			describeLoadBalancerHTTPSListenerAttributeResponse.StickySession = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySession");
			describeLoadBalancerHTTPSListenerAttributeResponse.StickySessionType = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.StickySessionType");
			describeLoadBalancerHTTPSListenerAttributeResponse.CookieTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.CookieTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.Cookie = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Cookie");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheck = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheck");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckDomain = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckDomain");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckURI = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckURI");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthyThreshold");
			describeLoadBalancerHTTPSListenerAttributeResponse.UnhealthyThreshold = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.UnhealthyThreshold");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckInterval = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckInterval");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckConnectPort = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckConnectPort");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckHttpCode = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckHttpCode");
			describeLoadBalancerHTTPSListenerAttributeResponse.ServerCertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.ServerCertificateId");
			describeLoadBalancerHTTPSListenerAttributeResponse.CACertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.CACertificateId");
			describeLoadBalancerHTTPSListenerAttributeResponse.HealthCheckMethod = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.HealthCheckMethod");
			describeLoadBalancerHTTPSListenerAttributeResponse.MaxConnection = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.MaxConnection");
			describeLoadBalancerHTTPSListenerAttributeResponse.VServerGroupId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.VServerGroupId");
			describeLoadBalancerHTTPSListenerAttributeResponse.Gzip = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Gzip");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBIP = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBIP");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_SLBID = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_SLBID");
			describeLoadBalancerHTTPSListenerAttributeResponse.XForwardedFor_proto = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.XForwardedFor_proto");
			describeLoadBalancerHTTPSListenerAttributeResponse.AclId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclId");
			describeLoadBalancerHTTPSListenerAttributeResponse.AclType = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclType");
			describeLoadBalancerHTTPSListenerAttributeResponse.AclStatus = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.AclStatus");
			describeLoadBalancerHTTPSListenerAttributeResponse.VpcIds = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.VpcIds");
			describeLoadBalancerHTTPSListenerAttributeResponse.RequestTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.RequestTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.IdleTimeout = context.IntegerValue("DescribeLoadBalancerHTTPSListenerAttribute.IdleTimeout");
			describeLoadBalancerHTTPSListenerAttributeResponse.EnableHttp2 = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.EnableHttp2");
			describeLoadBalancerHTTPSListenerAttributeResponse.TLSCipherPolicy = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.TLSCipherPolicy");
			describeLoadBalancerHTTPSListenerAttributeResponse.Description = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Description");

			List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule> describeLoadBalancerHTTPSListenerAttributeResponse_rules = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerHTTPSListenerAttribute.Rules.Length"); i++) {
				DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule rule = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_Rule();
				rule.RuleId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].RuleId");
				rule.RuleName = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].RuleName");
				rule.Domain = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].Domain");
				rule.Url = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].Url");
				rule.VServerGroupId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.Rules["+ i +"].VServerGroupId");

				describeLoadBalancerHTTPSListenerAttributeResponse_rules.Add(rule);
			}
			describeLoadBalancerHTTPSListenerAttributeResponse.Rules = describeLoadBalancerHTTPSListenerAttributeResponse_rules;

			List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension> describeLoadBalancerHTTPSListenerAttributeResponse_domainExtensions = new List<DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension>();
			for (int i = 0; i < context.Length("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions.Length"); i++) {
				DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension domainExtension = new DescribeLoadBalancerHTTPSListenerAttributeResponse.DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension();
				domainExtension.DomainExtensionId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].DomainExtensionId");
				domainExtension.Domain = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].Domain");
				domainExtension.ServerCertificateId = context.StringValue("DescribeLoadBalancerHTTPSListenerAttribute.DomainExtensions["+ i +"].ServerCertificateId");

				describeLoadBalancerHTTPSListenerAttributeResponse_domainExtensions.Add(domainExtension);
			}
			describeLoadBalancerHTTPSListenerAttributeResponse.DomainExtensions = describeLoadBalancerHTTPSListenerAttributeResponse_domainExtensions;
        
			return describeLoadBalancerHTTPSListenerAttributeResponse;
        }
    }
}
