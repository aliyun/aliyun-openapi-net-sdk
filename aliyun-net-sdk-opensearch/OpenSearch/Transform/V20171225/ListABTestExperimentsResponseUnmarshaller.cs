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
    public class ListABTestExperimentsResponseUnmarshaller
    {
        public static ListABTestExperimentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListABTestExperimentsResponse listABTestExperimentsResponse = new ListABTestExperimentsResponse();

			listABTestExperimentsResponse.HttpResponse = _ctx.HttpResponse;
			listABTestExperimentsResponse.RequestId = _ctx.StringValue("ListABTestExperiments.requestId");

			List<ListABTestExperimentsResponse.ListABTestExperiments_ResultItem> listABTestExperimentsResponse_result = new List<ListABTestExperimentsResponse.ListABTestExperiments_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListABTestExperiments.Result.Length"); i++) {
				ListABTestExperimentsResponse.ListABTestExperiments_ResultItem resultItem = new ListABTestExperimentsResponse.ListABTestExperiments_ResultItem();
				resultItem.Id = _ctx.StringValue("ListABTestExperiments.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListABTestExperiments.Result["+ i +"].name");
				resultItem._Params = _ctx.StringValue("ListABTestExperiments.Result["+ i +"].params");
				resultItem.Created = _ctx.IntegerValue("ListABTestExperiments.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListABTestExperiments.Result["+ i +"].updated");
				resultItem.Online = _ctx.BooleanValue("ListABTestExperiments.Result["+ i +"].online");
				resultItem.Traffic = _ctx.IntegerValue("ListABTestExperiments.Result["+ i +"].traffic");

				listABTestExperimentsResponse_result.Add(resultItem);
			}
			listABTestExperimentsResponse.Result = listABTestExperimentsResponse_result;
        
			return listABTestExperimentsResponse;
        }
    }
}
