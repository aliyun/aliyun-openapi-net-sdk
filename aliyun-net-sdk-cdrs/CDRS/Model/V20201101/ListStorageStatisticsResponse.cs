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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListStorageStatisticsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private long? totalCount;

		private List<ListStorageStatistics_Datas> data;

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

		public long? TotalCount
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

		public List<ListStorageStatistics_Datas> Data
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

		public class ListStorageStatistics_Datas
		{

			private string corpId;

			private string number;

			private string totalStore;

			private string unusedStore;

			private string usedStore;

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
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

			public string TotalStore
			{
				get
				{
					return totalStore;
				}
				set	
				{
					totalStore = value;
				}
			}

			public string UnusedStore
			{
				get
				{
					return unusedStore;
				}
				set	
				{
					unusedStore = value;
				}
			}

			public string UsedStore
			{
				get
				{
					return usedStore;
				}
				set	
				{
					usedStore = value;
				}
			}
		}
	}
}
