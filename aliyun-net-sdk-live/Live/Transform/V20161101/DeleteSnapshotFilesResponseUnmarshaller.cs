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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DeleteSnapshotFilesResponseUnmarshaller
    {
        public static DeleteSnapshotFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteSnapshotFilesResponse deleteSnapshotFilesResponse = new DeleteSnapshotFilesResponse();

			deleteSnapshotFilesResponse.HttpResponse = _ctx.HttpResponse;
			deleteSnapshotFilesResponse.FailureCount = _ctx.IntegerValue("DeleteSnapshotFiles.FailureCount");
			deleteSnapshotFilesResponse.RequestId = _ctx.StringValue("DeleteSnapshotFiles.RequestId");
			deleteSnapshotFilesResponse.SuccessCount = _ctx.IntegerValue("DeleteSnapshotFiles.SuccessCount");

			List<DeleteSnapshotFilesResponse.DeleteSnapshotFiles_SnapshotDeleteInfo> deleteSnapshotFilesResponse_snapshotDeleteInfoList = new List<DeleteSnapshotFilesResponse.DeleteSnapshotFiles_SnapshotDeleteInfo>();
			for (int i = 0; i < _ctx.Length("DeleteSnapshotFiles.SnapshotDeleteInfoList.Length"); i++) {
				DeleteSnapshotFilesResponse.DeleteSnapshotFiles_SnapshotDeleteInfo snapshotDeleteInfo = new DeleteSnapshotFilesResponse.DeleteSnapshotFiles_SnapshotDeleteInfo();
				snapshotDeleteInfo.Message = _ctx.StringValue("DeleteSnapshotFiles.SnapshotDeleteInfoList["+ i +"].Message");
				snapshotDeleteInfo.CreateTimestamp = _ctx.LongValue("DeleteSnapshotFiles.SnapshotDeleteInfoList["+ i +"].CreateTimestamp");

				deleteSnapshotFilesResponse_snapshotDeleteInfoList.Add(snapshotDeleteInfo);
			}
			deleteSnapshotFilesResponse.SnapshotDeleteInfoList = deleteSnapshotFilesResponse_snapshotDeleteInfoList;
        
			return deleteSnapshotFilesResponse;
        }
    }
}
