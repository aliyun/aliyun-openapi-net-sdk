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
    public class ModifyInstanceTemporaryCapacityRequest : RpcAcsRequest<ModifyInstanceTemporaryCapacityResponse>
    {
        public ModifyInstanceTemporaryCapacityRequest()
            : base("OceanBasePro", "2019-09-01", "ModifyInstanceTemporaryCapacity", "oceanbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OceanBasePro.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string diskSize;

		private string spec;

		private string instanceId;

		private string acceptLanguage;

		[JsonProperty(PropertyName = "DiskSize")]
		public string DiskSize
		{
			get
			{
				return diskSize;
			}
			set	
			{
				diskSize = value;
				DictionaryUtil.Add(BodyParameters, "DiskSize", value);
			}
		}

		[JsonProperty(PropertyName = "Spec")]
		public string Spec
		{
			get
			{
				return spec;
			}
			set	
			{
				spec = value;
				DictionaryUtil.Add(BodyParameters, "Spec", value);
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

		[JsonProperty(PropertyName = "AcceptLanguage")]
		public string AcceptLanguage
		{
			get
			{
				return acceptLanguage;
			}
			set	
			{
				acceptLanguage = value;
				DictionaryUtil.Add(BodyParameters, "AcceptLanguage", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyInstanceTemporaryCapacityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceTemporaryCapacityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
