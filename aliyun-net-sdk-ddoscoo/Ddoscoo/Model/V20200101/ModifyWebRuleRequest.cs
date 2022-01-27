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
    public class ModifyWebRuleRequest : RpcAcsRequest<ModifyWebRuleResponse>
    {
        public ModifyWebRuleRequest()
            : base("ddoscoo", "2020-01-01", "ModifyWebRule")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string httpsExt;

		private string resourceGroupId;

		private int? rsType;

		private List<string> realServerss = new List<string>(){ };

		private string proxyTypes;

		private List<string> instanceIdss = new List<string>(){ };

		private string domain;

		public string HttpsExt
		{
			get
			{
				return httpsExt;
			}
			set	
			{
				httpsExt = value;
				DictionaryUtil.Add(QueryParameters, "HttpsExt", value);
			}
		}

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

		public int? RsType
		{
			get
			{
				return rsType;
			}
			set	
			{
				rsType = value;
				DictionaryUtil.Add(QueryParameters, "RsType", value.ToString());
			}
		}

		public List<string> RealServerss
		{
			get
			{
				return realServerss;
			}

			set
			{
				realServerss = value;
				for (int i = 0; i < realServerss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RealServers." + (i + 1) , realServerss[i]);
				}
			}
		}

		public string ProxyTypes
		{
			get
			{
				return proxyTypes;
			}
			set	
			{
				proxyTypes = value;
				DictionaryUtil.Add(QueryParameters, "ProxyTypes", value);
			}
		}

		public List<string> InstanceIdss
		{
			get
			{
				return instanceIdss;
			}

			set
			{
				instanceIdss = value;
				for (int i = 0; i < instanceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceIds." + (i + 1) , instanceIdss[i]);
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

        public override ModifyWebRuleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyWebRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
