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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeNodeCidrListResponseUnmarshaller
    {
        public static DescribeNodeCidrListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNodeCidrListResponse describeNodeCidrListResponse = new DescribeNodeCidrListResponse();

			describeNodeCidrListResponse.HttpResponse = _ctx.HttpResponse;
			describeNodeCidrListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeNodeCidrList.HttpStatusCode");
			describeNodeCidrListResponse.RequestId = _ctx.StringValue("DescribeNodeCidrList.RequestId");
			describeNodeCidrListResponse.ErrCode = _ctx.StringValue("DescribeNodeCidrList.ErrCode");
			describeNodeCidrListResponse.Success = _ctx.BooleanValue("DescribeNodeCidrList.Success");
			describeNodeCidrListResponse.ErrMessage = _ctx.StringValue("DescribeNodeCidrList.ErrMessage");

			List<string> describeNodeCidrListResponse_intranetIPs = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeNodeCidrList.IntranetIPs.Length"); i++) {
				describeNodeCidrListResponse_intranetIPs.Add(_ctx.StringValue("DescribeNodeCidrList.IntranetIPs["+ i +"]"));
			}
			describeNodeCidrListResponse.IntranetIPs = describeNodeCidrListResponse_intranetIPs;

			List<string> describeNodeCidrListResponse_internetIPs = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeNodeCidrList.InternetIPs.Length"); i++) {
				describeNodeCidrListResponse_internetIPs.Add(_ctx.StringValue("DescribeNodeCidrList.InternetIPs["+ i +"]"));
			}
			describeNodeCidrListResponse.InternetIPs = describeNodeCidrListResponse_internetIPs;
        
			return describeNodeCidrListResponse;
        }
    }
}
