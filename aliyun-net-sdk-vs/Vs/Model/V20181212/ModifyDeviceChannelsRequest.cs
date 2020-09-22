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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class ModifyDeviceChannelsRequest : RpcAcsRequest<ModifyDeviceChannelsResponse>
    {
        public ModifyDeviceChannelsRequest()
            : base("vs", "2018-12-12", "ModifyDeviceChannels", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string deviceStatus;

		private string id;

		private long? ownerId;

		private string channels;

		private string dsn;

		public string DeviceStatus
		{
			get
			{
				return deviceStatus;
			}
			set	
			{
				deviceStatus = value;
				DictionaryUtil.Add(QueryParameters, "DeviceStatus", value);
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Channels
		{
			get
			{
				return channels;
			}
			set	
			{
				channels = value;
				DictionaryUtil.Add(QueryParameters, "Channels", value);
			}
		}

		public string Dsn
		{
			get
			{
				return dsn;
			}
			set	
			{
				dsn = value;
				DictionaryUtil.Add(QueryParameters, "Dsn", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDeviceChannelsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDeviceChannelsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
