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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class RemoveFirstRankResponse : AcsResponse
	{

		private string requestId;

		private RemoveFirstRank_Result result;

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

		public RemoveFirstRank_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class RemoveFirstRank_Result
		{

			private string name;

			private string description;

			private bool? active;

			private List<RemoveFirstRank_MetaItem> meta;

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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public bool? Active
			{
				get
				{
					return active;
				}
				set	
				{
					active = value;
				}
			}

			public List<RemoveFirstRank_MetaItem> Meta
			{
				get
				{
					return meta;
				}
				set	
				{
					meta = value;
				}
			}

			public class RemoveFirstRank_MetaItem
			{

				private string attribute;

				private string arg;

				private float? weight;

				public string Attribute
				{
					get
					{
						return attribute;
					}
					set	
					{
						attribute = value;
					}
				}

				public string Arg
				{
					get
					{
						return arg;
					}
					set	
					{
						arg = value;
					}
				}

				public float? Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}
			}
		}
	}
}
