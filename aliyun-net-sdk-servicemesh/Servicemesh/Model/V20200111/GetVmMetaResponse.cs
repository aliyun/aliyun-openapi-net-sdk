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

namespace Aliyun.Acs.servicemesh.Model.V20200111
{
	public class GetVmMetaResponse : AcsResponse
	{

		private string requestId;

		private GetVmMeta_VmMetaInfo vmMetaInfo;

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

		public GetVmMeta_VmMetaInfo VmMetaInfo
		{
			get
			{
				return vmMetaInfo;
			}
			set	
			{
				vmMetaInfo = value;
			}
		}

		public class GetVmMeta_VmMetaInfo
		{

			private string rootCertPath;

			private string rootCertContent;

			private string keyPath;

			private string keyContent;

			private string certChainPath;

			private string certChainContent;

			private string envoyEnvPath;

			private string envoyEnvContent;

			private string hostsPath;

			private string hostsContent;

			private string tokenPath;

			private string tokenContent;

			public string RootCertPath
			{
				get
				{
					return rootCertPath;
				}
				set	
				{
					rootCertPath = value;
				}
			}

			public string RootCertContent
			{
				get
				{
					return rootCertContent;
				}
				set	
				{
					rootCertContent = value;
				}
			}

			public string KeyPath
			{
				get
				{
					return keyPath;
				}
				set	
				{
					keyPath = value;
				}
			}

			public string KeyContent
			{
				get
				{
					return keyContent;
				}
				set	
				{
					keyContent = value;
				}
			}

			public string CertChainPath
			{
				get
				{
					return certChainPath;
				}
				set	
				{
					certChainPath = value;
				}
			}

			public string CertChainContent
			{
				get
				{
					return certChainContent;
				}
				set	
				{
					certChainContent = value;
				}
			}

			public string EnvoyEnvPath
			{
				get
				{
					return envoyEnvPath;
				}
				set	
				{
					envoyEnvPath = value;
				}
			}

			public string EnvoyEnvContent
			{
				get
				{
					return envoyEnvContent;
				}
				set	
				{
					envoyEnvContent = value;
				}
			}

			public string HostsPath
			{
				get
				{
					return hostsPath;
				}
				set	
				{
					hostsPath = value;
				}
			}

			public string HostsContent
			{
				get
				{
					return hostsContent;
				}
				set	
				{
					hostsContent = value;
				}
			}

			public string TokenPath
			{
				get
				{
					return tokenPath;
				}
				set	
				{
					tokenPath = value;
				}
			}

			public string TokenContent
			{
				get
				{
					return tokenContent;
				}
				set	
				{
					tokenContent = value;
				}
			}
		}
	}
}
