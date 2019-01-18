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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ots.Model.V20160620;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ots.Transform.V20160620
{
    public class ListVpcInfoByInstanceResponseUnmarshaller
    {
        public static ListVpcInfoByInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListVpcInfoByInstanceResponse listVpcInfoByInstanceResponse = new ListVpcInfoByInstanceResponse();

			listVpcInfoByInstanceResponse.HttpResponse = context.HttpResponse;
			listVpcInfoByInstanceResponse.RequestId = context.StringValue("ListVpcInfoByInstance.RequestId");
			listVpcInfoByInstanceResponse.InstanceName = context.StringValue("ListVpcInfoByInstance.InstanceName");
			listVpcInfoByInstanceResponse.TotalCount = context.LongValue("ListVpcInfoByInstance.TotalCount");
			listVpcInfoByInstanceResponse.PageNum = context.LongValue("ListVpcInfoByInstance.PageNum");
			listVpcInfoByInstanceResponse.PageSize = context.LongValue("ListVpcInfoByInstance.PageSize");

			List<ListVpcInfoByInstanceResponse.ListVpcInfoByInstance_VpcInfo> listVpcInfoByInstanceResponse_vpcInfos = new List<ListVpcInfoByInstanceResponse.ListVpcInfoByInstance_VpcInfo>();
			for (int i = 0; i < context.Length("ListVpcInfoByInstance.VpcInfos.Length"); i++) {
				ListVpcInfoByInstanceResponse.ListVpcInfoByInstance_VpcInfo vpcInfo = new ListVpcInfoByInstanceResponse.ListVpcInfoByInstance_VpcInfo();
				vpcInfo.InstanceVpcName = context.StringValue("ListVpcInfoByInstance.VpcInfos["+ i +"].InstanceVpcName");
				vpcInfo.VpcId = context.StringValue("ListVpcInfoByInstance.VpcInfos["+ i +"].VpcId");
				vpcInfo.Endpoint = context.StringValue("ListVpcInfoByInstance.VpcInfos["+ i +"].Endpoint");
				vpcInfo.Domain = context.StringValue("ListVpcInfoByInstance.VpcInfos["+ i +"].Domain");
				vpcInfo.RegionNo = context.StringValue("ListVpcInfoByInstance.VpcInfos["+ i +"].RegionNo");

				listVpcInfoByInstanceResponse_vpcInfos.Add(vpcInfo);
			}
			listVpcInfoByInstanceResponse.VpcInfos = listVpcInfoByInstanceResponse_vpcInfos;
        
			return listVpcInfoByInstanceResponse;
        }
    }
}