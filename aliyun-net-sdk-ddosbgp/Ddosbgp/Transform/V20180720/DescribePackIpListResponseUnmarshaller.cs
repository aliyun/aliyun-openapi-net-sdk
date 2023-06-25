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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class DescribePackIpListResponseUnmarshaller
    {
        public static DescribePackIpListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePackIpListResponse describePackIpListResponse = new DescribePackIpListResponse();

			describePackIpListResponse.HttpResponse = _ctx.HttpResponse;
			describePackIpListResponse.Code = _ctx.StringValue("DescribePackIpList.Code");
			describePackIpListResponse.RequestId = _ctx.StringValue("DescribePackIpList.RequestId");
			describePackIpListResponse.Total = _ctx.IntegerValue("DescribePackIpList.Total");
			describePackIpListResponse.Success = _ctx.BooleanValue("DescribePackIpList.Success");

			List<DescribePackIpListResponse.DescribePackIpList_Ipitem> describePackIpListResponse_ipList = new List<DescribePackIpListResponse.DescribePackIpList_Ipitem>();
			for (int i = 0; i < _ctx.Length("DescribePackIpList.IpList.Length"); i++) {
				DescribePackIpListResponse.DescribePackIpList_Ipitem ipitem = new DescribePackIpListResponse.DescribePackIpList_Ipitem();
				ipitem.Status = _ctx.StringValue("DescribePackIpList.IpList["+ i +"].Status");
				ipitem.Ip = _ctx.StringValue("DescribePackIpList.IpList["+ i +"].Ip");
				ipitem.Remark = _ctx.StringValue("DescribePackIpList.IpList["+ i +"].Remark");
				ipitem.Product = _ctx.StringValue("DescribePackIpList.IpList["+ i +"].Product");
				ipitem.Region = _ctx.StringValue("DescribePackIpList.IpList["+ i +"].Region");

				describePackIpListResponse_ipList.Add(ipitem);
			}
			describePackIpListResponse.IpList = describePackIpListResponse_ipList;
        
			return describePackIpListResponse;
        }
    }
}
