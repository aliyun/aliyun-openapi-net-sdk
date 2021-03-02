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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class UpdateGtmInstanceGlobalConfigRequest : RpcAcsRequest<UpdateGtmInstanceGlobalConfigResponse>
    {
        public UpdateGtmInstanceGlobalConfigRequest()
            : base("Alidns", "2015-01-09", "UpdateGtmInstanceGlobalConfig", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string alertGroup;

		private string cnameMode;

		private string lbaStrategy;

		private int? ttl;

		private string cnameCustomDomainName;

		private string instanceId;

		private string instanceName;

		private string userDomainName;

		private string lang;

		public string AlertGroup
		{
			get
			{
				return alertGroup;
			}
			set	
			{
				alertGroup = value;
				DictionaryUtil.Add(QueryParameters, "AlertGroup", value);
			}
		}

		public string CnameMode
		{
			get
			{
				return cnameMode;
			}
			set	
			{
				cnameMode = value;
				DictionaryUtil.Add(QueryParameters, "CnameMode", value);
			}
		}

		public string LbaStrategy
		{
			get
			{
				return lbaStrategy;
			}
			set	
			{
				lbaStrategy = value;
				DictionaryUtil.Add(QueryParameters, "LbaStrategy", value);
			}
		}

		public int? Ttl
		{
			get
			{
				return ttl;
			}
			set	
			{
				ttl = value;
				DictionaryUtil.Add(QueryParameters, "Ttl", value.ToString());
			}
		}

		public string CnameCustomDomainName
		{
			get
			{
				return cnameCustomDomainName;
			}
			set	
			{
				cnameCustomDomainName = value;
				DictionaryUtil.Add(QueryParameters, "CnameCustomDomainName", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public string UserDomainName
		{
			get
			{
				return userDomainName;
			}
			set	
			{
				userDomainName = value;
				DictionaryUtil.Add(QueryParameters, "UserDomainName", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override UpdateGtmInstanceGlobalConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateGtmInstanceGlobalConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
