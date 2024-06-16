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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeDBNodeDirectVipInfoResponseUnmarshaller
    {
        public static DescribeDBNodeDirectVipInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBNodeDirectVipInfoResponse describeDBNodeDirectVipInfoResponse = new DescribeDBNodeDirectVipInfoResponse();

			describeDBNodeDirectVipInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDBNodeDirectVipInfoResponse.RequestId = _ctx.StringValue("DescribeDBNodeDirectVipInfo.RequestId");
			describeDBNodeDirectVipInfoResponse.InstanceId = _ctx.StringValue("DescribeDBNodeDirectVipInfo.InstanceId");

			List<DescribeDBNodeDirectVipInfoResponse.DescribeDBNodeDirectVipInfo_VipInfo> describeDBNodeDirectVipInfoResponse_directVipInfo = new List<DescribeDBNodeDirectVipInfoResponse.DescribeDBNodeDirectVipInfo_VipInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBNodeDirectVipInfo.DirectVipInfo.Length"); i++) {
				DescribeDBNodeDirectVipInfoResponse.DescribeDBNodeDirectVipInfo_VipInfo vipInfo = new DescribeDBNodeDirectVipInfoResponse.DescribeDBNodeDirectVipInfo_VipInfo();
				vipInfo.NodeId = _ctx.StringValue("DescribeDBNodeDirectVipInfo.DirectVipInfo["+ i +"].NodeId");
				vipInfo.Vip = _ctx.StringValue("DescribeDBNodeDirectVipInfo.DirectVipInfo["+ i +"].Vip");
				vipInfo.Port = _ctx.StringValue("DescribeDBNodeDirectVipInfo.DirectVipInfo["+ i +"].Port");
				vipInfo.NetType = _ctx.StringValue("DescribeDBNodeDirectVipInfo.DirectVipInfo["+ i +"].NetType");

				describeDBNodeDirectVipInfoResponse_directVipInfo.Add(vipInfo);
			}
			describeDBNodeDirectVipInfoResponse.DirectVipInfo = describeDBNodeDirectVipInfoResponse_directVipInfo;
        
			return describeDBNodeDirectVipInfoResponse;
        }
    }
}
