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
using Aliyun.Acs.LinkWAN.Transform;
using Aliyun.Acs.LinkWAN.Transform.V20190301;

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
    public class UpdateDataDispatchEnablingStateRequest : RpcAcsRequest<UpdateDataDispatchEnablingStateResponse>
    {
        public UpdateDataDispatchEnablingStateRequest()
            : base("LinkWAN", "2019-03-01", "UpdateDataDispatchEnablingState", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? dataDispatchEnabled;

		private string nodeGroupId;

		public bool? DataDispatchEnabled
		{
			get
			{
				return dataDispatchEnabled;
			}
			set	
			{
				dataDispatchEnabled = value;
				DictionaryUtil.Add(QueryParameters, "DataDispatchEnabled", value.ToString());
			}
		}

		public string NodeGroupId
		{
			get
			{
				return nodeGroupId;
			}
			set	
			{
				nodeGroupId = value;
				DictionaryUtil.Add(QueryParameters, "NodeGroupId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateDataDispatchEnablingStateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDataDispatchEnablingStateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
