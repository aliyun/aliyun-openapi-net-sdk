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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBClusterAccessWhiteListResponseUnmarshaller
    {
        public static DescribeDBClusterAccessWhiteListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterAccessWhiteListResponse describeDBClusterAccessWhiteListResponse = new DescribeDBClusterAccessWhiteListResponse();

			describeDBClusterAccessWhiteListResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterAccessWhiteListResponse.RequestId = _ctx.StringValue("DescribeDBClusterAccessWhiteList.RequestId");

			List<DescribeDBClusterAccessWhiteListResponse.DescribeDBClusterAccessWhiteList_IPArray> describeDBClusterAccessWhiteListResponse_items = new List<DescribeDBClusterAccessWhiteListResponse.DescribeDBClusterAccessWhiteList_IPArray>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterAccessWhiteList.Items.Length"); i++) {
				DescribeDBClusterAccessWhiteListResponse.DescribeDBClusterAccessWhiteList_IPArray iPArray = new DescribeDBClusterAccessWhiteListResponse.DescribeDBClusterAccessWhiteList_IPArray();
				iPArray.DBClusterIPArrayName = _ctx.StringValue("DescribeDBClusterAccessWhiteList.Items["+ i +"].DBClusterIPArrayName");
				iPArray.SecurityIPList = _ctx.StringValue("DescribeDBClusterAccessWhiteList.Items["+ i +"].SecurityIPList");
				iPArray.DBClusterIPArrayAttribute = _ctx.StringValue("DescribeDBClusterAccessWhiteList.Items["+ i +"].DBClusterIPArrayAttribute");

				describeDBClusterAccessWhiteListResponse_items.Add(iPArray);
			}
			describeDBClusterAccessWhiteListResponse.Items = describeDBClusterAccessWhiteListResponse_items;
        
			return describeDBClusterAccessWhiteListResponse;
        }
    }
}
