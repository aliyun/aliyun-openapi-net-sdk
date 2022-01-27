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
	public class DescribeDomainExtensionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainExtensions_DomainExtension> domainExtensions;

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

		public List<DescribeDomainExtensions_DomainExtension> DomainExtensions
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

		public class DescribeDomainExtensions_DomainExtension
		{

			private string domainExtensionId;

			private string domain;

			private string serverCertificateId;

			private List<DescribeDomainExtensions_Certificate> certificates;

			private List<DescribeDomainExtensions_ServerCertificate> serverCertificates;

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

			public List<DescribeDomainExtensions_Certificate> Certificates
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

			public List<DescribeDomainExtensions_ServerCertificate> ServerCertificates
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

			public class DescribeDomainExtensions_Certificate
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

			public class DescribeDomainExtensions_ServerCertificate
			{

				private string certificateId;

				private string encryptionAlgorithm;

				private string bindingType;

				private string standardType;

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
			}
		}
	}
}
