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
using Aliyun.Acs.alikafka.Transform;
using Aliyun.Acs.alikafka.Transform.V20190916;

namespace Aliyun.Acs.alikafka.Model.V20190916
{
    public class StartInstanceRequest : RpcAcsRequest<StartInstanceResponse>
    {
        public StartInstanceRequest()
            : base("alikafka", "2019-09-16", "StartInstance", "alikafka", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string selectedZones;

		private bool? isEipInner;

		private string securityGroup;

		private string deployModule;

		private bool? isSetUserAndPassword;

		private string password;

		private string notifier;

		private bool? isForceSelectedZones;

		private string vSwitchId;

		private string userPhoneNum;

		private string instanceId;

		private string vpcId;

		private string name;

		private string serviceVersion;

		private string zoneId;

		private string kMSKeyId;

		private string config;

		private string username;

		public string SelectedZones
		{
			get
			{
				return selectedZones;
			}
			set	
			{
				selectedZones = value;
				DictionaryUtil.Add(QueryParameters, "SelectedZones", value);
			}
		}

		public bool? IsEipInner
		{
			get
			{
				return isEipInner;
			}
			set	
			{
				isEipInner = value;
				DictionaryUtil.Add(QueryParameters, "IsEipInner", value.ToString());
			}
		}

		public string SecurityGroup
		{
			get
			{
				return securityGroup;
			}
			set	
			{
				securityGroup = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroup", value);
			}
		}

		public string DeployModule
		{
			get
			{
				return deployModule;
			}
			set	
			{
				deployModule = value;
				DictionaryUtil.Add(QueryParameters, "DeployModule", value);
			}
		}

		public bool? IsSetUserAndPassword
		{
			get
			{
				return isSetUserAndPassword;
			}
			set	
			{
				isSetUserAndPassword = value;
				DictionaryUtil.Add(QueryParameters, "IsSetUserAndPassword", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string Notifier
		{
			get
			{
				return notifier;
			}
			set	
			{
				notifier = value;
				DictionaryUtil.Add(QueryParameters, "Notifier", value);
			}
		}

		public bool? IsForceSelectedZones
		{
			get
			{
				return isForceSelectedZones;
			}
			set	
			{
				isForceSelectedZones = value;
				DictionaryUtil.Add(QueryParameters, "IsForceSelectedZones", value.ToString());
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string UserPhoneNum
		{
			get
			{
				return userPhoneNum;
			}
			set	
			{
				userPhoneNum = value;
				DictionaryUtil.Add(QueryParameters, "UserPhoneNum", value);
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

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
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

		public string ServiceVersion
		{
			get
			{
				return serviceVersion;
			}
			set	
			{
				serviceVersion = value;
				DictionaryUtil.Add(QueryParameters, "ServiceVersion", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string KMSKeyId
		{
			get
			{
				return kMSKeyId;
			}
			set	
			{
				kMSKeyId = value;
				DictionaryUtil.Add(QueryParameters, "KMSKeyId", value);
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
				DictionaryUtil.Add(QueryParameters, "Config", value);
			}
		}

		public string Username
		{
			get
			{
				return username;
			}
			set	
			{
				username = value;
				DictionaryUtil.Add(QueryParameters, "Username", value);
			}
		}

        public override StartInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
