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

			private int? ipFollowStatus;

			private int? httpToUserIp;

			private int? httpsRedirect;

			private int? loadBalancing;

			private string cname;

			private int? isAccessProduct;

			private int? accessHeaderMode;

			private long? version;

			private int? clusterType;

			private int? connectionTime;

			private int? readTime;

			private int? writeTime;

			private string resourceGroupId;

			private string accessType;

			private List<DescribeDomain_LogHeader> logHeaders;

			private List<DescribeDomain_CloudNativeInstancesItem> cloudNativeInstances;

			private List<string> sourceIps;

			private List<string> http2Port;

			private List<string> httpPort;

			private List<string> accessHeaders;

			private List<string> httpsPort;

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

			public class DescribeDomain_LogHeader
			{

				private string v;

				private string k;

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
			}

			public class DescribeDomain_CloudNativeInstancesItem
			{

				private string cloudNativeProductName;

				private string redirectionTypeName;

				private string instanceId;

				private string iPAddressList;

				private List<DescribeDomain_ProtocolPortConfigsItem> protocolPortConfigs;

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

				public string IPAddressList
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

				public class DescribeDomain_ProtocolPortConfigsItem
				{

					private string protocol;

					private string ports;

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

					public string Ports
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
