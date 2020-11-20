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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class SearchFaceResponse : AcsResponse
	{

		private string requestId;

		private SearchFace_Data data;

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

		public SearchFace_Data Data
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

		public class SearchFace_Data
		{

			private List<SearchFace_MatchListItem> matchList;

			public List<SearchFace_MatchListItem> MatchList
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

			public class SearchFace_MatchListItem
			{

				private List<SearchFace_FaceItemsItem> faceItems;

				private SearchFace_Location location;

				public List<SearchFace_FaceItemsItem> FaceItems
				{
					get
					{
						return faceItems;
					}
					set	
					{
						faceItems = value;
					}
				}

				public SearchFace_Location Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public class SearchFace_FaceItemsItem
				{

					private string faceId;

					private float? score;

					private string extraData;

					private string entityId;

					public string FaceId
					{
						get
						{
							return faceId;
						}
						set	
						{
							faceId = value;
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
				}

				public class SearchFace_Location
				{

					private int? x;

					private int? y;

					private int? width;

					private int? height;

					public int? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public int? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}
			}
		}
	}
}
