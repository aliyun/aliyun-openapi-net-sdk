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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeCdnSMCertificateDetailResponse : AcsResponse
	{

		private string requestId;

		private string signCertificate;

		private string encryptCertificate;

		private string certIdentifier;

		private string certName;

		private string commonName;

		private string sans;

		private string certOrg;

		private string certExpireTime;

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

		public string SignCertificate
		{
			get
			{
				return signCertificate;
			}
			set	
			{
				signCertificate = value;
			}
		}

		public string EncryptCertificate
		{
			get
			{
				return encryptCertificate;
			}
			set	
			{
				encryptCertificate = value;
			}
		}

		public string CertIdentifier
		{
			get
			{
				return certIdentifier;
			}
			set	
			{
				certIdentifier = value;
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

		public string CommonName
		{
			get
			{
				return commonName;
			}
			set	
			{
				commonName = value;
			}
		}

		public string Sans
		{
			get
			{
				return sans;
			}
			set	
			{
				sans = value;
			}
		}

		public string CertOrg
		{
			get
			{
				return certOrg;
			}
			set	
			{
				certOrg = value;
			}
		}

		public string CertExpireTime
		{
			get
			{
				return certExpireTime;
			}
			set	
			{
				certExpireTime = value;
			}
		}
	}
}
