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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class PushFaultEventRequest : RpcAcsRequest<PushFaultEventResponse>
    {
        public PushFaultEventRequest()
            : base("UniMkt", "2018-12-12", "PushFaultEvent", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string faultComment;

		private long? time;

		private int? type;

		private string deviceSn;

		private string channelId;

		private string faultType;

		public string FaultComment
		{
			get
			{
				return faultComment;
			}
			set	
			{
				faultComment = value;
				DictionaryUtil.Add(BodyParameters, "FaultComment", value);
			}
		}

		public long? Time
		{
			get
			{
				return time;
			}
			set	
			{
				time = value;
				DictionaryUtil.Add(BodyParameters, "Time", value.ToString());
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value.ToString());
			}
		}

		public string DeviceSn
		{
			get
			{
				return deviceSn;
			}
			set	
			{
				deviceSn = value;
				DictionaryUtil.Add(BodyParameters, "DeviceSn", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(BodyParameters, "ChannelId", value);
			}
		}

		public string FaultType
		{
			get
			{
				return faultType;
			}
			set	
			{
				faultType = value;
				DictionaryUtil.Add(BodyParameters, "FaultType", value);
			}
		}

        public override PushFaultEventResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushFaultEventResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
