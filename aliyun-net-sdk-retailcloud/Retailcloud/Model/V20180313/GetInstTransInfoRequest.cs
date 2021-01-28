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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class GetInstTransInfoRequest : RpcAcsRequest<GetInstTransInfoResponse>
    {
        public GetInstTransInfoRequest()
            : base("retailcloud", "2018-03-13", "GetInstTransInfo", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string aliyunUid;

		private string aliyunEquipId;

		private string aliyunCommodityCode;

		public string AliyunUid
		{
			get
			{
				return aliyunUid;
			}
			set	
			{
				aliyunUid = value;
				DictionaryUtil.Add(BodyParameters, "aliyunUid", value);
			}
		}

		public string AliyunEquipId
		{
			get
			{
				return aliyunEquipId;
			}
			set	
			{
				aliyunEquipId = value;
				DictionaryUtil.Add(BodyParameters, "aliyunEquipId", value);
			}
		}

		public string AliyunCommodityCode
		{
			get
			{
				return aliyunCommodityCode;
			}
			set	
			{
				aliyunCommodityCode = value;
				DictionaryUtil.Add(BodyParameters, "aliyunCommodityCode", value);
			}
		}

        public override GetInstTransInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetInstTransInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
