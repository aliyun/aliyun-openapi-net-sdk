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
using Aliyun.Acs.goodstech.Transform;
using Aliyun.Acs.goodstech.Transform.V20191230;

namespace Aliyun.Acs.goodstech.Model.V20191230
{
    public class RecognizeFurnitureSpuRequest : RpcAcsRequest<RecognizeFurnitureSpuResponse>
    {
        public RecognizeFurnitureSpuRequest()
            : base("goodstech", "2019-12-30", "RecognizeFurnitureSpu", "goodstech", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.goodstech.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.goodstech.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? xLength;

		private float? zLength;

		private string imageURL;

		private float? yLength;

		public float? XLength
		{
			get
			{
				return xLength;
			}
			set	
			{
				xLength = value;
				DictionaryUtil.Add(BodyParameters, "XLength", value.ToString());
			}
		}

		public float? ZLength
		{
			get
			{
				return zLength;
			}
			set	
			{
				zLength = value;
				DictionaryUtil.Add(BodyParameters, "ZLength", value.ToString());
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

		public float? YLength
		{
			get
			{
				return yLength;
			}
			set	
			{
				yLength = value;
				DictionaryUtil.Add(BodyParameters, "YLength", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RecognizeFurnitureSpuResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RecognizeFurnitureSpuResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
