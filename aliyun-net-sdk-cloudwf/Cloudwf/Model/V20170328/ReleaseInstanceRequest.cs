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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class ReleaseInstanceRequest : RpcAcsRequest<ReleaseInstanceResponse>
    {
        public ReleaseInstanceRequest()
            : base("cloudwf", "2017-03-28", "ReleaseInstance", "cloudwf", "openAPI")
        {
        }

		private string traceId;

		private string spMsg;

		private string accessKeyId;

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
				DictionaryUtil.Add(QueryParameters, "TraceId", value);
			}
		}

		public string SpMsg
		{
			get
			{
				return spMsg;
			}
			set	
			{
				spMsg = value;
				DictionaryUtil.Add(QueryParameters, "SpMsg", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ReleaseInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ReleaseInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
