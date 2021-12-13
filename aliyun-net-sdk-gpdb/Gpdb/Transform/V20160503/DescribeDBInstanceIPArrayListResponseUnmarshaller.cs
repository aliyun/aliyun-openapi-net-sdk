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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeDBInstanceIPArrayListResponseUnmarshaller
    {
        public static DescribeDBInstanceIPArrayListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceIPArrayListResponse describeDBInstanceIPArrayListResponse = new DescribeDBInstanceIPArrayListResponse();

			describeDBInstanceIPArrayListResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceIPArrayListResponse.RequestId = _ctx.StringValue("DescribeDBInstanceIPArrayList.RequestId");

			List<DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray> describeDBInstanceIPArrayListResponse_items = new List<DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceIPArrayList.Items.Length"); i++) {
				DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray dBInstanceIPArray = new DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray();
				dBInstanceIPArray.DBInstanceIPArrayName = _ctx.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].DBInstanceIPArrayName");
				dBInstanceIPArray.SecurityIPList = _ctx.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].SecurityIPList");
				dBInstanceIPArray.DBInstanceIPArrayAttribute = _ctx.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].DBInstanceIPArrayAttribute");

				describeDBInstanceIPArrayListResponse_items.Add(dBInstanceIPArray);
			}
			describeDBInstanceIPArrayListResponse.Items = describeDBInstanceIPArrayListResponse_items;
        
			return describeDBInstanceIPArrayListResponse;
        }
    }
}
