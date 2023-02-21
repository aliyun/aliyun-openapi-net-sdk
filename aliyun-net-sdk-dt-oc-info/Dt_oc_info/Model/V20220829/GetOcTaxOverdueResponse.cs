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

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcTaxOverdueResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcTaxOverdue_DataItem> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

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

		public List<GetOcTaxOverdue_DataItem> Data
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

		public class GetOcTaxOverdue_DataItem
		{

			private string entName;

			private string overdueType;

			private string entAddress;

			private string overdueAmount;

			private string legalName;

			private string taxpayerType;

			private string taxpayerNum;

			private string department;

			private string currOverdueAmount;

			private string publishDate;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string OverdueType
			{
				get
				{
					return overdueType;
				}
				set	
				{
					overdueType = value;
				}
			}

			public string EntAddress
			{
				get
				{
					return entAddress;
				}
				set	
				{
					entAddress = value;
				}
			}

			public string OverdueAmount
			{
				get
				{
					return overdueAmount;
				}
				set	
				{
					overdueAmount = value;
				}
			}

			public string LegalName
			{
				get
				{
					return legalName;
				}
				set	
				{
					legalName = value;
				}
			}

			public string TaxpayerType
			{
				get
				{
					return taxpayerType;
				}
				set	
				{
					taxpayerType = value;
				}
			}

			public string TaxpayerNum
			{
				get
				{
					return taxpayerNum;
				}
				set	
				{
					taxpayerNum = value;
				}
			}

			public string Department
			{
				get
				{
					return department;
				}
				set	
				{
					department = value;
				}
			}

			public string CurrOverdueAmount
			{
				get
				{
					return currOverdueAmount;
				}
				set	
				{
					currOverdueAmount = value;
				}
			}

			public string PublishDate
			{
				get
				{
					return publishDate;
				}
				set	
				{
					publishDate = value;
				}
			}
		}
	}
}
