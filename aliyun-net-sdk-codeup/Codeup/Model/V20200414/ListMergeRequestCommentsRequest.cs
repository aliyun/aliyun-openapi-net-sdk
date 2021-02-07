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
using Aliyun.Acs.codeup;
using Aliyun.Acs.codeup.Transform;
using Aliyun.Acs.codeup.Transform.V20200414;

namespace Aliyun.Acs.codeup.Model.V20200414
{
    public class ListMergeRequestCommentsRequest : RoaAcsRequest<ListMergeRequestCommentsResponse>
    {
        public ListMergeRequestCommentsRequest()
            : base("codeup", "2020-04-14", "ListMergeRequestComments")
        {
			UriPattern = "/api/v4/projects/[ProjectId]/merge_request/[MergeRequestId]/comments";
			Method = MethodType.GET;
        }

		private string organizationId;

		private long? mergeRequestId;

		private string fromCommit;

		private string accessToken;

		private string toCommit;

		private long? projectId;

		public string OrganizationId
		{
			get
			{
				return organizationId;
			}
			set	
			{
				organizationId = value;
				DictionaryUtil.Add(QueryParameters, "OrganizationId", value);
			}
		}

		public long? MergeRequestId
		{
			get
			{
				return mergeRequestId;
			}
			set	
			{
				mergeRequestId = value;
				DictionaryUtil.Add(PathParameters, "MergeRequestId", value.ToString());
			}
		}

		public string FromCommit
		{
			get
			{
				return fromCommit;
			}
			set	
			{
				fromCommit = value;
				DictionaryUtil.Add(QueryParameters, "FromCommit", value);
			}
		}

		public string AccessToken
		{
			get
			{
				return accessToken;
			}
			set	
			{
				accessToken = value;
				DictionaryUtil.Add(QueryParameters, "AccessToken", value);
			}
		}

		public string ToCommit
		{
			get
			{
				return toCommit;
			}
			set	
			{
				toCommit = value;
				DictionaryUtil.Add(QueryParameters, "ToCommit", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(PathParameters, "ProjectId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListMergeRequestCommentsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListMergeRequestCommentsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
