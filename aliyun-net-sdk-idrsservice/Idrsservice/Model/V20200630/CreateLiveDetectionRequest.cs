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
using Aliyun.Acs.idrsservice.Transform;
using Aliyun.Acs.idrsservice.Transform.V20200630;

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
    public class CreateLiveDetectionRequest : RpcAcsRequest<CreateLiveDetectionResponse>
    {
        public CreateLiveDetectionRequest()
            : base("idrsservice", "2020-06-30", "CreateLiveDetection", "idrsservice", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string liveId;

		private string userId;

		private string metaUrl;

		private string ruleId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string LiveId
		{
			get
			{
				return liveId;
			}
			set	
			{
				liveId = value;
				DictionaryUtil.Add(QueryParameters, "LiveId", value);
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

		public string MetaUrl
		{
			get
			{
				return metaUrl;
			}
			set	
			{
				metaUrl = value;
				DictionaryUtil.Add(QueryParameters, "MetaUrl", value);
			}
		}

		public string RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateLiveDetectionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLiveDetectionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
