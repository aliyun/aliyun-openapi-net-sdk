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
using Aliyun.Acs.cr.Transform;
using Aliyun.Acs.cr.Transform.V20160607;

namespace Aliyun.Acs.cr.Model.V20160607
{
    public class GetUserSourceRepoRefListRequest : RoaAcsRequest<GetUserSourceRepoRefListResponse>
    {
        public GetUserSourceRepoRefListRequest()
            : base("cr", "2016-06-07", "GetUserSourceRepoRefList", "cr", "openAPI")
        {
			UriPattern = "/users/sourceAccount/[SourceAccountId]/repos/[SourceRepoNamespace]/[SourceRepoName]/refs";
			Method = MethodType.GET;
        }

		private long? sourceAccountId;

		private string sourceRepoName;

		private string sourceRepoNamespace;

		public long? SourceAccountId
		{
			get
			{
				return sourceAccountId;
			}
			set	
			{
				sourceAccountId = value;
				DictionaryUtil.Add(PathParameters, "SourceAccountId", value.ToString());
			}
		}

		public string SourceRepoName
		{
			get
			{
				return sourceRepoName;
			}
			set	
			{
				sourceRepoName = value;
				DictionaryUtil.Add(PathParameters, "SourceRepoName", value);
			}
		}

		public string SourceRepoNamespace
		{
			get
			{
				return sourceRepoNamespace;
			}
			set	
			{
				sourceRepoNamespace = value;
				DictionaryUtil.Add(PathParameters, "SourceRepoNamespace", value);
			}
		}

        public override GetUserSourceRepoRefListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetUserSourceRepoRefListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
