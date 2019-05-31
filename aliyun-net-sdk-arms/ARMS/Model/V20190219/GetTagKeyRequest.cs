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
using Aliyun.Acs.ARMS.Transform;
using Aliyun.Acs.ARMS.Transform.V20190219;

namespace Aliyun.Acs.ARMS.Model.V20190219
{
    public class GetTagKeyRequest : RpcAcsRequest<GetTagKeyResponse>
    {
        public GetTagKeyRequest()
            : base("ARMS", "2019-02-19", "GetTagKey")
        {
        }

		private long? endTime;

		private string serviceName;

		private long? startTime;

		private string spanName;

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

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public string SpanName
		{
			get
			{
				return spanName;
			}
			set	
			{
				spanName = value;
				DictionaryUtil.Add(QueryParameters, "SpanName", value);
			}
		}

        public override GetTagKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTagKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
