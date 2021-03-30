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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListExperimentsResponseUnmarshaller
    {
        public static ListExperimentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListExperimentsResponse listExperimentsResponse = new ListExperimentsResponse();

			listExperimentsResponse.HttpResponse = _ctx.HttpResponse;
			listExperimentsResponse.RequestId = _ctx.StringValue("ListExperiments.requestId");

			List<ListExperimentsResponse.ListExperiments_ResultItem> listExperimentsResponse_result = new List<ListExperimentsResponse.ListExperiments_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListExperiments.Result.Length"); i++) {
				ListExperimentsResponse.ListExperiments_ResultItem resultItem = new ListExperimentsResponse.ListExperiments_ResultItem();
				resultItem.ExperimentId = _ctx.StringValue("ListExperiments.Result["+ i +"].experimentId");
				resultItem.Name = _ctx.StringValue("ListExperiments.Result["+ i +"].name");
				resultItem.Description = _ctx.StringValue("ListExperiments.Result["+ i +"].description");
				resultItem.Status = _ctx.StringValue("ListExperiments.Result["+ i +"].status");
				resultItem._Base = _ctx.BooleanValue("ListExperiments.Result["+ i +"].base");
				resultItem.OnlineTime = _ctx.StringValue("ListExperiments.Result["+ i +"].onlineTime");
				resultItem.OfflineTime = _ctx.StringValue("ListExperiments.Result["+ i +"].offlineTime");

				List<string> resultItem_buckets = new List<string>();
				for (int j = 0; j < _ctx.Length("ListExperiments.Result["+ i +"].Buckets.Length"); j++) {
					resultItem_buckets.Add(_ctx.StringValue("ListExperiments.Result["+ i +"].Buckets["+ j +"]"));
				}
				resultItem.Buckets = resultItem_buckets;

				listExperimentsResponse_result.Add(resultItem);
			}
			listExperimentsResponse.Result = listExperimentsResponse_result;
        
			return listExperimentsResponse;
        }
    }
}
