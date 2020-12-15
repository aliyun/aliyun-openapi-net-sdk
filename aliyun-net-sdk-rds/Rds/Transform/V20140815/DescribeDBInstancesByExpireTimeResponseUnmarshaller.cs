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
    public class DescribeDBInstancesByExpireTimeResponseUnmarshaller
    {
        public static DescribeDBInstancesByExpireTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesByExpireTimeResponse describeDBInstancesByExpireTimeResponse = new DescribeDBInstancesByExpireTimeResponse();

			describeDBInstancesByExpireTimeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesByExpireTimeResponse.RequestId = _ctx.StringValue("DescribeDBInstancesByExpireTime.RequestId");
			describeDBInstancesByExpireTimeResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstancesByExpireTime.PageNumber");
			describeDBInstancesByExpireTimeResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstancesByExpireTime.TotalRecordCount");
			describeDBInstancesByExpireTimeResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBInstancesByExpireTime.PageRecordCount");

			List<DescribeDBInstancesByExpireTimeResponse.DescribeDBInstancesByExpireTime_DBInstanceExpireTime> describeDBInstancesByExpireTimeResponse_items = new List<DescribeDBInstancesByExpireTimeResponse.DescribeDBInstancesByExpireTime_DBInstanceExpireTime>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstancesByExpireTime.Items.Length"); i++) {
				DescribeDBInstancesByExpireTimeResponse.DescribeDBInstancesByExpireTime_DBInstanceExpireTime dBInstanceExpireTime = new DescribeDBInstancesByExpireTimeResponse.DescribeDBInstancesByExpireTime_DBInstanceExpireTime();
				dBInstanceExpireTime.DBInstanceId = _ctx.StringValue("DescribeDBInstancesByExpireTime.Items["+ i +"].DBInstanceId");
				dBInstanceExpireTime.DBInstanceDescription = _ctx.StringValue("DescribeDBInstancesByExpireTime.Items["+ i +"].DBInstanceDescription");
				dBInstanceExpireTime.ExpireTime = _ctx.StringValue("DescribeDBInstancesByExpireTime.Items["+ i +"].ExpireTime");
				dBInstanceExpireTime.DBInstanceStatus = _ctx.StringValue("DescribeDBInstancesByExpireTime.Items["+ i +"].DBInstanceStatus");
				dBInstanceExpireTime.LockMode = _ctx.StringValue("DescribeDBInstancesByExpireTime.Items["+ i +"].LockMode");
				dBInstanceExpireTime.PayType = _ctx.StringValue("DescribeDBInstancesByExpireTime.Items["+ i +"].PayType");

				describeDBInstancesByExpireTimeResponse_items.Add(dBInstanceExpireTime);
			}
			describeDBInstancesByExpireTimeResponse.Items = describeDBInstancesByExpireTimeResponse_items;
        
			return describeDBInstancesByExpireTimeResponse;
        }
    }
}
