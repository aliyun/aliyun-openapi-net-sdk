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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryDomainSpecialBizInfoByDomainResponse : AcsResponse
	{

		private string requestId;

		private int? httpStatusCode;

		private string dynamicCode;

		private string dynamicMessage;

		private bool? synchro;

		private string errorMsg;

		private string errorCode;

		private bool? success;

		private bool? allowRetry;

		private string appName;

		private List<string> errorArgs;

		private QueryDomainSpecialBizInfoByDomain_Module module;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public bool? Synchro
		{
			get
			{
				return synchro;
			}
			set	
			{
				synchro = value;
			}
		}

		public string ErrorMsg
		{
			get
			{
				return errorMsg;
			}
			set	
			{
				errorMsg = value;
			}
		}

		public string ErrorCode
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

		public bool? AllowRetry
		{
			get
			{
				return allowRetry;
			}
			set	
			{
				allowRetry = value;
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
			}
		}

		public List<string> ErrorArgs
		{
			get
			{
				return errorArgs;
			}
			set	
			{
				errorArgs = value;
			}
		}

		public QueryDomainSpecialBizInfoByDomain_Module Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public class QueryDomainSpecialBizInfoByDomain_Module
		{

			private long? id;

			private string gmtCreate;

			private string gmtModified;

			private string bizName;

			private string bizNo;

			private string domainName;

			private string saleId;

			private string userId;

			private string productId;

			private string bizType;

			private string bizStatus;

			private int? status;

			private string statusDesc;

			private string auditMsg;

			private string orderId;

			private long? updateTime;

			private long? createTime;

			private List<QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential> domainSpecialBizCredentials;

			private QueryDomainSpecialBizInfoByDomain_DomainSpecialBizContact domainSpecialBizContact;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string BizName
			{
				get
				{
					return bizName;
				}
				set	
				{
					bizName = value;
				}
			}

			public string BizNo
			{
				get
				{
					return bizNo;
				}
				set	
				{
					bizNo = value;
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

			public string SaleId
			{
				get
				{
					return saleId;
				}
				set	
				{
					saleId = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string BizStatus
			{
				get
				{
					return bizStatus;
				}
				set	
				{
					bizStatus = value;
				}
			}

			public int? Status
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

			public string StatusDesc
			{
				get
				{
					return statusDesc;
				}
				set	
				{
					statusDesc = value;
				}
			}

			public string AuditMsg
			{
				get
				{
					return auditMsg;
				}
				set	
				{
					auditMsg = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public List<QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential> DomainSpecialBizCredentials
			{
				get
				{
					return domainSpecialBizCredentials;
				}
				set	
				{
					domainSpecialBizCredentials = value;
				}
			}

			public QueryDomainSpecialBizInfoByDomain_DomainSpecialBizContact DomainSpecialBizContact
			{
				get
				{
					return domainSpecialBizContact;
				}
				set	
				{
					domainSpecialBizContact = value;
				}
			}

			public class QueryDomainSpecialBizInfoByDomain_DomainSpecialBizCredential
			{

				private string domainName;

				private string saleId;

				private long? bizId;

				private string credentialNo;

				private string credentialType;

				private string credentialUrl;

				private int? holderCert;

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

				public string SaleId
				{
					get
					{
						return saleId;
					}
					set	
					{
						saleId = value;
					}
				}

				public long? BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				public string CredentialNo
				{
					get
					{
						return credentialNo;
					}
					set	
					{
						credentialNo = value;
					}
				}

				public string CredentialType
				{
					get
					{
						return credentialType;
					}
					set	
					{
						credentialType = value;
					}
				}

				public string CredentialUrl
				{
					get
					{
						return credentialUrl;
					}
					set	
					{
						credentialUrl = value;
					}
				}

				public int? HolderCert
				{
					get
					{
						return holderCert;
					}
					set	
					{
						holderCert = value;
					}
				}
			}

			public class QueryDomainSpecialBizInfoByDomain_DomainSpecialBizContact
			{

				private long? bizId;

				private int? regType;

				private string cCompany;

				private string eCompany;

				private string cName;

				private string eName;

				private string cCountry;

				private string cProvince;

				private string eProvince;

				private string cCity;

				private string eCity;

				private string cVenu;

				private string eVenu;

				private string postalcode;

				private string email;

				private string telArea;

				private string telMain;

				private string telExt;

				private string faxArea;

				private string faxMain;

				private string faxExt;

				private string mobile;

				private string extend;

				private string vspContactId;

				private string registrantId;

				public long? BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				public int? RegType
				{
					get
					{
						return regType;
					}
					set	
					{
						regType = value;
					}
				}

				public string CCompany
				{
					get
					{
						return cCompany;
					}
					set	
					{
						cCompany = value;
					}
				}

				public string ECompany
				{
					get
					{
						return eCompany;
					}
					set	
					{
						eCompany = value;
					}
				}

				public string CName
				{
					get
					{
						return cName;
					}
					set	
					{
						cName = value;
					}
				}

				public string EName
				{
					get
					{
						return eName;
					}
					set	
					{
						eName = value;
					}
				}

				public string CCountry
				{
					get
					{
						return cCountry;
					}
					set	
					{
						cCountry = value;
					}
				}

				public string CProvince
				{
					get
					{
						return cProvince;
					}
					set	
					{
						cProvince = value;
					}
				}

				public string EProvince
				{
					get
					{
						return eProvince;
					}
					set	
					{
						eProvince = value;
					}
				}

				public string CCity
				{
					get
					{
						return cCity;
					}
					set	
					{
						cCity = value;
					}
				}

				public string ECity
				{
					get
					{
						return eCity;
					}
					set	
					{
						eCity = value;
					}
				}

				public string CVenu
				{
					get
					{
						return cVenu;
					}
					set	
					{
						cVenu = value;
					}
				}

				public string EVenu
				{
					get
					{
						return eVenu;
					}
					set	
					{
						eVenu = value;
					}
				}

				public string Postalcode
				{
					get
					{
						return postalcode;
					}
					set	
					{
						postalcode = value;
					}
				}

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
					}
				}

				public string TelArea
				{
					get
					{
						return telArea;
					}
					set	
					{
						telArea = value;
					}
				}

				public string TelMain
				{
					get
					{
						return telMain;
					}
					set	
					{
						telMain = value;
					}
				}

				public string TelExt
				{
					get
					{
						return telExt;
					}
					set	
					{
						telExt = value;
					}
				}

				public string FaxArea
				{
					get
					{
						return faxArea;
					}
					set	
					{
						faxArea = value;
					}
				}

				public string FaxMain
				{
					get
					{
						return faxMain;
					}
					set	
					{
						faxMain = value;
					}
				}

				public string FaxExt
				{
					get
					{
						return faxExt;
					}
					set	
					{
						faxExt = value;
					}
				}

				public string Mobile
				{
					get
					{
						return mobile;
					}
					set	
					{
						mobile = value;
					}
				}

				public string Extend
				{
					get
					{
						return extend;
					}
					set	
					{
						extend = value;
					}
				}

				public string VspContactId
				{
					get
					{
						return vspContactId;
					}
					set	
					{
						vspContactId = value;
					}
				}

				public string RegistrantId
				{
					get
					{
						return registrantId;
					}
					set	
					{
						registrantId = value;
					}
				}
			}
		}
	}
}
