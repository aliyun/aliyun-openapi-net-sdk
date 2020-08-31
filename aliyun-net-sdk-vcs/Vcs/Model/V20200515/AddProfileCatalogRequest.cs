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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class AddProfileCatalogRequest : RpcAcsRequest<AddProfileCatalogResponse>
    {
        public AddProfileCatalogRequest()
            : base("Vcs", "2020-05-15", "AddProfileCatalog")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string isvSubId;

		private long? parentCatalogId;

		private string corpId;

		private string catalogName;

		public string IsvSubId
		{
			get
			{
				return isvSubId;
			}
			set	
			{
				isvSubId = value;
				DictionaryUtil.Add(BodyParameters, "IsvSubId", value);
			}
		}

		public long? ParentCatalogId
		{
			get
			{
				return parentCatalogId;
			}
			set	
			{
				parentCatalogId = value;
				DictionaryUtil.Add(BodyParameters, "ParentCatalogId", value.ToString());
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string CatalogName
		{
			get
			{
				return catalogName;
			}
			set	
			{
				catalogName = value;
				DictionaryUtil.Add(BodyParameters, "CatalogName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddProfileCatalogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddProfileCatalogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
