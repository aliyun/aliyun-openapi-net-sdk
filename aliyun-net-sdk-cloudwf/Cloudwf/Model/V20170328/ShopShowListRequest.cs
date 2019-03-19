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
    public class ShopShowListRequest : RpcAcsRequest<ShopShowListResponse>
    {
        public ShopShowListRequest()
            : base("cloudwf", "2017-03-28", "ShopShowList", "cloudwf", "openAPI")
        {
        }

		private long? gid;

		private string address;

		private string name;

		private string dirc;

		private int? page;

		private long? bid;

		private int? per;

		private int? shopStatus;

		private string accessKeyId;

		public long? Gid
		{
			get
			{
				return gid;
			}
			set	
			{
				gid = value;
				DictionaryUtil.Add(QueryParameters, "Gid", value.ToString());
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
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

		public string Dirc
		{
			get
			{
				return dirc;
			}
			set	
			{
				dirc = value;
				DictionaryUtil.Add(QueryParameters, "Dirc", value);
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value.ToString());
			}
		}

		public long? Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value.ToString());
			}
		}

		public int? Per
		{
			get
			{
				return per;
			}
			set	
			{
				per = value;
				DictionaryUtil.Add(QueryParameters, "Per", value.ToString());
			}
		}

		public int? ShopStatus
		{
			get
			{
				return shopStatus;
			}
			set	
			{
				shopStatus = value;
				DictionaryUtil.Add(QueryParameters, "ShopStatus", value.ToString());
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

        public override ShopShowListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ShopShowListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
