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
    public class AreaUpdateRequest : RpcAcsRequest<AreaUpdateResponse>
    {
        public AreaUpdateRequest()
            : base("cloudwf", "2017-03-28", "AreaUpdate", "cloudwf", "openAPI")
        {
        }

		private string name;

		private string dids;

		private long? aid;

		private string accessKeyId;

		private long? sid;

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

		public string Dids
		{
			get
			{
				return dids;
			}
			set	
			{
				dids = value;
				DictionaryUtil.Add(QueryParameters, "Dids", value);
			}
		}

		public long? Aid
		{
			get
			{
				return aid;
			}
			set	
			{
				aid = value;
				DictionaryUtil.Add(QueryParameters, "Aid", value.ToString());
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

        public override AreaUpdateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AreaUpdateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
