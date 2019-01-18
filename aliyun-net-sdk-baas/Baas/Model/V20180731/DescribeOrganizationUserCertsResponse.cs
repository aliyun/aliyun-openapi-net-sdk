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

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class DescribeOrganizationUserCertsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string dynamicCode;

		private string dynamicMessage;

		private DescribeOrganizationUserCerts_Result result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public DescribeOrganizationUserCerts_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeOrganizationUserCerts_Result
		{

			private List<DescribeOrganizationUserCerts_Certificate> certificates;

			private DescribeOrganizationUserCerts_KeyPair keyPair;

			public List<DescribeOrganizationUserCerts_Certificate> Certificates
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

			public DescribeOrganizationUserCerts_KeyPair KeyPair
			{
				get
				{
					return keyPair;
				}
				set	
				{
					keyPair = value;
				}
			}

			public class DescribeOrganizationUserCerts_Certificate
			{

				private string scope;

				private string name;

				private string subject;

				private string issuer;

				private string validFrom;

				private string validTo;

				private string certData;

				public string Scope
				{
					get
					{
						return scope;
					}
					set	
					{
						scope = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
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

				public string ValidFrom
				{
					get
					{
						return validFrom;
					}
					set	
					{
						validFrom = value;
					}
				}

				public string ValidTo
				{
					get
					{
						return validTo;
					}
					set	
					{
						validTo = value;
					}
				}

				public string CertData
				{
					get
					{
						return certData;
					}
					set	
					{
						certData = value;
					}
				}
			}

			public class DescribeOrganizationUserCerts_KeyPair
			{

				private string privateKey;

				private string publicKey;

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

				public string PublicKey
				{
					get
					{
						return publicKey;
					}
					set	
					{
						publicKey = value;
					}
				}
			}
		}
	}
}