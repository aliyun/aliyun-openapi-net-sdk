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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListABTestFixedFlowDividersResponseUnmarshaller
    {
        public static ListABTestFixedFlowDividersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListABTestFixedFlowDividersResponse listABTestFixedFlowDividersResponse = new ListABTestFixedFlowDividersResponse();

			listABTestFixedFlowDividersResponse.HttpResponse = _ctx.HttpResponse;
			listABTestFixedFlowDividersResponse.RequestId = _ctx.StringValue("ListABTestFixedFlowDividers.requestId");

			List<string> listABTestFixedFlowDividersResponse_result = new List<string>();
			for (int i = 0; i < _ctx.Length("ListABTestFixedFlowDividers.Result.Length"); i++) {
				listABTestFixedFlowDividersResponse_result.Add(_ctx.StringValue("ListABTestFixedFlowDividers.Result["+ i +"]"));
			}
			listABTestFixedFlowDividersResponse.Result = listABTestFixedFlowDividersResponse_result;
        
			return listABTestFixedFlowDividersResponse;
        }
    }
}
