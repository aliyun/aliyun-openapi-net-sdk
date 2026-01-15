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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class SearchImageRequest : RpcAcsRequest<SearchImageResponse>
    {
        public SearchImageRequest()
            : base("WebsiteBuild", "2025-04-29", "SearchImage")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? hasPerson;

		private int? maxWidth;

		private string ossKey;

		private string imageCategory;

		private int? maxHeight;

		private string imageRatio;

		private string nextToken;

		private string text;

		private string colorHex;

		private int? minHeight;

		private int? start;

		private List<string> tags = new List<string>(){ };

		private int? size;

		private int? minWidth;

		private int? maxResults;

		[JsonProperty(PropertyName = "HasPerson")]
		public bool? HasPerson
		{
			get
			{
				return hasPerson;
			}
			set	
			{
				hasPerson = value;
				DictionaryUtil.Add(QueryParameters, "HasPerson", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MaxWidth")]
		public int? MaxWidth
		{
			get
			{
				return maxWidth;
			}
			set	
			{
				maxWidth = value;
				DictionaryUtil.Add(QueryParameters, "MaxWidth", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OssKey")]
		public string OssKey
		{
			get
			{
				return ossKey;
			}
			set	
			{
				ossKey = value;
				DictionaryUtil.Add(QueryParameters, "OssKey", value);
			}
		}

		[JsonProperty(PropertyName = "ImageCategory")]
		public string ImageCategory
		{
			get
			{
				return imageCategory;
			}
			set	
			{
				imageCategory = value;
				DictionaryUtil.Add(QueryParameters, "ImageCategory", value);
			}
		}

		[JsonProperty(PropertyName = "MaxHeight")]
		public int? MaxHeight
		{
			get
			{
				return maxHeight;
			}
			set	
			{
				maxHeight = value;
				DictionaryUtil.Add(QueryParameters, "MaxHeight", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ImageRatio")]
		public string ImageRatio
		{
			get
			{
				return imageRatio;
			}
			set	
			{
				imageRatio = value;
				DictionaryUtil.Add(QueryParameters, "ImageRatio", value);
			}
		}

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		[JsonProperty(PropertyName = "Text")]
		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(QueryParameters, "Text", value);
			}
		}

		[JsonProperty(PropertyName = "ColorHex")]
		public string ColorHex
		{
			get
			{
				return colorHex;
			}
			set	
			{
				colorHex = value;
				DictionaryUtil.Add(QueryParameters, "ColorHex", value);
			}
		}

		[JsonProperty(PropertyName = "MinHeight")]
		public int? MinHeight
		{
			get
			{
				return minHeight;
			}
			set	
			{
				minHeight = value;
				DictionaryUtil.Add(QueryParameters, "MinHeight", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Start")]
		public int? Start
		{
			get
			{
				return start;
			}
			set	
			{
				start = value;
				DictionaryUtil.Add(QueryParameters, "Start", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Tags")]
		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tags." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "Size")]
		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MinWidth")]
		public int? MinWidth
		{
			get
			{
				return minWidth;
			}
			set	
			{
				minWidth = value;
				DictionaryUtil.Add(QueryParameters, "MinWidth", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
