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
    public class GetDbfsResponseUnmarshaller
    {
        public static GetDbfsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDbfsResponse getDbfsResponse = new GetDbfsResponse();

			getDbfsResponse.HttpResponse = _ctx.HttpResponse;
			getDbfsResponse.RequestId = _ctx.StringValue("GetDbfs.RequestId");

			GetDbfsResponse.GetDbfs_DBFSInfo dBFSInfo = new GetDbfsResponse.GetDbfs_DBFSInfo();
			dBFSInfo.Status = _ctx.StringValue("GetDbfs.DBFSInfo.Status");
			dBFSInfo.PayType = _ctx.StringValue("GetDbfs.DBFSInfo.PayType");
			dBFSInfo.FsId = _ctx.StringValue("GetDbfs.DBFSInfo.FsId");
			dBFSInfo.SizeG = _ctx.IntegerValue("GetDbfs.DBFSInfo.SizeG");
			dBFSInfo.RegionId = _ctx.StringValue("GetDbfs.DBFSInfo.RegionId");
			dBFSInfo.DBFSClusterId = _ctx.StringValue("GetDbfs.DBFSInfo.DBFSClusterId");
			dBFSInfo.Description = _ctx.StringValue("GetDbfs.DBFSInfo.Description");
			dBFSInfo.ZoneId = _ctx.StringValue("GetDbfs.DBFSInfo.ZoneId");
			dBFSInfo.FsName = _ctx.StringValue("GetDbfs.DBFSInfo.FsName");
			dBFSInfo.Category = _ctx.StringValue("GetDbfs.DBFSInfo.Category");
			dBFSInfo.CreatedTime = _ctx.StringValue("GetDbfs.DBFSInfo.CreatedTime");
			dBFSInfo.AttachNodeNumber = _ctx.IntegerValue("GetDbfs.DBFSInfo.AttachNodeNumber");
			dBFSInfo.KMSKeyId = _ctx.StringValue("GetDbfs.DBFSInfo.KMSKeyId");
			dBFSInfo.Encryption = _ctx.BooleanValue("GetDbfs.DBFSInfo.Encryption");
			dBFSInfo.PerformanceLevel = _ctx.StringValue("GetDbfs.DBFSInfo.PerformanceLevel");
			dBFSInfo.UsedScene = _ctx.StringValue("GetDbfs.DBFSInfo.UsedScene");
			dBFSInfo.LastMountTime = _ctx.StringValue("GetDbfs.DBFSInfo.LastMountTime");
			dBFSInfo.LastUmountTime = _ctx.StringValue("GetDbfs.DBFSInfo.LastUmountTime");
			dBFSInfo.EnableRaid = _ctx.BooleanValue("GetDbfs.DBFSInfo.EnableRaid");
			dBFSInfo.RaidStrip = _ctx.IntegerValue("GetDbfs.DBFSInfo.RaidStrip");

			List<GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_TagList> dBFSInfo_tags = new List<GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_TagList>();
			for (int i = 0; i < _ctx.Length("GetDbfs.DBFSInfo.Tags.Length"); i++) {
				GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_TagList tagList = new GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_TagList();
				tagList.TagValue = _ctx.StringValue("GetDbfs.DBFSInfo.Tags["+ i +"].TagValue");
				tagList.Id = _ctx.IntegerValue("GetDbfs.DBFSInfo.Tags["+ i +"].Id");
				tagList.TagKey = _ctx.StringValue("GetDbfs.DBFSInfo.Tags["+ i +"].TagKey");

				dBFSInfo_tags.Add(tagList);
			}
			dBFSInfo.Tags = dBFSInfo_tags;

			List<GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EcsListItem> dBFSInfo_ecsList = new List<GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EcsListItem>();
			for (int i = 0; i < _ctx.Length("GetDbfs.DBFSInfo.EcsList.Length"); i++) {
				GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EcsListItem ecsListItem = new GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EcsListItem();
				ecsListItem.EcsId = _ctx.StringValue("GetDbfs.DBFSInfo.EcsList["+ i +"].EcsId");

				dBFSInfo_ecsList.Add(ecsListItem);
			}
			dBFSInfo.EcsList = dBFSInfo_ecsList;

			List<GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EbsListItem> dBFSInfo_ebsList = new List<GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EbsListItem>();
			for (int i = 0; i < _ctx.Length("GetDbfs.DBFSInfo.EbsList.Length"); i++) {
				GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EbsListItem ebsListItem = new GetDbfsResponse.GetDbfs_DBFSInfo.GetDbfs_EbsListItem();
				ebsListItem.EbsId = _ctx.StringValue("GetDbfs.DBFSInfo.EbsList["+ i +"].EbsId");
				ebsListItem.SizeG = _ctx.IntegerValue("GetDbfs.DBFSInfo.EbsList["+ i +"].SizeG");

				dBFSInfo_ebsList.Add(ebsListItem);
			}
			dBFSInfo.EbsList = dBFSInfo_ebsList;
			getDbfsResponse.DBFSInfo = dBFSInfo;
        
			return getDbfsResponse;
        }
    }
}
