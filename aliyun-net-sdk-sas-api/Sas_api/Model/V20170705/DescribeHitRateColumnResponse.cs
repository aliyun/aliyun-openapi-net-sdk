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

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
	public class DescribeHitRateColumnResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeHitRateColumn_Item> items;

		private DescribeHitRateColumn_TimeScope timeScope;

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

		public List<DescribeHitRateColumn_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public DescribeHitRateColumn_TimeScope TimeScope
		{
			get
			{
				return timeScope;
			}
			set	
			{
				timeScope = value;
			}
		}

		public class DescribeHitRateColumn_Item
		{

			private long? data;

			private string id;

			private string name;

			public long? Data
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

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

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
		}

		public class DescribeHitRateColumn_TimeScope
		{

			private long? interval;

			private long? start;

			public long? Interval
			{
				get
				{
					return interval;
				}
				set	
				{
					interval = value;
				}
			}

			public long? Start
			{
				get
				{
					return start;
				}
				set	
				{
					start = value;
				}
			}
		}
	}
}
