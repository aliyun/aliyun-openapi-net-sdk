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
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class CreateOceanBaseDataSourceRequest : RpcAcsRequest<CreateOceanBaseDataSourceResponse>
    {
        public CreateOceanBaseDataSourceRequest()
            : base("OceanBasePro", "2019-09-01", "CreateOceanBaseDataSource", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string cluster;

		private string drcUserName;

		private string logProxyIp;

		private string description;

		private string type;

		private string password;

		private string innerDrcPassword;

		private string tenant;

		private string configUrl;

		private string ip;

		private int? port;

		private string vpcId;

		private string name;

		private string drcPassword;

		private string logProxyPort;

		private string userName;

		public string Cluster
		{
			get
			{
				return cluster;
			}
			set	
			{
				cluster = value;
				DictionaryUtil.Add(BodyParameters, "Cluster", value);
			}
		}

		public string DrcUserName
		{
			get
			{
				return drcUserName;
			}
			set	
			{
				drcUserName = value;
				DictionaryUtil.Add(BodyParameters, "DrcUserName", value);
			}
		}

		public string LogProxyIp
		{
			get
			{
				return logProxyIp;
			}
			set	
			{
				logProxyIp = value;
				DictionaryUtil.Add(BodyParameters, "LogProxyIp", value);
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
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(BodyParameters, "Password", value);
			}
		}

		public string InnerDrcPassword
		{
			get
			{
				return innerDrcPassword;
			}
			set	
			{
				innerDrcPassword = value;
				DictionaryUtil.Add(BodyParameters, "InnerDrcPassword", value);
			}
		}

		public string Tenant
		{
			get
			{
				return tenant;
			}
			set	
			{
				tenant = value;
				DictionaryUtil.Add(BodyParameters, "Tenant", value);
			}
		}

		public string ConfigUrl
		{
			get
			{
				return configUrl;
			}
			set	
			{
				configUrl = value;
				DictionaryUtil.Add(BodyParameters, "ConfigUrl", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(BodyParameters, "Ip", value);
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(BodyParameters, "Port", value.ToString());
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string DrcPassword
		{
			get
			{
				return drcPassword;
			}
			set	
			{
				drcPassword = value;
				DictionaryUtil.Add(BodyParameters, "DrcPassword", value);
			}
		}

		public string LogProxyPort
		{
			get
			{
				return logProxyPort;
			}
			set	
			{
				logProxyPort = value;
				DictionaryUtil.Add(BodyParameters, "LogProxyPort", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(BodyParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOceanBaseDataSourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOceanBaseDataSourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
