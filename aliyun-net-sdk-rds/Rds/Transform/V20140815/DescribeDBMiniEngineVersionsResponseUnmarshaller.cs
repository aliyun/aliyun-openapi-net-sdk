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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBMiniEngineVersionsResponseUnmarshaller
    {
        public static DescribeDBMiniEngineVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBMiniEngineVersionsResponse describeDBMiniEngineVersionsResponse = new DescribeDBMiniEngineVersionsResponse();

			describeDBMiniEngineVersionsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBMiniEngineVersionsResponse.DBInstanceId = _ctx.StringValue("DescribeDBMiniEngineVersions.DBInstanceId");
			describeDBMiniEngineVersionsResponse.RequestId = _ctx.StringValue("DescribeDBMiniEngineVersions.RequestId");
			describeDBMiniEngineVersionsResponse.TotalCount = _ctx.IntegerValue("DescribeDBMiniEngineVersions.TotalCount");
			describeDBMiniEngineVersionsResponse.PageNumbers = _ctx.IntegerValue("DescribeDBMiniEngineVersions.PageNumbers");
			describeDBMiniEngineVersionsResponse.MaxRecordsPerPage = _ctx.IntegerValue("DescribeDBMiniEngineVersions.MaxRecordsPerPage");

			List<DescribeDBMiniEngineVersionsResponse.DescribeDBMiniEngineVersions_MinorVersionItemsItem> describeDBMiniEngineVersionsResponse_minorVersionItems = new List<DescribeDBMiniEngineVersionsResponse.DescribeDBMiniEngineVersions_MinorVersionItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBMiniEngineVersions.MinorVersionItems.Length"); i++) {
				DescribeDBMiniEngineVersionsResponse.DescribeDBMiniEngineVersions_MinorVersionItemsItem minorVersionItemsItem = new DescribeDBMiniEngineVersionsResponse.DescribeDBMiniEngineVersions_MinorVersionItemsItem();
				minorVersionItemsItem.ReleaseNote = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].ReleaseNote");
				minorVersionItemsItem.NodeType = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].NodeType");
				minorVersionItemsItem.IsHotfixVersion = _ctx.BooleanValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].IsHotfixVersion");
				minorVersionItemsItem.Engine = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].Engine");
				minorVersionItemsItem.ReleaseType = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].ReleaseType");
				minorVersionItemsItem.StatusDesc = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].StatusDesc");
				minorVersionItemsItem.EngineVersion = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].EngineVersion");
				minorVersionItemsItem.MinorVersion = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].MinorVersion");
				minorVersionItemsItem.CommunityMinorVersion = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].CommunityMinorVersion");
				minorVersionItemsItem.Tag = _ctx.StringValue("DescribeDBMiniEngineVersions.MinorVersionItems["+ i +"].Tag");

				describeDBMiniEngineVersionsResponse_minorVersionItems.Add(minorVersionItemsItem);
			}
			describeDBMiniEngineVersionsResponse.MinorVersionItems = describeDBMiniEngineVersionsResponse_minorVersionItems;
        
			return describeDBMiniEngineVersionsResponse;
        }
    }
}
