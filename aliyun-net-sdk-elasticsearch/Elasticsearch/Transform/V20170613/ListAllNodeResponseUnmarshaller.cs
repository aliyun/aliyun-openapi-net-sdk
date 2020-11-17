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
    public class ListAllNodeResponseUnmarshaller
    {
        public static ListAllNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllNodeResponse listAllNodeResponse = new ListAllNodeResponse();

			listAllNodeResponse.HttpResponse = _ctx.HttpResponse;
			listAllNodeResponse.RequestId = _ctx.StringValue("ListAllNode.RequestId");

			List<ListAllNodeResponse.ListAllNode_ResultItem> listAllNodeResponse_result = new List<ListAllNodeResponse.ListAllNode_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListAllNode.Result.Length"); i++) {
				ListAllNodeResponse.ListAllNode_ResultItem resultItem = new ListAllNodeResponse.ListAllNode_ResultItem();
				resultItem.Host = _ctx.StringValue("ListAllNode.Result["+ i +"].host");
				resultItem.Port = _ctx.IntegerValue("ListAllNode.Result["+ i +"].port");
				resultItem.ZoneId = _ctx.StringValue("ListAllNode.Result["+ i +"].zoneId");
				resultItem.NodeType = _ctx.StringValue("ListAllNode.Result["+ i +"].nodeType");
				resultItem.CpuPercent = _ctx.StringValue("ListAllNode.Result["+ i +"].cpuPercent");
				resultItem.LoadOneM = _ctx.StringValue("ListAllNode.Result["+ i +"].loadOneM");
				resultItem.HeapPercent = _ctx.StringValue("ListAllNode.Result["+ i +"].heapPercent");
				resultItem.Health = _ctx.StringValue("ListAllNode.Result["+ i +"].health");
				resultItem.DiskUsedPercent = _ctx.StringValue("ListAllNode.Result["+ i +"].diskUsedPercent");

				listAllNodeResponse_result.Add(resultItem);
			}
			listAllNodeResponse.Result = listAllNodeResponse_result;
        
			return listAllNodeResponse;
        }
    }
}
