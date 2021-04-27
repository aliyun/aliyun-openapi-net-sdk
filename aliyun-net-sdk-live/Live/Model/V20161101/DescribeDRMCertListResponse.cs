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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeDRMCertListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDRMCertList_CertInfo> dRMCertInfoListList;

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

		public List<DescribeDRMCertList_CertInfo> DRMCertInfoListList
		{
			get
			{
				return dRMCertInfoListList;
			}
			set	
			{
				dRMCertInfoListList = value;
			}
		}

		public class DescribeDRMCertList_CertInfo
		{

			private string certId;

			private string certName;

			private string servCert;

			private string privateKey;

			private string passphrase;

			private string ask;

			private string description;

			public string CertId
			{
				get
				{
					return certId;
				}
				set	
				{
					certId = value;
				}
			}

			public string CertName
			{
				get
				{
					return certName;
				}
				set	
				{
					certName = value;
				}
			}

			public string ServCert
			{
				get
				{
					return servCert;
				}
				set	
				{
					servCert = value;
				}
			}

			public string PrivateKey
			{
				get
				{
					return privateKey;
				}
				set	
				{
					privateKey = value;
				}
			}

			public string Passphrase
			{
				get
				{
					return passphrase;
				}
				set	
				{
					passphrase = value;
				}
			}

			public string Ask
			{
				get
				{
					return ask;
				}
				set	
				{
					ask = value;
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
		}
	}
}
