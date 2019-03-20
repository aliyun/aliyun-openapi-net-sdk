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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class DescribeAlarmsRequest : RpcAcsRequest<DescribeAlarmsResponse>
    {
        public DescribeAlarmsRequest()
            : base("Cms", "2018-03-08", "DescribeAlarms", "cms", "openAPI")
        {
        }

		private bool? enableState;

		private string names;

		private string displayName;

		private string groupId;

		private string _namespace;

		private string pageSize;

		private string alertState;

		private string nameKeyword;

		private string groupBy;

		private string page;

		private string metricName;

		public bool? EnableState
		{
			get
			{
				return enableState;
			}
			set	
			{
				enableState = value;
				DictionaryUtil.Add(QueryParameters, "EnableState", value.ToString());
			}
		}

		public string Names
		{
			get
			{
				return names;
			}
			set	
			{
				names = value;
				DictionaryUtil.Add(QueryParameters, "Names", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(QueryParameters, "DisplayName", value);
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

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public string AlertState
		{
			get
			{
				return alertState;
			}
			set	
			{
				alertState = value;
				DictionaryUtil.Add(QueryParameters, "AlertState", value);
			}
		}

		public string NameKeyword
		{
			get
			{
				return nameKeyword;
			}
			set	
			{
				nameKeyword = value;
				DictionaryUtil.Add(QueryParameters, "NameKeyword", value);
			}
		}

		public string GroupBy
		{
			get
			{
				return groupBy;
			}
			set	
			{
				groupBy = value;
				DictionaryUtil.Add(QueryParameters, "GroupBy", value);
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

        public override DescribeAlarmsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAlarmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
