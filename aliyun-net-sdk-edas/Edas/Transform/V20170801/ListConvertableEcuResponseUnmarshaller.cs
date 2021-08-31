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
    public class ListConvertableEcuResponseUnmarshaller
    {
        public static ListConvertableEcuResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConvertableEcuResponse listConvertableEcuResponse = new ListConvertableEcuResponse();

			listConvertableEcuResponse.HttpResponse = _ctx.HttpResponse;
			listConvertableEcuResponse.Code = _ctx.IntegerValue("ListConvertableEcu.Code");
			listConvertableEcuResponse.Message = _ctx.StringValue("ListConvertableEcu.Message");
			listConvertableEcuResponse.RequestId = _ctx.StringValue("ListConvertableEcu.RequestId");

			List<ListConvertableEcuResponse.ListConvertableEcu_Instance> listConvertableEcuResponse_instanceList = new List<ListConvertableEcuResponse.ListConvertableEcu_Instance>();
			for (int i = 0; i < _ctx.Length("ListConvertableEcu.InstanceList.Length"); i++) {
				ListConvertableEcuResponse.ListConvertableEcu_Instance instance = new ListConvertableEcuResponse.ListConvertableEcu_Instance();
				instance.InstanceId = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].InstanceId");
				instance.InstanceName = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].InstanceName");
				instance.EcuId = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].EcuId");
				instance.VpcId = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].VpcId");
				instance.VpcName = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].VpcName");
				instance.Expired = _ctx.BooleanValue("ListConvertableEcu.InstanceList["+ i +"].Expired");
				instance.Status = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].Status");
				instance.RegionId = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].RegionId");
				instance.Cpu = _ctx.IntegerValue("ListConvertableEcu.InstanceList["+ i +"].Cpu");
				instance.Mem = _ctx.IntegerValue("ListConvertableEcu.InstanceList["+ i +"].Mem");
				instance.PublicIp = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].PublicIp");
				instance.InnerIp = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].InnerIp");
				instance.PrivateIp = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].PrivateIp");
				instance.Eip = _ctx.StringValue("ListConvertableEcu.InstanceList["+ i +"].Eip");

				listConvertableEcuResponse_instanceList.Add(instance);
			}
			listConvertableEcuResponse.InstanceList = listConvertableEcuResponse_instanceList;
        
			return listConvertableEcuResponse;
        }
    }
}
