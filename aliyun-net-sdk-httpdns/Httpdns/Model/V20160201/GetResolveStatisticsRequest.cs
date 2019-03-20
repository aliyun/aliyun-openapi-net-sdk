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
using Aliyun.Acs.Httpdns.Transform;
using Aliyun.Acs.Httpdns.Transform.V20160201;

namespace Aliyun.Acs.Httpdns.Model.V20160201
{
    public class GetResolveStatisticsRequest : RpcAcsRequest<GetResolveStatisticsResponse>
    {
        public GetResolveStatisticsRequest()
            : base("Httpdns", "2016-02-01", "GetResolveStatistics", "httpdns", "openAPI")
        {
        }

		private string granularity;

		private string protocolName;

		private string domainName;

		private int? timeSpan;

		private string accessKeyId;

		public string Granularity
		{
			get
			{
				return granularity;
			}
			set	
			{
				granularity = value;
				DictionaryUtil.Add(QueryParameters, "Granularity", value);
			}
		}

		public string ProtocolName
		{
			get
			{
				return protocolName;
			}
			set	
			{
				protocolName = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolName", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public int? TimeSpan
		{
			get
			{
				return timeSpan;
			}
			set	
			{
				timeSpan = value;
				DictionaryUtil.Add(QueryParameters, "TimeSpan", value.ToString());
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

        public override GetResolveStatisticsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetResolveStatisticsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
