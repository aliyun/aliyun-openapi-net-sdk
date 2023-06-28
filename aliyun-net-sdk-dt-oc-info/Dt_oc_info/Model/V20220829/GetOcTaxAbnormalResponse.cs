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
	public class GetOcTaxAbnormalResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcTaxAbnormal_DataItem> data;

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

		public List<GetOcTaxAbnormal_DataItem> Data
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

		public class GetOcTaxAbnormal_DataItem
		{

			private string entName;

			private string legalName;

			private string cardNum;

			private string cardType;

			private string judgeDate;

			private string judgeDepartment;

			private string judgeReason;

			private string overdueType;

			private string overdueAmount;

			private string status;

			private string taxpayerNum;

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

			public string CardNum
			{
				get
				{
					return cardNum;
				}
				set	
				{
					cardNum = value;
				}
			}

			public string CardType
			{
				get
				{
					return cardType;
				}
				set	
				{
					cardType = value;
				}
			}

			public string JudgeDate
			{
				get
				{
					return judgeDate;
				}
				set	
				{
					judgeDate = value;
				}
			}

			public string JudgeDepartment
			{
				get
				{
					return judgeDepartment;
				}
				set	
				{
					judgeDepartment = value;
				}
			}

			public string JudgeReason
			{
				get
				{
					return judgeReason;
				}
				set	
				{
					judgeReason = value;
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
		}
	}
}
