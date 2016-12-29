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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class DescribeDomainRecordsRequest : RpcAcsRequest<DescribeDomainRecordsResponse>
    {
        public DescribeDomainRecordsRequest()
            : base("Alidns", "2015-01-09", "DescribeDomainRecords")
        {
        }

		private string lang;

		private string userClientIp;

		private string domainName;

		private long? pageNumber;

		private long? pageSize;

		private string rRKeyWord;

		private string typeKeyWord;

		private string valueKeyWord;

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

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
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

        public override DescribeDomainRecordsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}