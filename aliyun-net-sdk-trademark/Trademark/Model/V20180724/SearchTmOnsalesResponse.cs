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

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class SearchTmOnsalesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private int? totalPageNumber;

		private List<SearchTmOnsales_Trademark> trademarks;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public int? TotalPageNumber
		{
			get
			{
				return totalPageNumber;
			}
			set	
			{
				totalPageNumber = value;
			}
		}

		public List<SearchTmOnsales_Trademark> Trademarks
		{
			get
			{
				return trademarks;
			}
			set	
			{
				trademarks = value;
			}
		}

		public class SearchTmOnsales_Trademark
		{

			private string uid;

			private string trademarkName;

			private string registrationNumber;

			private string classification;

			private string icon;

			private string productCode;

			private long? orderPrice;

			private string productDesc;

			private string partnerCode;

			private long? status;

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
				}
			}

			public string TrademarkName
			{
				get
				{
					return trademarkName;
				}
				set	
				{
					trademarkName = value;
				}
			}

			public string RegistrationNumber
			{
				get
				{
					return registrationNumber;
				}
				set	
				{
					registrationNumber = value;
				}
			}

			public string Classification
			{
				get
				{
					return classification;
				}
				set	
				{
					classification = value;
				}
			}

			public string Icon
			{
				get
				{
					return icon;
				}
				set	
				{
					icon = value;
				}
			}

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public long? OrderPrice
			{
				get
				{
					return orderPrice;
				}
				set	
				{
					orderPrice = value;
				}
			}

			public string ProductDesc
			{
				get
				{
					return productDesc;
				}
				set	
				{
					productDesc = value;
				}
			}

			public string PartnerCode
			{
				get
				{
					return partnerCode;
				}
				set	
				{
					partnerCode = value;
				}
			}

			public long? Status
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
		}
	}
}
