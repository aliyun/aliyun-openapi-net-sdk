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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class DescribeDomainRecordsRequest : RpcAcsRequest<DescribeDomainRecordsResponse>
    {
        public DescribeDomainRecordsRequest()
            : base("Alidns", "2015-01-09", "DescribeDomainRecords", "Alidns", "openAPI")
        {
        }

		private string valueKeyWord;

		private string line;

		private long? groupId;

		private string domainName;

		private string orderBy;

		private string type;

		private long? pageNumber;

		private long? pageSize;

		private string searchMode;

		private string lang;

		private string keyWord;

		private string typeKeyWord;

		private string rRKeyWord;

		private string direction;

		private string status;

		public string ValueKeyWord
		{
			get
			{
				return valueKeyWord;
			}
			set	
			{
				valueKeyWord = value;
				DictionaryUtil.Add(QueryParameters, "ValueKeyWord", value);
			}
		}

		public string Line
		{
			get
			{
				return line;
			}
			set	
			{
				line = value;
				DictionaryUtil.Add(QueryParameters, "Line", value);
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
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

		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string SearchMode
		{
			get
			{
				return searchMode;
			}
			set	
			{
				searchMode = value;
				DictionaryUtil.Add(QueryParameters, "SearchMode", value);
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

		public string KeyWord
		{
			get
			{
				return keyWord;
			}
			set	
			{
				keyWord = value;
				DictionaryUtil.Add(QueryParameters, "KeyWord", value);
			}
		}

		public string TypeKeyWord
		{
			get
			{
				return typeKeyWord;
			}
			set	
			{
				typeKeyWord = value;
				DictionaryUtil.Add(QueryParameters, "TypeKeyWord", value);
			}
		}

		public string RRKeyWord
		{
			get
			{
				return rRKeyWord;
			}
			set	
			{
				rRKeyWord = value;
				DictionaryUtil.Add(QueryParameters, "RRKeyWord", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override DescribeDomainRecordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
