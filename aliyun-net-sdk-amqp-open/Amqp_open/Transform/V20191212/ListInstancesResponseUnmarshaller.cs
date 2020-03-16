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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = context.HttpResponse;
			listInstancesResponse.RequestId = context.StringValue("ListInstances.RequestId");

			ListInstancesResponse.ListInstances_Data data = new ListInstancesResponse.ListInstances_Data();
			data.MaxResults = context.IntegerValue("ListInstances.Data.MaxResults");
			data.NextToken = context.StringValue("ListInstances.Data.NextToken");

			List<ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO> data_instances = new List<ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO>();
			for (int i = 0; i < context.Length("ListInstances.Data.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO instanceVO = new ListInstancesResponse.ListInstances_Data.ListInstances_InstanceVO();
				instanceVO.InstanceId = context.StringValue("ListInstances.Data.Instances["+ i +"].InstanceId");
				instanceVO.InstanceName = context.StringValue("ListInstances.Data.Instances["+ i +"].InstanceName");
				instanceVO.InstanceType = context.StringValue("ListInstances.Data.Instances["+ i +"].InstanceType");
				instanceVO.Status = context.StringValue("ListInstances.Data.Instances["+ i +"].Status");
				instanceVO.OrderType = context.StringValue("ListInstances.Data.Instances["+ i +"].OrderType");
				instanceVO.OrderCreateTime = context.LongValue("ListInstances.Data.Instances["+ i +"].OrderCreateTime");
				instanceVO.ExpireTime = context.LongValue("ListInstances.Data.Instances["+ i +"].ExpireTime");
				instanceVO.AutoRenewInstance = context.BooleanValue("ListInstances.Data.Instances["+ i +"].AutoRenewInstance");
				instanceVO.SupportEIP = context.BooleanValue("ListInstances.Data.Instances["+ i +"].SupportEIP");
				instanceVO.PrivateEndpoint = context.StringValue("ListInstances.Data.Instances["+ i +"].PrivateEndpoint");
				instanceVO.PublicEndpoint = context.StringValue("ListInstances.Data.Instances["+ i +"].PublicEndpoint");

				data_instances.Add(instanceVO);
			}
			data.Instances = data_instances;
			listInstancesResponse.Data = data;
        
			return listInstancesResponse;
        }
    }
}
