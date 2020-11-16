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

namespace Aliyun.Acs.imgsearch.Model.V20200320
{
	public class ListImagesResponse : AcsResponse
	{

		private string requestId;

		private ListImages_Data data;

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

		public ListImages_Data Data
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

		public class ListImages_Data
		{

			private string token;

			private int? totalCount;

			private List<ListImages_ImageListItem> imageList;

			public string Token
			{
				get
				{
					return token;
				}
				set	
				{
					token = value;
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

			public List<ListImages_ImageListItem> ImageList
			{
				get
				{
					return imageList;
				}
				set	
				{
					imageList = value;
				}
			}

			public class ListImages_ImageListItem
			{

				private string dataId;

				private string extraData;

				private string entityId;

				private long? updatedAt;

				private long? createdAt;

				public string DataId
				{
					get
					{
						return dataId;
					}
					set	
					{
						dataId = value;
					}
				}

				public string ExtraData
				{
					get
					{
						return extraData;
					}
					set	
					{
						extraData = value;
					}
				}

				public string EntityId
				{
					get
					{
						return entityId;
					}
					set	
					{
						entityId = value;
					}
				}

				public long? UpdatedAt
				{
					get
					{
						return updatedAt;
					}
					set	
					{
						updatedAt = value;
					}
				}

				public long? CreatedAt
				{
					get
					{
						return createdAt;
					}
					set	
					{
						createdAt = value;
					}
				}
			}
		}
	}
}
