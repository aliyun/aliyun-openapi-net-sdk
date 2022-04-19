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
        public static DescribeAssetDetailByUuidResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAssetDetailByUuidResponse describeAssetDetailByUuidResponse = new DescribeAssetDetailByUuidResponse();

			describeAssetDetailByUuidResponse.HttpResponse = _ctx.HttpResponse;
			describeAssetDetailByUuidResponse.RequestId = _ctx.StringValue("DescribeAssetDetailByUuid.RequestId");

			DescribeAssetDetailByUuidResponse.DescribeAssetDetailByUuid_AssetDetail assetDetail = new DescribeAssetDetailByUuidResponse.DescribeAssetDetailByUuid_AssetDetail();
			assetDetail.CpuInfo = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.CpuInfo");
			assetDetail.InternetIp = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.InternetIp");
			assetDetail.OsDetail = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.OsDetail");
			assetDetail.CreateTime = _ctx.LongValue("DescribeAssetDetailByUuid.AssetDetail.CreateTime");
			assetDetail.Kernel = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.Kernel");
			assetDetail.Bind = _ctx.BooleanValue("DescribeAssetDetailByUuid.AssetDetail.Bind");
			assetDetail.OsName = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.OsName");
			assetDetail.Tag = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.Tag");
			assetDetail.ClientStatus = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.ClientStatus");
			assetDetail.Mem = _ctx.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.Mem");
			assetDetail.Memory = _ctx.LongValue("DescribeAssetDetailByUuid.AssetDetail.Memory");
			assetDetail.VpcInstanceId = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.VpcInstanceId");
			assetDetail.AuthVersion = _ctx.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.AuthVersion");
			assetDetail.InstanceName = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.InstanceName");
			assetDetail.Region = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.Region");
			assetDetail.GroupTrace = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.GroupTrace");
			assetDetail.Ip = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.Ip");
			assetDetail.HostName = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.HostName");
			assetDetail.Os = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.Os");
			assetDetail.AuthModifyTime = _ctx.LongValue("DescribeAssetDetailByUuid.AssetDetail.AuthModifyTime");
			assetDetail.InstanceId = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.InstanceId");
			assetDetail.IntranetIp = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.IntranetIp");
			assetDetail.AssetType = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.AssetType");
			assetDetail.RegionId = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.RegionId");
			assetDetail.SysInfo = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.SysInfo");
			assetDetail.Uuid = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.Uuid");
			assetDetail.Cpu = _ctx.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.Cpu");
			assetDetail.RegionName = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.RegionName");
			assetDetail.InstanceStatus = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.InstanceStatus");
			assetDetail.Flag = _ctx.IntegerValue("DescribeAssetDetailByUuid.AssetDetail.Flag");
			assetDetail.ClientVersion = _ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.ClientVersion");

			List<string> assetDetail_ipList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAssetDetailByUuid.AssetDetail.IpList.Length"); i++) {
				assetDetail_ipList.Add(_ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.IpList["+ i +"]"));
			}
			assetDetail.IpList = assetDetail_ipList;

			List<string> assetDetail_macList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAssetDetailByUuid.AssetDetail.MacList.Length"); i++) {
				assetDetail_macList.Add(_ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.MacList["+ i +"]"));
			}
			assetDetail.MacList = assetDetail_macList;

			List<string> assetDetail_diskInfoList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAssetDetailByUuid.AssetDetail.DiskInfoList.Length"); i++) {
				assetDetail_diskInfoList.Add(_ctx.StringValue("DescribeAssetDetailByUuid.AssetDetail.DiskInfoList["+ i +"]"));
			}
			assetDetail.DiskInfoList = assetDetail_diskInfoList;
			describeAssetDetailByUuidResponse.AssetDetail = assetDetail;
        
			return describeAssetDetailByUuidResponse;
        }
    }
}
