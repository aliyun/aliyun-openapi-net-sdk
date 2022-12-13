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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class ListFirstRanksResponse : AcsResponse
	{

		private string requestId;

		private List<ListFirstRanks_FirstRankItem> result;

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

		public List<ListFirstRanks_FirstRankItem> Result
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

		public class ListFirstRanks_FirstRankItem
		{

			private int? created;

			private bool? active;

			private string description;

			private int? updated;

			private string name;

			private List<ListFirstRanks_MetaItem> meta;

			public int? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
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

			public int? Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
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

			public List<ListFirstRanks_MetaItem> Meta
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

			public class ListFirstRanks_MetaItem
			{

				private string arg;

				private string attribute;

				private int? weight;

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

				public int? Weight
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
