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
    public class AddRouteRuleRequest : RpcAcsRequest<AddRouteRuleResponse>
    {
        public AddRouteRuleRequest()
            : base("lto", "2021-07-07", "AddRouteRule")
        {
			Method = MethodType.POST;
        }

		private string contractTemplateId;

		private string contractName;

		private string privacyRuleId;

		private string remark;

		private string bizChainId;

		private string invokeType;

		private string deviceGroupId;

		private string chainUpMode;

		public string ContractTemplateId
		{
			get
			{
				return contractTemplateId;
			}
			set	
			{
				contractTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContractTemplateId", value);
			}
		}

		public string ContractName
		{
			get
			{
				return contractName;
			}
			set	
			{
				contractName = value;
				DictionaryUtil.Add(QueryParameters, "ContractName", value);
			}
		}

		public string PrivacyRuleId
		{
			get
			{
				return privacyRuleId;
			}
			set	
			{
				privacyRuleId = value;
				DictionaryUtil.Add(QueryParameters, "PrivacyRuleId", value);
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

		public string BizChainId
		{
			get
			{
				return bizChainId;
			}
			set	
			{
				bizChainId = value;
				DictionaryUtil.Add(QueryParameters, "BizChainId", value);
			}
		}

		public string InvokeType
		{
			get
			{
				return invokeType;
			}
			set	
			{
				invokeType = value;
				DictionaryUtil.Add(QueryParameters, "InvokeType", value);
			}
		}

		public string DeviceGroupId
		{
			get
			{
				return deviceGroupId;
			}
			set	
			{
				deviceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceGroupId", value);
			}
		}

		public string ChainUpMode
		{
			get
			{
				return chainUpMode;
			}
			set	
			{
				chainUpMode = value;
				DictionaryUtil.Add(QueryParameters, "ChainUpMode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddRouteRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddRouteRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
