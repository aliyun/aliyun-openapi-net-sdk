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
using Aliyun.Acs.multimediaai;
using Aliyun.Acs.multimediaai.Transform;
using Aliyun.Acs.multimediaai.Transform.V20190810;

namespace Aliyun.Acs.multimediaai.Model.V20190810
{
    public class RegisterFaceImageRequest : RpcAcsRequest<RegisterFaceImageResponse>
    {
        public RegisterFaceImageRequest()
            : base("multimediaai", "2019-08-10", "RegisterFaceImage")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.multimediaai.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.multimediaai.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? faceGroupId;

		private long? facePersonId;

		private string imageUrl;

		public long? FaceGroupId
		{
			get
			{
				return faceGroupId;
			}
			set	
			{
				faceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "FaceGroupId", value.ToString());
			}
		}

		public long? FacePersonId
		{
			get
			{
				return facePersonId;
			}
			set	
			{
				facePersonId = value;
				DictionaryUtil.Add(QueryParameters, "FacePersonId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ImageUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegisterFaceImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegisterFaceImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
