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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class DetectImageTagsResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private List<DetectImageTags_TagsItem> tags;

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

		public List<DetectImageTags_TagsItem> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public class DetectImageTags_TagsItem
		{

			private string tagName;

			private float? tagConfidence;

			private int? tagLevel;

			private string parentTagName;

			private string parentTagEnName;

			private string tagEnName;

			public string TagName
			{
				get
				{
					return tagName;
				}
				set	
				{
					tagName = value;
				}
			}

			public float? TagConfidence
			{
				get
				{
					return tagConfidence;
				}
				set	
				{
					tagConfidence = value;
				}
			}

			public int? TagLevel
			{
				get
				{
					return tagLevel;
				}
				set	
				{
					tagLevel = value;
				}
			}

			public string ParentTagName
			{
				get
				{
					return parentTagName;
				}
				set	
				{
					parentTagName = value;
				}
			}

			public string ParentTagEnName
			{
				get
				{
					return parentTagEnName;
				}
				set	
				{
					parentTagEnName = value;
				}
			}

			public string TagEnName
			{
				get
				{
					return tagEnName;
				}
				set	
				{
					tagEnName = value;
				}
			}
		}
	}
}