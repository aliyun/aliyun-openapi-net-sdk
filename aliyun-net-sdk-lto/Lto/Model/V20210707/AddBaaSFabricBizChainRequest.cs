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
using Aliyun.Acs.lto;
using Aliyun.Acs.lto.Transform;
using Aliyun.Acs.lto.Transform.V20210707;

namespace Aliyun.Acs.lto.Model.V20210707
{
    public class AddBaaSFabricBizChainRequest : RpcAcsRequest<AddBaaSFabricBizChainResponse>
    {
        public AddBaaSFabricBizChainRequest()
            : base("lto", "2021-07-07", "AddBaaSFabricBizChain")
        {
			Method = MethodType.POST;
        }

		private string baaSFabricConsortiumId;

		private string remark;

		private string name;

		private string baaSFabricChannelId;

		private string baaSFabricOrganizationId;

		private string contractTemplateIdList;

		public string BaaSFabricConsortiumId
		{
			get
			{
				return baaSFabricConsortiumId;
			}
			set	
			{
				baaSFabricConsortiumId = value;
				DictionaryUtil.Add(QueryParameters, "BaaSFabricConsortiumId", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
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

		public string BaaSFabricChannelId
		{
			get
			{
				return baaSFabricChannelId;
			}
			set	
			{
				baaSFabricChannelId = value;
				DictionaryUtil.Add(QueryParameters, "BaaSFabricChannelId", value);
			}
		}

		public string BaaSFabricOrganizationId
		{
			get
			{
				return baaSFabricOrganizationId;
			}
			set	
			{
				baaSFabricOrganizationId = value;
				DictionaryUtil.Add(QueryParameters, "BaaSFabricOrganizationId", value);
			}
		}

		public string ContractTemplateIdList
		{
			get
			{
				return contractTemplateIdList;
			}
			set	
			{
				contractTemplateIdList = value;
				DictionaryUtil.Add(QueryParameters, "ContractTemplateIdList", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddBaaSFabricBizChainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddBaaSFabricBizChainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
