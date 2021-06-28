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
using Aliyun.Acs.ivision;
using Aliyun.Acs.ivision.Transform;
using Aliyun.Acs.ivision.Transform.V20190308;

namespace Aliyun.Acs.ivision.Model.V20190308
{
    public class PredictPictureRequest : RpcAcsRequest<PredictPictureResponse>
    {
        public PredictPictureRequest()
            : base("ivision", "2019-03-08", "PredictPicture")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ivision.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ossPath;

		private string resourceUrl;

		private string imageUrl;

		private string customerData;

		private string algorithmCode;

		public string OssPath
		{
			get
			{
				return ossPath;
			}
			set	
			{
				ossPath = value;
				DictionaryUtil.Add(BodyParameters, "OssPath", value);
			}
		}

		public string ResourceUrl
		{
			get
			{
				return resourceUrl;
			}
			set	
			{
				resourceUrl = value;
				DictionaryUtil.Add(BodyParameters, "ResourceUrl", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(BodyParameters, "ImageUrl", value);
			}
		}

		public string CustomerData
		{
			get
			{
				return customerData;
			}
			set	
			{
				customerData = value;
				DictionaryUtil.Add(BodyParameters, "CustomerData", value);
			}
		}

		public string AlgorithmCode
		{
			get
			{
				return algorithmCode;
			}
			set	
			{
				algorithmCode = value;
				DictionaryUtil.Add(BodyParameters, "AlgorithmCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PredictPictureResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PredictPictureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
