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
using Aliyun.Acs.finmall.Transform;
using Aliyun.Acs.finmall.Transform.V20180723;

namespace Aliyun.Acs.finmall.Model.V20180723
{
    public class GetSignContractUrlRequest : RpcAcsRequest<GetSignContractUrlResponse>
    {
        public GetSignContractUrlRequest()
            : base("finmall", "2018-07-23", "GetSignContractUrl", "finmall", "openAPI")
        {
        }

		private string extInfo;

		private string bizId;

		private string sceneId;

		private string returnUrl;

		private string userId;

		public string ExtInfo
		{
			get
			{
				return extInfo;
			}
			set	
			{
				extInfo = value;
				DictionaryUtil.Add(QueryParameters, "ExtInfo", value);
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

		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(QueryParameters, "SceneId", value);
			}
		}

		public string ReturnUrl
		{
			get
			{
				return returnUrl;
			}
			set	
			{
				returnUrl = value;
				DictionaryUtil.Add(QueryParameters, "ReturnUrl", value);
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

        public override GetSignContractUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSignContractUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
