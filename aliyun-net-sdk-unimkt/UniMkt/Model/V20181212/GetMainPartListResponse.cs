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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class GetMainPartListResponse : AcsResponse
	{

		private long? code;

		private bool? success;

		private string requestId;

		private GetMainPartList_Data data;

		public long? Code
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

		public GetMainPartList_Data Data
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

		public class GetMainPartList_Data
		{

			private long? count;

			private List<GetMainPartList_MainPartBizs> list;

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public List<GetMainPartList_MainPartBizs> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class GetMainPartList_MainPartBizs
			{

				private string accountNo;

				private string accountType;

				private long? brandUserId;

				private string brandUserNick;

				private long? mainId;

				private string mainName;

				private long? proxyUserId;

				public string AccountNo
				{
					get
					{
						return accountNo;
					}
					set	
					{
						accountNo = value;
					}
				}

				public string AccountType
				{
					get
					{
						return accountType;
					}
					set	
					{
						accountType = value;
					}
				}

				public long? BrandUserId
				{
					get
					{
						return brandUserId;
					}
					set	
					{
						brandUserId = value;
					}
				}

				public string BrandUserNick
				{
					get
					{
						return brandUserNick;
					}
					set	
					{
						brandUserNick = value;
					}
				}

				public long? MainId
				{
					get
					{
						return mainId;
					}
					set	
					{
						mainId = value;
					}
				}

				public string MainName
				{
					get
					{
						return mainName;
					}
					set	
					{
						mainName = value;
					}
				}

				public long? ProxyUserId
				{
					get
					{
						return proxyUserId;
					}
					set	
					{
						proxyUserId = value;
					}
				}
			}
		}
	}
}
