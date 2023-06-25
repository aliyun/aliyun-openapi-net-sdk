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
    public class DescribeInstanceListResponseUnmarshaller
    {
        public static DescribeInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceListResponse describeInstanceListResponse = new DescribeInstanceListResponse();

			describeInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceListResponse.Total = _ctx.LongValue("DescribeInstanceList.Total");
			describeInstanceListResponse.RequestId = _ctx.StringValue("DescribeInstanceList.RequestId");

			List<DescribeInstanceListResponse.DescribeInstanceList_Instance> describeInstanceListResponse_instanceList = new List<DescribeInstanceListResponse.DescribeInstanceList_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceList.InstanceList.Length"); i++) {
				DescribeInstanceListResponse.DescribeInstanceList_Instance instance = new DescribeInstanceListResponse.DescribeInstanceList_Instance();
				instance.Status = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].Status");
				instance.IpType = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].IpType");
				instance.AutoRenewal = _ctx.BooleanValue("DescribeInstanceList.InstanceList["+ i +"].AutoRenewal");
				instance.Remark = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].Remark");
				instance.ExpireTime = _ctx.LongValue("DescribeInstanceList.InstanceList["+ i +"].ExpireTime");
				instance.Product = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].Product");
				instance.GmtCreate = _ctx.LongValue("DescribeInstanceList.InstanceList["+ i +"].GmtCreate");
				instance.InstanceId = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].InstanceId");
				instance.InstanceType = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].InstanceType");
				instance.BlackholdingCount = _ctx.StringValue("DescribeInstanceList.InstanceList["+ i +"].BlackholdingCount");
				instance.CoverageType = _ctx.IntegerValue("DescribeInstanceList.InstanceList["+ i +"].CoverageType");

				describeInstanceListResponse_instanceList.Add(instance);
			}
			describeInstanceListResponse.InstanceList = describeInstanceListResponse_instanceList;
        
			return describeInstanceListResponse;
        }
    }
}
