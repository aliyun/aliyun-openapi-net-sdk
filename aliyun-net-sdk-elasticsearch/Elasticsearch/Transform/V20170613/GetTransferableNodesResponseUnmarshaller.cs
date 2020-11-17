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
    public class GetTransferableNodesResponseUnmarshaller
    {
        public static GetTransferableNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTransferableNodesResponse getTransferableNodesResponse = new GetTransferableNodesResponse();

			getTransferableNodesResponse.HttpResponse = _ctx.HttpResponse;
			getTransferableNodesResponse.RequestId = _ctx.StringValue("GetTransferableNodes.RequestId");

			List<GetTransferableNodesResponse.GetTransferableNodes_ResultItem> getTransferableNodesResponse_result = new List<GetTransferableNodesResponse.GetTransferableNodes_ResultItem>();
			for (int i = 0; i < _ctx.Length("GetTransferableNodes.Result.Length"); i++) {
				GetTransferableNodesResponse.GetTransferableNodes_ResultItem resultItem = new GetTransferableNodesResponse.GetTransferableNodes_ResultItem();
				resultItem.Host = _ctx.StringValue("GetTransferableNodes.Result["+ i +"].host");
				resultItem.Port = _ctx.IntegerValue("GetTransferableNodes.Result["+ i +"].port");

				getTransferableNodesResponse_result.Add(resultItem);
			}
			getTransferableNodesResponse.Result = getTransferableNodesResponse_result;
        
			return getTransferableNodesResponse;
        }
    }
}
