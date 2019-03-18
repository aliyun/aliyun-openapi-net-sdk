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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeCertificateListResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? showSize;

		private int? currentPage;

		private List<DescribeCertificateList_Certificate> certificateList;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? ShowSize
		{
			get
			{
				return showSize;
			}
			set	
			{
				showSize = value;
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public List<DescribeCertificateList_Certificate> CertificateList
		{
			get
			{
				return certificateList;
			}
			set	
			{
				certificateList = value;
			}
		}

		public class DescribeCertificateList_Certificate
		{

			private long? id;

			private string name;

			private string sourceType;

			private string certType;

			private string instanceId;

			private long? orderId;

			private string orderType;

			private string brandName;

			private long? beforeDate;

			private long? afterDate;

			private int? year;

			private string domain;

			private int? remainingDays;

			private string deploymentCloudProduct;

			private string statusCode;

			private string newBuyCertType;

			private string newBuyDomainType;

			private string newBuyBrand;

			private int? showDeployment;

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

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string CertType
			{
				get
				{
					return certType;
				}
				set	
				{
					certType = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? OrderId
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

			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}

			public string BrandName
			{
				get
				{
					return brandName;
				}
				set	
				{
					brandName = value;
				}
			}

			public long? BeforeDate
			{
				get
				{
					return beforeDate;
				}
				set	
				{
					beforeDate = value;
				}
			}

			public long? AfterDate
			{
				get
				{
					return afterDate;
				}
				set	
				{
					afterDate = value;
				}
			}

			public int? Year
			{
				get
				{
					return year;
				}
				set	
				{
					year = value;
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

			public int? RemainingDays
			{
				get
				{
					return remainingDays;
				}
				set	
				{
					remainingDays = value;
				}
			}

			public string DeploymentCloudProduct
			{
				get
				{
					return deploymentCloudProduct;
				}
				set	
				{
					deploymentCloudProduct = value;
				}
			}

			public string StatusCode
			{
				get
				{
					return statusCode;
				}
				set	
				{
					statusCode = value;
				}
			}

			public string NewBuyCertType
			{
				get
				{
					return newBuyCertType;
				}
				set	
				{
					newBuyCertType = value;
				}
			}

			public string NewBuyDomainType
			{
				get
				{
					return newBuyDomainType;
				}
				set	
				{
					newBuyDomainType = value;
				}
			}

			public string NewBuyBrand
			{
				get
				{
					return newBuyBrand;
				}
				set	
				{
					newBuyBrand = value;
				}
			}

			public int? ShowDeployment
			{
				get
				{
					return showDeployment;
				}
				set	
				{
					showDeployment = value;
				}
			}
		}
	}
}
