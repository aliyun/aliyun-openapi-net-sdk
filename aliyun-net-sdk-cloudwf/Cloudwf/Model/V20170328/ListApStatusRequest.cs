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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class ListApStatusRequest : RpcAcsRequest<ListApStatusResponse>
    {
        public ListApStatusRequest()
            : base("cloudwf", "2017-03-28", "ListApStatus", "cloudwf", "openAPI")
        {
        }

		private string orderCol;

		private string searchName;

		private string searchGroupName;

		private int? searchStatus;

		private string searchWanIp;

		private string searchApModelName;

		private int? length;

		private string orderDir;

		private string accessKeyId;

		private int? searchBssEquals;

		private long? searchSwVersion;

		private string searchCompanyName;

		private string searchMac;

		private int? pageIndex;

		public string OrderCol
		{
			get
			{
				return orderCol;
			}
			set	
			{
				orderCol = value;
				DictionaryUtil.Add(QueryParameters, "OrderCol", value);
			}
		}

		public string SearchName
		{
			get
			{
				return searchName;
			}
			set	
			{
				searchName = value;
				DictionaryUtil.Add(QueryParameters, "SearchName", value);
			}
		}

		public string SearchGroupName
		{
			get
			{
				return searchGroupName;
			}
			set	
			{
				searchGroupName = value;
				DictionaryUtil.Add(QueryParameters, "SearchGroupName", value);
			}
		}

		public int? SearchStatus
		{
			get
			{
				return searchStatus;
			}
			set	
			{
				searchStatus = value;
				DictionaryUtil.Add(QueryParameters, "SearchStatus", value.ToString());
			}
		}

		public string SearchWanIp
		{
			get
			{
				return searchWanIp;
			}
			set	
			{
				searchWanIp = value;
				DictionaryUtil.Add(QueryParameters, "SearchWanIp", value);
			}
		}

		public string SearchApModelName
		{
			get
			{
				return searchApModelName;
			}
			set	
			{
				searchApModelName = value;
				DictionaryUtil.Add(QueryParameters, "SearchApModelName", value);
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
			}
		}

		public string OrderDir
		{
			get
			{
				return orderDir;
			}
			set	
			{
				orderDir = value;
				DictionaryUtil.Add(QueryParameters, "OrderDir", value);
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

		public int? SearchBssEquals
		{
			get
			{
				return searchBssEquals;
			}
			set	
			{
				searchBssEquals = value;
				DictionaryUtil.Add(QueryParameters, "SearchBssEquals", value.ToString());
			}
		}

		public long? SearchSwVersion
		{
			get
			{
				return searchSwVersion;
			}
			set	
			{
				searchSwVersion = value;
				DictionaryUtil.Add(QueryParameters, "SearchSwVersion", value.ToString());
			}
		}

		public string SearchCompanyName
		{
			get
			{
				return searchCompanyName;
			}
			set	
			{
				searchCompanyName = value;
				DictionaryUtil.Add(QueryParameters, "SearchCompanyName", value);
			}
		}

		public string SearchMac
		{
			get
			{
				return searchMac;
			}
			set	
			{
				searchMac = value;
				DictionaryUtil.Add(QueryParameters, "SearchMac", value);
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
				DictionaryUtil.Add(QueryParameters, "PageIndex", value.ToString());
			}
		}

        public override ListApStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListApStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
