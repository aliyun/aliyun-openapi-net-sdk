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
    public class ListShardRecoveriesResponseUnmarshaller
    {
        public static ListShardRecoveriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListShardRecoveriesResponse listShardRecoveriesResponse = new ListShardRecoveriesResponse();

			listShardRecoveriesResponse.HttpResponse = _ctx.HttpResponse;
			listShardRecoveriesResponse.RequestId = _ctx.StringValue("ListShardRecoveries.RequestId");

			List<ListShardRecoveriesResponse.ListShardRecoveries_ResultItem> listShardRecoveriesResponse_result = new List<ListShardRecoveriesResponse.ListShardRecoveries_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListShardRecoveries.Result.Length"); i++) {
				ListShardRecoveriesResponse.ListShardRecoveries_ResultItem resultItem = new ListShardRecoveriesResponse.ListShardRecoveries_ResultItem();
				resultItem.Index = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].index");
				resultItem.SourceHost = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].sourceHost");
				resultItem.TargetNode = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].targetNode");
				resultItem.Stage = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].stage");
				resultItem.FilesTotal = _ctx.LongValue("ListShardRecoveries.Result["+ i +"].filesTotal");
				resultItem.FilesPercent = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].filesPercent");
				resultItem.BytesTotal = _ctx.LongValue("ListShardRecoveries.Result["+ i +"].bytesTotal");
				resultItem.BytesPercent = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].bytesPercent");
				resultItem.TranslogOps = _ctx.LongValue("ListShardRecoveries.Result["+ i +"].translogOps");
				resultItem.TranslogOpsPercent = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].translogOpsPercent");
				resultItem.SourceNode = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].sourceNode");
				resultItem.TargetHost = _ctx.StringValue("ListShardRecoveries.Result["+ i +"].targetHost");

				listShardRecoveriesResponse_result.Add(resultItem);
			}
			listShardRecoveriesResponse.Result = listShardRecoveriesResponse_result;
        
			return listShardRecoveriesResponse;
        }
    }
}
