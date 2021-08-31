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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class BindEcsSlbRequest : RoaAcsRequest<BindEcsSlbResponse>
    {
        public BindEcsSlbRequest()
            : base("Edas", "2017-08-01", "BindEcsSlb", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/app/slb/bind_slb";
			Method = MethodType.POST;
        }

		private string vServerGroupId;

		private int? listenerPort;

		private string vForwardingUrlRule;

		private string slbId;

		private string deployGroupId;

		private string listenerHealthCheckUrl;

		private string appId;

		private string listenerProtocol;

		private string vServerGroupName;

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroupId", value);
			}
		}

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public string VForwardingUrlRule
		{
			get
			{
				return vForwardingUrlRule;
			}
			set	
			{
				vForwardingUrlRule = value;
				DictionaryUtil.Add(QueryParameters, "VForwardingUrlRule", value);
			}
		}

		public string SlbId
		{
			get
			{
				return slbId;
			}
			set	
			{
				slbId = value;
				DictionaryUtil.Add(QueryParameters, "SlbId", value);
			}
		}

		public string DeployGroupId
		{
			get
			{
				return deployGroupId;
			}
			set	
			{
				deployGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DeployGroupId", value);
			}
		}

		public string ListenerHealthCheckUrl
		{
			get
			{
				return listenerHealthCheckUrl;
			}
			set	
			{
				listenerHealthCheckUrl = value;
				DictionaryUtil.Add(QueryParameters, "ListenerHealthCheckUrl", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string ListenerProtocol
		{
			get
			{
				return listenerProtocol;
			}
			set	
			{
				listenerProtocol = value;
				DictionaryUtil.Add(QueryParameters, "ListenerProtocol", value);
			}
		}

		public string VServerGroupName
		{
			get
			{
				return vServerGroupName;
			}
			set	
			{
				vServerGroupName = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroupName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BindEcsSlbResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BindEcsSlbResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
