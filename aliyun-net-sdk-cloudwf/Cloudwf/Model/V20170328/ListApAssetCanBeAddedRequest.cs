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
    public class ListApAssetCanBeAddedRequest : RpcAcsRequest<ListApAssetCanBeAddedResponse>
    {
        public ListApAssetCanBeAddedRequest()
            : base("cloudwf", "2017-03-28", "ListApAssetCanBeAdded", "cloudwf", "openAPI")
        {
        }

		private string searchName;

		private long? apgroupId;

		private int? length;

		private int? pageIndex;

		private string searchMac;

		private string accessKeyId;

		private string searchModel;

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

		public long? ApgroupId
		{
			get
			{
				return apgroupId;
			}
			set	
			{
				apgroupId = value;
				DictionaryUtil.Add(QueryParameters, "ApgroupId", value.ToString());
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

		public string SearchModel
		{
			get
			{
				return searchModel;
			}
			set	
			{
				searchModel = value;
				DictionaryUtil.Add(QueryParameters, "SearchModel", value);
			}
		}

        public override ListApAssetCanBeAddedResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListApAssetCanBeAddedResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
