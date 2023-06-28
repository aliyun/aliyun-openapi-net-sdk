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
    public class ListBaaSAntChainPeerRequest : RpcAcsRequest<ListBaaSAntChainPeerResponse>
    {
        public ListBaaSAntChainPeerRequest()
            : base("lto", "2021-07-07", "ListBaaSAntChainPeer")
        {
			Method = MethodType.POST;
        }

		private string baaSAntChainConsortiumId;

		private string baaSAntChainChainId;

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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListBaaSAntChainPeerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListBaaSAntChainPeerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
