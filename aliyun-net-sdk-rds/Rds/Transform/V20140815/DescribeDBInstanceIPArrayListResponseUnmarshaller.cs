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
    public class DescribeDBInstanceIPArrayListResponseUnmarshaller
    {
        public static DescribeDBInstanceIPArrayListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceIPArrayListResponse describeDBInstanceIPArrayListResponse = new DescribeDBInstanceIPArrayListResponse();

			describeDBInstanceIPArrayListResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceIPArrayListResponse.RequestId = context.StringValue("DescribeDBInstanceIPArrayList.RequestId");

			List<DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray> describeDBInstanceIPArrayListResponse_items = new List<DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray>();
			for (int i = 0; i < context.Length("DescribeDBInstanceIPArrayList.Items.Length"); i++) {
				DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray dBInstanceIPArray = new DescribeDBInstanceIPArrayListResponse.DescribeDBInstanceIPArrayList_DBInstanceIPArray();
				dBInstanceIPArray.DBInstanceIPArrayName = context.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].DBInstanceIPArrayName");
				dBInstanceIPArray.DBInstanceIPArrayAttribute = context.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].DBInstanceIPArrayAttribute");
				dBInstanceIPArray.SecurityIPType = context.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].SecurityIPType");
				dBInstanceIPArray.SecurityIPList = context.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].SecurityIPList");
				dBInstanceIPArray.WhitelistNetworkType = context.StringValue("DescribeDBInstanceIPArrayList.Items["+ i +"].WhitelistNetworkType");

				describeDBInstanceIPArrayListResponse_items.Add(dBInstanceIPArray);
			}
			describeDBInstanceIPArrayListResponse.Items = describeDBInstanceIPArrayListResponse_items;
        
			return describeDBInstanceIPArrayListResponse;
        }
    }
}
