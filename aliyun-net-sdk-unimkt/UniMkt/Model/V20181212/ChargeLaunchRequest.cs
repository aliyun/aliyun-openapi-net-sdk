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
    public class ChargeLaunchRequest : RpcAcsRequest<ChargeLaunchResponse>
    {
        public ChargeLaunchRequest()
            : base("UniMkt", "2018-12-12", "ChargeLaunch", "1.0.0", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extra;

		private string alipayOpenId;

		private string channelId;

		private string outerCode;

		public string Extra
		{
			get
			{
				return extra;
			}
			set	
			{
				extra = value;
				DictionaryUtil.Add(QueryParameters, "Extra", value);
			}
		}

		public string AlipayOpenId
		{
			get
			{
				return alipayOpenId;
			}
			set	
			{
				alipayOpenId = value;
				DictionaryUtil.Add(QueryParameters, "AlipayOpenId", value);
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
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public string OuterCode
		{
			get
			{
				return outerCode;
			}
			set	
			{
				outerCode = value;
				DictionaryUtil.Add(QueryParameters, "OuterCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ChargeLaunchResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChargeLaunchResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
