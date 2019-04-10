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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class QueryInvalidAddressResponse : AcsResponse
	{

		private string requestId;

		private int? nextStart;

		private int? totalCount;

		private List<QueryInvalidAddress_MailDetail> data;

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

		public int? NextStart
		{
			get
			{
				return nextStart;
			}
			set	
			{
				nextStart = value;
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

		public List<QueryInvalidAddress_MailDetail> Data
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

		public class QueryInvalidAddress_MailDetail
		{

			private string lastUpdateTime;

			private long? utcLastUpdateTime;

			private string toAddress;

			public string LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
				}
			}

			public long? UtcLastUpdateTime
			{
				get
				{
					return utcLastUpdateTime;
				}
				set	
				{
					utcLastUpdateTime = value;
				}
			}

			public string ToAddress
			{
				get
				{
					return toAddress;
				}
				set	
				{
					toAddress = value;
				}
			}
		}
	}
}
