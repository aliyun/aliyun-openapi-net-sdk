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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterVersionResponseUnmarshaller
    {
        public static DescribeDBClusterVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterVersionResponse describeDBClusterVersionResponse = new DescribeDBClusterVersionResponse();

			describeDBClusterVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterVersionResponse.IsLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.IsLatestVersion");
			describeDBClusterVersionResponse.IsProxyLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.IsProxyLatestVersion");
			describeDBClusterVersionResponse.DBVersion = _ctx.StringValue("DescribeDBClusterVersion.DBVersion");
			describeDBClusterVersionResponse.DBRevisionVersion = _ctx.StringValue("DescribeDBClusterVersion.DBRevisionVersion");
			describeDBClusterVersionResponse.RequestId = _ctx.StringValue("DescribeDBClusterVersion.RequestId");
			describeDBClusterVersionResponse.DBVersionStatus = _ctx.StringValue("DescribeDBClusterVersion.DBVersionStatus");
			describeDBClusterVersionResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterVersion.DBClusterId");
			describeDBClusterVersionResponse.DBMinorVersion = _ctx.StringValue("DescribeDBClusterVersion.DBMinorVersion");
			describeDBClusterVersionResponse.ProxyRevisionVersion = _ctx.StringValue("DescribeDBClusterVersion.ProxyRevisionVersion");
			describeDBClusterVersionResponse.ProxyVersionStatus = _ctx.StringValue("DescribeDBClusterVersion.ProxyVersionStatus");
			describeDBClusterVersionResponse.ProxyLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.ProxyLatestVersion");
			describeDBClusterVersionResponse.DBLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.DBLatestVersion");
			describeDBClusterVersionResponse.ProxyLatestVersionAfterDBEngineUpgraded = _ctx.StringValue("DescribeDBClusterVersion.ProxyLatestVersionAfterDBEngineUpgraded");
			describeDBClusterVersionResponse.DBInnerRevisionVersion = _ctx.StringValue("DescribeDBClusterVersion.DBInnerRevisionVersion");

			List<DescribeDBClusterVersionResponse.DescribeDBClusterVersion_DBRevisionVersionListItem> describeDBClusterVersionResponse_dBRevisionVersionList = new List<DescribeDBClusterVersionResponse.DescribeDBClusterVersion_DBRevisionVersionListItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterVersion.DBRevisionVersionList.Length"); i++) {
				DescribeDBClusterVersionResponse.DescribeDBClusterVersion_DBRevisionVersionListItem dBRevisionVersionListItem = new DescribeDBClusterVersionResponse.DescribeDBClusterVersion_DBRevisionVersionListItem();
				dBRevisionVersionListItem.ReleaseType = _ctx.StringValue("DescribeDBClusterVersion.DBRevisionVersionList["+ i +"].ReleaseType");
				dBRevisionVersionListItem.RevisionVersionCode = _ctx.StringValue("DescribeDBClusterVersion.DBRevisionVersionList["+ i +"].RevisionVersionCode");
				dBRevisionVersionListItem.RevisionVersionName = _ctx.StringValue("DescribeDBClusterVersion.DBRevisionVersionList["+ i +"].RevisionVersionName");
				dBRevisionVersionListItem.ReleaseNote = _ctx.StringValue("DescribeDBClusterVersion.DBRevisionVersionList["+ i +"].ReleaseNote");

				describeDBClusterVersionResponse_dBRevisionVersionList.Add(dBRevisionVersionListItem);
			}
			describeDBClusterVersionResponse.DBRevisionVersionList = describeDBClusterVersionResponse_dBRevisionVersionList;

			List<DescribeDBClusterVersionResponse.DescribeDBClusterVersion_ProxyRevisionVersionListItem> describeDBClusterVersionResponse_proxyRevisionVersionList = new List<DescribeDBClusterVersionResponse.DescribeDBClusterVersion_ProxyRevisionVersionListItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterVersion.ProxyRevisionVersionList.Length"); i++) {
				DescribeDBClusterVersionResponse.DescribeDBClusterVersion_ProxyRevisionVersionListItem proxyRevisionVersionListItem = new DescribeDBClusterVersionResponse.DescribeDBClusterVersion_ProxyRevisionVersionListItem();
				proxyRevisionVersionListItem.ReleaseType = _ctx.StringValue("DescribeDBClusterVersion.ProxyRevisionVersionList["+ i +"].ReleaseType");
				proxyRevisionVersionListItem.RevisionVersionCode = _ctx.StringValue("DescribeDBClusterVersion.ProxyRevisionVersionList["+ i +"].RevisionVersionCode");
				proxyRevisionVersionListItem.RevisionVersionName = _ctx.StringValue("DescribeDBClusterVersion.ProxyRevisionVersionList["+ i +"].RevisionVersionName");
				proxyRevisionVersionListItem.ReleaseNote = _ctx.StringValue("DescribeDBClusterVersion.ProxyRevisionVersionList["+ i +"].ReleaseNote");

				describeDBClusterVersionResponse_proxyRevisionVersionList.Add(proxyRevisionVersionListItem);
			}
			describeDBClusterVersionResponse.ProxyRevisionVersionList = describeDBClusterVersionResponse_proxyRevisionVersionList;
        
			return describeDBClusterVersionResponse;
        }
    }
}
