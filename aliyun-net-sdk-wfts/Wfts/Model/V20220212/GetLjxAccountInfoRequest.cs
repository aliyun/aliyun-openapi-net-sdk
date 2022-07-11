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
using Aliyun.Acs.Wfts;
using Aliyun.Acs.Wfts.Transform;
using Aliyun.Acs.Wfts.Transform.V20220212;

namespace Aliyun.Acs.Wfts.Model.V20220212
{
    public class GetLjxAccountInfoRequest : RoaAcsRequest<GetLjxAccountInfoResponse>
    {
        public GetLjxAccountInfoRequest()
            : base("Wfts", "2022-02-12", "GetLjxAccountInfo")
        {
			UriPattern = "/get/ljx/acc";
			Method = MethodType.GET;
        }

		private string ljxAccountInfoId;

		public string LjxAccountInfoId
		{
			get
			{
				return ljxAccountInfoId;
			}
			set	
			{
				ljxAccountInfoId = value;
				DictionaryUtil.Add(QueryParameters, "LjxAccountInfoId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetLjxAccountInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetLjxAccountInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
