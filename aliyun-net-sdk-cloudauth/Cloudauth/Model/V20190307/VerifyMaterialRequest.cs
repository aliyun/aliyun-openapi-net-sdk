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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class VerifyMaterialRequest : RpcAcsRequest<VerifyMaterialResponse>
    {
        public VerifyMaterialRequest()
            : base("Cloudauth", "2019-03-07", "VerifyMaterial", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string faceImageUrl;

		private string userId;

		private string idCardBackImageUrl;

		private string idCardNumber;

		private string idCardFrontImageUrl;

		private string bizType;

		private string bizId;

		private string name;

		public string FaceImageUrl
		{
			get
			{
				return faceImageUrl;
			}
			set	
			{
				faceImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "FaceImageUrl", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string IdCardBackImageUrl
		{
			get
			{
				return idCardBackImageUrl;
			}
			set	
			{
				idCardBackImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "IdCardBackImageUrl", value);
			}
		}

		public string IdCardNumber
		{
			get
			{
				return idCardNumber;
			}
			set	
			{
				idCardNumber = value;
				DictionaryUtil.Add(QueryParameters, "IdCardNumber", value);
			}
		}

		public string IdCardFrontImageUrl
		{
			get
			{
				return idCardFrontImageUrl;
			}
			set	
			{
				idCardFrontImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "IdCardFrontImageUrl", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override VerifyMaterialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return VerifyMaterialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
