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
	public class GetOcJusticeAuctionResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcJusticeAuction_DataItem> data;

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

		public List<GetOcJusticeAuction_DataItem> Data
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

		public class GetOcJusticeAuction_DataItem
		{

			private string entName;

			private string auctionName;

			private string court;

			private string auctionDate;

			private string startPrice;

			private string estPrice;

			private string owner;

			private string restrict;

			private string certificate;

			private string document;

			private string basis;

			private string description;

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

			public string AuctionName
			{
				get
				{
					return auctionName;
				}
				set	
				{
					auctionName = value;
				}
			}

			public string Court
			{
				get
				{
					return court;
				}
				set	
				{
					court = value;
				}
			}

			public string AuctionDate
			{
				get
				{
					return auctionDate;
				}
				set	
				{
					auctionDate = value;
				}
			}

			public string StartPrice
			{
				get
				{
					return startPrice;
				}
				set	
				{
					startPrice = value;
				}
			}

			public string EstPrice
			{
				get
				{
					return estPrice;
				}
				set	
				{
					estPrice = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string Restrict
			{
				get
				{
					return restrict;
				}
				set	
				{
					restrict = value;
				}
			}

			public string Certificate
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

			public string Document
			{
				get
				{
					return document;
				}
				set	
				{
					document = value;
				}
			}

			public string Basis
			{
				get
				{
					return basis;
				}
				set	
				{
					basis = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}
		}
	}
}
