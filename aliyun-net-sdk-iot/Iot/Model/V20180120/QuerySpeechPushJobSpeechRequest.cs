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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class QuerySpeechPushJobSpeechRequest : RpcAcsRequest<QuerySpeechPushJobSpeechResponse>
    {
        public QuerySpeechPushJobSpeechRequest()
            : base("Iot", "2018-01-20", "QuerySpeechPushJobSpeech", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageId;

		private string iotInstanceId;

		private int? pageSize;

		private string jobCode;

		public int? PageId
		{
			get
			{
				return pageId;
			}
			set	
			{
				pageId = value;
				DictionaryUtil.Add(BodyParameters, "PageId", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "IotInstanceId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string JobCode
		{
			get
			{
				return jobCode;
			}
			set	
			{
				jobCode = value;
				DictionaryUtil.Add(BodyParameters, "JobCode", value);
			}
		}

        public override QuerySpeechPushJobSpeechResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QuerySpeechPushJobSpeechResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
