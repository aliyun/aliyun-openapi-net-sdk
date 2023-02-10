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
    public class ListSnapshotLinksResponseUnmarshaller
    {
        public static ListSnapshotLinksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSnapshotLinksResponse listSnapshotLinksResponse = new ListSnapshotLinksResponse();

			listSnapshotLinksResponse.HttpResponse = _ctx.HttpResponse;
			listSnapshotLinksResponse.TotalCount = _ctx.IntegerValue("ListSnapshotLinks.TotalCount");
			listSnapshotLinksResponse.PageSize = _ctx.IntegerValue("ListSnapshotLinks.PageSize");
			listSnapshotLinksResponse.RequestId = _ctx.StringValue("ListSnapshotLinks.RequestId");
			listSnapshotLinksResponse.PageNumber = _ctx.IntegerValue("ListSnapshotLinks.PageNumber");

			List<ListSnapshotLinksResponse.ListSnapshotLinks_Info> listSnapshotLinksResponse_snapshotLinks = new List<ListSnapshotLinksResponse.ListSnapshotLinks_Info>();
			for (int i = 0; i < _ctx.Length("ListSnapshotLinks.SnapshotLinks.Length"); i++) {
				ListSnapshotLinksResponse.ListSnapshotLinks_Info info = new ListSnapshotLinksResponse.ListSnapshotLinks_Info();
				info.Status = _ctx.StringValue("ListSnapshotLinks.SnapshotLinks["+ i +"].Status");
				info.TotalSize = _ctx.LongValue("ListSnapshotLinks.SnapshotLinks["+ i +"].TotalSize");
				info.SourceSize = _ctx.IntegerValue("ListSnapshotLinks.SnapshotLinks["+ i +"].SourceSize");
				info.FsId = _ctx.StringValue("ListSnapshotLinks.SnapshotLinks["+ i +"].FsId");
				info.SnapshotCount = _ctx.IntegerValue("ListSnapshotLinks.SnapshotLinks["+ i +"].SnapshotCount");
				info.FsName = _ctx.StringValue("ListSnapshotLinks.SnapshotLinks["+ i +"].FsName");
				info.LinkId = _ctx.StringValue("ListSnapshotLinks.SnapshotLinks["+ i +"].LinkId");

				List<ListSnapshotLinksResponse.ListSnapshotLinks_Info.ListSnapshotLinks_EcsListItem> info_ecsList = new List<ListSnapshotLinksResponse.ListSnapshotLinks_Info.ListSnapshotLinks_EcsListItem>();
				for (int j = 0; j < _ctx.Length("ListSnapshotLinks.SnapshotLinks["+ i +"].EcsList.Length"); j++) {
					ListSnapshotLinksResponse.ListSnapshotLinks_Info.ListSnapshotLinks_EcsListItem ecsListItem = new ListSnapshotLinksResponse.ListSnapshotLinks_Info.ListSnapshotLinks_EcsListItem();
					ecsListItem.EcsId = _ctx.StringValue("ListSnapshotLinks.SnapshotLinks["+ i +"].EcsList["+ j +"].EcsId");

					info_ecsList.Add(ecsListItem);
				}
				info.EcsList = info_ecsList;

				listSnapshotLinksResponse_snapshotLinks.Add(info);
			}
			listSnapshotLinksResponse.SnapshotLinks = listSnapshotLinksResponse_snapshotLinks;
        
			return listSnapshotLinksResponse;
        }
    }
}
