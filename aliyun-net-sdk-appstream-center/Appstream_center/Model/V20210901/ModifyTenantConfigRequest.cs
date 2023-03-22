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
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class ModifyTenantConfigRequest : RpcAcsRequest<ModifyTenantConfigResponse>
    {
        public ModifyTenantConfigRequest()
            : base("appstream-center", "2021-09-01", "ModifyTenantConfig")
        {
			Method = MethodType.POST;
        }

		private bool? appInstanceGroupExpireRemind;

		[JsonProperty(PropertyName = "AppInstanceGroupExpireRemind")]
		public bool? AppInstanceGroupExpireRemind
		{
			get
			{
				return appInstanceGroupExpireRemind;
			}
			set	
			{
				appInstanceGroupExpireRemind = value;
				DictionaryUtil.Add(BodyParameters, "AppInstanceGroupExpireRemind", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyTenantConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyTenantConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
