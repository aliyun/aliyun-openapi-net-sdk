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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.OceanBasePro.Transform;
using Aliyun.Acs.OceanBasePro.Transform.V20190901;

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
    public class ModifyTenantPrimaryZoneRequest : RpcAcsRequest<ModifyTenantPrimaryZoneResponse>
    {
        public ModifyTenantPrimaryZoneRequest()
            : base("OceanBasePro", "2019-09-01", "ModifyTenantPrimaryZone", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userVSwitchId;

		private string masterIntranetAddressZone;

		private string tenantId;

		private string tenantEndpointId;

		private string instanceId;

		private string primaryZone;

		[JsonProperty(PropertyName = "UserVSwitchId")]
		public string UserVSwitchId
		{
			get
			{
				return userVSwitchId;
			}
			set	
			{
				userVSwitchId = value;
				DictionaryUtil.Add(BodyParameters, "UserVSwitchId", value);
			}
		}

		[JsonProperty(PropertyName = "MasterIntranetAddressZone")]
		public string MasterIntranetAddressZone
		{
			get
			{
				return masterIntranetAddressZone;
			}
			set	
			{
				masterIntranetAddressZone = value;
				DictionaryUtil.Add(BodyParameters, "MasterIntranetAddressZone", value);
			}
		}

		[JsonProperty(PropertyName = "TenantId")]
		public string TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(BodyParameters, "TenantId", value);
			}
		}

		[JsonProperty(PropertyName = "TenantEndpointId")]
		public string TenantEndpointId
		{
			get
			{
				return tenantEndpointId;
			}
			set	
			{
				tenantEndpointId = value;
				DictionaryUtil.Add(BodyParameters, "TenantEndpointId", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "PrimaryZone")]
		public string PrimaryZone
		{
			get
			{
				return primaryZone;
			}
			set	
			{
				primaryZone = value;
				DictionaryUtil.Add(BodyParameters, "PrimaryZone", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyTenantPrimaryZoneResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyTenantPrimaryZoneResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
