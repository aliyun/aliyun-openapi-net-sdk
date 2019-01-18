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
using Aliyun.Acs.TeslaDam.Transform;
using Aliyun.Acs.TeslaDam.Transform.V20180118;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaDam.Model.V20180118
{
    public class HostGetsRequest : RpcAcsRequest<HostGetsResponse>
    {
        public HostGetsRequest()
            : base("TeslaDam", "2018-01-18", "HostGets")
        {
        }

		private string query;

		private int? endTime;

		private int? startTime;

		private string queryType;

		public string Query
		{
			get
			{
				return query;
			}
			set	
			{
				query = value;
				DictionaryUtil.Add(QueryParameters, "Query", value);
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

		public int? StartTime
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

		public string QueryType
		{
			get
			{
				return queryType;
			}
			set	
			{
				queryType = value;
				DictionaryUtil.Add(QueryParameters, "QueryType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override HostGetsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return HostGetsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}