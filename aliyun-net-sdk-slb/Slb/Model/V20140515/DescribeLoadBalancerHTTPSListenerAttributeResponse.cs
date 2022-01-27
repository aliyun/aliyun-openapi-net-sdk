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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeLoadBalancerHTTPSListenerAttributeResponse : AcsResponse
	{

		private string requestId;

		private int? listenerPort;

		private int? backendServerPort;

		private string backendProtocol;

		private int? bandwidth;

		private string status;

		private string securityStatus;

		private string xForwardedFor;

		private string scheduler;

		private string stickySession;

		private string stickySessionType;

		private int? cookieTimeout;

		private string cookie;

		private string healthCheck;

		private string healthCheckType;

		private string healthCheckDomain;

		private string healthCheckURI;

		private int? healthyThreshold;

		private int? unhealthyThreshold;

		private int? healthCheckTimeout;

		private int? healthCheckInterval;

		private int? healthCheckConnectPort;

		private string healthCheckHttpCode;

		private string serverCertificateId;

		private string cACertificateId;

		private string healthCheckMethod;

		private string healthCheckHttpVersion;

		private int? maxConnection;

		private string vServerGroupId;

		private string gzip;

		private string xForwardedFor_SLBIP;

		private string xForwardedFor_SLBID;

		private string xForwardedFor_proto;

		private string aclId;

		private string aclType;

		private string aclStatus;

		private string vpcIds;

		private int? requestTimeout;

		private int? idleTimeout;

		private string enableHttp2;

		private string tLSCipherPolicy;

		private string description;

		private string xForwardedFor_SLBPORT;

		private string xForwardedFor_ClientSrcPort;

		private string xForwardedFor_ClientCertSubjectDN;

		private string xForwardedFor_ClientCertIssuerDN;

		private string xForwardedFor_ClientCertFingerprint;

		private string xForwardedFor_ClientCertClientVerify;

		private string xForwardedFor_ClientCertSubjectDNAlias;

		private string xForwardedFor_ClientCertIssuerDNAlias;

		private string xForwardedFor_ClientCertFingerprintAlias;

		private string xForwardedFor_ClientCertClientVerifyAlias;

		private List<DescribeLoadBalancerHTTPSListenerAttribute_Rule> rules;

		private List<DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension> domainExtensions;

		private List<DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2> serverCertificates;

		private List<string> aclIds;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
			}
		}

		public int? BackendServerPort
		{
			get
			{
				return backendServerPort;
			}
			set	
			{
				backendServerPort = value;
			}
		}

		public string BackendProtocol
		{
			get
			{
				return backendProtocol;
			}
			set	
			{
				backendProtocol = value;
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string SecurityStatus
		{
			get
			{
				return securityStatus;
			}
			set	
			{
				securityStatus = value;
			}
		}

		public string XForwardedFor
		{
			get
			{
				return xForwardedFor;
			}
			set	
			{
				xForwardedFor = value;
			}
		}

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
			}
		}

		public string StickySession
		{
			get
			{
				return stickySession;
			}
			set	
			{
				stickySession = value;
			}
		}

		public string StickySessionType
		{
			get
			{
				return stickySessionType;
			}
			set	
			{
				stickySessionType = value;
			}
		}

		public int? CookieTimeout
		{
			get
			{
				return cookieTimeout;
			}
			set	
			{
				cookieTimeout = value;
			}
		}

		public string Cookie
		{
			get
			{
				return cookie;
			}
			set	
			{
				cookie = value;
			}
		}

		public string HealthCheck
		{
			get
			{
				return healthCheck;
			}
			set	
			{
				healthCheck = value;
			}
		}

		public string HealthCheckType
		{
			get
			{
				return healthCheckType;
			}
			set	
			{
				healthCheckType = value;
			}
		}

		public string HealthCheckDomain
		{
			get
			{
				return healthCheckDomain;
			}
			set	
			{
				healthCheckDomain = value;
			}
		}

		public string HealthCheckURI
		{
			get
			{
				return healthCheckURI;
			}
			set	
			{
				healthCheckURI = value;
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return healthyThreshold;
			}
			set	
			{
				healthyThreshold = value;
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return unhealthyThreshold;
			}
			set	
			{
				unhealthyThreshold = value;
			}
		}

		public int? HealthCheckTimeout
		{
			get
			{
				return healthCheckTimeout;
			}
			set	
			{
				healthCheckTimeout = value;
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return healthCheckInterval;
			}
			set	
			{
				healthCheckInterval = value;
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return healthCheckConnectPort;
			}
			set	
			{
				healthCheckConnectPort = value;
			}
		}

		public string HealthCheckHttpCode
		{
			get
			{
				return healthCheckHttpCode;
			}
			set	
			{
				healthCheckHttpCode = value;
			}
		}

		public string ServerCertificateId
		{
			get
			{
				return serverCertificateId;
			}
			set	
			{
				serverCertificateId = value;
			}
		}

		public string CACertificateId
		{
			get
			{
				return cACertificateId;
			}
			set	
			{
				cACertificateId = value;
			}
		}

		public string HealthCheckMethod
		{
			get
			{
				return healthCheckMethod;
			}
			set	
			{
				healthCheckMethod = value;
			}
		}

		public string HealthCheckHttpVersion
		{
			get
			{
				return healthCheckHttpVersion;
			}
			set	
			{
				healthCheckHttpVersion = value;
			}
		}

		public int? MaxConnection
		{
			get
			{
				return maxConnection;
			}
			set	
			{
				maxConnection = value;
			}
		}

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
			}
		}

		public string Gzip
		{
			get
			{
				return gzip;
			}
			set	
			{
				gzip = value;
			}
		}

		public string XForwardedFor_SLBIP
		{
			get
			{
				return xForwardedFor_SLBIP;
			}
			set	
			{
				xForwardedFor_SLBIP = value;
			}
		}

		public string XForwardedFor_SLBID
		{
			get
			{
				return xForwardedFor_SLBID;
			}
			set	
			{
				xForwardedFor_SLBID = value;
			}
		}

		public string XForwardedFor_proto
		{
			get
			{
				return xForwardedFor_proto;
			}
			set	
			{
				xForwardedFor_proto = value;
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
			}
		}

		public string VpcIds
		{
			get
			{
				return vpcIds;
			}
			set	
			{
				vpcIds = value;
			}
		}

		public int? RequestTimeout
		{
			get
			{
				return requestTimeout;
			}
			set	
			{
				requestTimeout = value;
			}
		}

		public int? IdleTimeout
		{
			get
			{
				return idleTimeout;
			}
			set	
			{
				idleTimeout = value;
			}
		}

		public string EnableHttp2
		{
			get
			{
				return enableHttp2;
			}
			set	
			{
				enableHttp2 = value;
			}
		}

		public string TLSCipherPolicy
		{
			get
			{
				return tLSCipherPolicy;
			}
			set	
			{
				tLSCipherPolicy = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
			}
		}

		public string XForwardedFor_SLBPORT
		{
			get
			{
				return xForwardedFor_SLBPORT;
			}
			set	
			{
				xForwardedFor_SLBPORT = value;
			}
		}

		public string XForwardedFor_ClientSrcPort
		{
			get
			{
				return xForwardedFor_ClientSrcPort;
			}
			set	
			{
				xForwardedFor_ClientSrcPort = value;
			}
		}

		public string XForwardedFor_ClientCertSubjectDN
		{
			get
			{
				return xForwardedFor_ClientCertSubjectDN;
			}
			set	
			{
				xForwardedFor_ClientCertSubjectDN = value;
			}
		}

		public string XForwardedFor_ClientCertIssuerDN
		{
			get
			{
				return xForwardedFor_ClientCertIssuerDN;
			}
			set	
			{
				xForwardedFor_ClientCertIssuerDN = value;
			}
		}

		public string XForwardedFor_ClientCertFingerprint
		{
			get
			{
				return xForwardedFor_ClientCertFingerprint;
			}
			set	
			{
				xForwardedFor_ClientCertFingerprint = value;
			}
		}

		public string XForwardedFor_ClientCertClientVerify
		{
			get
			{
				return xForwardedFor_ClientCertClientVerify;
			}
			set	
			{
				xForwardedFor_ClientCertClientVerify = value;
			}
		}

		public string XForwardedFor_ClientCertSubjectDNAlias
		{
			get
			{
				return xForwardedFor_ClientCertSubjectDNAlias;
			}
			set	
			{
				xForwardedFor_ClientCertSubjectDNAlias = value;
			}
		}

		public string XForwardedFor_ClientCertIssuerDNAlias
		{
			get
			{
				return xForwardedFor_ClientCertIssuerDNAlias;
			}
			set	
			{
				xForwardedFor_ClientCertIssuerDNAlias = value;
			}
		}

		public string XForwardedFor_ClientCertFingerprintAlias
		{
			get
			{
				return xForwardedFor_ClientCertFingerprintAlias;
			}
			set	
			{
				xForwardedFor_ClientCertFingerprintAlias = value;
			}
		}

		public string XForwardedFor_ClientCertClientVerifyAlias
		{
			get
			{
				return xForwardedFor_ClientCertClientVerifyAlias;
			}
			set	
			{
				xForwardedFor_ClientCertClientVerifyAlias = value;
			}
		}

		public List<DescribeLoadBalancerHTTPSListenerAttribute_Rule> Rules
		{
			get
			{
				return rules;
			}
			set	
			{
				rules = value;
			}
		}

		public List<DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension> DomainExtensions
		{
			get
			{
				return domainExtensions;
			}
			set	
			{
				domainExtensions = value;
			}
		}

		public List<DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2> ServerCertificates
		{
			get
			{
				return serverCertificates;
			}
			set	
			{
				serverCertificates = value;
			}
		}

		public List<string> AclIds
		{
			get
			{
				return aclIds;
			}
			set	
			{
				aclIds = value;
			}
		}

		public class DescribeLoadBalancerHTTPSListenerAttribute_Rule
		{

			private string ruleId;

			private string ruleName;

			private string domain;

			private string url;

			private string vServerGroupId;

			public string RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string VServerGroupId
			{
				get
				{
					return vServerGroupId;
				}
				set	
				{
					vServerGroupId = value;
				}
			}
		}

		public class DescribeLoadBalancerHTTPSListenerAttribute_DomainExtension
		{

			private string domainExtensionId;

			private string domain;

			private string serverCertificateId;

			private List<DescribeLoadBalancerHTTPSListenerAttribute_Certificate> certificates;

			private List<DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate> serverCertificates1;

			public string DomainExtensionId
			{
				get
				{
					return domainExtensionId;
				}
				set	
				{
					domainExtensionId = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string ServerCertificateId
			{
				get
				{
					return serverCertificateId;
				}
				set	
				{
					serverCertificateId = value;
				}
			}

			public List<DescribeLoadBalancerHTTPSListenerAttribute_Certificate> Certificates
			{
				get
				{
					return certificates;
				}
				set	
				{
					certificates = value;
				}
			}

			public List<DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate> ServerCertificates1
			{
				get
				{
					return serverCertificates1;
				}
				set	
				{
					serverCertificates1 = value;
				}
			}

			public class DescribeLoadBalancerHTTPSListenerAttribute_Certificate
			{

				private string certificateId;

				private string encryptionAlgorithm;

				public string CertificateId
				{
					get
					{
						return certificateId;
					}
					set	
					{
						certificateId = value;
					}
				}

				public string EncryptionAlgorithm
				{
					get
					{
						return encryptionAlgorithm;
					}
					set	
					{
						encryptionAlgorithm = value;
					}
				}
			}

			public class DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate
			{

				private string certificateId;

				private string encryptionAlgorithm;

				private string standardType;

				private string bindingType;

				public string CertificateId
				{
					get
					{
						return certificateId;
					}
					set	
					{
						certificateId = value;
					}
				}

				public string EncryptionAlgorithm
				{
					get
					{
						return encryptionAlgorithm;
					}
					set	
					{
						encryptionAlgorithm = value;
					}
				}

				public string StandardType
				{
					get
					{
						return standardType;
					}
					set	
					{
						standardType = value;
					}
				}

				public string BindingType
				{
					get
					{
						return bindingType;
					}
					set	
					{
						bindingType = value;
					}
				}
			}
		}

		public class DescribeLoadBalancerHTTPSListenerAttribute_ServerCertificate2
		{

			private string certificateId;

			private string encryptionAlgorithm;

			private string standardType;

			private string bindingType;

			public string CertificateId
			{
				get
				{
					return certificateId;
				}
				set	
				{
					certificateId = value;
				}
			}

			public string EncryptionAlgorithm
			{
				get
				{
					return encryptionAlgorithm;
				}
				set	
				{
					encryptionAlgorithm = value;
				}
			}

			public string StandardType
			{
				get
				{
					return standardType;
				}
				set	
				{
					standardType = value;
				}
			}

			public string BindingType
			{
				get
				{
					return bindingType;
				}
				set	
				{
					bindingType = value;
				}
			}
		}
	}
}
