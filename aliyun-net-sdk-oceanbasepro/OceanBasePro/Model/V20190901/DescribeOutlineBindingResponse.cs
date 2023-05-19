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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeOutlineBindingResponse : AcsResponse
	{

		private string requestId;

		private DescribeOutlineBinding_OutlineBinding outlineBinding;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "OutlineBinding")]
		public DescribeOutlineBinding_OutlineBinding OutlineBinding
		{
			get
			{
				return outlineBinding;
			}
			set	
			{
				outlineBinding = value;
			}
		}

		public class DescribeOutlineBinding_OutlineBinding
		{

			private string bindPlan;

			private long? outlineId;

			private string bindIndex;

			private int? maxConcurrent;

			private string tableName;

			[JsonProperty(PropertyName = "BindPlan")]
			public string BindPlan
			{
				get
				{
					return bindPlan;
				}
				set	
				{
					bindPlan = value;
				}
			}

			[JsonProperty(PropertyName = "OutlineId")]
			public long? OutlineId
			{
				get
				{
					return outlineId;
				}
				set	
				{
					outlineId = value;
				}
			}

			[JsonProperty(PropertyName = "BindIndex")]
			public string BindIndex
			{
				get
				{
					return bindIndex;
				}
				set	
				{
					bindIndex = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConcurrent")]
			public int? MaxConcurrent
			{
				get
				{
					return maxConcurrent;
				}
				set	
				{
					maxConcurrent = value;
				}
			}

			[JsonProperty(PropertyName = "TableName")]
			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}
		}
	}
}
