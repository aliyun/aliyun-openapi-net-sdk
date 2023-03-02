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
    public class AddBaaSAntChainBizChainRequest : RpcAcsRequest<AddBaaSAntChainBizChainResponse>
    {
        public AddBaaSAntChainBizChainRequest()
            : base("lto", "2021-07-07", "AddBaaSAntChainBizChain")
        {
			Method = MethodType.POST;
        }

		private string caCertPassword;

		private string nodeNameList;

		private string remark;

		private string userKey;

		private string clientCert;

		private string baaSAntChainConsortiumId;

		private string userKeyPassword;

		private string baaSAntChainChainId;

		private string clientKey;

		private string caCert;

		private string name;

		private string clientKeyPassword;

		private string contractTemplateIdList;

		private string userName;

		public string CaCertPassword
		{
			get
			{
				return caCertPassword;
			}
			set	
			{
				caCertPassword = value;
				DictionaryUtil.Add(QueryParameters, "CaCertPassword", value);
			}
		}

		public string NodeNameList
		{
			get
			{
				return nodeNameList;
			}
			set	
			{
				nodeNameList = value;
				DictionaryUtil.Add(QueryParameters, "NodeNameList", value);
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

		public string UserKey
		{
			get
			{
				return userKey;
			}
			set	
			{
				userKey = value;
				DictionaryUtil.Add(QueryParameters, "UserKey", value);
			}
		}

		public string ClientCert
		{
			get
			{
				return clientCert;
			}
			set	
			{
				clientCert = value;
				DictionaryUtil.Add(QueryParameters, "ClientCert", value);
			}
		}

		public string BaaSAntChainConsortiumId
		{
			get
			{
				return baaSAntChainConsortiumId;
			}
			set	
			{
				baaSAntChainConsortiumId = value;
				DictionaryUtil.Add(QueryParameters, "BaaSAntChainConsortiumId", value);
			}
		}

		public string UserKeyPassword
		{
			get
			{
				return userKeyPassword;
			}
			set	
			{
				userKeyPassword = value;
				DictionaryUtil.Add(QueryParameters, "UserKeyPassword", value);
			}
		}

		public string BaaSAntChainChainId
		{
			get
			{
				return baaSAntChainChainId;
			}
			set	
			{
				baaSAntChainChainId = value;
				DictionaryUtil.Add(QueryParameters, "BaaSAntChainChainId", value);
			}
		}

		public string ClientKey
		{
			get
			{
				return clientKey;
			}
			set	
			{
				clientKey = value;
				DictionaryUtil.Add(QueryParameters, "ClientKey", value);
			}
		}

		public string CaCert
		{
			get
			{
				return caCert;
			}
			set	
			{
				caCert = value;
				DictionaryUtil.Add(QueryParameters, "CaCert", value);
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

		public string ClientKeyPassword
		{
			get
			{
				return clientKeyPassword;
			}
			set	
			{
				clientKeyPassword = value;
				DictionaryUtil.Add(QueryParameters, "ClientKeyPassword", value);
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

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddBaaSAntChainBizChainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddBaaSAntChainBizChainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
