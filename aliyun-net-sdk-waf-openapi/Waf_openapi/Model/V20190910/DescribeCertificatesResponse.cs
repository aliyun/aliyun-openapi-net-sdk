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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeCertificatesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCertificates_Certificate> certificates;

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

		public List<DescribeCertificates_Certificate> Certificates
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

		public class DescribeCertificates_Certificate
		{

			private string commonName;

			private bool? isUsing;

			private string certificateName;

			private long? certificateId;

			private List<string> sans;

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

			public bool? IsUsing
			{
				get
				{
					return isUsing;
				}
				set	
				{
					isUsing = value;
				}
			}

			public string CertificateName
			{
				get
				{
					return certificateName;
				}
				set	
				{
					certificateName = value;
				}
			}

			public long? CertificateId
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

			public List<string> Sans
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
		}
	}
}
