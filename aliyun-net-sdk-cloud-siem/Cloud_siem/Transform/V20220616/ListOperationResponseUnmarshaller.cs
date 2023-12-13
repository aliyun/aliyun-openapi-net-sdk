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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListOperationResponseUnmarshaller
    {
        public static ListOperationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOperationResponse listOperationResponse = new ListOperationResponse();

			listOperationResponse.HttpResponse = _ctx.HttpResponse;
			listOperationResponse.RequestId = _ctx.StringValue("ListOperation.RequestId");

			ListOperationResponse.ListOperation_Data data = new ListOperationResponse.ListOperation_Data();
			data.AdminOrNot = _ctx.BooleanValue("ListOperation.Data.AdminOrNot");

			List<string> data_operationList = new List<string>();
			for (int i = 0; i < _ctx.Length("ListOperation.Data.OperationList.Length"); i++) {
				data_operationList.Add(_ctx.StringValue("ListOperation.Data.OperationList["+ i +"]"));
			}
			data.OperationList = data_operationList;
			listOperationResponse.Data = data;
        
			return listOperationResponse;
        }
    }
}
