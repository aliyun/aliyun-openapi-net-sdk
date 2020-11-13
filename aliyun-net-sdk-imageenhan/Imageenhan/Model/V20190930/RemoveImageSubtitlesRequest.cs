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
    public class RemoveImageSubtitlesRequest : RpcAcsRequest<RemoveImageSubtitlesResponse>
    {
        public RemoveImageSubtitlesRequest()
            : base("imageenhan", "2019-09-30", "RemoveImageSubtitles", "imageenhan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageenhan.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? bH;

		private float? bW;

		private float? bX;

		private string imageURL;

		private float? bY;

		public float? BH
		{
			get
			{
				return bH;
			}
			set	
			{
				bH = value;
				DictionaryUtil.Add(BodyParameters, "BH", value.ToString());
			}
		}

		public float? BW
		{
			get
			{
				return bW;
			}
			set	
			{
				bW = value;
				DictionaryUtil.Add(BodyParameters, "BW", value.ToString());
			}
		}

		public float? BX
		{
			get
			{
				return bX;
			}
			set	
			{
				bX = value;
				DictionaryUtil.Add(BodyParameters, "BX", value.ToString());
			}
		}

		public string ImageURL
		{
			get
			{
				return imageURL;
			}
			set	
			{
				imageURL = value;
				DictionaryUtil.Add(BodyParameters, "ImageURL", value);
			}
		}

		public float? BY
		{
			get
			{
				return bY;
			}
			set	
			{
				bY = value;
				DictionaryUtil.Add(BodyParameters, "BY", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RemoveImageSubtitlesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RemoveImageSubtitlesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
