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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class GetLogsRequest : RpcAcsRequest<GetLogsResponse>
    {
        public GetLogsRequest()
            : base("cloud-siem", "2022-06-16", "GetLogs", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? total;

		private int? pageSize;

		private int? from;

		private int? pageIndex;

		private bool? reverseOrNot;

		private string query;

		private int? to;

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
				DictionaryUtil.Add(BodyParameters, "Total", value.ToString());
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

		public int? From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(BodyParameters, "From", value.ToString());
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(BodyParameters, "PageIndex", value.ToString());
			}
		}

		public bool? ReverseOrNot
		{
			get
			{
				return reverseOrNot;
			}
			set	
			{
				reverseOrNot = value;
				DictionaryUtil.Add(BodyParameters, "ReverseOrNot", value.ToString());
			}
		}

		public string Query
		{
			get
			{
				return query;
			}
			set	
			{
				query = value;
				DictionaryUtil.Add(BodyParameters, "Query", value);
			}
		}

		public int? To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(BodyParameters, "To", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetLogsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetLogsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
