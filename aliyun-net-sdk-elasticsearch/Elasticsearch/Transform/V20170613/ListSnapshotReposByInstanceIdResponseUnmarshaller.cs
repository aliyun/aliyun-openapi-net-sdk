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
    public class ListSnapshotReposByInstanceIdResponseUnmarshaller
    {
        public static ListSnapshotReposByInstanceIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSnapshotReposByInstanceIdResponse listSnapshotReposByInstanceIdResponse = new ListSnapshotReposByInstanceIdResponse();

			listSnapshotReposByInstanceIdResponse.HttpResponse = _ctx.HttpResponse;
			listSnapshotReposByInstanceIdResponse.RequestId = _ctx.StringValue("ListSnapshotReposByInstanceId.RequestId");

			List<ListSnapshotReposByInstanceIdResponse.ListSnapshotReposByInstanceId_Repo> listSnapshotReposByInstanceIdResponse_result = new List<ListSnapshotReposByInstanceIdResponse.ListSnapshotReposByInstanceId_Repo>();
			for (int i = 0; i < _ctx.Length("ListSnapshotReposByInstanceId.Result.Length"); i++) {
				ListSnapshotReposByInstanceIdResponse.ListSnapshotReposByInstanceId_Repo repo = new ListSnapshotReposByInstanceIdResponse.ListSnapshotReposByInstanceId_Repo();
				repo.InstanceId = _ctx.StringValue("ListSnapshotReposByInstanceId.Result["+ i +"].instanceId");
				repo.SnapWarehouse = _ctx.StringValue("ListSnapshotReposByInstanceId.Result["+ i +"].snapWarehouse");
				repo.RepoPath = _ctx.StringValue("ListSnapshotReposByInstanceId.Result["+ i +"].repoPath");
				repo.Status = _ctx.StringValue("ListSnapshotReposByInstanceId.Result["+ i +"].status");

				listSnapshotReposByInstanceIdResponse_result.Add(repo);
			}
			listSnapshotReposByInstanceIdResponse.Result = listSnapshotReposByInstanceIdResponse_result;
        
			return listSnapshotReposByInstanceIdResponse;
        }
    }
}
