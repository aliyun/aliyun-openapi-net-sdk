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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class ListPlaylistItemsResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<ListPlaylistItems_ProgramItem> programItems;

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

			private string programId;

			private string programItemId;

			private string programItemName;

			private string resourceType;

			private string resourceValue;

			private int? index;

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
		}
	}
}
