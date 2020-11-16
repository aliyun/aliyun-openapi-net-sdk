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
	public class SearchImageResponse : AcsResponse
	{

		private string requestId;

		private SearchImage_Data data;

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

		public SearchImage_Data Data
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

		public class SearchImage_Data
		{

			private List<SearchImage_MatchListItem> matchList;

			public List<SearchImage_MatchListItem> MatchList
			{
				get
				{
					return matchList;
				}
				set	
				{
					matchList = value;
				}
			}

			public class SearchImage_MatchListItem
			{

				private string dataId;

				private string extraData;

				private string entityId;

				private string imageUrl;

				private float? score;

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

				public string ImageUrl
				{
					get
					{
						return imageUrl;
					}
					set	
					{
						imageUrl = value;
					}
				}

				public float? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}
			}
		}
	}
}
