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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodCertificateListResponse : AcsResponse
	{

		private string requestId;

		private DescribeVodCertificateList_CertificateListModel certificateListModel;

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

		public DescribeVodCertificateList_CertificateListModel CertificateListModel
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

		public class DescribeVodCertificateList_CertificateListModel
		{

			private int? count;

			private List<DescribeVodCertificateList_Cert> certList;

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

			public List<DescribeVodCertificateList_Cert> CertList
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

			public class DescribeVodCertificateList_Cert
			{

				private string certName;

				private long? certId;

				private string fingerprint;

				private string common;

				private string issuer;

				private long? lastTime;

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
			}
		}
	}
}