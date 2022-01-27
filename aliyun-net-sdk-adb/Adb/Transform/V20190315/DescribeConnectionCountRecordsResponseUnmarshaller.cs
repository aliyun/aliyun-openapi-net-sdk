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
    public class DescribeConnectionCountRecordsResponseUnmarshaller
    {
        public static DescribeConnectionCountRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConnectionCountRecordsResponse describeConnectionCountRecordsResponse = new DescribeConnectionCountRecordsResponse();

			describeConnectionCountRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeConnectionCountRecordsResponse.TotalCount = _ctx.StringValue("DescribeConnectionCountRecords.TotalCount");
			describeConnectionCountRecordsResponse.RequestId = _ctx.StringValue("DescribeConnectionCountRecords.RequestId");
			describeConnectionCountRecordsResponse.DBClusterId = _ctx.StringValue("DescribeConnectionCountRecords.DBClusterId");

			List<DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_Users> describeConnectionCountRecordsResponse_userRecords = new List<DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_Users>();
			for (int i = 0; i < _ctx.Length("DescribeConnectionCountRecords.UserRecords.Length"); i++) {
				DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_Users users = new DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_Users();
				users.User = _ctx.StringValue("DescribeConnectionCountRecords.UserRecords["+ i +"].User");
				users.Count = _ctx.LongValue("DescribeConnectionCountRecords.UserRecords["+ i +"].Count");

				describeConnectionCountRecordsResponse_userRecords.Add(users);
			}
			describeConnectionCountRecordsResponse.UserRecords = describeConnectionCountRecordsResponse_userRecords;

			List<DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_AccessIps> describeConnectionCountRecordsResponse_accessIpRecords = new List<DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_AccessIps>();
			for (int i = 0; i < _ctx.Length("DescribeConnectionCountRecords.AccessIpRecords.Length"); i++) {
				DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_AccessIps accessIps = new DescribeConnectionCountRecordsResponse.DescribeConnectionCountRecords_AccessIps();
				accessIps.AccessIp = _ctx.StringValue("DescribeConnectionCountRecords.AccessIpRecords["+ i +"].AccessIp");
				accessIps.Count = _ctx.LongValue("DescribeConnectionCountRecords.AccessIpRecords["+ i +"].Count");

				describeConnectionCountRecordsResponse_accessIpRecords.Add(accessIps);
			}
			describeConnectionCountRecordsResponse.AccessIpRecords = describeConnectionCountRecordsResponse_accessIpRecords;
        
			return describeConnectionCountRecordsResponse;
        }
    }
}
