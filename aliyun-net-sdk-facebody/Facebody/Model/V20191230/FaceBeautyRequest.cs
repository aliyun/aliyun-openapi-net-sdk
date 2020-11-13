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
using Aliyun.Acs.facebody.Transform;
using Aliyun.Acs.facebody.Transform.V20191230;

namespace Aliyun.Acs.facebody.Model.V20191230
{
    public class FaceBeautyRequest : RpcAcsRequest<FaceBeautyResponse>
    {
        public FaceBeautyRequest()
            : base("facebody", "2019-12-30", "FaceBeauty", "facebody", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? sharp;

		private float? white;

		private string imageURL;

		private float? smooth;

		public float? Sharp
		{
			get
			{
				return sharp;
			}
			set	
			{
				sharp = value;
				DictionaryUtil.Add(BodyParameters, "Sharp", value.ToString());
			}
		}

		public float? White
		{
			get
			{
				return white;
			}
			set	
			{
				white = value;
				DictionaryUtil.Add(BodyParameters, "White", value.ToString());
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

		public float? Smooth
		{
			get
			{
				return smooth;
			}
			set	
			{
				smooth = value;
				DictionaryUtil.Add(BodyParameters, "Smooth", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FaceBeautyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FaceBeautyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
