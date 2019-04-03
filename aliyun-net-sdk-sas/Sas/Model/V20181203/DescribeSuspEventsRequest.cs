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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeSuspEventsRequest : RpcAcsRequest<DescribeSuspEventsResponse>
    {
        public DescribeSuspEventsRequest()
            : base("Sas", "2018-12-03", "DescribeSuspEvents", "sas", "openAPI")
        {
        }

		private string alarmUniqueInfo;

		private string sourceIp;

		private string name;

		private string pageSize;

		private string dealed;

		private string remark;

		private string currentPage;

		private string from;

		private string lang;

		private string levels;

		private string parentEventTypes;

		public string AlarmUniqueInfo
		{
			get
			{
				return alarmUniqueInfo;
			}
			set	
			{
				alarmUniqueInfo = value;
				DictionaryUtil.Add(QueryParameters, "AlarmUniqueInfo", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value);
			}
		}

		public string From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Levels
		{
			get
			{
				return levels;
			}
			set	
			{
				levels = value;
				DictionaryUtil.Add(QueryParameters, "Levels", value);
			}
		}

		public string ParentEventTypes
		{
			get
			{
				return parentEventTypes;
			}
			set	
			{
				parentEventTypes = value;
				DictionaryUtil.Add(QueryParameters, "ParentEventTypes", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSuspEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSuspEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
