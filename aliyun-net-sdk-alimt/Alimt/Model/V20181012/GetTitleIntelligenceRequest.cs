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
using Aliyun.Acs.alimt.Transform;
using Aliyun.Acs.alimt.Transform.V20181012;

namespace Aliyun.Acs.alimt.Model.V20181012
{
    public class GetTitleIntelligenceRequest : RpcAcsRequest<GetTitleIntelligenceResponse>
    {
        public GetTitleIntelligenceRequest()
            : base("alimt", "2018-10-12", "GetTitleIntelligence", "alimt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? catLevelThreeId;

		private long? catLevelTwoId;

		private string keywords;

		private string platform;

		private string extra;

		public long? CatLevelThreeId
		{
			get
			{
				return catLevelThreeId;
			}
			set	
			{
				catLevelThreeId = value;
				DictionaryUtil.Add(BodyParameters, "CatLevelThreeId", value.ToString());
			}
		}

		public long? CatLevelTwoId
		{
			get
			{
				return catLevelTwoId;
			}
			set	
			{
				catLevelTwoId = value;
				DictionaryUtil.Add(BodyParameters, "CatLevelTwoId", value.ToString());
			}
		}

		public string Keywords
		{
			get
			{
				return keywords;
			}
			set	
			{
				keywords = value;
				DictionaryUtil.Add(BodyParameters, "Keywords", value);
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(BodyParameters, "Platform", value);
			}
		}

		public string Extra
		{
			get
			{
				return extra;
			}
			set	
			{
				extra = value;
				DictionaryUtil.Add(BodyParameters, "Extra", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTitleIntelligenceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTitleIntelligenceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
