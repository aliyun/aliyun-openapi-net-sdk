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
using Aliyun.Acs.nis.Transform;
using Aliyun.Acs.nis.Transform.V20211216;

namespace Aliyun.Acs.nis.Model.V20211216
{
    public class GetNatTopNRequest : RpcAcsRequest<GetNatTopNResponse>
    {
        public GetNatTopNRequest()
            : base("nis", "2021-12-16", "GetNatTopN", "networkana", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string ip;

		private long? endTime;

		private string orderBy;

		private long? beginTime;

		private int? topN;

		private string natGatewayId;

		[JsonProperty(PropertyName = "Ip")]
		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OrderBy")]
		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		[JsonProperty(PropertyName = "BeginTime")]
		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TopN")]
		public int? TopN
		{
			get
			{
				return topN;
			}
			set	
			{
				topN = value;
				DictionaryUtil.Add(QueryParameters, "TopN", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NatGatewayId")]
		public string NatGatewayId
		{
			get
			{
				return natGatewayId;
			}
			set	
			{
				natGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "NatGatewayId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetNatTopNResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetNatTopNResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
