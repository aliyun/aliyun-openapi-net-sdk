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
using Aliyun.Acs.dt_oc_info;
using Aliyun.Acs.dt_oc_info.Transform;
using Aliyun.Acs.dt_oc_info.Transform.V20220829;

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
    public class GetOcJusticeDishonestyRequest : RpcAcsRequest<GetOcJusticeDishonestyResponse>
    {
        public GetOcJusticeDishonestyRequest()
            : base("dt-oc-info", "2022-08-29", "GetOcJusticeDishonesty")
        {
			Method = MethodType.POST;
        }

		private int? pageNo;

		private int? pageSize;

		private string searchKey;

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(BodyParameters, "PageNo", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(BodyParameters, "SearchKey", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetOcJusticeDishonestyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetOcJusticeDishonestyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
