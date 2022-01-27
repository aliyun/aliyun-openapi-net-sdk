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
    public class ListDbfsResponseUnmarshaller
    {
        public static ListDbfsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDbfsResponse listDbfsResponse = new ListDbfsResponse();

			listDbfsResponse.HttpResponse = _ctx.HttpResponse;
			listDbfsResponse.TotalCount = _ctx.IntegerValue("ListDbfs.TotalCount");
			listDbfsResponse.PageSize = _ctx.IntegerValue("ListDbfs.PageSize");
			listDbfsResponse.RequestId = _ctx.StringValue("ListDbfs.RequestId");
			listDbfsResponse.PageNumber = _ctx.IntegerValue("ListDbfs.PageNumber");

			List<ListDbfsResponse.ListDbfs_Info> listDbfsResponse_dBFSInfo = new List<ListDbfsResponse.ListDbfs_Info>();
			for (int i = 0; i < _ctx.Length("ListDbfs.DBFSInfo.Length"); i++) {
				ListDbfsResponse.ListDbfs_Info info = new ListDbfsResponse.ListDbfs_Info();
				info.Status = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].Status");
				info.Encryption = _ctx.BooleanValue("ListDbfs.DBFSInfo["+ i +"].Encryption");
				info.PayType = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].PayType");
				info.FsId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].FsId");
				info.SizeG = _ctx.IntegerValue("ListDbfs.DBFSInfo["+ i +"].SizeG");
				info.RegionId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].RegionId");
				info.DBFSClusterId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].DBFSClusterId");
				info.ZoneId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].ZoneId");
				info.FsName = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].FsName");
				info.Category = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].Category");
				info.CreatedTime = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].CreatedTime");
				info.AttachNodeNumber = _ctx.IntegerValue("ListDbfs.DBFSInfo["+ i +"].AttachNodeNumber");
				info.KMSKeyId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].KMSKeyId");
				info.PerformanceLevel = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].PerformanceLevel");
				info.UsedScene = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].UsedScene");
				info.LastMountTime = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].LastMountTime");
				info.LastUmountTime = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].LastUmountTime");
				info.EnableRaid = _ctx.BooleanValue("ListDbfs.DBFSInfo["+ i +"].EnableRaid");
				info.RaidStrip = _ctx.IntegerValue("ListDbfs.DBFSInfo["+ i +"].RaidStrip");

				List<ListDbfsResponse.ListDbfs_Info.ListDbfs_TagList> info_tags = new List<ListDbfsResponse.ListDbfs_Info.ListDbfs_TagList>();
				for (int j = 0; j < _ctx.Length("ListDbfs.DBFSInfo["+ i +"].Tags.Length"); j++) {
					ListDbfsResponse.ListDbfs_Info.ListDbfs_TagList tagList = new ListDbfsResponse.ListDbfs_Info.ListDbfs_TagList();
					tagList.TagValue = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].Tags["+ j +"].TagValue");
					tagList.Id = _ctx.LongValue("ListDbfs.DBFSInfo["+ i +"].Tags["+ j +"].Id");
					tagList.TagKey = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].Tags["+ j +"].TagKey");

					info_tags.Add(tagList);
				}
				info.Tags = info_tags;

				List<ListDbfsResponse.ListDbfs_Info.ListDbfs_EcsListItem> info_ecsList = new List<ListDbfsResponse.ListDbfs_Info.ListDbfs_EcsListItem>();
				for (int j = 0; j < _ctx.Length("ListDbfs.DBFSInfo["+ i +"].EcsList.Length"); j++) {
					ListDbfsResponse.ListDbfs_Info.ListDbfs_EcsListItem ecsListItem = new ListDbfsResponse.ListDbfs_Info.ListDbfs_EcsListItem();
					ecsListItem.EcsId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].EcsList["+ j +"].EcsId");

					info_ecsList.Add(ecsListItem);
				}
				info.EcsList = info_ecsList;

				List<ListDbfsResponse.ListDbfs_Info.ListDbfs_EbsListItem> info_ebsList = new List<ListDbfsResponse.ListDbfs_Info.ListDbfs_EbsListItem>();
				for (int j = 0; j < _ctx.Length("ListDbfs.DBFSInfo["+ i +"].EbsList.Length"); j++) {
					ListDbfsResponse.ListDbfs_Info.ListDbfs_EbsListItem ebsListItem = new ListDbfsResponse.ListDbfs_Info.ListDbfs_EbsListItem();
					ebsListItem.EbsId = _ctx.StringValue("ListDbfs.DBFSInfo["+ i +"].EbsList["+ j +"].EbsId");
					ebsListItem.SizeG = _ctx.IntegerValue("ListDbfs.DBFSInfo["+ i +"].EbsList["+ j +"].SizeG");

					info_ebsList.Add(ebsListItem);
				}
				info.EbsList = info_ebsList;

				listDbfsResponse_dBFSInfo.Add(info);
			}
			listDbfsResponse.DBFSInfo = listDbfsResponse_dBFSInfo;
        
			return listDbfsResponse;
        }
    }
}
