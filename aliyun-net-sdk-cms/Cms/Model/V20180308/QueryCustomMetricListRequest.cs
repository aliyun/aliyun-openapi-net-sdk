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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class QueryCustomMetricListRequest : RpcAcsRequest<QueryCustomMetricListResponse>
    {
        public QueryCustomMetricListRequest()
            : base("Cms", "2018-03-08", "QueryCustomMetricList", "cms", "openAPI")
        {
        }

		private string size;

		private string groupId;

		private string page;

		private string metricName;

		private string dimension;

		private string accessKeyId;

		private string md5;

		public string Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value);
			}
		}

		public string MetricName
		{
			get
			{
				return metricName;
			}
			set	
			{
				metricName = value;
				DictionaryUtil.Add(QueryParameters, "MetricName", value);
			}
		}

		public string Dimension
		{
			get
			{
				return dimension;
			}
			set	
			{
				dimension = value;
				DictionaryUtil.Add(QueryParameters, "Dimension", value);
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

		public string Md5
		{
			get
			{
				return md5;
			}
			set	
			{
				md5 = value;
				DictionaryUtil.Add(QueryParameters, "Md5", value);
			}
		}

        public override QueryCustomMetricListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryCustomMetricListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}