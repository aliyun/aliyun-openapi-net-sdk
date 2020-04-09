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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeProtectBlockSummaryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeProtectBlockSummary_Item> protectBlockSummarys;

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

		public List<DescribeProtectBlockSummary_Item> ProtectBlockSummarys
		{
			get
			{
				return protectBlockSummarys;
			}
			set	
			{
				protectBlockSummarys = value;
			}
		}

		public class DescribeProtectBlockSummary_Item
		{

			private long? blockPv;

			private long? index;

			private long? allPv;

			public long? BlockPv
			{
				get
				{
					return blockPv;
				}
				set	
				{
					blockPv = value;
				}
			}

			public long? Index
			{
				get
				{
					return index;
				}
				set	
				{
					index = value;
				}
			}

			public long? AllPv
			{
				get
				{
					return allPv;
				}
				set	
				{
					allPv = value;
				}
			}
		}
	}
}
