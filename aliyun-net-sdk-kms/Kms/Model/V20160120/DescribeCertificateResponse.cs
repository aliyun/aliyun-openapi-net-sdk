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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class DescribeCertificateResponse : AcsResponse
	{

		private string requestId;

		private string certificateId;

		private string arn;

		private string keySpec;

		private string status;

		private string createdAt;

		private string updatedAt;

		private string serial;

		private string subject;

		private string issuer;

		private string notBefore;

		private string notAfter;

		private string signatureAlgorithm;

		private string subjectPublicKey;

		private string subjectKeyIdentifier;

		private string tags;

		private bool? exportablePrivateKey;

		private string protectionLevel;

		private List<string> subjectAlternativeNames;

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

		public string Arn
		{
			get
			{
				return arn;
			}
			set	
			{
				arn = value;
			}
		}

		public string KeySpec
		{
			get
			{
				return keySpec;
			}
			set	
			{
				keySpec = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string CreatedAt
		{
			get
			{
				return createdAt;
			}
			set	
			{
				createdAt = value;
			}
		}

		public string UpdatedAt
		{
			get
			{
				return updatedAt;
			}
			set	
			{
				updatedAt = value;
			}
		}

		public string Serial
		{
			get
			{
				return serial;
			}
			set	
			{
				serial = value;
			}
		}

		public string Subject
		{
			get
			{
				return subject;
			}
			set	
			{
				subject = value;
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

		public string NotBefore
		{
			get
			{
				return notBefore;
			}
			set	
			{
				notBefore = value;
			}
		}

		public string NotAfter
		{
			get
			{
				return notAfter;
			}
			set	
			{
				notAfter = value;
			}
		}

		public string SignatureAlgorithm
		{
			get
			{
				return signatureAlgorithm;
			}
			set	
			{
				signatureAlgorithm = value;
			}
		}

		public string SubjectPublicKey
		{
			get
			{
				return subjectPublicKey;
			}
			set	
			{
				subjectPublicKey = value;
			}
		}

		public string SubjectKeyIdentifier
		{
			get
			{
				return subjectKeyIdentifier;
			}
			set	
			{
				subjectKeyIdentifier = value;
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public bool? ExportablePrivateKey
		{
			get
			{
				return exportablePrivateKey;
			}
			set	
			{
				exportablePrivateKey = value;
			}
		}

		public string ProtectionLevel
		{
			get
			{
				return protectionLevel;
			}
			set	
			{
				protectionLevel = value;
			}
		}

		public List<string> SubjectAlternativeNames
		{
			get
			{
				return subjectAlternativeNames;
			}
			set	
			{
				subjectAlternativeNames = value;
			}
		}
	}
}
