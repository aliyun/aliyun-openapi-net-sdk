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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveCertificateListResponse : AcsResponse
	{

		private string requestId;

		private DescribeLiveCertificateList_CertificateListModel certificateListModel;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "CertificateListModel")]
		public DescribeLiveCertificateList_CertificateListModel CertificateListModel
		{
			get
			{
				return certificateListModel;
			}
			set	
			{
				certificateListModel = value;
			}
		}

		public class DescribeLiveCertificateList_CertificateListModel
		{

			private int? count;

			private List<DescribeLiveCertificateList_Cert> certList;

			[JsonProperty(PropertyName = "Count")]
			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			[JsonProperty(PropertyName = "CertList")]
			public List<DescribeLiveCertificateList_Cert> CertList
			{
				get
				{
					return certList;
				}
				set	
				{
					certList = value;
				}
			}

			public class DescribeLiveCertificateList_Cert
			{

				private long? lastTime;

				private string fingerprint;

				private string certName;

				private string issuer;

				private long? certId;

				private string common;

				[JsonProperty(PropertyName = "LastTime")]
				public long? LastTime
				{
					get
					{
						return lastTime;
					}
					set	
					{
						lastTime = value;
					}
				}

				[JsonProperty(PropertyName = "Fingerprint")]
				public string Fingerprint
				{
					get
					{
						return fingerprint;
					}
					set	
					{
						fingerprint = value;
					}
				}

				[JsonProperty(PropertyName = "CertName")]
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

				[JsonProperty(PropertyName = "Issuer")]
				public string Issuer
				{
					get
					{
						return issuer;
					}
					set	
					{
						issuer = value;
					}
				}

				[JsonProperty(PropertyName = "CertId")]
				public long? CertId
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

				[JsonProperty(PropertyName = "Common")]
				public string Common
				{
					get
					{
						return common;
					}
					set	
					{
						common = value;
					}
				}
			}
		}
	}
}
