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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class ListPlaylistItemsResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<ListPlaylistItems_ProgramItem> programItems;

		[JsonProperty(PropertyName = "Total")]
		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

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

		[JsonProperty(PropertyName = "ProgramItems")]
		public List<ListPlaylistItems_ProgramItem> ProgramItems
		{
			get
			{
				return programItems;
			}
			set	
			{
				programItems = value;
			}
		}

		public class ListPlaylistItems_ProgramItem
		{

			private int? index;

			private string resourceType;

			private string programItemId;

			private string programId;

			private string programItemName;

			private string resourceValue;

			[JsonProperty(PropertyName = "Index")]
			public int? Index
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

			[JsonProperty(PropertyName = "ResourceType")]
			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			[JsonProperty(PropertyName = "ProgramItemId")]
			public string ProgramItemId
			{
				get
				{
					return programItemId;
				}
				set	
				{
					programItemId = value;
				}
			}

			[JsonProperty(PropertyName = "ProgramId")]
			public string ProgramId
			{
				get
				{
					return programId;
				}
				set	
				{
					programId = value;
				}
			}

			[JsonProperty(PropertyName = "ProgramItemName")]
			public string ProgramItemName
			{
				get
				{
					return programItemName;
				}
				set	
				{
					programItemName = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceValue")]
			public string ResourceValue
			{
				get
				{
					return resourceValue;
				}
				set	
				{
					resourceValue = value;
				}
			}
		}
	}
}
