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
    public class AddBsnFabricBizChainRequest : RpcAcsRequest<AddBsnFabricBizChainResponse>
    {
        public AddBsnFabricBizChainRequest()
            : base("lto", "2021-07-07", "AddBsnFabricBizChain")
        {
			Method = MethodType.POST;
        }

		private string remark;

		private string name;

		private string appCode;

		private string nodeList;

		private string userCode;

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

		public string AppCode
		{
			get
			{
				return appCode;
			}
			set	
			{
				appCode = value;
				DictionaryUtil.Add(QueryParameters, "AppCode", value);
			}
		}

		public string NodeList
		{
			get
			{
				return nodeList;
			}
			set	
			{
				nodeList = value;
				DictionaryUtil.Add(QueryParameters, "NodeList", value);
			}
		}

		public string UserCode
		{
			get
			{
				return userCode;
			}
			set	
			{
				userCode = value;
				DictionaryUtil.Add(QueryParameters, "UserCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddBsnFabricBizChainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddBsnFabricBizChainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
