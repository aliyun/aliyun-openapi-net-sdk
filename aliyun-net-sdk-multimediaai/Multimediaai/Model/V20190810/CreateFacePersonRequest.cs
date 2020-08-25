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
    public class CreateFacePersonRequest : RpcAcsRequest<CreateFacePersonResponse>
    {
        public CreateFacePersonRequest()
            : base("multimediaai", "2019-08-10", "CreateFacePerson")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? faceGroupId;

		private string imageUrls;

		private string facePersonName;

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

		public string ImageUrls
		{
			get
			{
				return imageUrls;
			}
			set	
			{
				imageUrls = value;
				DictionaryUtil.Add(QueryParameters, "ImageUrls", value);
			}
		}

		public string FacePersonName
		{
			get
			{
				return facePersonName;
			}
			set	
			{
				facePersonName = value;
				DictionaryUtil.Add(QueryParameters, "FacePersonName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateFacePersonResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFacePersonResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
