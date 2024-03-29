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
    public class ConfigLayer4RuleBakModeRequest : RpcAcsRequest<ConfigLayer4RuleBakModeResponse>
    {
        public ConfigLayer4RuleBakModeRequest()
            : base("ddoscoo", "2020-01-01", "ConfigLayer4RuleBakMode")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string bakMode;

		private string listeners;

		public string BakMode
		{
			get
			{
				return bakMode;
			}
			set	
			{
				bakMode = value;
				DictionaryUtil.Add(QueryParameters, "BakMode", value);
			}
		}

		public string Listeners
		{
			get
			{
				return listeners;
			}
			set	
			{
				listeners = value;
				DictionaryUtil.Add(QueryParameters, "Listeners", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ConfigLayer4RuleBakModeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigLayer4RuleBakModeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
