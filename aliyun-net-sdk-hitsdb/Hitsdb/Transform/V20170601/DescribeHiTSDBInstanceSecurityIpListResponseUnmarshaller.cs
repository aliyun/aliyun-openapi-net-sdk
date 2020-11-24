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
using Aliyun.Acs.hitsdb.Model.V20170601;

namespace Aliyun.Acs.hitsdb.Transform.V20170601
{
    public class DescribeHiTSDBInstanceSecurityIpListResponseUnmarshaller
    {
        public static DescribeHiTSDBInstanceSecurityIpListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHiTSDBInstanceSecurityIpListResponse describeHiTSDBInstanceSecurityIpListResponse = new DescribeHiTSDBInstanceSecurityIpListResponse();

			describeHiTSDBInstanceSecurityIpListResponse.HttpResponse = _ctx.HttpResponse;
			describeHiTSDBInstanceSecurityIpListResponse.RequestId = _ctx.StringValue("DescribeHiTSDBInstanceSecurityIpList.RequestId");

			List<DescribeHiTSDBInstanceSecurityIpListResponse.DescribeHiTSDBInstanceSecurityIpList_SecurityIp> describeHiTSDBInstanceSecurityIpListResponse_securityIpList = new List<DescribeHiTSDBInstanceSecurityIpListResponse.DescribeHiTSDBInstanceSecurityIpList_SecurityIp>();
			for (int i = 0; i < _ctx.Length("DescribeHiTSDBInstanceSecurityIpList.SecurityIpList.Length"); i++) {
				DescribeHiTSDBInstanceSecurityIpListResponse.DescribeHiTSDBInstanceSecurityIpList_SecurityIp securityIp = new DescribeHiTSDBInstanceSecurityIpListResponse.DescribeHiTSDBInstanceSecurityIpList_SecurityIp();
				securityIp.Ip = _ctx.StringValue("DescribeHiTSDBInstanceSecurityIpList.SecurityIpList["+ i +"].Ip");

				describeHiTSDBInstanceSecurityIpListResponse_securityIpList.Add(securityIp);
			}
			describeHiTSDBInstanceSecurityIpListResponse.SecurityIpList = describeHiTSDBInstanceSecurityIpListResponse_securityIpList;
        
			return describeHiTSDBInstanceSecurityIpListResponse;
        }
    }
}
