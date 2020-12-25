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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class SearchLogRequest : RpcAcsRequest<SearchLogResponse>
    {
        public SearchLogRequest()
            : base("Emr", "2016-04-08", "SearchLog", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? line;

		private string hostName;

		private string logstoreName;

		private int? fromTimestamp;

		private int? offset;

		private string clusterId;

		private bool? reverse;

		private string hostInnerIp;

		private int? toTimestamp;

		private string slsQueryString;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? Line
		{
			get
			{
				return line;
			}
			set	
			{
				line = value;
				DictionaryUtil.Add(QueryParameters, "Line", value.ToString());
			}
		}

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public string LogstoreName
		{
			get
			{
				return logstoreName;
			}
			set	
			{
				logstoreName = value;
				DictionaryUtil.Add(QueryParameters, "LogstoreName", value);
			}
		}

		public int? FromTimestamp
		{
			get
			{
				return fromTimestamp;
			}
			set	
			{
				fromTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "FromTimestamp", value.ToString());
			}
		}

		public int? Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(QueryParameters, "Offset", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(QueryParameters, "Reverse", value.ToString());
			}
		}

		public string HostInnerIp
		{
			get
			{
				return hostInnerIp;
			}
			set	
			{
				hostInnerIp = value;
				DictionaryUtil.Add(QueryParameters, "HostInnerIp", value);
			}
		}

		public int? ToTimestamp
		{
			get
			{
				return toTimestamp;
			}
			set	
			{
				toTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "ToTimestamp", value.ToString());
			}
		}

		public string SlsQueryString
		{
			get
			{
				return slsQueryString;
			}
			set	
			{
				slsQueryString = value;
				DictionaryUtil.Add(QueryParameters, "SlsQueryString", value);
			}
		}

        public override SearchLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
