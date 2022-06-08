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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class QueryNotifyResponse : AcsResponse
	{

		private string requestId;

		private QueryNotify_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public QueryNotify_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryNotify_Data
		{

			private int? pageSize;

			private int? pageNumber;

			private int? totalRecordCount;

			private List<QueryNotify_NotifyItemListItem> notifyItemList;

			[JsonProperty(PropertyName = "PageSize")]
			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			[JsonProperty(PropertyName = "PageNumber")]
			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			[JsonProperty(PropertyName = "TotalRecordCount")]
			public int? TotalRecordCount
			{
				get
				{
					return totalRecordCount;
				}
				set	
				{
					totalRecordCount = value;
				}
			}

			[JsonProperty(PropertyName = "NotifyItemList")]
			public List<QueryNotify_NotifyItemListItem> NotifyItemList
			{
				get
				{
					return notifyItemList;
				}
				set	
				{
					notifyItemList = value;
				}
			}

			public class QueryNotify_NotifyItemListItem
			{

				private long? id;

				private string gmtCreated;

				private string gmtModified;

				private long? aliUid;

				private string idempotentId;

				private string idempotentCount;

				private string type;

				private string level;

				private string templateName;

				private string notifyElement;

				private bool? confirmFlag;

				private long? confirmor;

				[JsonProperty(PropertyName = "Id")]
				public long? Id
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

				[JsonProperty(PropertyName = "GmtCreated")]
				public string GmtCreated
				{
					get
					{
						return gmtCreated;
					}
					set	
					{
						gmtCreated = value;
					}
				}

				[JsonProperty(PropertyName = "GmtModified")]
				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				[JsonProperty(PropertyName = "AliUid")]
				public long? AliUid
				{
					get
					{
						return aliUid;
					}
					set	
					{
						aliUid = value;
					}
				}

				[JsonProperty(PropertyName = "IdempotentId")]
				public string IdempotentId
				{
					get
					{
						return idempotentId;
					}
					set	
					{
						idempotentId = value;
					}
				}

				[JsonProperty(PropertyName = "IdempotentCount")]
				public string IdempotentCount
				{
					get
					{
						return idempotentCount;
					}
					set	
					{
						idempotentCount = value;
					}
				}

				[JsonProperty(PropertyName = "Type")]
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

				[JsonProperty(PropertyName = "Level")]
				public string Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
					}
				}

				[JsonProperty(PropertyName = "TemplateName")]
				public string TemplateName
				{
					get
					{
						return templateName;
					}
					set	
					{
						templateName = value;
					}
				}

				[JsonProperty(PropertyName = "NotifyElement")]
				public string NotifyElement
				{
					get
					{
						return notifyElement;
					}
					set	
					{
						notifyElement = value;
					}
				}

				[JsonProperty(PropertyName = "ConfirmFlag")]
				public bool? ConfirmFlag
				{
					get
					{
						return confirmFlag;
					}
					set	
					{
						confirmFlag = value;
					}
				}

				[JsonProperty(PropertyName = "Confirmor")]
				public long? Confirmor
				{
					get
					{
						return confirmor;
					}
					set	
					{
						confirmor = value;
					}
				}
			}
		}
	}
}
