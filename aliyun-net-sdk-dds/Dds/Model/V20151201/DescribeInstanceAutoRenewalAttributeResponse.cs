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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeInstanceAutoRenewalAttributeResponse : AcsResponse
	{

		private int? itemsNumbers;

		private int? pageRecordCount;

		private string requestId;

		private int? pageNumber;

		private List<DescribeInstanceAutoRenewalAttribute_Item> items;

		public int? ItemsNumbers
		{
			get
			{
				return itemsNumbers;
			}
			set	
			{
				itemsNumbers = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<DescribeInstanceAutoRenewalAttribute_Item> Items
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

		public class DescribeInstanceAutoRenewalAttribute_Item
		{

			private string autoRenew;

			private string dBInstanceType;

			private string duration;

			private string regionId;

			private string dbInstanceId;

			public string AutoRenew
			{
				get
				{
					return autoRenew;
				}
				set	
				{
					autoRenew = value;
				}
			}

			public string DBInstanceType
			{
				get
				{
					return dBInstanceType;
				}
				set	
				{
					dBInstanceType = value;
				}
			}

			public string Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string DbInstanceId
			{
				get
				{
					return dbInstanceId;
				}
				set	
				{
					dbInstanceId = value;
				}
			}
		}
	}
}
