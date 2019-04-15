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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeLogInfoResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeLogInfo_Item> logInfoItems;

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

		public List<DescribeLogInfo_Item> LogInfoItems
		{
			get
			{
				return logInfoItems;
			}
			set	
			{
				logInfoItems = value;
			}
		}

		public class DescribeLogInfo_Item
		{

			private string name;

			private string id;

			private List<DescribeLogInfo_Field> fields;

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

			public List<DescribeLogInfo_Field> Fields
			{
				get
				{
					return fields;
				}
				set	
				{
					fields = value;
				}
			}

			public class DescribeLogInfo_Field
			{

				private string name;

				private string type;

				private string desc;

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

				public string Desc
				{
					get
					{
						return desc;
					}
					set	
					{
						desc = value;
					}
				}
			}
		}
	}
}
