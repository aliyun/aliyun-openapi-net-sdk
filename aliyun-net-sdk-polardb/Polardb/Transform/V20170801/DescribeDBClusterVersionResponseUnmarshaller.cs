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
			describeDBClusterVersionResponse.ProxyVersionStatus = _ctx.StringValue("DescribeDBClusterVersion.ProxyVersionStatus");
			describeDBClusterVersionResponse.IsLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.IsLatestVersion");
			describeDBClusterVersionResponse.DBVersion = _ctx.StringValue("DescribeDBClusterVersion.DBVersion");
			describeDBClusterVersionResponse.RequestId = _ctx.StringValue("DescribeDBClusterVersion.RequestId");
			describeDBClusterVersionResponse.DBRevisionVersion = _ctx.StringValue("DescribeDBClusterVersion.DBRevisionVersion");
			describeDBClusterVersionResponse.DBVersionStatus = _ctx.StringValue("DescribeDBClusterVersion.DBVersionStatus");
			describeDBClusterVersionResponse.DBClusterId = _ctx.StringValue("DescribeDBClusterVersion.DBClusterId");
			describeDBClusterVersionResponse.DBLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.DBLatestVersion");
			describeDBClusterVersionResponse.ProxyRevisionVersion = _ctx.StringValue("DescribeDBClusterVersion.ProxyRevisionVersion");
			describeDBClusterVersionResponse.DBMinorVersion = _ctx.StringValue("DescribeDBClusterVersion.DBMinorVersion");
			describeDBClusterVersionResponse.ProxyLatestVersion = _ctx.StringValue("DescribeDBClusterVersion.ProxyLatestVersion");
        
			return describeDBClusterVersionResponse;
        }
    }
}
