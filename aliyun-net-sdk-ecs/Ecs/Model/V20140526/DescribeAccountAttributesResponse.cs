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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAccountAttributesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAccountAttributes_AccountAttributeItem> accountAttributeItems;

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

		public List<DescribeAccountAttributes_AccountAttributeItem> AccountAttributeItems
		{
			get
			{
				return accountAttributeItems;
			}
			set	
			{
				accountAttributeItems = value;
			}
		}

		public class DescribeAccountAttributes_AccountAttributeItem
		{

			private string attributeName;

			private List<DescribeAccountAttributes_ValueItem> attributeValues;

			public string AttributeName
			{
				get
				{
					return attributeName;
				}
				set	
				{
					attributeName = value;
				}
			}

			public List<DescribeAccountAttributes_ValueItem> AttributeValues
			{
				get
				{
					return attributeValues;
				}
				set	
				{
					attributeValues = value;
				}
			}

			public class DescribeAccountAttributes_ValueItem
			{

				private string _value;

				private string expiredTime;

				private string zoneId;

				private string instanceChargeType;

				private string instanceType;

				private int? count;

				private string diskCategory;

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public string ExpiredTime
				{
					get
					{
						return expiredTime;
					}
					set	
					{
						expiredTime = value;
					}
				}

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string InstanceChargeType
				{
					get
					{
						return instanceChargeType;
					}
					set	
					{
						instanceChargeType = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public int? Count
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

				public string DiskCategory
				{
					get
					{
						return diskCategory;
					}
					set	
					{
						diskCategory = value;
					}
				}
			}
		}
	}
}
