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
using Aliyun.Acs.eflo.Transform;
using Aliyun.Acs.eflo.Transform.V20220530;

namespace Aliyun.Acs.eflo.Model.V20220530
{
    public class GetFabricTopologyRequest : RpcAcsRequest<GetFabricTopologyResponse>
    {
        public GetFabricTopologyRequest()
            : base("eflo", "2022-05-30", "GetFabricTopology", "eflo", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string clusterId;

		private string vpdId;

		private string vpcId;

		private List<string> lniIdss = new List<string>(){ };

		private List<string> nodeIdss = new List<string>(){ };

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(BodyParameters, "ClusterId", value);
			}
		}

		public string VpdId
		{
			get
			{
				return vpdId;
			}
			set	
			{
				vpdId = value;
				DictionaryUtil.Add(BodyParameters, "VpdId", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(BodyParameters, "VpcId", value);
			}
		}

		public List<string> LniIdss
		{
			get
			{
				return lniIdss;
			}

			set
			{
				lniIdss = value;
			}
		}

		public List<string> NodeIdss
		{
			get
			{
				return nodeIdss;
			}

			set
			{
				nodeIdss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetFabricTopologyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetFabricTopologyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
