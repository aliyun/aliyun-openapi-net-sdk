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
using Aliyun.Acs.Linkvisual.Transform;
using Aliyun.Acs.Linkvisual.Transform.V20180120;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
    public class QueryRecordUrlByTimeRequest : RpcAcsRequest<QueryRecordUrlByTimeResponse>
    {
        public QueryRecordUrlByTimeRequest()
            : base("Linkvisual", "2018-01-20", "QueryRecordUrlByTime", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotId;

		private string iotInstanceId;

		private int? streamType;

		private int? endTime;

		private int? beginTime;

		private string productKey;

		private string deviceName;

		private int? urlValidDuration;

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
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

		public int? StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(QueryParameters, "StreamType", value.ToString());
			}
		}

		public int? EndTime
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

		public int? BeginTime
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

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public int? UrlValidDuration
		{
			get
			{
				return urlValidDuration;
			}
			set	
			{
				urlValidDuration = value;
				DictionaryUtil.Add(QueryParameters, "UrlValidDuration", value.ToString());
			}
		}

        public override QueryRecordUrlByTimeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryRecordUrlByTimeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
