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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeDomainResponse : AcsResponse
	{

		private string requestId;

		private DescribeDomain_Domain domain;

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

		public DescribeDomain_Domain Domain
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

		public class DescribeDomain_Domain
		{

			private int? httpToUserIp;

			private int? sniStatus;

			private int? isAccessProduct;

			private int? accessHeaderMode;

			private int? httpsRedirect;

			private int? ipFollowStatus;

			private int? loadBalancing;

			private string accessType;

			private long? version;

			private int? clusterType;

			private int? readTime;

			private int? writeTime;

			private string sniHost;

			private string resourceGroupId;

			private string cname;

			private int? connectionTime;

			private bool? retry;

			private bool? keepalive;

			private int? keepaliveRequests;

			private int? keepaliveTimeout;

			private List<DescribeDomain_LogHeader> logHeaders;

			private List<DescribeDomain_CloudNativeInstancesItem> cloudNativeInstances;

			private List<string> httpPort;

			private List<string> http2Port;

			private List<string> sourceIps;

			private List<string> httpsPort;

			private List<string> accessHeaders;

			public int? HttpToUserIp
			{
				get
				{
					return httpToUserIp;
				}
				set	
				{
					httpToUserIp = value;
				}
			}

			public int? SniStatus
			{
				get
				{
					return sniStatus;
				}
				set	
				{
					sniStatus = value;
				}
			}

			public int? IsAccessProduct
			{
				get
				{
					return isAccessProduct;
				}
				set	
				{
					isAccessProduct = value;
				}
			}

			public int? AccessHeaderMode
			{
				get
				{
					return accessHeaderMode;
				}
				set	
				{
					accessHeaderMode = value;
				}
			}

			public int? HttpsRedirect
			{
				get
				{
					return httpsRedirect;
				}
				set	
				{
					httpsRedirect = value;
				}
			}

			public int? IpFollowStatus
			{
				get
				{
					return ipFollowStatus;
				}
				set	
				{
					ipFollowStatus = value;
				}
			}

			public int? LoadBalancing
			{
				get
				{
					return loadBalancing;
				}
				set	
				{
					loadBalancing = value;
				}
			}

			public string AccessType
			{
				get
				{
					return accessType;
				}
				set	
				{
					accessType = value;
				}
			}

			public long? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public int? ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
				}
			}

			public int? ReadTime
			{
				get
				{
					return readTime;
				}
				set	
				{
					readTime = value;
				}
			}

			public int? WriteTime
			{
				get
				{
					return writeTime;
				}
				set	
				{
					writeTime = value;
				}
			}

			public string SniHost
			{
				get
				{
					return sniHost;
				}
				set	
				{
					sniHost = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string Cname
			{
				get
				{
					return cname;
				}
				set	
				{
					cname = value;
				}
			}

			public int? ConnectionTime
			{
				get
				{
					return connectionTime;
				}
				set	
				{
					connectionTime = value;
				}
			}

			public bool? Retry
			{
				get
				{
					return retry;
				}
				set	
				{
					retry = value;
				}
			}

			public bool? Keepalive
			{
				get
				{
					return keepalive;
				}
				set	
				{
					keepalive = value;
				}
			}

			public int? KeepaliveRequests
			{
				get
				{
					return keepaliveRequests;
				}
				set	
				{
					keepaliveRequests = value;
				}
			}

			public int? KeepaliveTimeout
			{
				get
				{
					return keepaliveTimeout;
				}
				set	
				{
					keepaliveTimeout = value;
				}
			}

			public List<DescribeDomain_LogHeader> LogHeaders
			{
				get
				{
					return logHeaders;
				}
				set	
				{
					logHeaders = value;
				}
			}

			public List<DescribeDomain_CloudNativeInstancesItem> CloudNativeInstances
			{
				get
				{
					return cloudNativeInstances;
				}
				set	
				{
					cloudNativeInstances = value;
				}
			}

			public List<string> HttpPort
			{
				get
				{
					return httpPort;
				}
				set	
				{
					httpPort = value;
				}
			}

			public List<string> Http2Port
			{
				get
				{
					return http2Port;
				}
				set	
				{
					http2Port = value;
				}
			}

			public List<string> SourceIps
			{
				get
				{
					return sourceIps;
				}
				set	
				{
					sourceIps = value;
				}
			}

			public List<string> HttpsPort
			{
				get
				{
					return httpsPort;
				}
				set	
				{
					httpsPort = value;
				}
			}

			public List<string> AccessHeaders
			{
				get
				{
					return accessHeaders;
				}
				set	
				{
					accessHeaders = value;
				}
			}

			public class DescribeDomain_LogHeader
			{

				private string k;

				private string v;

				public string K
				{
					get
					{
						return k;
					}
					set	
					{
						k = value;
					}
				}

				public string V
				{
					get
					{
						return v;
					}
					set	
					{
						v = value;
					}
				}
			}

			public class DescribeDomain_CloudNativeInstancesItem
			{

				private string redirectionTypeName;

				private string cloudNativeProductName;

				private string instanceId;

				private List<DescribeDomain_ProtocolPortConfigsItem> protocolPortConfigs;

				private List<string> iPAddressList;

				public string RedirectionTypeName
				{
					get
					{
						return redirectionTypeName;
					}
					set	
					{
						redirectionTypeName = value;
					}
				}

				public string CloudNativeProductName
				{
					get
					{
						return cloudNativeProductName;
					}
					set	
					{
						cloudNativeProductName = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public List<DescribeDomain_ProtocolPortConfigsItem> ProtocolPortConfigs
				{
					get
					{
						return protocolPortConfigs;
					}
					set	
					{
						protocolPortConfigs = value;
					}
				}

				public List<string> IPAddressList
				{
					get
					{
						return iPAddressList;
					}
					set	
					{
						iPAddressList = value;
					}
				}

				public class DescribeDomain_ProtocolPortConfigsItem
				{

					private string protocol;

					private List<string> ports;

					public string Protocol
					{
						get
						{
							return protocol;
						}
						set	
						{
							protocol = value;
						}
					}

					public List<string> Ports
					{
						get
						{
							return ports;
						}
						set	
						{
							ports = value;
						}
					}
				}
			}
		}
	}
}
