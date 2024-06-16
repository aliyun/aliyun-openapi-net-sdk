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
    public class ModifyInstanceSpecRequest : RpcAcsRequest<ModifyInstanceSpecResponse>
    {
        public ModifyInstanceSpecRequest()
            : base("OceanBasePro", "2019-09-01", "ModifyInstanceSpec", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string instanceClass;

		private bool? dryRun;

		private long? diskSize;

		private string diskType;

		private string instanceId;

		[JsonProperty(PropertyName = "InstanceClass")]
		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(BodyParameters, "InstanceClass", value);
			}
		}

		[JsonProperty(PropertyName = "DryRun")]
		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(BodyParameters, "DryRun", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DiskSize")]
		public long? DiskSize
		{
			get
			{
				return diskSize;
			}
			set	
			{
				diskSize = value;
				DictionaryUtil.Add(BodyParameters, "DiskSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DiskType")]
		public string DiskType
		{
			get
			{
				return diskType;
			}
			set	
			{
				diskType = value;
				DictionaryUtil.Add(BodyParameters, "DiskType", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyInstanceSpecResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceSpecResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
