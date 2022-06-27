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
	public class AddPlaylistItemsResponse : AcsResponse
	{

		private string requestId;

		private string programId;

		private AddPlaylistItems_Items items;

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

		public AddPlaylistItems_Items Items
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

		public class AddPlaylistItems_Items
		{

			private List<AddPlaylistItems_SuccessItem> successItems;

			private List<AddPlaylistItems_FailedItem> failedItems;

			public List<AddPlaylistItems_SuccessItem> SuccessItems
			{
				get
				{
					return successItems;
				}
				set	
				{
					successItems = value;
				}
			}

			public List<AddPlaylistItems_FailedItem> FailedItems
			{
				get
				{
					return failedItems;
				}
				set	
				{
					failedItems = value;
				}
			}

			public class AddPlaylistItems_SuccessItem
			{

				private string itemId;

				private string itemName;

				public string ItemId
				{
					get
					{
						return itemId;
					}
					set	
					{
						itemId = value;
					}
				}

				public string ItemName
				{
					get
					{
						return itemName;
					}
					set	
					{
						itemName = value;
					}
				}
			}

			public class AddPlaylistItems_FailedItem
			{

				private string itemId;

				private string itemName;

				public string ItemId
				{
					get
					{
						return itemId;
					}
					set	
					{
						itemId = value;
					}
				}

				public string ItemName
				{
					get
					{
						return itemName;
					}
					set	
					{
						itemName = value;
					}
				}
			}
		}
	}
}
