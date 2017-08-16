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

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class OSuborderDomainResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? pageSize;

		private List<OSuborderDomain__Object> data;

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

		public List<OSuborderDomain__Object> Data
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

		public class OSuborderDomain__Object
		{

			private string commodityKey;

			private string commodityCode;

			private long? amount;

			private string settleTime;

			public string CommodityKey
			{
				get
				{
					return commodityKey;
				}
				set	
				{
					commodityKey = value;
				}
			}

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public long? Amount
			{
				get
				{
					return amount;
				}
				set	
				{
					amount = value;
				}
			}

			public string SettleTime
			{
				get
				{
					return settleTime;
				}
				set	
				{
					settleTime = value;
				}
			}
		}
	}
}