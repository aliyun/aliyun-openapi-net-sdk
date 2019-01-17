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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudAPI.Transform;
using Aliyun.Acs.CloudAPI.Transform.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
    public class CreateIpControlRequest : RpcAcsRequest<CreateIpControlResponse>
    {
        public CreateIpControlRequest()
            : base("CloudAPI", "2016-07-14", "CreateIpControl", "apigateway", "openAPI")
        {
        }

		private string securityToken;

		private string ipControlName;

		private string ipControlType;

		private List<IpControlPolicys> ipControlPolicyss;

		private string action;

		private string description;

		private string accessKeyId;

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string IpControlName
		{
			get
			{
				return ipControlName;
			}
			set	
			{
				ipControlName = value;
				DictionaryUtil.Add(QueryParameters, "IpControlName", value);
			}
		}

		public string IpControlType
		{
			get
			{
				return ipControlType;
			}
			set	
			{
				ipControlType = value;
				DictionaryUtil.Add(QueryParameters, "IpControlType", value);
			}
		}

		public List<IpControlPolicys> IpControlPolicyss
		{
			get
			{
				return ipControlPolicyss;
			}

			set
			{
				ipControlPolicyss = value;
				for (int i = 0; i < ipControlPolicyss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IpControlPolicys." + (i + 1) + ".AppId", ipControlPolicyss[i].AppId);
					DictionaryUtil.Add(QueryParameters,"IpControlPolicys." + (i + 1) + ".CidrIp", ipControlPolicyss[i].CidrIp);
				}
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public class IpControlPolicys
		{

			private string appId;

			private string cidrIp;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string CidrIp
			{
				get
				{
					return cidrIp;
				}
				set	
				{
					cidrIp = value;
				}
			}
		}

        public override CreateIpControlResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateIpControlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}