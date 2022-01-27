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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListApmResponseUnmarshaller
    {
        public static ListApmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApmResponse listApmResponse = new ListApmResponse();

			listApmResponse.HttpResponse = _ctx.HttpResponse;
			listApmResponse.RequestId = _ctx.StringValue("ListApm.RequestId");

			ListApmResponse.ListApm_Headers headers = new ListApmResponse.ListApm_Headers();
			headers.XTotalCount = _ctx.LongValue("ListApm.Headers.X-Total-Count");
			listApmResponse.Headers = headers;

			List<ListApmResponse.ListApm_返回结果> listApmResponse_result = new List<ListApmResponse.ListApm_返回结果>();
			for (int i = 0; i < _ctx.Length("ListApm.Result.Length"); i++) {
				ListApmResponse.ListApm_返回结果 返回结果 = new ListApmResponse.ListApm_返回结果();
				返回结果.CreatedAt = _ctx.StringValue("ListApm.Result["+ i +"].createdAt");
				返回结果.DeployedReplica = _ctx.LongValue("ListApm.Result["+ i +"].deployedReplica");
				返回结果.Description = _ctx.StringValue("ListApm.Result["+ i +"].description");
				返回结果.InstanceId = _ctx.StringValue("ListApm.Result["+ i +"].instanceId");
				返回结果.NodeAmount = _ctx.LongValue("ListApm.Result["+ i +"].nodeAmount");
				返回结果.OutputES = _ctx.StringValue("ListApm.Result["+ i +"].outputES");
				返回结果.OutputESUserName = _ctx.StringValue("ListApm.Result["+ i +"].outputESUserName");
				返回结果.OwnerId = _ctx.StringValue("ListApm.Result["+ i +"].ownerId");
				返回结果.PaymentType = _ctx.StringValue("ListApm.Result["+ i +"].paymentType");
				返回结果.Region = _ctx.StringValue("ListApm.Result["+ i +"].region");
				返回结果.Replica = _ctx.LongValue("ListApm.Result["+ i +"].replica");
				返回结果.ResourceSpec = _ctx.StringValue("ListApm.Result["+ i +"].resourceSpec");
				返回结果.Status = _ctx.StringValue("ListApm.Result["+ i +"].status");
				返回结果.Version = _ctx.StringValue("ListApm.Result["+ i +"].version");
				返回结果.VpcId = _ctx.StringValue("ListApm.Result["+ i +"].vpcId");
				返回结果.VsArea = _ctx.StringValue("ListApm.Result["+ i +"].vsArea");
				返回结果.VswitchId = _ctx.StringValue("ListApm.Result["+ i +"].vswitchId");

				listApmResponse_result.Add(返回结果);
			}
			listApmResponse.Result = listApmResponse_result;
        
			return listApmResponse;
        }
    }
}
