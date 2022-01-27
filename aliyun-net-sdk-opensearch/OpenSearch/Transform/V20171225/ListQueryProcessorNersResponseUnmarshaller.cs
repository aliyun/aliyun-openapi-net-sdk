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
    public class ListQueryProcessorNersResponseUnmarshaller
    {
        public static ListQueryProcessorNersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQueryProcessorNersResponse listQueryProcessorNersResponse = new ListQueryProcessorNersResponse();

			listQueryProcessorNersResponse.HttpResponse = _ctx.HttpResponse;
			listQueryProcessorNersResponse.RequestId = _ctx.StringValue("ListQueryProcessorNers.requestId");

			List<ListQueryProcessorNersResponse.ListQueryProcessorNers_ResultItem> listQueryProcessorNersResponse_result = new List<ListQueryProcessorNersResponse.ListQueryProcessorNers_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListQueryProcessorNers.Result.Length"); i++) {
				ListQueryProcessorNersResponse.ListQueryProcessorNers_ResultItem resultItem = new ListQueryProcessorNersResponse.ListQueryProcessorNers_ResultItem();
				resultItem.Tag = _ctx.StringValue("ListQueryProcessorNers.Result["+ i +"].tag");
				resultItem.Priority = _ctx.StringValue("ListQueryProcessorNers.Result["+ i +"].priority");
				resultItem.Order = _ctx.IntegerValue("ListQueryProcessorNers.Result["+ i +"].order");
				resultItem.Label = _ctx.StringValue("ListQueryProcessorNers.Result["+ i +"].label");

				listQueryProcessorNersResponse_result.Add(resultItem);
			}
			listQueryProcessorNersResponse.Result = listQueryProcessorNersResponse_result;
        
			return listQueryProcessorNersResponse;
        }
    }
}
