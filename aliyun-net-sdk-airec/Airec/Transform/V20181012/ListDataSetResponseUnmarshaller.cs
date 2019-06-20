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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ListDataSetResponseUnmarshaller
    {
        public static ListDataSetResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataSetResponse listDataSetResponse = new ListDataSetResponse();

			listDataSetResponse.HttpResponse = context.HttpResponse;
			listDataSetResponse.RequestId = context.StringValue("ListDataSet.RequestId");
			listDataSetResponse.Code = context.StringValue("ListDataSet.Code");
			listDataSetResponse.Message = context.StringValue("ListDataSet.Message");

			List<ListDataSetResponse.ListDataSet_ResultItem> listDataSetResponse_result = new List<ListDataSetResponse.ListDataSet_ResultItem>();
			for (int i = 0; i < context.Length("ListDataSet.Result.Length"); i++) {
				ListDataSetResponse.ListDataSet_ResultItem resultItem = new ListDataSetResponse.ListDataSet_ResultItem();
				resultItem.InstanceId = context.StringValue("ListDataSet.Result["+ i +"].InstanceId");
				resultItem.VersionId = context.StringValue("ListDataSet.Result["+ i +"].VersionId");
				resultItem.State = context.StringValue("ListDataSet.Result["+ i +"].State");
				resultItem.GmtCreate = context.LongValue("ListDataSet.Result["+ i +"].GmtCreate");
				resultItem.GmtModified = context.LongValue("ListDataSet.Result["+ i +"].GmtModified");

				listDataSetResponse_result.Add(resultItem);
			}
			listDataSetResponse.Result = listDataSetResponse_result;
        
			return listDataSetResponse;
        }
    }
}
