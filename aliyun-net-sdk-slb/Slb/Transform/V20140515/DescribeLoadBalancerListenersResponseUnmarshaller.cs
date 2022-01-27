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
    public class DescribeLoadBalancerListenersResponseUnmarshaller
    {
        public static DescribeLoadBalancerListenersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLoadBalancerListenersResponse describeLoadBalancerListenersResponse = new DescribeLoadBalancerListenersResponse();

			describeLoadBalancerListenersResponse.HttpResponse = _ctx.HttpResponse;
			describeLoadBalancerListenersResponse.MaxResults = _ctx.IntegerValue("DescribeLoadBalancerListeners.MaxResults");
			describeLoadBalancerListenersResponse.NextToken = _ctx.StringValue("DescribeLoadBalancerListeners.NextToken");
			describeLoadBalancerListenersResponse.RequestId = _ctx.StringValue("DescribeLoadBalancerListeners.RequestId");
			describeLoadBalancerListenersResponse.TotalCount = _ctx.IntegerValue("DescribeLoadBalancerListeners.TotalCount");

			List<DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener> describeLoadBalancerListenersResponse_listeners = new List<DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener>();
			for (int i = 0; i < _ctx.Length("DescribeLoadBalancerListeners.Listeners.Length"); i++) {
				DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener listener = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener();
				listener.AclId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].AclId");
				listener.AclStatus = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].AclStatus");
				listener.AclType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].AclType");
				listener.BackendServerPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].BackendServerPort");
				listener.Bandwidth = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].Bandwidth");
				listener.Description = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].Description");
				listener.ListenerPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].ListenerPort");
				listener.ListenerProtocol = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].ListenerProtocol");
				listener.LoadBalancerId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].LoadBalancerId");
				listener.Scheduler = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].Scheduler");
				listener.Status = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].Status");
				listener.VServerGroupId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].VServerGroupId");

				List<string> listener_aclIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLoadBalancerListeners.Listeners["+ i +"].AclIds.Length"); j++) {
					listener_aclIds.Add(_ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].AclIds["+ j +"]"));
				}
				listener.AclIds = listener_aclIds;

				DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_HTTPListenerConfig hTTPListenerConfig = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_HTTPListenerConfig();
				hTTPListenerConfig.Cookie = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.Cookie");
				hTTPListenerConfig.CookieTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.CookieTimeout");
				hTTPListenerConfig.ForwardCode = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.ForwardCode");
				hTTPListenerConfig.ForwardPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.ForwardPort");
				hTTPListenerConfig.Gzip = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.Gzip");
				hTTPListenerConfig.HealthCheck = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheck");
				hTTPListenerConfig.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckConnectPort");
				hTTPListenerConfig.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckDomain");
				hTTPListenerConfig.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckHttpCode");
				hTTPListenerConfig.HealthCheckHttpVersion = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckHttpVersion");
				hTTPListenerConfig.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckInterval");
				hTTPListenerConfig.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckMethod");
				hTTPListenerConfig.HealthCheckTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckTimeout");
				hTTPListenerConfig.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckType");
				hTTPListenerConfig.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthCheckURI");
				hTTPListenerConfig.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.HealthyThreshold");
				hTTPListenerConfig.IdleTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.IdleTimeout");
				hTTPListenerConfig.ListenerForward = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.ListenerForward");
				hTTPListenerConfig.RequestTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.RequestTimeout");
				hTTPListenerConfig.StickySession = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.StickySession");
				hTTPListenerConfig.StickySessionType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.StickySessionType");
				hTTPListenerConfig.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.UnhealthyThreshold");
				hTTPListenerConfig.XForwardedFor = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.XForwardedFor");
				hTTPListenerConfig.XForwardedFor_ClientSrcPort = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.XForwardedFor_ClientSrcPort");
				hTTPListenerConfig.XForwardedFor_SLBID = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.XForwardedFor_SLBID");
				hTTPListenerConfig.XForwardedFor_SLBIP = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.XForwardedFor_SLBIP");
				hTTPListenerConfig.XForwardedFor_SLBPORT = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.XForwardedFor_SLBPORT");
				hTTPListenerConfig.XForwardedFor_proto = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPListenerConfig.XForwardedFor_proto");
				listener.HTTPListenerConfig = hTTPListenerConfig;

				DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_HTTPSListenerConfig hTTPSListenerConfig = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_HTTPSListenerConfig();
				hTTPSListenerConfig.CACertificateId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.CACertificateId");
				hTTPSListenerConfig.Cookie = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.Cookie");
				hTTPSListenerConfig.CookieTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.CookieTimeout");
				hTTPSListenerConfig.EnableHttp2 = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.EnableHttp2");
				hTTPSListenerConfig.Gzip = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.Gzip");
				hTTPSListenerConfig.HealthCheck = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheck");
				hTTPSListenerConfig.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckConnectPort");
				hTTPSListenerConfig.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckDomain");
				hTTPSListenerConfig.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckHttpCode");
				hTTPSListenerConfig.HealthCheckHttpVersion = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckHttpVersion");
				hTTPSListenerConfig.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckInterval");
				hTTPSListenerConfig.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckMethod");
				hTTPSListenerConfig.HealthCheckTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckTimeout");
				hTTPSListenerConfig.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckType");
				hTTPSListenerConfig.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthCheckURI");
				hTTPSListenerConfig.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.HealthyThreshold");
				hTTPSListenerConfig.IdleTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.IdleTimeout");
				hTTPSListenerConfig.RequestTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.RequestTimeout");
				hTTPSListenerConfig.ServerCertificateId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.ServerCertificateId");
				hTTPSListenerConfig.StickySession = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.StickySession");
				hTTPSListenerConfig.StickySessionType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.StickySessionType");
				hTTPSListenerConfig.TLSCipherPolicy = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.TLSCipherPolicy");
				hTTPSListenerConfig.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.UnhealthyThreshold");
				hTTPSListenerConfig.XForwardedFor = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor");
				hTTPSListenerConfig.XForwardedFor_ClientCertClientVerify = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertClientVerify");
				hTTPSListenerConfig.XForwardedFor_ClientCertClientVerifyAlias = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertClientVerifyAlias");
				hTTPSListenerConfig.XForwardedFor_ClientCertFingerprint = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertFingerprint");
				hTTPSListenerConfig.XForwardedFor_ClientCertFingerprintAlias = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertFingerprintAlias");
				hTTPSListenerConfig.XForwardedFor_ClientCertIssuerDN = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertIssuerDN");
				hTTPSListenerConfig.XForwardedFor_ClientCertIssuerDNAlias = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertIssuerDNAlias");
				hTTPSListenerConfig.XForwardedFor_ClientCertSubjectDN = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertSubjectDN");
				hTTPSListenerConfig.XForwardedFor_ClientCertSubjectDNAlias = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientCertSubjectDNAlias");
				hTTPSListenerConfig.XForwardedFor_ClientSrcPort = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_ClientSrcPort");
				hTTPSListenerConfig.XForwardedFor_SLBID = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_SLBID");
				hTTPSListenerConfig.XForwardedFor_SLBIP = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_SLBIP");
				hTTPSListenerConfig.XForwardedFor_SLBPORT = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_SLBPORT");
				hTTPSListenerConfig.XForwardedFor_proto = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].HTTPSListenerConfig.XForwardedFor_proto");
				listener.HTTPSListenerConfig = hTTPSListenerConfig;

				DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPListenerConfig tCPListenerConfig = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPListenerConfig();
				tCPListenerConfig.ConnectionDrain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.ConnectionDrain");
				tCPListenerConfig.ConnectionDrainTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.ConnectionDrainTimeout");
				tCPListenerConfig.EstablishedTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.EstablishedTimeout");
				tCPListenerConfig.HealthCheck = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheck");
				tCPListenerConfig.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckConnectPort");
				tCPListenerConfig.HealthCheckConnectTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckConnectTimeout");
				tCPListenerConfig.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckDomain");
				tCPListenerConfig.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckHttpCode");
				tCPListenerConfig.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckInterval");
				tCPListenerConfig.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckMethod");
				tCPListenerConfig.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckType");
				tCPListenerConfig.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckURI");
				tCPListenerConfig.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthyThreshold");
				tCPListenerConfig.MasterSlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.MasterSlaveServerGroupId");
				tCPListenerConfig.PersistenceTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.PersistenceTimeout");
				tCPListenerConfig.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.UnhealthyThreshold");
				tCPListenerConfig.HealthCheckSwitch = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.HealthCheckSwitch");

				List<DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPListenerConfig.DescribeLoadBalancerListeners_PortRange> tCPListenerConfig_portRanges = new List<DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPListenerConfig.DescribeLoadBalancerListeners_PortRange>();
				for (int j = 0; j < _ctx.Length("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.PortRanges.Length"); j++) {
					DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPListenerConfig.DescribeLoadBalancerListeners_PortRange portRange = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPListenerConfig.DescribeLoadBalancerListeners_PortRange();
					portRange.EndPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.PortRanges["+ j +"].EndPort");
					portRange.StartPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPListenerConfig.PortRanges["+ j +"].StartPort");

					tCPListenerConfig_portRanges.Add(portRange);
				}
				tCPListenerConfig.PortRanges = tCPListenerConfig_portRanges;
				listener.TCPListenerConfig = tCPListenerConfig;

				DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPSListenerConfig tCPSListenerConfig = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_TCPSListenerConfig();
				tCPSListenerConfig.CACertificateId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.CACertificateId");
				tCPSListenerConfig.Cookie = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.Cookie");
				tCPSListenerConfig.CookieTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.CookieTimeout");
				tCPSListenerConfig.HealthCheck = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheck");
				tCPSListenerConfig.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckConnectPort");
				tCPSListenerConfig.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckDomain");
				tCPSListenerConfig.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckHttpCode");
				tCPSListenerConfig.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckInterval");
				tCPSListenerConfig.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckMethod");
				tCPSListenerConfig.HealthCheckTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckTimeout");
				tCPSListenerConfig.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckType");
				tCPSListenerConfig.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthCheckURI");
				tCPSListenerConfig.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.HealthyThreshold");
				tCPSListenerConfig.IdleTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.IdleTimeout");
				tCPSListenerConfig.ServerCertificateId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.ServerCertificateId");
				tCPSListenerConfig.StickySession = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.StickySession");
				tCPSListenerConfig.StickySessionType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.StickySessionType");
				tCPSListenerConfig.TLSCipherPolicy = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.TLSCipherPolicy");
				tCPSListenerConfig.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].TCPSListenerConfig.UnhealthyThreshold");
				listener.TCPSListenerConfig = tCPSListenerConfig;

				DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_UDPListenerConfig uDPListenerConfig = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_UDPListenerConfig();
				uDPListenerConfig.ConnectionDrain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.ConnectionDrain");
				uDPListenerConfig.ConnectionDrainTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.ConnectionDrainTimeout");
				uDPListenerConfig.HealthCheck = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheck");
				uDPListenerConfig.HealthCheckConnectPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckConnectPort");
				uDPListenerConfig.HealthCheckConnectTimeout = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckConnectTimeout");
				uDPListenerConfig.HealthCheckDomain = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckDomain");
				uDPListenerConfig.HealthCheckExp = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckExp");
				uDPListenerConfig.HealthCheckHttpCode = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckHttpCode");
				uDPListenerConfig.HealthCheckInterval = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckInterval");
				uDPListenerConfig.HealthCheckMethod = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckMethod");
				uDPListenerConfig.HealthCheckReq = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckReq");
				uDPListenerConfig.HealthCheckType = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckType");
				uDPListenerConfig.HealthCheckURI = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckURI");
				uDPListenerConfig.HealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthyThreshold");
				uDPListenerConfig.MasterSlaveServerGroupId = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.MasterSlaveServerGroupId");
				uDPListenerConfig.UnhealthyThreshold = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.UnhealthyThreshold");
				uDPListenerConfig.HealthCheckSwitch = _ctx.StringValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.HealthCheckSwitch");

				List<DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_UDPListenerConfig.DescribeLoadBalancerListeners_PortRange2> uDPListenerConfig_portRanges1 = new List<DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_UDPListenerConfig.DescribeLoadBalancerListeners_PortRange2>();
				for (int j = 0; j < _ctx.Length("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.PortRanges.Length"); j++) {
					DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_UDPListenerConfig.DescribeLoadBalancerListeners_PortRange2 portRange2 = new DescribeLoadBalancerListenersResponse.DescribeLoadBalancerListeners_Listener.DescribeLoadBalancerListeners_UDPListenerConfig.DescribeLoadBalancerListeners_PortRange2();
					portRange2.EndPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.PortRanges["+ j +"].EndPort");
					portRange2.StartPort = _ctx.IntegerValue("DescribeLoadBalancerListeners.Listeners["+ i +"].UDPListenerConfig.PortRanges["+ j +"].StartPort");

					uDPListenerConfig_portRanges1.Add(portRange2);
				}
				uDPListenerConfig.PortRanges1 = uDPListenerConfig_portRanges1;
				listener.UDPListenerConfig = uDPListenerConfig;

				describeLoadBalancerListenersResponse_listeners.Add(listener);
			}
			describeLoadBalancerListenersResponse.Listeners = describeLoadBalancerListenersResponse_listeners;
        
			return describeLoadBalancerListenersResponse;
        }
    }
}
