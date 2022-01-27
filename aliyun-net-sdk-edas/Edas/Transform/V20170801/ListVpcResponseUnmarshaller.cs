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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListVpcResponseUnmarshaller
    {
        public static ListVpcResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcResponse listVpcResponse = new ListVpcResponse();

			listVpcResponse.HttpResponse = _ctx.HttpResponse;
			listVpcResponse.Code = _ctx.IntegerValue("ListVpc.Code");
			listVpcResponse.Message = _ctx.StringValue("ListVpc.Message");
			listVpcResponse.RequestId = _ctx.StringValue("ListVpc.RequestId");

			List<ListVpcResponse.ListVpc_VpcEntity> listVpcResponse_vpcList = new List<ListVpcResponse.ListVpc_VpcEntity>();
			for (int i = 0; i < _ctx.Length("ListVpc.VpcList.Length"); i++) {
				ListVpcResponse.ListVpc_VpcEntity vpcEntity = new ListVpcResponse.ListVpc_VpcEntity();
				vpcEntity.VpcId = _ctx.StringValue("ListVpc.VpcList["+ i +"].VpcId");
				vpcEntity.VpcName = _ctx.StringValue("ListVpc.VpcList["+ i +"].VpcName");
				vpcEntity.RegionId = _ctx.StringValue("ListVpc.VpcList["+ i +"].RegionId");
				vpcEntity.UserId = _ctx.StringValue("ListVpc.VpcList["+ i +"].UserId");
				vpcEntity.Expired = _ctx.BooleanValue("ListVpc.VpcList["+ i +"].Expired");
				vpcEntity.EcsNum = _ctx.IntegerValue("ListVpc.VpcList["+ i +"].EcsNum");

				listVpcResponse_vpcList.Add(vpcEntity);
			}
			listVpcResponse.VpcList = listVpcResponse_vpcList;
        
			return listVpcResponse;
        }
    }
}
