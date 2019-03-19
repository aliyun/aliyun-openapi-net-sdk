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
    public class ShopSetredressRequest : RpcAcsRequest<ShopSetredressResponse>
    {
        public ShopSetredressRequest()
            : base("cloudwf", "2017-03-28", "ShopSetredress", "cloudwf", "openAPI")
        {
        }

		private string workday;

		private int? filterclose;

		private int? minstoptime;

		private string holiday;

		private string hnum;

		private string accessKeyId;

		private long? sid;

		private int? clerk;

		private int? filterstate;

		private string wnum;

		private int? state;

		private int? crowdfixed;

		private int? maxstoptime;

		public string Workday
		{
			get
			{
				return workday;
			}
			set	
			{
				workday = value;
				DictionaryUtil.Add(QueryParameters, "Workday", value);
			}
		}

		public int? Filterclose
		{
			get
			{
				return filterclose;
			}
			set	
			{
				filterclose = value;
				DictionaryUtil.Add(QueryParameters, "Filterclose", value.ToString());
			}
		}

		public int? Minstoptime
		{
			get
			{
				return minstoptime;
			}
			set	
			{
				minstoptime = value;
				DictionaryUtil.Add(QueryParameters, "Minstoptime", value.ToString());
			}
		}

		public string Holiday
		{
			get
			{
				return holiday;
			}
			set	
			{
				holiday = value;
				DictionaryUtil.Add(QueryParameters, "Holiday", value);
			}
		}

		public string Hnum
		{
			get
			{
				return hnum;
			}
			set	
			{
				hnum = value;
				DictionaryUtil.Add(QueryParameters, "Hnum", value);
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

		public long? Sid
		{
			get
			{
				return sid;
			}
			set	
			{
				sid = value;
				DictionaryUtil.Add(QueryParameters, "Sid", value.ToString());
			}
		}

		public int? Clerk
		{
			get
			{
				return clerk;
			}
			set	
			{
				clerk = value;
				DictionaryUtil.Add(QueryParameters, "Clerk", value.ToString());
			}
		}

		public int? Filterstate
		{
			get
			{
				return filterstate;
			}
			set	
			{
				filterstate = value;
				DictionaryUtil.Add(QueryParameters, "Filterstate", value.ToString());
			}
		}

		public string Wnum
		{
			get
			{
				return wnum;
			}
			set	
			{
				wnum = value;
				DictionaryUtil.Add(QueryParameters, "Wnum", value);
			}
		}

		public int? State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value.ToString());
			}
		}

		public int? Crowdfixed
		{
			get
			{
				return crowdfixed;
			}
			set	
			{
				crowdfixed = value;
				DictionaryUtil.Add(QueryParameters, "Crowdfixed", value.ToString());
			}
		}

		public int? Maxstoptime
		{
			get
			{
				return maxstoptime;
			}
			set	
			{
				maxstoptime = value;
				DictionaryUtil.Add(QueryParameters, "Maxstoptime", value.ToString());
			}
		}

        public override ShopSetredressResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ShopSetredressResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
