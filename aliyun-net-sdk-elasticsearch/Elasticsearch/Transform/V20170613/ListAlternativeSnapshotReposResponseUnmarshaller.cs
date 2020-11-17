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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListAlternativeSnapshotReposResponseUnmarshaller
    {
        public static ListAlternativeSnapshotReposResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAlternativeSnapshotReposResponse listAlternativeSnapshotReposResponse = new ListAlternativeSnapshotReposResponse();

			listAlternativeSnapshotReposResponse.HttpResponse = _ctx.HttpResponse;
			listAlternativeSnapshotReposResponse.RequestId = _ctx.StringValue("ListAlternativeSnapshotRepos.RequestId");

			List<ListAlternativeSnapshotReposResponse.ListAlternativeSnapshotRepos_Repo> listAlternativeSnapshotReposResponse_result = new List<ListAlternativeSnapshotReposResponse.ListAlternativeSnapshotRepos_Repo>();
			for (int i = 0; i < _ctx.Length("ListAlternativeSnapshotRepos.Result.Length"); i++) {
				ListAlternativeSnapshotReposResponse.ListAlternativeSnapshotRepos_Repo repo = new ListAlternativeSnapshotReposResponse.ListAlternativeSnapshotRepos_Repo();
				repo.InstanceId = _ctx.StringValue("ListAlternativeSnapshotRepos.Result["+ i +"].instanceId");
				repo.RepoPath = _ctx.StringValue("ListAlternativeSnapshotRepos.Result["+ i +"].repoPath");

				listAlternativeSnapshotReposResponse_result.Add(repo);
			}
			listAlternativeSnapshotReposResponse.Result = listAlternativeSnapshotReposResponse_result;
        
			return listAlternativeSnapshotReposResponse;
        }
    }
}
