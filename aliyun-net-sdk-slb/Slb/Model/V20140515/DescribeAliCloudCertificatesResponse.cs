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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeAliCloudCertificatesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAliCloudCertificates_AliCloudCertificate> aliCloudCertificates;

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

		public List<DescribeAliCloudCertificates_AliCloudCertificate> AliCloudCertificates
		{
			get
			{
				return aliCloudCertificates;
			}
			set	
			{
				aliCloudCertificates = value;
			}
		}

		public class DescribeAliCloudCertificates_AliCloudCertificate
		{

			private string aliCloudCertificateId;

			private string aliCloudCertificateName;

			private string fingerprint;

			private string domainName;

			private string issuer;

			public string AliCloudCertificateId
			{
				get
				{
					return aliCloudCertificateId;
				}
				set	
				{
					aliCloudCertificateId = value;
				}
			}

			public string AliCloudCertificateName
			{
				get
				{
					return aliCloudCertificateName;
				}
				set	
				{
					aliCloudCertificateName = value;
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

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
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
		}
	}
}