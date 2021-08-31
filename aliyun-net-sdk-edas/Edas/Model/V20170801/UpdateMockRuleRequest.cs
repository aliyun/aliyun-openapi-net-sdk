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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class UpdateMockRuleRequest : RoaAcsRequest<UpdateMockRuleResponse>
    {
        public UpdateMockRuleRequest()
            : base("Edas", "2017-08-01", "UpdateMockRule", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/sp/api/mock/updateMockRule";
			Method = MethodType.POST;
        }

		private string scMockItemJson;

		private string dubboMockItemJson;

		private string extraJson;

		private string name;

		private string id;

		private string region;

		public string ScMockItemJson
		{
			get
			{
				return scMockItemJson;
			}
			set	
			{
				scMockItemJson = value;
				DictionaryUtil.Add(QueryParameters, "ScMockItemJson", value);
			}
		}

		public string DubboMockItemJson
		{
			get
			{
				return dubboMockItemJson;
			}
			set	
			{
				dubboMockItemJson = value;
				DictionaryUtil.Add(QueryParameters, "DubboMockItemJson", value);
			}
		}

		public string ExtraJson
		{
			get
			{
				return extraJson;
			}
			set	
			{
				extraJson = value;
				DictionaryUtil.Add(QueryParameters, "ExtraJson", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateMockRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateMockRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
