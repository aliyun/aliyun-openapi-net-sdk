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
    public class DescribeVulListResponseUnmarshaller
    {
        public static DescribeVulListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulListResponse describeVulListResponse = new DescribeVulListResponse();

			describeVulListResponse.HttpResponse = context.HttpResponse;
			describeVulListResponse.RequestId = context.StringValue("DescribeVulList.RequestId");
			describeVulListResponse.PageSize = context.IntegerValue("DescribeVulList.PageSize");
			describeVulListResponse.CurrentPage = context.IntegerValue("DescribeVulList.CurrentPage");
			describeVulListResponse.TotalCount = context.IntegerValue("DescribeVulList.TotalCount");

			List<DescribeVulListResponse.DescribeVulList_VulRecord> describeVulListResponse_vulRecords = new List<DescribeVulListResponse.DescribeVulList_VulRecord>();
			for (int i = 0; i < context.Length("DescribeVulList.VulRecords.Length"); i++) {
				DescribeVulListResponse.DescribeVulList_VulRecord vulRecord = new DescribeVulListResponse.DescribeVulList_VulRecord();
				vulRecord.PrimaryId = context.LongValue("DescribeVulList.VulRecords["+ i +"].PrimaryId");
				vulRecord.Uuid = context.StringValue("DescribeVulList.VulRecords["+ i +"].Uuid");
				vulRecord.Name = context.StringValue("DescribeVulList.VulRecords["+ i +"].Name");
				vulRecord.Tag = context.StringValue("DescribeVulList.VulRecords["+ i +"].Tag");
				vulRecord.Type = context.StringValue("DescribeVulList.VulRecords["+ i +"].Type");
				vulRecord.AliasName = context.StringValue("DescribeVulList.VulRecords["+ i +"].AliasName");
				vulRecord.FirstTs = context.LongValue("DescribeVulList.VulRecords["+ i +"].FirstTs");
				vulRecord.LastTs = context.LongValue("DescribeVulList.VulRecords["+ i +"].LastTs");
				vulRecord.RepairTs = context.LongValue("DescribeVulList.VulRecords["+ i +"].RepairTs");
				vulRecord.Status = context.IntegerValue("DescribeVulList.VulRecords["+ i +"].Status");
				vulRecord.Related = context.StringValue("DescribeVulList.VulRecords["+ i +"].Related");
				vulRecord.ResultCode = context.StringValue("DescribeVulList.VulRecords["+ i +"].ResultCode");
				vulRecord.ResultMessage = context.StringValue("DescribeVulList.VulRecords["+ i +"].ResultMessage");
				vulRecord.ModifyTs = context.LongValue("DescribeVulList.VulRecords["+ i +"].ModifyTs");
				vulRecord.Necessity = context.StringValue("DescribeVulList.VulRecords["+ i +"].Necessity");
				vulRecord.GroupId = context.IntegerValue("DescribeVulList.VulRecords["+ i +"].GroupId");
				vulRecord.InstanceId = context.StringValue("DescribeVulList.VulRecords["+ i +"].InstanceId");
				vulRecord.InstanceName = context.StringValue("DescribeVulList.VulRecords["+ i +"].InstanceName");
				vulRecord.InternetIp = context.StringValue("DescribeVulList.VulRecords["+ i +"].InternetIp");
				vulRecord.IntranetIp = context.StringValue("DescribeVulList.VulRecords["+ i +"].IntranetIp");
				vulRecord.Ip = context.StringValue("DescribeVulList.VulRecords["+ i +"].Ip");
				vulRecord.OsVersion = context.StringValue("DescribeVulList.VulRecords["+ i +"].OsVersion");
				vulRecord.NeedReboot = context.StringValue("DescribeVulList.VulRecords["+ i +"].NeedReboot");

				DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson extendContentJson = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson();
				extendContentJson.Os = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Os");
				extendContentJson.OsRelease = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.OsRelease");
				extendContentJson.Status = context.IntegerValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Status");
				extendContentJson.LastTs = context.LongValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.LastTs");
				extendContentJson.AliasName = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.AliasName");
				extendContentJson.Tag = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Tag");
				extendContentJson.PrimaryId = context.LongValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.PrimaryId");
				extendContentJson.AbsolutePath = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.AbsolutePath");

				List<string> extendContentJson_cveList = new List<string>();
				for (int j = 0; j < context.Length("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.CveList.Length"); j++) {
					extendContentJson_cveList.Add(context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.CveList["+ j +"]"));
				}
				extendContentJson.CveList = extendContentJson_cveList;

				DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_Necessity necessity = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_Necessity();
				necessity.Cvss_factor = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Cvss_factor");
				necessity.Gmt_create = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Gmt_create");
				necessity.Status = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Status");
				necessity.Enviroment_factor = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Enviroment_factor");
				necessity.Assets_factor = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Assets_factor");
				necessity.Is_calc = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Is_calc");
				necessity.Total_score = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Total_score");
				necessity.Time_factor = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.Necessity.Time_factor");
				extendContentJson.Necessity = necessity;

				List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntityListItem> extendContentJson_rpmEntityList = new List<DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntityListItem>();
				for (int j = 0; j < context.Length("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList.Length"); j++) {
					DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntityListItem rpmEntityListItem = new DescribeVulListResponse.DescribeVulList_VulRecord.DescribeVulList_ExtendContentJson.DescribeVulList_RpmEntityListItem();
					rpmEntityListItem.FullVersion = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].FullVersion");
					rpmEntityListItem.MatchDetail = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].MatchDetail");
					rpmEntityListItem.Name = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Name");
					rpmEntityListItem.Path = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Path");
					rpmEntityListItem.UpdateCmd = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].UpdateCmd");
					rpmEntityListItem.Version = context.StringValue("DescribeVulList.VulRecords["+ i +"].ExtendContentJson.RpmEntityList["+ j +"].Version");

					extendContentJson_rpmEntityList.Add(rpmEntityListItem);
				}
				extendContentJson.RpmEntityList = extendContentJson_rpmEntityList;
				vulRecord.ExtendContentJson = extendContentJson;

				describeVulListResponse_vulRecords.Add(vulRecord);
			}
			describeVulListResponse.VulRecords = describeVulListResponse_vulRecords;
        
			return describeVulListResponse;
        }
    }
}
