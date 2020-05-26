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
    public class DescribeAssetDetailByUuidResponseUnmarshaller
    {
        public static DescribeAssetDetailByUuidResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAssetDetailByUuidResponse describeAssetDetailByUuidResponse = new DescribeAssetDetailByUuidResponse();

			describeAssetDetailByUuidResponse.HttpResponse = context.HttpResponse;
			describeAssetDetailByUuidResponse.RequestId = context.StringValue("DescribeAssetDetailByUuid.RequestId");

			DescribeAssetDetailByUuidResponse.DescribeAssetDetailByUuid_AssetDetail assetDetail = new DescribeAssetDetailByUuidResponse.DescribeAssetDetailByUuid_AssetDetail();
			assetDetail.InternetIp = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.InternetIp");
			assetDetail.IntranetIp = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.IntranetIp");
			assetDetail.InstanceName = context.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.InstanceName");
			assetDetail.InstanceId = context.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.InstanceId");
			assetDetail.Ip = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.Ip");
			assetDetail.Uuid = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.Uuid");
			assetDetail.AssetType = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.AssetType");
			assetDetail.Os = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.Os");
			assetDetail.ClientStatus = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.ClientStatus");
			assetDetail.Region = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.Region");
			assetDetail.RegionName = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.RegionName");
			assetDetail.Tag = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.Tag");
			assetDetail.GroupTrace = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.GroupTrace");
			assetDetail.Cpu = context.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.Cpu");
			assetDetail.CpuInfo = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.CpuInfo");
			assetDetail.Kernel = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.Kernel");
			assetDetail.OsDetail = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.OsDetail");
			assetDetail.Mem = context.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.Mem");
			assetDetail.SysInfo = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.SysInfo");
			assetDetail.HostName = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.HostName");
			assetDetail.OsName = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.OsName");
			assetDetail.VpcInstanceId = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.VpcInstanceId");
			assetDetail.OsName1 = context.StringValue("DescribeAssetDetailByUuid.AssetDetail.OsName");

			List<string> assetDetail_ipList = new List<string>();
			for (int i = 0; i < context.Length("DescribeAssetDetailByUuid.AssetDetail.IpList.Length"); i++) {
				assetDetail_ipList.Add(context.StringValue("DescribeAssetDetailByUuid.AssetDetail.IpList["+ i +"]"));
			}
			assetDetail.IpList = assetDetail_ipList;

			List<string> assetDetail_macList = new List<string>();
			for (int i = 0; i < context.Length("DescribeAssetDetailByUuid.AssetDetail.MacList.Length"); i++) {
				assetDetail_macList.Add(context.StringValue("DescribeAssetDetailByUuid.AssetDetail.MacList["+ i +"]"));
			}
			assetDetail.MacList = assetDetail_macList;

			List<string> assetDetail_diskInfoList = new List<string>();
			for (int i = 0; i < context.Length("DescribeAssetDetailByUuid.AssetDetail.DiskInfoList.Length"); i++) {
				assetDetail_diskInfoList.Add(context.StringValue("DescribeAssetDetailByUuid.AssetDetail.DiskInfoList["+ i +"]"));
			}
			assetDetail.DiskInfoList = assetDetail_diskInfoList;
			describeAssetDetailByUuidResponse.AssetDetail = assetDetail;
        
			return describeAssetDetailByUuidResponse;
        }
    }
}
