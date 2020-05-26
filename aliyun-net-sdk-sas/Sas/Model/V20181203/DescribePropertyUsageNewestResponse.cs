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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribePropertyUsageNewestResponse : AcsResponse
	{

		private string requestId;

		private int? itemCount;

		private string type;

		private List<DescribePropertyUsageNewest_NewestStatisticItem> newestStatisticItems;

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

		public int? ItemCount
		{
			get
			{
				return itemCount;
			}
			set	
			{
				itemCount = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public List<DescribePropertyUsageNewest_NewestStatisticItem> NewestStatisticItems
		{
			get
			{
				return newestStatisticItems;
			}
			set	
			{
				newestStatisticItems = value;
			}
		}

		public class DescribePropertyUsageNewest_NewestStatisticItem
		{

			private string name;

			private long? create;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public long? Create
			{
				get
				{
					return create;
				}
				set	
				{
					create = value;
				}
			}
		}
	}
}
