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
    public class GetSnapshotLinkResponseUnmarshaller
    {
        public static GetSnapshotLinkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSnapshotLinkResponse getSnapshotLinkResponse = new GetSnapshotLinkResponse();

			getSnapshotLinkResponse.HttpResponse = _ctx.HttpResponse;
			getSnapshotLinkResponse.RequestId = _ctx.StringValue("GetSnapshotLink.RequestId");

			GetSnapshotLinkResponse.GetSnapshotLink_Data data = new GetSnapshotLinkResponse.GetSnapshotLink_Data();
			data.Status = _ctx.StringValue("GetSnapshotLink.Data.Status");
			data.TotalSize = _ctx.LongValue("GetSnapshotLink.Data.TotalSize");
			data.SourceSize = _ctx.IntegerValue("GetSnapshotLink.Data.SourceSize");
			data.FsId = _ctx.StringValue("GetSnapshotLink.Data.FsId");
			data.SnapshotCount = _ctx.IntegerValue("GetSnapshotLink.Data.SnapshotCount");
			data.FsName = _ctx.StringValue("GetSnapshotLink.Data.FsName");
			data.LinkId = _ctx.StringValue("GetSnapshotLink.Data.LinkId");
			data.Category = _ctx.StringValue("GetSnapshotLink.Data.Category");

			List<GetSnapshotLinkResponse.GetSnapshotLink_Data.GetSnapshotLink_EcsListItem> data_ecsList = new List<GetSnapshotLinkResponse.GetSnapshotLink_Data.GetSnapshotLink_EcsListItem>();
			for (int i = 0; i < _ctx.Length("GetSnapshotLink.Data.EcsList.Length"); i++) {
				GetSnapshotLinkResponse.GetSnapshotLink_Data.GetSnapshotLink_EcsListItem ecsListItem = new GetSnapshotLinkResponse.GetSnapshotLink_Data.GetSnapshotLink_EcsListItem();
				ecsListItem.EcsId = _ctx.StringValue("GetSnapshotLink.Data.EcsList["+ i +"].EcsId");

				data_ecsList.Add(ecsListItem);
			}
			data.EcsList = data_ecsList;
			getSnapshotLinkResponse.Data = data;
        
			return getSnapshotLinkResponse;
        }
    }
}
