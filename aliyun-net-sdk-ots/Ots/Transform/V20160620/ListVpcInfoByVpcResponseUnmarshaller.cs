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
using Aliyun.Acs.Ots.Model.V20160620;

namespace Aliyun.Acs.Ots.Transform.V20160620
{
    public class ListVpcInfoByVpcResponseUnmarshaller
    {
        public static ListVpcInfoByVpcResponse Unmarshall(UnmarshallerContext context)
        {
			ListVpcInfoByVpcResponse listVpcInfoByVpcResponse = new ListVpcInfoByVpcResponse();

			listVpcInfoByVpcResponse.HttpResponse = context.HttpResponse;
			listVpcInfoByVpcResponse.TotalCount = context.LongValue("ListVpcInfoByVpc.TotalCount");
			listVpcInfoByVpcResponse.PageNum = context.LongValue("ListVpcInfoByVpc.PageNum");
			listVpcInfoByVpcResponse.PageSize = context.LongValue("ListVpcInfoByVpc.PageSize");
			listVpcInfoByVpcResponse.RequestId = context.StringValue("ListVpcInfoByVpc.RequestId");
			listVpcInfoByVpcResponse.VpcId = context.StringValue("ListVpcInfoByVpc.VpcId");

			List<ListVpcInfoByVpcResponse.ListVpcInfoByVpc_VpcInfo> listVpcInfoByVpcResponse_vpcInfos = new List<ListVpcInfoByVpcResponse.ListVpcInfoByVpc_VpcInfo>();
			for (int i = 0; i < context.Length("ListVpcInfoByVpc.VpcInfos.Length"); i++) {
				ListVpcInfoByVpcResponse.ListVpcInfoByVpc_VpcInfo vpcInfo = new ListVpcInfoByVpcResponse.ListVpcInfoByVpc_VpcInfo();
				vpcInfo.InstanceName = context.StringValue("ListVpcInfoByVpc.VpcInfos["+ i +"].InstanceName");
				vpcInfo.InstanceVpcName = context.StringValue("ListVpcInfoByVpc.VpcInfos["+ i +"].InstanceVpcName");
				vpcInfo.Endpoint = context.StringValue("ListVpcInfoByVpc.VpcInfos["+ i +"].Endpoint");
				vpcInfo.Domain = context.StringValue("ListVpcInfoByVpc.VpcInfos["+ i +"].Domain");
				vpcInfo.RegionNo = context.StringValue("ListVpcInfoByVpc.VpcInfos["+ i +"].RegionNo");

				listVpcInfoByVpcResponse_vpcInfos.Add(vpcInfo);
			}
			listVpcInfoByVpcResponse.VpcInfos = listVpcInfoByVpcResponse_vpcInfos;
        
			return listVpcInfoByVpcResponse;
        }
    }
}
