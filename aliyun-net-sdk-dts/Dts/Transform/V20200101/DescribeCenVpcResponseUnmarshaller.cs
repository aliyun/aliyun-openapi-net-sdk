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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeCenVpcResponseUnmarshaller
    {
        public static DescribeCenVpcResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCenVpcResponse describeCenVpcResponse = new DescribeCenVpcResponse();

			describeCenVpcResponse.HttpResponse = _ctx.HttpResponse;
			describeCenVpcResponse.DynamicCode = _ctx.StringValue("DescribeCenVpc.DynamicCode");
			describeCenVpcResponse.DynamicMessage = _ctx.StringValue("DescribeCenVpc.DynamicMessage");
			describeCenVpcResponse.ErrCode = _ctx.StringValue("DescribeCenVpc.ErrCode");
			describeCenVpcResponse.ErrMessage = _ctx.StringValue("DescribeCenVpc.ErrMessage");
			describeCenVpcResponse.HttpStatusCode = _ctx.IntegerValue("DescribeCenVpc.HttpStatusCode");
			describeCenVpcResponse.RequestId = _ctx.StringValue("DescribeCenVpc.RequestId");
			describeCenVpcResponse.Success = _ctx.BooleanValue("DescribeCenVpc.Success");

			List<DescribeCenVpcResponse.DescribeCenVpc_CenVpcItem> describeCenVpcResponse_cenVpc = new List<DescribeCenVpcResponse.DescribeCenVpc_CenVpcItem>();
			for (int i = 0; i < _ctx.Length("DescribeCenVpc.CenVpc.Length"); i++) {
				DescribeCenVpcResponse.DescribeCenVpc_CenVpcItem cenVpcItem = new DescribeCenVpcResponse.DescribeCenVpc_CenVpcItem();
				cenVpcItem.Engine = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].Engine");
				cenVpcItem.GroupId = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].GroupId");
				cenVpcItem.InstanceId = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].InstanceId");
				cenVpcItem.InstanceName = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].InstanceName");
				cenVpcItem.Ip = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].Ip");
				cenVpcItem.Port = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].Port");
				cenVpcItem.Region = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].Region");
				cenVpcItem.Status = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].Status");
				cenVpcItem.VpcCloudInstanceId = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].VpcCloudInstanceId");
				cenVpcItem.VpcId = _ctx.StringValue("DescribeCenVpc.CenVpc["+ i +"].VpcId");

				describeCenVpcResponse_cenVpc.Add(cenVpcItem);
			}
			describeCenVpcResponse.CenVpc = describeCenVpcResponse_cenVpc;
        
			return describeCenVpcResponse;
        }
    }
}
