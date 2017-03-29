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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeDomainResponse : AcsResponse
	{

		private string groupId;

		private string domainName;

		private string subDomain;

		private string certificateId;

		private string certificateName;

		private string certificateBody;

		private string certificatePrivateKey;

		private string domainBindingStatus;

		private string domainCNAMEStatus;

		private string domainLegalStatus;

		private string domainRemark;

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
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

		public string SubDomain
		{
			get
			{
				return subDomain;
			}
			set	
			{
				subDomain = value;
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

		public string CertificateBody
		{
			get
			{
				return certificateBody;
			}
			set	
			{
				certificateBody = value;
			}
		}

		public string CertificatePrivateKey
		{
			get
			{
				return certificatePrivateKey;
			}
			set	
			{
				certificatePrivateKey = value;
			}
		}

		public string DomainBindingStatus
		{
			get
			{
				return domainBindingStatus;
			}
			set	
			{
				domainBindingStatus = value;
			}
		}

		public string DomainCNAMEStatus
		{
			get
			{
				return domainCNAMEStatus;
			}
			set	
			{
				domainCNAMEStatus = value;
			}
		}

		public string DomainLegalStatus
		{
			get
			{
				return domainLegalStatus;
			}
			set	
			{
				domainLegalStatus = value;
			}
		}

		public string DomainRemark
		{
			get
			{
				return domainRemark;
			}
			set	
			{
				domainRemark = value;
			}
		}
	}
}