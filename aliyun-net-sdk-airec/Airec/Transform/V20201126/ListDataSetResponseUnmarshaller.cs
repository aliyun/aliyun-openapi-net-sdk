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
    public class ListDataSetResponseUnmarshaller
    {
        public static ListDataSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSetResponse listDataSetResponse = new ListDataSetResponse();

			listDataSetResponse.HttpResponse = _ctx.HttpResponse;
			listDataSetResponse.Code = _ctx.StringValue("ListDataSet.code");
			listDataSetResponse.Message = _ctx.StringValue("ListDataSet.message");
			listDataSetResponse.RequestId = _ctx.StringValue("ListDataSet.requestId");

			List<ListDataSetResponse.ListDataSet_ResultItem> listDataSetResponse_result = new List<ListDataSetResponse.ListDataSet_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDataSet.Result.Length"); i++) {
				ListDataSetResponse.ListDataSet_ResultItem resultItem = new ListDataSetResponse.ListDataSet_ResultItem();
				resultItem.GmtCreate = _ctx.LongValue("ListDataSet.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.LongValue("ListDataSet.Result["+ i +"].gmtModified");
				resultItem.InstanceId = _ctx.StringValue("ListDataSet.Result["+ i +"].instanceId");
				resultItem.State = _ctx.StringValue("ListDataSet.Result["+ i +"].state");
				resultItem.VersionId = _ctx.StringValue("ListDataSet.Result["+ i +"].versionId");

				listDataSetResponse_result.Add(resultItem);
			}
			listDataSetResponse.Result = listDataSetResponse_result;
        
			return listDataSetResponse;
        }
    }
}
