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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imageenhan.Transform;
using Aliyun.Acs.imageenhan.Transform.V20190930;

namespace Aliyun.Acs.imageenhan.Model.V20190930
{
    public class RecolorHDImageRequest : RpcAcsRequest<RecolorHDImageResponse>
    {
        public RecolorHDImageRequest()
            : base("imageenhan", "2019-09-30", "RecolorHDImage", "imageenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<ColorTemplate> colorTemplates = new List<ColorTemplate>(){ };

		private string degree;

		private string url;

		private string mode;

		private int? colorCount;

		private string refUrl;

		public List<ColorTemplate> ColorTemplates
		{
			get
			{
				return colorTemplates;
			}

			set
			{
				colorTemplates = value;
				for (int i = 0; i < colorTemplates.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ColorTemplate." + (i + 1) + ".Color", colorTemplates[i].Color);
				}
			}
		}

		public string Degree
		{
			get
			{
				return degree;
			}
			set	
			{
				degree = value;
				DictionaryUtil.Add(BodyParameters, "Degree", value);
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(BodyParameters, "Url", value);
			}
		}

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(BodyParameters, "Mode", value);
			}
		}

		public int? ColorCount
		{
			get
			{
				return colorCount;
			}
			set	
			{
				colorCount = value;
				DictionaryUtil.Add(BodyParameters, "ColorCount", value.ToString());
			}
		}

		public string RefUrl
		{
			get
			{
				return refUrl;
			}
			set	
			{
				refUrl = value;
				DictionaryUtil.Add(BodyParameters, "RefUrl", value);
			}
		}

		public class ColorTemplate
		{

			private string color;

			public string Color
			{
				get
				{
					return color;
				}
				set	
				{
					color = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecolorHDImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecolorHDImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
