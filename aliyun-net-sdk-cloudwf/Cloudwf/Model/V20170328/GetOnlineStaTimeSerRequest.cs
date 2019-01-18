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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class GetOnlineStaTimeSerRequest : RpcAcsRequest<GetOnlineStaTimeSerResponse>
    {
        public GetOnlineStaTimeSerRequest()
            : base("cloudwf", "2017-03-28", "GetOnlineStaTimeSer")
        {
        }

		private long? zoomStart;

		private long? companyId;

		private long? apgroupId;

		private long? start;

		private long? zoomEnd;

		private long? end;

		private string accessKeyId;

		public long? ZoomStart
		{
			get
			{
				return zoomStart;
			}
			set	
			{
				zoomStart = value;
				DictionaryUtil.Add(QueryParameters, "ZoomStart", value.ToString());
			}
		}

		public long? CompanyId
		{
			get
			{
				return companyId;
			}
			set	
			{
				companyId = value;
				DictionaryUtil.Add(QueryParameters, "CompanyId", value.ToString());
			}
		}

		public long? ApgroupId
		{
			get
			{
				return apgroupId;
			}
			set	
			{
				apgroupId = value;
				DictionaryUtil.Add(QueryParameters, "ApgroupId", value.ToString());
			}
		}

		public long? Start
		{
			get
			{
				return start;
			}
			set	
			{
				start = value;
				DictionaryUtil.Add(QueryParameters, "Start", value.ToString());
			}
		}

		public long? ZoomEnd
		{
			get
			{
				return zoomEnd;
			}
			set	
			{
				zoomEnd = value;
				DictionaryUtil.Add(QueryParameters, "ZoomEnd", value.ToString());
			}
		}

		public long? End
		{
			get
			{
				return end;
			}
			set	
			{
				end = value;
				DictionaryUtil.Add(QueryParameters, "End", value.ToString());
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

        public override GetOnlineStaTimeSerResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetOnlineStaTimeSerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}