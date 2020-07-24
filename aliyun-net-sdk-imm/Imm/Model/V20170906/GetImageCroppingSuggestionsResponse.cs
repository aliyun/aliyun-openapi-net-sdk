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
	public class GetImageCroppingSuggestionsResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private List<GetImageCroppingSuggestions_CroppingSuggestionsItem> croppingSuggestions;

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

		public List<GetImageCroppingSuggestions_CroppingSuggestionsItem> CroppingSuggestions
		{
			get
			{
				return croppingSuggestions;
			}
			set	
			{
				croppingSuggestions = value;
			}
		}

		public class GetImageCroppingSuggestions_CroppingSuggestionsItem
		{

			private float? score;

			private string aspectRatio;

			private GetImageCroppingSuggestions_CroppingBoundary croppingBoundary;

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

			public string AspectRatio
			{
				get
				{
					return aspectRatio;
				}
				set	
				{
					aspectRatio = value;
				}
			}

			public GetImageCroppingSuggestions_CroppingBoundary CroppingBoundary
			{
				get
				{
					return croppingBoundary;
				}
				set	
				{
					croppingBoundary = value;
				}
			}

			public class GetImageCroppingSuggestions_CroppingBoundary
			{

				private int? left;

				private int? top;

				private int? width;

				private int? height;

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
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
