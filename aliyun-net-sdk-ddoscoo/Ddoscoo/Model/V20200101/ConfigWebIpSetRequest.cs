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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class ConfigWebIpSetRequest : RpcAcsRequest<ConfigWebIpSetResponse>
    {
        public ConfigWebIpSetRequest()
            : base("ddoscoo", "2020-01-01", "ConfigWebIpSet")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private List<string> blackLists = new List<string>(){ };

		private List<string> whiteLists = new List<string>(){ };

		private string domain;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public List<string> BlackLists
		{
			get
			{
				return blackLists;
			}

			set
			{
				blackLists = value;
				for (int i = 0; i < blackLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BlackList." + (i + 1) , blackLists[i]);
				}
			}
		}

		public List<string> WhiteLists
		{
			get
			{
				return whiteLists;
			}

			set
			{
				whiteLists = value;
				for (int i = 0; i < whiteLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"WhiteList." + (i + 1) , whiteLists[i]);
				}
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ConfigWebIpSetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigWebIpSetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
