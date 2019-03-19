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
    public class GetCrowdListRequest : RpcAcsRequest<GetCrowdListResponse>
    {
        public GetCrowdListRequest()
            : base("cloudwf", "2017-03-28", "GetCrowdList", "cloudwf", "openAPI")
        {
        }

		private long? gsid;

		private int? classType;

		private string gsType;

		private string endTime;

		private int? page;

		private string startTime;

		private int? per;

		private long? bid;

		private string accessKeyId;

		public long? Gsid
		{
			get
			{
				return gsid;
			}
			set	
			{
				gsid = value;
				DictionaryUtil.Add(QueryParameters, "Gsid", value.ToString());
			}
		}

		public int? ClassType
		{
			get
			{
				return classType;
			}
			set	
			{
				classType = value;
				DictionaryUtil.Add(QueryParameters, "ClassType", value.ToString());
			}
		}

		public string GsType
		{
			get
			{
				return gsType;
			}
			set	
			{
				gsType = value;
				DictionaryUtil.Add(QueryParameters, "GsType", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value.ToString());
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public int? Per
		{
			get
			{
				return per;
			}
			set	
			{
				per = value;
				DictionaryUtil.Add(QueryParameters, "Per", value.ToString());
			}
		}

		public long? Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value.ToString());
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

        public override GetCrowdListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetCrowdListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
