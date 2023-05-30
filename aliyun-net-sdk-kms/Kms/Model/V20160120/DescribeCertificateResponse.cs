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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class DescribeCertificateResponse : AcsResponse
	{

		private string status;

		private string serial;

		private string createdAt;

		private string tags;

		private string subjectKeyIdentifier;

		private bool? exportablePrivateKey;

		private string issuer;

		private string signatureAlgorithm;

		private string notAfter;

		private string arn;

		private string certificateId;

		private string requestId;

		private string keySpec;

		private string protectionLevel;

		private string subjectPublicKey;

		private string subject;

		private string notBefore;

		private string updatedAt;

		private List<string> subjectAlternativeNames;

		[JsonProperty(PropertyName = "Status")]
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

		[JsonProperty(PropertyName = "Serial")]
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

		[JsonProperty(PropertyName = "CreatedAt")]
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

		[JsonProperty(PropertyName = "Tags")]
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

		[JsonProperty(PropertyName = "SubjectKeyIdentifier")]
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

		[JsonProperty(PropertyName = "ExportablePrivateKey")]
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

		[JsonProperty(PropertyName = "SignatureAlgorithm")]
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

		[JsonProperty(PropertyName = "NotAfter")]
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

		[JsonProperty(PropertyName = "Arn")]
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

		[JsonProperty(PropertyName = "CertificateId")]
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

		[JsonProperty(PropertyName = "KeySpec")]
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

		[JsonProperty(PropertyName = "ProtectionLevel")]
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

		[JsonProperty(PropertyName = "SubjectPublicKey")]
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

		[JsonProperty(PropertyName = "Subject")]
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

		[JsonProperty(PropertyName = "NotBefore")]
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

		[JsonProperty(PropertyName = "UpdatedAt")]
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

		[JsonProperty(PropertyName = "SubjectAlternativeNames")]
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
