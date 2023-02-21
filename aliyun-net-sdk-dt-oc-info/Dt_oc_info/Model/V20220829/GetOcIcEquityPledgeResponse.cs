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
	public class GetOcIcEquityPledgeResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcIcEquityPledge_DataItem> data;

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

		public List<GetOcIcEquityPledge_DataItem> Data
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

		public class GetOcIcEquityPledge_DataItem
		{

			private string number;

			private string pledgor;

			private string relatedComp;

			private string pawnee;

			private string regDate;

			private string status;

			private string pledgorAmount;

			private string pawneeIdentifyNo;

			private string pledgorIdentifyNo;

			private string publicDate;

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

			public string Pledgor
			{
				get
				{
					return pledgor;
				}
				set	
				{
					pledgor = value;
				}
			}

			public string RelatedComp
			{
				get
				{
					return relatedComp;
				}
				set	
				{
					relatedComp = value;
				}
			}

			public string Pawnee
			{
				get
				{
					return pawnee;
				}
				set	
				{
					pawnee = value;
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

			public string PledgorAmount
			{
				get
				{
					return pledgorAmount;
				}
				set	
				{
					pledgorAmount = value;
				}
			}

			public string PawneeIdentifyNo
			{
				get
				{
					return pawneeIdentifyNo;
				}
				set	
				{
					pawneeIdentifyNo = value;
				}
			}

			public string PledgorIdentifyNo
			{
				get
				{
					return pledgorIdentifyNo;
				}
				set	
				{
					pledgorIdentifyNo = value;
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
