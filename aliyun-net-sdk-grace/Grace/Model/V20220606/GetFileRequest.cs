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
using Aliyun.Acs.grace.Transform;
using Aliyun.Acs.grace.Transform.V20220606;

namespace Aliyun.Acs.grace.Model.V20220606
{
    public class GetFileRequest : RoaAcsRequest<GetFileResponse>
    {
        public GetFileRequest()
            : base("grace", "2022-06-06", "GetFile", "grace", "openAPI")
        {
			UriPattern = "/GetFile";
			Method = MethodType.GET;
        }

		private string token;

		private string name;

		public string Token
		{
			get
			{
				return token;
			}
			set	
			{
				token = value;
				DictionaryUtil.Add(QueryParameters, "token", value);
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
				DictionaryUtil.Add(QueryParameters, "name", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
