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
	public class GetOcIcMortgageResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIcMortgage_DataItem> data;

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

		public List<GetOcIcMortgage_DataItem> Data
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

		public class GetOcIcMortgage_DataItem
		{

			private string onecompId;

			private string number;

			private string regDate;

			private string department;

			private string mortgageesName;

			private string identifyType;

			private string identifyNo;

			private string debitType;

			private string debitAmount;

			private string debitPeriod;

			private string debitScope;

			private string guarantees;

			private string status;

			private string publicDate;

			public string OnecompId
			{
				get
				{
					return onecompId;
				}
				set	
				{
					onecompId = value;
				}
			}

			public string Number
			{
				get
				{
					return number;
				}
				set	
				{
					number = value;
				}
			}

			public string RegDate
			{
				get
				{
					return regDate;
				}
				set	
				{
					regDate = value;
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

			public string MortgageesName
			{
				get
				{
					return mortgageesName;
				}
				set	
				{
					mortgageesName = value;
				}
			}

			public string IdentifyType
			{
				get
				{
					return identifyType;
				}
				set	
				{
					identifyType = value;
				}
			}

			public string IdentifyNo
			{
				get
				{
					return identifyNo;
				}
				set	
				{
					identifyNo = value;
				}
			}

			public string DebitType
			{
				get
				{
					return debitType;
				}
				set	
				{
					debitType = value;
				}
			}

			public string DebitAmount
			{
				get
				{
					return debitAmount;
				}
				set	
				{
					debitAmount = value;
				}
			}

			public string DebitPeriod
			{
				get
				{
					return debitPeriod;
				}
				set	
				{
					debitPeriod = value;
				}
			}

			public string DebitScope
			{
				get
				{
					return debitScope;
				}
				set	
				{
					debitScope = value;
				}
			}

			public string Guarantees
			{
				get
				{
					return guarantees;
				}
				set	
				{
					guarantees = value;
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

			public string PublicDate
			{
				get
				{
					return publicDate;
				}
				set	
				{
					publicDate = value;
				}
			}
		}
	}
}
