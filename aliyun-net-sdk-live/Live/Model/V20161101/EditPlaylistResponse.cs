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
	public class EditPlaylistResponse : AcsResponse
	{

		private string requestId;

		private string casterId;

		private string programId;

		private EditPlaylist_Items items;

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

		[JsonProperty(PropertyName = "CasterId")]
		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
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

		[JsonProperty(PropertyName = "Items")]
		public EditPlaylist_Items Items
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

		public class EditPlaylist_Items
		{

			private List<EditPlaylist_SuccessItem> successItems;

			private List<EditPlaylist_FailedItem> failedItems;

			[JsonProperty(PropertyName = "SuccessItems")]
			public List<EditPlaylist_SuccessItem> SuccessItems
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

			[JsonProperty(PropertyName = "FailedItems")]
			public List<EditPlaylist_FailedItem> FailedItems
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

			public class EditPlaylist_SuccessItem
			{

				private string itemName;

				private string itemId;

				[JsonProperty(PropertyName = "ItemName")]
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

				[JsonProperty(PropertyName = "ItemId")]
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
			}

			public class EditPlaylist_FailedItem
			{

				private string itemName;

				private string itemId;

				[JsonProperty(PropertyName = "ItemName")]
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

				[JsonProperty(PropertyName = "ItemId")]
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
			}
		}
	}
}
