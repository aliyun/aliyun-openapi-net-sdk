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
using Aliyun.Acs.aliyuncvc.Transform;
using Aliyun.Acs.aliyuncvc.Transform.V20191030;

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
    public class UpdateDeviceHeartBeatRequest : RpcAcsRequest<UpdateDeviceHeartBeatResponse>
    {
        public UpdateDeviceHeartBeatRequest()
            : base("aliyuncvc", "2019-10-30", "UpdateDeviceHeartBeat", "aliyuncvc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.aliyuncvc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.aliyuncvc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string message;

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
				DictionaryUtil.Add(QueryParameters, "Message", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDeviceHeartBeatResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDeviceHeartBeatResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
