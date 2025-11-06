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

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class ListAppInstanceDomainsResponse : AcsResponse
	{

		private string requestId;

		private string dynamicCode;

		private string dynamicMessage;

		private bool? synchro;

		private string accessDeniedDetail;

		private string rootErrorMsg;

		private string rootErrorCode;

		private bool? allowRetry;

		private string appName;

		private int? maxResults;

		private string nextToken;

		private List<string> errorArgs;

		private ListAppInstanceDomains_Module module;

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

		public string AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		public string RootErrorMsg
		{
			get
			{
				return rootErrorMsg;
			}
			set	
			{
				rootErrorMsg = value;
			}
		}

		public string RootErrorCode
		{
			get
			{
				return rootErrorCode;
			}
			set	
			{
				rootErrorCode = value;
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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public ListAppInstanceDomains_Module Module
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

		public class ListAppInstanceDomains_Module
		{

			private int? totalItemNum;

			private int? currentPageNum;

			private int? pageSize;

			private int? totalPageNum;

			private bool? prePage;

			private bool? nextPage;

			private bool? resultLimit;

			private List<ListAppInstanceDomains_DataItem> data;

			private ListAppInstanceDomains_Next next;

			public int? TotalItemNum
			{
				get
				{
					return totalItemNum;
				}
				set	
				{
					totalItemNum = value;
				}
			}

			public int? CurrentPageNum
			{
				get
				{
					return currentPageNum;
				}
				set	
				{
					currentPageNum = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? TotalPageNum
			{
				get
				{
					return totalPageNum;
				}
				set	
				{
					totalPageNum = value;
				}
			}

			public bool? PrePage
			{
				get
				{
					return prePage;
				}
				set	
				{
					prePage = value;
				}
			}

			public bool? NextPage
			{
				get
				{
					return nextPage;
				}
				set	
				{
					nextPage = value;
				}
			}

			public bool? ResultLimit
			{
				get
				{
					return resultLimit;
				}
				set	
				{
					resultLimit = value;
				}
			}

			public List<ListAppInstanceDomains_DataItem> Data
			{
				get
				{
					return data;
				}
				set	
				{
					data = value;
				}
			}

			public ListAppInstanceDomains_Next Next
			{
				get
				{
					return next;
				}
				set	
				{
					next = value;
				}
			}

			public class ListAppInstanceDomains_DataItem
			{

				private string domainName;

				private string createTime;

				private string overallStatus;

				private ListAppInstanceDomains_Verification verification;

				private ListAppInstanceDomains_Resolution resolution;

				private ListAppInstanceDomains_Certificate certificate;

				private ListAppInstanceDomains_Ownership ownership;

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

				public string CreateTime
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

				public string OverallStatus
				{
					get
					{
						return overallStatus;
					}
					set	
					{
						overallStatus = value;
					}
				}

				public ListAppInstanceDomains_Verification Verification
				{
					get
					{
						return verification;
					}
					set	
					{
						verification = value;
					}
				}

				public ListAppInstanceDomains_Resolution Resolution
				{
					get
					{
						return resolution;
					}
					set	
					{
						resolution = value;
					}
				}

				public ListAppInstanceDomains_Certificate Certificate
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

				public ListAppInstanceDomains_Ownership Ownership
				{
					get
					{
						return ownership;
					}
					set	
					{
						ownership = value;
					}
				}

				public class ListAppInstanceDomains_Verification
				{

					private string verificationStatus;

					private string errorMsg;

					private string verificationStatusCode;

					private ListAppInstanceDomains_DnsRecord dnsRecord;

					public string VerificationStatus
					{
						get
						{
							return verificationStatus;
						}
						set	
						{
							verificationStatus = value;
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

					public string VerificationStatusCode
					{
						get
						{
							return verificationStatusCode;
						}
						set	
						{
							verificationStatusCode = value;
						}
					}

					public ListAppInstanceDomains_DnsRecord DnsRecord
					{
						get
						{
							return dnsRecord;
						}
						set	
						{
							dnsRecord = value;
						}
					}

					public class ListAppInstanceDomains_DnsRecord
					{

						private string recordType;

						private string host;

						private string _value;

						public string RecordType
						{
							get
							{
								return recordType;
							}
							set	
							{
								recordType = value;
							}
						}

						public string Host
						{
							get
							{
								return host;
							}
							set	
							{
								host = value;
							}
						}

						public string _Value
						{
							get
							{
								return _value;
							}
							set	
							{
								_value = value;
							}
						}
					}
				}

				public class ListAppInstanceDomains_Resolution
				{

					private string resolutionStatus;

					private string errorMsg;

					private ListAppInstanceDomains_DnsRecord1 dnsRecord1;

					public string ResolutionStatus
					{
						get
						{
							return resolutionStatus;
						}
						set	
						{
							resolutionStatus = value;
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

					public ListAppInstanceDomains_DnsRecord1 DnsRecord1
					{
						get
						{
							return dnsRecord1;
						}
						set	
						{
							dnsRecord1 = value;
						}
					}

					public class ListAppInstanceDomains_DnsRecord1
					{

						private string recordType;

						private string host;

						private string _value;

						public string RecordType
						{
							get
							{
								return recordType;
							}
							set	
							{
								recordType = value;
							}
						}

						public string Host
						{
							get
							{
								return host;
							}
							set	
							{
								host = value;
							}
						}

						public string _Value
						{
							get
							{
								return _value;
							}
							set	
							{
								_value = value;
							}
						}
					}
				}

				public class ListAppInstanceDomains_Certificate
				{

					private string certificateStatus;

					private string certificateType;

					private string certificateName;

					private string endTime;

					public string CertificateStatus
					{
						get
						{
							return certificateStatus;
						}
						set	
						{
							certificateStatus = value;
						}
					}

					public string CertificateType
					{
						get
						{
							return certificateType;
						}
						set	
						{
							certificateType = value;
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

					public string EndTime
					{
						get
						{
							return endTime;
						}
						set	
						{
							endTime = value;
						}
					}
				}

				public class ListAppInstanceDomains_Ownership
				{

					private string account;

					private string provider;

					private string rootDomain;

					public string Account
					{
						get
						{
							return account;
						}
						set	
						{
							account = value;
						}
					}

					public string Provider
					{
						get
						{
							return provider;
						}
						set	
						{
							provider = value;
						}
					}

					public string RootDomain
					{
						get
						{
							return rootDomain;
						}
						set	
						{
							rootDomain = value;
						}
					}
				}
			}

			public class ListAppInstanceDomains_Next
			{

				private string domainName;

				private string createTime;

				private string overallStatus;

				private ListAppInstanceDomains_Verification2 verification2;

				private ListAppInstanceDomains_Resolution3 resolution3;

				private ListAppInstanceDomains_Certificate4 certificate4;

				private ListAppInstanceDomains_Ownership5 ownership5;

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

				public string CreateTime
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

				public string OverallStatus
				{
					get
					{
						return overallStatus;
					}
					set	
					{
						overallStatus = value;
					}
				}

				public ListAppInstanceDomains_Verification2 Verification2
				{
					get
					{
						return verification2;
					}
					set	
					{
						verification2 = value;
					}
				}

				public ListAppInstanceDomains_Resolution3 Resolution3
				{
					get
					{
						return resolution3;
					}
					set	
					{
						resolution3 = value;
					}
				}

				public ListAppInstanceDomains_Certificate4 Certificate4
				{
					get
					{
						return certificate4;
					}
					set	
					{
						certificate4 = value;
					}
				}

				public ListAppInstanceDomains_Ownership5 Ownership5
				{
					get
					{
						return ownership5;
					}
					set	
					{
						ownership5 = value;
					}
				}

				public class ListAppInstanceDomains_Verification2
				{

					private string verificationStatus;

					private string errorMsg;

					private ListAppInstanceDomains_DnsRecord6 dnsRecord6;

					public string VerificationStatus
					{
						get
						{
							return verificationStatus;
						}
						set	
						{
							verificationStatus = value;
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

					public ListAppInstanceDomains_DnsRecord6 DnsRecord6
					{
						get
						{
							return dnsRecord6;
						}
						set	
						{
							dnsRecord6 = value;
						}
					}

					public class ListAppInstanceDomains_DnsRecord6
					{

						private string recordType;

						private string host;

						private string _value;

						public string RecordType
						{
							get
							{
								return recordType;
							}
							set	
							{
								recordType = value;
							}
						}

						public string Host
						{
							get
							{
								return host;
							}
							set	
							{
								host = value;
							}
						}

						public string _Value
						{
							get
							{
								return _value;
							}
							set	
							{
								_value = value;
							}
						}
					}
				}

				public class ListAppInstanceDomains_Resolution3
				{

					private string resolutionStatus;

					private string errorMsg;

					private ListAppInstanceDomains_DnsRecord7 dnsRecord7;

					public string ResolutionStatus
					{
						get
						{
							return resolutionStatus;
						}
						set	
						{
							resolutionStatus = value;
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

					public ListAppInstanceDomains_DnsRecord7 DnsRecord7
					{
						get
						{
							return dnsRecord7;
						}
						set	
						{
							dnsRecord7 = value;
						}
					}

					public class ListAppInstanceDomains_DnsRecord7
					{

						private string recordType;

						private string host;

						private string _value;

						public string RecordType
						{
							get
							{
								return recordType;
							}
							set	
							{
								recordType = value;
							}
						}

						public string Host
						{
							get
							{
								return host;
							}
							set	
							{
								host = value;
							}
						}

						public string _Value
						{
							get
							{
								return _value;
							}
							set	
							{
								_value = value;
							}
						}
					}
				}

				public class ListAppInstanceDomains_Certificate4
				{

					private string certificateStatus;

					private string certificateType;

					private string certificateName;

					private string endTime;

					public string CertificateStatus
					{
						get
						{
							return certificateStatus;
						}
						set	
						{
							certificateStatus = value;
						}
					}

					public string CertificateType
					{
						get
						{
							return certificateType;
						}
						set	
						{
							certificateType = value;
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

					public string EndTime
					{
						get
						{
							return endTime;
						}
						set	
						{
							endTime = value;
						}
					}
				}

				public class ListAppInstanceDomains_Ownership5
				{

					private string account;

					private string provider;

					public string Account
					{
						get
						{
							return account;
						}
						set	
						{
							account = value;
						}
					}

					public string Provider
					{
						get
						{
							return provider;
						}
						set	
						{
							provider = value;
						}
					}
				}
			}
		}
	}
}
