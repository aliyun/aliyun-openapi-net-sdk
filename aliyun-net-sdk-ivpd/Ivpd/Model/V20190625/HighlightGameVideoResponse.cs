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

namespace Aliyun.Acs.ivpd.Model.V20190625
{
	public class HighlightGameVideoResponse : AcsResponse
	{

		private string requestId;

		private HighlightGameVideo_Data data;

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

		public HighlightGameVideo_Data Data
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

		public class HighlightGameVideo_Data
		{

			private List<HighlightGameVideo_GameListItem> gameList;

			private List<HighlightGameVideo_HighlightListItem> highlightList;

			public List<HighlightGameVideo_GameListItem> GameList
			{
				get
				{
					return gameList;
				}
				set	
				{
					gameList = value;
				}
			}

			public List<HighlightGameVideo_HighlightListItem> HighlightList
			{
				get
				{
					return highlightList;
				}
				set	
				{
					highlightList = value;
				}
			}

			public class HighlightGameVideo_GameListItem
			{

				private string id;

				private float? end;

				private float? start;

				private string gameInfo;

				public string Id
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

				public float? End
				{
					get
					{
						return end;
					}
					set	
					{
						end = value;
					}
				}

				public float? Start
				{
					get
					{
						return start;
					}
					set	
					{
						start = value;
					}
				}

				public string GameInfo
				{
					get
					{
						return gameInfo;
					}
					set	
					{
						gameInfo = value;
					}
				}
			}

			public class HighlightGameVideo_HighlightListItem
			{

				private float? start;

				private float? end;

				public float? Start
				{
					get
					{
						return start;
					}
					set	
					{
						start = value;
					}
				}

				public float? End
				{
					get
					{
						return end;
					}
					set	
					{
						end = value;
					}
				}
			}
		}
	}
}
