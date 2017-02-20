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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class DescribeDomainRecordsRequest : RpcAcsRequest<DescribeDomainRecordsResponse>
    {
        public DescribeDomainRecordsRequest()
            : base("Alidns", "2015-01-09", "DescribeDomainRecords")
        {
        }

		private string _lang;

		private string _userClientIp;

		private string _domainName;

		private long? _pageNumber;

		private long? _pageSize;

		private string _rRKeyWord;

		private string _typeKeyWord;

		private string _valueKeyWord;

		public string Lang
		{
			get
			{
				return _lang;
			}
			set	
			{
				_lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return _userClientIp;
			}
			set	
			{
				_userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public long? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public long? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string RRKeyWord
		{
			get
			{
				return _rRKeyWord;
			}
			set	
			{
				_rRKeyWord = value;
				DictionaryUtil.Add(QueryParameters, "RRKeyWord", value);
			}
		}

		public string TypeKeyWord
		{
			get
			{
				return _typeKeyWord;
			}
			set	
			{
				_typeKeyWord = value;
				DictionaryUtil.Add(QueryParameters, "TypeKeyWord", value);
			}
		}

		public string ValueKeyWord
		{
			get
			{
				return _valueKeyWord;
			}
			set	
			{
				_valueKeyWord = value;
				DictionaryUtil.Add(QueryParameters, "ValueKeyWord", value);
			}
		}

        public override DescribeDomainRecordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}