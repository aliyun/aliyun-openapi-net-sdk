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
using Aliyun.Acs.videoenhan.Transform;
using Aliyun.Acs.videoenhan.Transform.V20200320;

namespace Aliyun.Acs.videoenhan.Model.V20200320
{
    public class ChangeVideoSizeRequest : RpcAcsRequest<ChangeVideoSizeResponse>
    {
        public ChangeVideoSizeRequest()
            : base("videoenhan", "2020-03-20", "ChangeVideoSize", "videoenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.videoenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? height;

		private int? b;

		private string fillType;

		private int? g;

		private string cropType;

		private int? r;

		private string videoUrl;

		private int? width;

		private float? tightness;

		public int? Height
		{
			get
			{
				return height;
			}
			set	
			{
				height = value;
				DictionaryUtil.Add(BodyParameters, "Height", value.ToString());
			}
		}

		public int? B
		{
			get
			{
				return b;
			}
			set	
			{
				b = value;
				DictionaryUtil.Add(BodyParameters, "B", value.ToString());
			}
		}

		public string FillType
		{
			get
			{
				return fillType;
			}
			set	
			{
				fillType = value;
				DictionaryUtil.Add(BodyParameters, "FillType", value);
			}
		}

		public int? G
		{
			get
			{
				return g;
			}
			set	
			{
				g = value;
				DictionaryUtil.Add(BodyParameters, "G", value.ToString());
			}
		}

		public string CropType
		{
			get
			{
				return cropType;
			}
			set	
			{
				cropType = value;
				DictionaryUtil.Add(BodyParameters, "CropType", value);
			}
		}

		public int? R
		{
			get
			{
				return r;
			}
			set	
			{
				r = value;
				DictionaryUtil.Add(BodyParameters, "R", value.ToString());
			}
		}

		public string VideoUrl
		{
			get
			{
				return videoUrl;
			}
			set	
			{
				videoUrl = value;
				DictionaryUtil.Add(BodyParameters, "VideoUrl", value);
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
				DictionaryUtil.Add(BodyParameters, "Width", value.ToString());
			}
		}

		public float? Tightness
		{
			get
			{
				return tightness;
			}
			set	
			{
				tightness = value;
				DictionaryUtil.Add(BodyParameters, "Tightness", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ChangeVideoSizeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeVideoSizeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
