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
    public class GetNodeTransferPacketRequest : RpcAcsRequest<GetNodeTransferPacketResponse>
    {
        public GetNodeTransferPacketRequest()
            : base("LinkWAN", "2019-03-01", "GetNodeTransferPacket", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string base64EncodedMacPayload;

		private string iotInstanceId;

		private long? logMillis;

		private string devEui;

		public string Base64EncodedMacPayload
		{
			get
			{
				return base64EncodedMacPayload;
			}
			set	
			{
				base64EncodedMacPayload = value;
				DictionaryUtil.Add(QueryParameters, "Base64EncodedMacPayload", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public long? LogMillis
		{
			get
			{
				return logMillis;
			}
			set	
			{
				logMillis = value;
				DictionaryUtil.Add(QueryParameters, "LogMillis", value.ToString());
			}
		}

		public string DevEui
		{
			get
			{
				return devEui;
			}
			set	
			{
				devEui = value;
				DictionaryUtil.Add(QueryParameters, "DevEui", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetNodeTransferPacketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetNodeTransferPacketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
