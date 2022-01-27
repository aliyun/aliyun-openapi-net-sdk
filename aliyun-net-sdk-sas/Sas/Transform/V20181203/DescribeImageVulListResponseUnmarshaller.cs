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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeImageVulListResponseUnmarshaller
    {
        public static DescribeImageVulListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageVulListResponse describeImageVulListResponse = new DescribeImageVulListResponse();

			describeImageVulListResponse.HttpResponse = _ctx.HttpResponse;
			describeImageVulListResponse.RequestId = _ctx.StringValue("DescribeImageVulList.RequestId");
			describeImageVulListResponse.PageSize = _ctx.IntegerValue("DescribeImageVulList.PageSize");
			describeImageVulListResponse.CurrentPage = _ctx.IntegerValue("DescribeImageVulList.CurrentPage");
			describeImageVulListResponse.TotalCount = _ctx.IntegerValue("DescribeImageVulList.TotalCount");

			List<DescribeImageVulListResponse.DescribeImageVulList_VulRecord> describeImageVulListResponse_vulRecords = new List<DescribeImageVulListResponse.DescribeImageVulList_VulRecord>();
			for (int i = 0; i < _ctx.Length("DescribeImageVulList.VulRecords.Length"); i++) {
				DescribeImageVulListResponse.DescribeImageVulList_VulRecord vulRecord = new DescribeImageVulListResponse.DescribeImageVulList_VulRecord();
				vulRecord.PrimaryId = _ctx.LongValue("DescribeImageVulList.VulRecords["+ i +"].PrimaryId");
				vulRecord.Uuid = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Uuid");
				vulRecord.Name = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Name");
				vulRecord.Tag = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Tag");
				vulRecord.AliasName = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].AliasName");
				vulRecord.Type = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Type");
				vulRecord.Level = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Level");
				vulRecord.FirstTs = _ctx.LongValue("DescribeImageVulList.VulRecords["+ i +"].FirstTs");
				vulRecord.LastTs = _ctx.LongValue("DescribeImageVulList.VulRecords["+ i +"].LastTs");
				vulRecord.Status = _ctx.IntegerValue("DescribeImageVulList.VulRecords["+ i +"].Status");
				vulRecord.Progress = _ctx.IntegerValue("DescribeImageVulList.VulRecords["+ i +"].Progress");
				vulRecord.Necessity = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Necessity");
				vulRecord.Related = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Related");
				vulRecord.ModifyTs = _ctx.LongValue("DescribeImageVulList.VulRecords["+ i +"].ModifyTs");
				vulRecord.ImageDigest = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ImageDigest");
				vulRecord.CanUpdate = _ctx.BooleanValue("DescribeImageVulList.VulRecords["+ i +"].CanUpdate");

				List<string> vulRecord_layers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeImageVulList.VulRecords["+ i +"].Layers.Length"); j++) {
					vulRecord_layers.Add(_ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].Layers["+ j +"]"));
				}
				vulRecord.Layers = vulRecord_layers;

				DescribeImageVulListResponse.DescribeImageVulList_VulRecord.DescribeImageVulList_ExtendContentJson extendContentJson = new DescribeImageVulListResponse.DescribeImageVulList_VulRecord.DescribeImageVulList_ExtendContentJson();
				extendContentJson.Os = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.Os");
				extendContentJson.OsRelease = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.OsRelease");

				List<DescribeImageVulListResponse.DescribeImageVulList_VulRecord.DescribeImageVulList_ExtendContentJson.DescribeImageVulList_RpmEntity> extendContentJson_rpmEntityList = new List<DescribeImageVulListResponse.DescribeImageVulList_VulRecord.DescribeImageVulList_ExtendContentJson.DescribeImageVulList_RpmEntity>();
				for (int j = 0; j < _ctx.Length("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList.Length"); j++) {
					DescribeImageVulListResponse.DescribeImageVulList_VulRecord.DescribeImageVulList_ExtendContentJson.DescribeImageVulList_RpmEntity rpmEntity = new DescribeImageVulListResponse.DescribeImageVulList_VulRecord.DescribeImageVulList_ExtendContentJson.DescribeImageVulList_RpmEntity();
					rpmEntity.FullVersion = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].FullVersion");
					rpmEntity.MatchDetail = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].MatchDetail");
					rpmEntity.Name = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Name");
					rpmEntity.Path = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Path");
					rpmEntity.UpdateCmd = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].UpdateCmd");
					rpmEntity.Version = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Version");
					rpmEntity.Layer = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Layer");
					rpmEntity.MatchList = _ctx.StringValue("DescribeImageVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].MatchList");

					extendContentJson_rpmEntityList.Add(rpmEntity);
				}
				extendContentJson.RpmEntityList = extendContentJson_rpmEntityList;
				vulRecord.ExtendContentJson = extendContentJson;

				describeImageVulListResponse_vulRecords.Add(vulRecord);
			}
			describeImageVulListResponse.VulRecords = describeImageVulListResponse_vulRecords;
        
			return describeImageVulListResponse;
        }
    }
}
