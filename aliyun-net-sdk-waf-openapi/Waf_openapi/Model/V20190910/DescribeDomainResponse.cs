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

			private int? httpToUserIp;

			private int? httpsRedirect;

			private int? loadBalancing;

			private string cname;

			private int? isAccessProduct;

			private long? version;

			private int? clusterType;

			private int? connectionTime;

			private int? readTime;

			private int? writeTime;

			private string resourceGroupId;

			private List<DescribeDomain_LogHeader> logHeaders;

			private List<string> sourceIps;

			private List<string> http2Port;

			private List<string> httpPort;

			private List<string> httpsPort;

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
		}
	}
}
