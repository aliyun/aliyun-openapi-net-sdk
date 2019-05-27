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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class SearchFaceResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private string groupName;

		private int? glasses;

		private int? hat;

		private float? score;

		private List<SearchFace_ResultFacesItem> resultFaces;

		private List<string> axis;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}

		public int? Glasses
		{
			get
			{
				return glasses;
			}
			set	
			{
				glasses = value;
			}
		}

		public int? Hat
		{
			get
			{
				return hat;
			}
			set	
			{
				hat = value;
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

		public List<SearchFace_ResultFacesItem> ResultFaces
		{
			get
			{
				return resultFaces;
			}
			set	
			{
				resultFaces = value;
			}
		}

		public List<string> Axis
		{
			get
			{
				return axis;
			}
			set	
			{
				axis = value;
			}
		}

		public class SearchFace_ResultFacesItem
		{

			private string groupId;

			private string user;

			private string imageId;

			private float? score;

			private string imageUri;

			private int? glasses;

			private int? hat;

			private List<string> axis1;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
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

			public string ImageUri
			{
				get
				{
					return imageUri;
				}
				set	
				{
					imageUri = value;
				}
			}

			public int? Glasses
			{
				get
				{
					return glasses;
				}
				set	
				{
					glasses = value;
				}
			}

			public int? Hat
			{
				get
				{
					return hat;
				}
				set	
				{
					hat = value;
				}
			}

			public List<string> Axis1
			{
				get
				{
					return axis1;
				}
				set	
				{
					axis1 = value;
				}
			}
		}
	}
}
