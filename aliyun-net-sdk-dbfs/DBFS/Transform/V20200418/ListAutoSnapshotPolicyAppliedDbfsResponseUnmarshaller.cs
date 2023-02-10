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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class ListAutoSnapshotPolicyAppliedDbfsResponseUnmarshaller
    {
        public static ListAutoSnapshotPolicyAppliedDbfsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAutoSnapshotPolicyAppliedDbfsResponse listAutoSnapshotPolicyAppliedDbfsResponse = new ListAutoSnapshotPolicyAppliedDbfsResponse();

			listAutoSnapshotPolicyAppliedDbfsResponse.HttpResponse = _ctx.HttpResponse;
			listAutoSnapshotPolicyAppliedDbfsResponse.PageNumber = _ctx.IntegerValue("ListAutoSnapshotPolicyAppliedDbfs.PageNumber");
			listAutoSnapshotPolicyAppliedDbfsResponse.PageSize = _ctx.IntegerValue("ListAutoSnapshotPolicyAppliedDbfs.PageSize");
			listAutoSnapshotPolicyAppliedDbfsResponse.TotalCount = _ctx.IntegerValue("ListAutoSnapshotPolicyAppliedDbfs.TotalCount");
			listAutoSnapshotPolicyAppliedDbfsResponse.RequestId = _ctx.StringValue("ListAutoSnapshotPolicyAppliedDbfs.RequestId");

			List<ListAutoSnapshotPolicyAppliedDbfsResponse.ListAutoSnapshotPolicyAppliedDbfs_DbfsListItem> listAutoSnapshotPolicyAppliedDbfsResponse_dbfsList = new List<ListAutoSnapshotPolicyAppliedDbfsResponse.ListAutoSnapshotPolicyAppliedDbfs_DbfsListItem>();
			for (int i = 0; i < _ctx.Length("ListAutoSnapshotPolicyAppliedDbfs.DbfsList.Length"); i++) {
				ListAutoSnapshotPolicyAppliedDbfsResponse.ListAutoSnapshotPolicyAppliedDbfs_DbfsListItem dbfsListItem = new ListAutoSnapshotPolicyAppliedDbfsResponse.ListAutoSnapshotPolicyAppliedDbfs_DbfsListItem();
				dbfsListItem.FsId = _ctx.StringValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].FsId");
				dbfsListItem.FsName = _ctx.StringValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].FsName");
				dbfsListItem.Status = _ctx.StringValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].Status");
				dbfsListItem.SizeG = _ctx.LongValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].SizeG");
				dbfsListItem.RegionId = _ctx.StringValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].RegionId");
				dbfsListItem.SnapshotCount = _ctx.IntegerValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].SnapshotCount");
				dbfsListItem.TotalSize = _ctx.LongValue("ListAutoSnapshotPolicyAppliedDbfs.DbfsList["+ i +"].TotalSize");

				listAutoSnapshotPolicyAppliedDbfsResponse_dbfsList.Add(dbfsListItem);
			}
			listAutoSnapshotPolicyAppliedDbfsResponse.DbfsList = listAutoSnapshotPolicyAppliedDbfsResponse_dbfsList;
        
			return listAutoSnapshotPolicyAppliedDbfsResponse;
        }
    }
}
