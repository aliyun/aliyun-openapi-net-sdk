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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeEngineVersionResponseUnmarshaller
    {
        public static DescribeEngineVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEngineVersionResponse describeEngineVersionResponse = new DescribeEngineVersionResponse();

			describeEngineVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeEngineVersionResponse.IsLatestVersion = _ctx.BooleanValue("DescribeEngineVersion.IsLatestVersion");
			describeEngineVersionResponse.RequestId = _ctx.StringValue("DescribeEngineVersion.RequestId");
			describeEngineVersionResponse.ProxyMinorVersion = _ctx.StringValue("DescribeEngineVersion.ProxyMinorVersion");
			describeEngineVersionResponse.DBVersionRelease = _ctx.StringValue("DescribeEngineVersion.DBVersionRelease");
			describeEngineVersionResponse.ProxyVersionRelease = _ctx.StringValue("DescribeEngineVersion.ProxyVersionRelease");
			describeEngineVersionResponse.EnableUpgradeMajorVersion = _ctx.BooleanValue("DescribeEngineVersion.EnableUpgradeMajorVersion");
			describeEngineVersionResponse.EnableUpgradeMinorVersion = _ctx.BooleanValue("DescribeEngineVersion.EnableUpgradeMinorVersion");
			describeEngineVersionResponse.MajorVersion = _ctx.StringValue("DescribeEngineVersion.MajorVersion");
			describeEngineVersionResponse.Engine = _ctx.StringValue("DescribeEngineVersion.Engine");
			describeEngineVersionResponse.MinorVersion = _ctx.StringValue("DescribeEngineVersion.MinorVersion");
			describeEngineVersionResponse.IsRedisCompatibleVersion = _ctx.StringValue("DescribeEngineVersion.IsRedisCompatibleVersion");
			describeEngineVersionResponse.IsSSLEnable = _ctx.StringValue("DescribeEngineVersion.IsSSLEnable");
			describeEngineVersionResponse.IsNewSSLMode = _ctx.StringValue("DescribeEngineVersion.IsNewSSLMode");
			describeEngineVersionResponse.IsAutoUpgradeOpen = _ctx.StringValue("DescribeEngineVersion.IsAutoUpgradeOpen");

			DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion dBLatestMinorVersion = new DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion();
			dBLatestMinorVersion.MinorVersion = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.MinorVersion");
			dBLatestMinorVersion.Level = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.Level");

			DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion.DescribeEngineVersion_VersionRelease versionRelease = new DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion.DescribeEngineVersion_VersionRelease();
			versionRelease.VersionChangesLevel = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.VersionChangesLevel");

			List<DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion.DescribeEngineVersion_VersionRelease.DescribeEngineVersion_ReleaseInfoList> versionRelease_releaseInfo = new List<DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion.DescribeEngineVersion_VersionRelease.DescribeEngineVersion_ReleaseInfoList>();
			for (int i = 0; i < _ctx.Length("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.ReleaseInfo.Length"); i++) {
				DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion.DescribeEngineVersion_VersionRelease.DescribeEngineVersion_ReleaseInfoList releaseInfoList = new DescribeEngineVersionResponse.DescribeEngineVersion_DBLatestMinorVersion.DescribeEngineVersion_VersionRelease.DescribeEngineVersion_ReleaseInfoList();
				releaseInfoList.ReleaseVersion = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].ReleaseVersion");
				releaseInfoList.CreateTime = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].CreateTime");
				releaseInfoList.ReleaseNote = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].ReleaseNote");
				releaseInfoList.Level = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].Level");
				releaseInfoList.ReleaseNoteEn = _ctx.StringValue("DescribeEngineVersion.DBLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].ReleaseNoteEn");

				versionRelease_releaseInfo.Add(releaseInfoList);
			}
			versionRelease.ReleaseInfo = versionRelease_releaseInfo;
			dBLatestMinorVersion.VersionRelease = versionRelease;
			describeEngineVersionResponse.DBLatestMinorVersion = dBLatestMinorVersion;

			DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion proxyLatestMinorVersion = new DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion();
			proxyLatestMinorVersion.MinorVersion = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.MinorVersion");
			proxyLatestMinorVersion.Level = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.Level");

			DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion.DescribeEngineVersion_VersionRelease1 versionRelease1 = new DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion.DescribeEngineVersion_VersionRelease1();
			versionRelease1.VersionChangesLevel = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.VersionChangesLevel");

			List<DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion.DescribeEngineVersion_VersionRelease1.DescribeEngineVersion_ReleaseInfoList3> versionRelease1_releaseInfo2 = new List<DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion.DescribeEngineVersion_VersionRelease1.DescribeEngineVersion_ReleaseInfoList3>();
			for (int i = 0; i < _ctx.Length("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.ReleaseInfo.Length"); i++) {
				DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion.DescribeEngineVersion_VersionRelease1.DescribeEngineVersion_ReleaseInfoList3 releaseInfoList3 = new DescribeEngineVersionResponse.DescribeEngineVersion_ProxyLatestMinorVersion.DescribeEngineVersion_VersionRelease1.DescribeEngineVersion_ReleaseInfoList3();
				releaseInfoList3.ReleaseVersion = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].ReleaseVersion");
				releaseInfoList3.CreateTime = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].CreateTime");
				releaseInfoList3.ReleaseNote = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].ReleaseNote");
				releaseInfoList3.Level = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].Level");
				releaseInfoList3.ReleaseNoteEn = _ctx.StringValue("DescribeEngineVersion.ProxyLatestMinorVersion.VersionRelease.ReleaseInfo["+ i +"].ReleaseNoteEn");

				versionRelease1_releaseInfo2.Add(releaseInfoList3);
			}
			versionRelease1.ReleaseInfo2 = versionRelease1_releaseInfo2;
			proxyLatestMinorVersion.VersionRelease1 = versionRelease1;
			describeEngineVersionResponse.ProxyLatestMinorVersion = proxyLatestMinorVersion;
        
			return describeEngineVersionResponse;
        }
    }
}
