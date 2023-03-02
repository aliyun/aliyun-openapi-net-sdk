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
using Aliyun.Acs.lto;
using Aliyun.Acs.lto.Transform;
using Aliyun.Acs.lto.Transform.V20210707;

namespace Aliyun.Acs.lto.Model.V20210707
{
    public class DisableDeviceGroupRequest : RpcAcsRequest<DisableDeviceGroupResponse>
    {
        public DisableDeviceGroupRequest()
            : base("lto", "2021-07-07", "DisableDeviceGroup")
        {
			Method = MethodType.POST;
        }

		private string deviceGroupId;

		public string DeviceGroupId
		{
			get
			{
				return deviceGroupId;
			}
			set	
			{
				deviceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceGroupId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DisableDeviceGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DisableDeviceGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
