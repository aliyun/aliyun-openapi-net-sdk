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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class ListApStaStatusRequest : RpcAcsRequest<ListApStaStatusResponse>
    {
        public ListApStaStatusRequest()
            : base("cloudwf", "2017-03-28", "ListApStaStatus")
        {
        }

		private string orderCol;

		private string searchProtocal;

		private string searchSsid;

		private string searchIp;

		private int? length;

		private string searchUsername;

		private string searchMac;

		private int? pageIndex;

		private long? id;

		private string orderDir;

		private string accessKeyId;

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

		public string SearchProtocal
		{
			get
			{
				return searchProtocal;
			}
			set	
			{
				searchProtocal = value;
				DictionaryUtil.Add(QueryParameters, "SearchProtocal", value);
			}
		}

		public string SearchSsid
		{
			get
			{
				return searchSsid;
			}
			set	
			{
				searchSsid = value;
				DictionaryUtil.Add(QueryParameters, "SearchSsid", value);
			}
		}

		public string SearchIp
		{
			get
			{
				return searchIp;
			}
			set	
			{
				searchIp = value;
				DictionaryUtil.Add(QueryParameters, "SearchIp", value);
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

		public string SearchUsername
		{
			get
			{
				return searchUsername;
			}
			set	
			{
				searchUsername = value;
				DictionaryUtil.Add(QueryParameters, "SearchUsername", value);
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

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
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

        public override ListApStaStatusResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListApStaStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}