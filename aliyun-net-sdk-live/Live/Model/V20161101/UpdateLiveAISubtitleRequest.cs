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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class UpdateLiveAISubtitleRequest : RpcAcsRequest<UpdateLiveAISubtitleResponse>
    {
        public UpdateLiveAISubtitleRequest()
            : base("live", "2016-11-01", "UpdateLiveAISubtitle", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string srcLanguage;

		private string description;

		private string fontName;

		private string subtitleName;

		private float? fontSizeNormalized;

		private string fontColor;

		private bool? showSourceLan;

		private List<float?> positionNormalized = new List<float?>(){ };

		private float? borderWidthNormalized;

		private int? maxLines;

		private string height;

		private int? wordPerLine;

		private long? ownerId;

		private float? bgWidthNormalized;

		private string bgColor;

		private string dstLanguage;

		private string width;

		private string subtitleId;

		[JsonProperty(PropertyName = "SrcLanguage")]
		public string SrcLanguage
		{
			get
			{
				return srcLanguage;
			}
			set	
			{
				srcLanguage = value;
				DictionaryUtil.Add(QueryParameters, "SrcLanguage", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "FontName")]
		public string FontName
		{
			get
			{
				return fontName;
			}
			set	
			{
				fontName = value;
				DictionaryUtil.Add(QueryParameters, "FontName", value);
			}
		}

		[JsonProperty(PropertyName = "SubtitleName")]
		public string SubtitleName
		{
			get
			{
				return subtitleName;
			}
			set	
			{
				subtitleName = value;
				DictionaryUtil.Add(QueryParameters, "SubtitleName", value);
			}
		}

		[JsonProperty(PropertyName = "FontSizeNormalized")]
		public float? FontSizeNormalized
		{
			get
			{
				return fontSizeNormalized;
			}
			set	
			{
				fontSizeNormalized = value;
				DictionaryUtil.Add(QueryParameters, "FontSizeNormalized", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "FontColor")]
		public string FontColor
		{
			get
			{
				return fontColor;
			}
			set	
			{
				fontColor = value;
				DictionaryUtil.Add(QueryParameters, "FontColor", value);
			}
		}

		[JsonProperty(PropertyName = "ShowSourceLan")]
		public bool? ShowSourceLan
		{
			get
			{
				return showSourceLan;
			}
			set	
			{
				showSourceLan = value;
				DictionaryUtil.Add(QueryParameters, "ShowSourceLan", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PositionNormalized")]
		public List<float?> PositionNormalized
		{
			get
			{
				return positionNormalized;
			}

			set
			{
				positionNormalized = value;
				if(positionNormalized != null)
				{
					for (int depth1 = 0; depth1 < positionNormalized.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"PositionNormalized." + (depth1 + 1), positionNormalized[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "BorderWidthNormalized")]
		public float? BorderWidthNormalized
		{
			get
			{
				return borderWidthNormalized;
			}
			set	
			{
				borderWidthNormalized = value;
				DictionaryUtil.Add(QueryParameters, "BorderWidthNormalized", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "MaxLines")]
		public int? MaxLines
		{
			get
			{
				return maxLines;
			}
			set	
			{
				maxLines = value;
				DictionaryUtil.Add(QueryParameters, "MaxLines", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Height")]
		public string Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(QueryParameters, "Height", value);
			}
		}

		[JsonProperty(PropertyName = "WordPerLine")]
		public int? WordPerLine
		{
			get
			{
				return wordPerLine;
			}
			set	
			{
				wordPerLine = value;
				DictionaryUtil.Add(QueryParameters, "WordPerLine", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BgWidthNormalized")]
		public float? BgWidthNormalized
		{
			get
			{
				return bgWidthNormalized;
			}
			set	
			{
				bgWidthNormalized = value;
				DictionaryUtil.Add(QueryParameters, "BgWidthNormalized", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BgColor")]
		public string BgColor
		{
			get
			{
				return bgColor;
			}
			set	
			{
				bgColor = value;
				DictionaryUtil.Add(QueryParameters, "BgColor", value);
			}
		}

		[JsonProperty(PropertyName = "DstLanguage")]
		public string DstLanguage
		{
			get
			{
				return dstLanguage;
			}
			set	
			{
				dstLanguage = value;
				DictionaryUtil.Add(QueryParameters, "DstLanguage", value);
			}
		}

		[JsonProperty(PropertyName = "Width")]
		public string Width
		{
			get
			{
				return width;
			}
			set	
			{
				width = value;
				DictionaryUtil.Add(QueryParameters, "Width", value);
			}
		}

		[JsonProperty(PropertyName = "SubtitleId")]
		public string SubtitleId
		{
			get
			{
				return subtitleId;
			}
			set	
			{
				subtitleId = value;
				DictionaryUtil.Add(QueryParameters, "SubtitleId", value);
			}
		}

        public override UpdateLiveAISubtitleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateLiveAISubtitleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
