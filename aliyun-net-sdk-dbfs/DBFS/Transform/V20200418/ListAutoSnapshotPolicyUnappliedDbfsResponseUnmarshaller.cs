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
    public class ListAutoSnapshotPolicyUnappliedDbfsResponseUnmarshaller
    {
        public static ListAutoSnapshotPolicyUnappliedDbfsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAutoSnapshotPolicyUnappliedDbfsResponse listAutoSnapshotPolicyUnappliedDbfsResponse = new ListAutoSnapshotPolicyUnappliedDbfsResponse();

			listAutoSnapshotPolicyUnappliedDbfsResponse.HttpResponse = _ctx.HttpResponse;
			listAutoSnapshotPolicyUnappliedDbfsResponse.PageNumber = _ctx.IntegerValue("ListAutoSnapshotPolicyUnappliedDbfs.PageNumber");
			listAutoSnapshotPolicyUnappliedDbfsResponse.PageSize = _ctx.IntegerValue("ListAutoSnapshotPolicyUnappliedDbfs.PageSize");
			listAutoSnapshotPolicyUnappliedDbfsResponse.TotalCount = _ctx.IntegerValue("ListAutoSnapshotPolicyUnappliedDbfs.TotalCount");
			listAutoSnapshotPolicyUnappliedDbfsResponse.RequestId = _ctx.StringValue("ListAutoSnapshotPolicyUnappliedDbfs.RequestId");

			List<ListAutoSnapshotPolicyUnappliedDbfsResponse.ListAutoSnapshotPolicyUnappliedDbfs_DbfsListItem> listAutoSnapshotPolicyUnappliedDbfsResponse_dbfsList = new List<ListAutoSnapshotPolicyUnappliedDbfsResponse.ListAutoSnapshotPolicyUnappliedDbfs_DbfsListItem>();
			for (int i = 0; i < _ctx.Length("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList.Length"); i++) {
				ListAutoSnapshotPolicyUnappliedDbfsResponse.ListAutoSnapshotPolicyUnappliedDbfs_DbfsListItem dbfsListItem = new ListAutoSnapshotPolicyUnappliedDbfsResponse.ListAutoSnapshotPolicyUnappliedDbfs_DbfsListItem();
				dbfsListItem.FsId = _ctx.StringValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].FsId");
				dbfsListItem.FsName = _ctx.StringValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].FsName");
				dbfsListItem.Status = _ctx.StringValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].Status");
				dbfsListItem.SizeG = _ctx.LongValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].SizeG");
				dbfsListItem.RegionId = _ctx.StringValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].RegionId");
				dbfsListItem.SnapshotCount = _ctx.StringValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].SnapshotCount");
				dbfsListItem.TotalSize = _ctx.LongValue("ListAutoSnapshotPolicyUnappliedDbfs.DbfsList["+ i +"].TotalSize");

				listAutoSnapshotPolicyUnappliedDbfsResponse_dbfsList.Add(dbfsListItem);
			}
			listAutoSnapshotPolicyUnappliedDbfsResponse.DbfsList = listAutoSnapshotPolicyUnappliedDbfsResponse_dbfsList;
        
			return listAutoSnapshotPolicyUnappliedDbfsResponse;
        }
    }
}
