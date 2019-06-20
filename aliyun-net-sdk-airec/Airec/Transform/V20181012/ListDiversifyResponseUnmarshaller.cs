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
    public class ListDiversifyResponseUnmarshaller
    {
        public static ListDiversifyResponse Unmarshall(UnmarshallerContext context)
        {
			ListDiversifyResponse listDiversifyResponse = new ListDiversifyResponse();

			listDiversifyResponse.HttpResponse = context.HttpResponse;
			listDiversifyResponse.RequestId = context.StringValue("ListDiversify.RequestId");
			listDiversifyResponse.Code = context.StringValue("ListDiversify.Code");
			listDiversifyResponse.Message = context.StringValue("ListDiversify.Message");

			List<ListDiversifyResponse.ListDiversify_ResultItem> listDiversifyResponse_result = new List<ListDiversifyResponse.ListDiversify_ResultItem>();
			for (int i = 0; i < context.Length("ListDiversify.Result.Length"); i++) {
				ListDiversifyResponse.ListDiversify_ResultItem resultItem = new ListDiversifyResponse.ListDiversify_ResultItem();
				resultItem.Name = context.StringValue("ListDiversify.Result["+ i +"].Name");
				resultItem.GmtCreate = context.StringValue("ListDiversify.Result["+ i +"].GmtCreate");
				resultItem.GmtModified = context.StringValue("ListDiversify.Result["+ i +"].GmtModified");

				ListDiversifyResponse.ListDiversify_ResultItem.ListDiversify_Parameter parameter = new ListDiversifyResponse.ListDiversify_ResultItem.ListDiversify_Parameter();
				parameter.CategoryIndex = context.IntegerValue("ListDiversify.Result["+ i +"].Parameter.CategoryIndex");
				parameter.Window = context.IntegerValue("ListDiversify.Result["+ i +"].Parameter.Window");
				resultItem.Parameter = parameter;

				listDiversifyResponse_result.Add(resultItem);
			}
			listDiversifyResponse.Result = listDiversifyResponse_result;
        
			return listDiversifyResponse;
        }
    }
}
