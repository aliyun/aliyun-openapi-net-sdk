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
    public class CreateTenantRequest : RpcAcsRequest<CreateTenantResponse>
    {
        public CreateTenantRequest()
            : base("OceanBasePro", "2019-09-01", "CreateTenant", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string charset;

		private string tenantMode;

		private int? memory;

		private long? logDisk;

		private string timeZone;

		private string description;

		private string userVSwitchId;

		private string userVpcId;

		private int? cpu;

		private int? unitNum;

		private string instanceId;

		private string primaryZone;

		private string tenantName;

		private string readOnlyZoneList;

		[JsonProperty(PropertyName = "Charset")]
		public string Charset
		{
			get
			{
				return charset;
			}
			set	
			{
				charset = value;
				DictionaryUtil.Add(BodyParameters, "Charset", value);
			}
		}

		[JsonProperty(PropertyName = "TenantMode")]
		public string TenantMode
		{
			get
			{
				return tenantMode;
			}
			set	
			{
				tenantMode = value;
				DictionaryUtil.Add(BodyParameters, "TenantMode", value);
			}
		}

		[JsonProperty(PropertyName = "Memory")]
		public int? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(BodyParameters, "Memory", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "LogDisk")]
		public long? LogDisk
		{
			get
			{
				return logDisk;
			}
			set	
			{
				logDisk = value;
				DictionaryUtil.Add(BodyParameters, "LogDisk", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TimeZone")]
		public string TimeZone
		{
			get
			{
				return timeZone;
			}
			set	
			{
				timeZone = value;
				DictionaryUtil.Add(BodyParameters, "TimeZone", value);
			}
		}

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "UserVpcId")]
		public string UserVpcId
		{
			get
			{
				return userVpcId;
			}
			set	
			{
				userVpcId = value;
				DictionaryUtil.Add(BodyParameters, "UserVpcId", value);
			}
		}

		[JsonProperty(PropertyName = "Cpu")]
		public int? Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
				DictionaryUtil.Add(BodyParameters, "Cpu", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UnitNum")]
		public int? UnitNum
		{
			get
			{
				return unitNum;
			}
			set	
			{
				unitNum = value;
				DictionaryUtil.Add(BodyParameters, "UnitNum", value.ToString());
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

		[JsonProperty(PropertyName = "TenantName")]
		public string TenantName
		{
			get
			{
				return tenantName;
			}
			set	
			{
				tenantName = value;
				DictionaryUtil.Add(BodyParameters, "TenantName", value);
			}
		}

		[JsonProperty(PropertyName = "ReadOnlyZoneList")]
		public string ReadOnlyZoneList
		{
			get
			{
				return readOnlyZoneList;
			}
			set	
			{
				readOnlyZoneList = value;
				DictionaryUtil.Add(BodyParameters, "ReadOnlyZoneList", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTenantResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTenantResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
