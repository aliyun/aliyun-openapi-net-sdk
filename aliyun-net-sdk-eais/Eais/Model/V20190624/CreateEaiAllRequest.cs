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
using Aliyun.Acs.eais.Transform;
using Aliyun.Acs.eais.Transform.V20190624;

namespace Aliyun.Acs.eais.Model.V20190624
{
    public class CreateEaiAllRequest : RpcAcsRequest<CreateEaiAllResponse>
    {
        public CreateEaiAllRequest()
            : base("eais", "2019-06-24", "CreateEaiAll", "eais", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eais.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eais.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientImageId;

		private string clientSystemDiskCategory;

		private int? clientInternetMaxBandwidthOut;

		private string clientToken;

		private string clientInstanceName;

		private int? clientInternetMaxBandwidthIn;

		private int? clientSystemDiskSize;

		private string clientVSwitchId;

		private string clientPassword;

		private string clientInstanceType;

		private string clientSecurityGroupId;

		private string eaiInstanceType;

		private string clientZoneId;

		private string instanceName;

		public string ClientImageId
		{
			get
			{
				return clientImageId;
			}
			set	
			{
				clientImageId = value;
				DictionaryUtil.Add(QueryParameters, "ClientImageId", value);
			}
		}

		public string ClientSystemDiskCategory
		{
			get
			{
				return clientSystemDiskCategory;
			}
			set	
			{
				clientSystemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "ClientSystemDiskCategory", value);
			}
		}

		public int? ClientInternetMaxBandwidthOut
		{
			get
			{
				return clientInternetMaxBandwidthOut;
			}
			set	
			{
				clientInternetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "ClientInternetMaxBandwidthOut", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string ClientInstanceName
		{
			get
			{
				return clientInstanceName;
			}
			set	
			{
				clientInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "ClientInstanceName", value);
			}
		}

		public int? ClientInternetMaxBandwidthIn
		{
			get
			{
				return clientInternetMaxBandwidthIn;
			}
			set	
			{
				clientInternetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "ClientInternetMaxBandwidthIn", value.ToString());
			}
		}

		public int? ClientSystemDiskSize
		{
			get
			{
				return clientSystemDiskSize;
			}
			set	
			{
				clientSystemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "ClientSystemDiskSize", value.ToString());
			}
		}

		public string ClientVSwitchId
		{
			get
			{
				return clientVSwitchId;
			}
			set	
			{
				clientVSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "ClientVSwitchId", value);
			}
		}

		public string ClientPassword
		{
			get
			{
				return clientPassword;
			}
			set	
			{
				clientPassword = value;
				DictionaryUtil.Add(QueryParameters, "ClientPassword", value);
			}
		}

		public string ClientInstanceType
		{
			get
			{
				return clientInstanceType;
			}
			set	
			{
				clientInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "ClientInstanceType", value);
			}
		}

		public string ClientSecurityGroupId
		{
			get
			{
				return clientSecurityGroupId;
			}
			set	
			{
				clientSecurityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ClientSecurityGroupId", value);
			}
		}

		public string EaiInstanceType
		{
			get
			{
				return eaiInstanceType;
			}
			set	
			{
				eaiInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "EaiInstanceType", value);
			}
		}

		public string ClientZoneId
		{
			get
			{
				return clientZoneId;
			}
			set	
			{
				clientZoneId = value;
				DictionaryUtil.Add(QueryParameters, "ClientZoneId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateEaiAllResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateEaiAllResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
