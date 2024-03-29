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
	public class GetCertificateResponse : AcsResponse
	{

		private string certificateChain;

		private string certificate;

		private string requestId;

		private string certificateId;

		private string csr;

		[JsonProperty(PropertyName = "CertificateChain")]
		public string CertificateChain
		{
			get
			{
				return certificateChain;
			}
			set	
			{
				certificateChain = value;
			}
		}

		[JsonProperty(PropertyName = "Certificate")]
		public string Certificate
		{
			get
			{
				return certificate;
			}
			set	
			{
				certificate = value;
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

		[JsonProperty(PropertyName = "Csr")]
		public string Csr
		{
			get
			{
				return csr;
			}
			set	
			{
				csr = value;
			}
		}
	}
}
