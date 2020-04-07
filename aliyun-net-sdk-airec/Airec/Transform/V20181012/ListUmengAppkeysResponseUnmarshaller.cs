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
    public class ListUmengAppkeysResponseUnmarshaller
    {
        public static ListUmengAppkeysResponse Unmarshall(UnmarshallerContext context)
        {
			ListUmengAppkeysResponse listUmengAppkeysResponse = new ListUmengAppkeysResponse();

			listUmengAppkeysResponse.HttpResponse = context.HttpResponse;
			listUmengAppkeysResponse.RequestId = context.StringValue("ListUmengAppkeys.RequestId");
			listUmengAppkeysResponse.Code = context.StringValue("ListUmengAppkeys.Code");
			listUmengAppkeysResponse.Message = context.StringValue("ListUmengAppkeys.Message");

			List<ListUmengAppkeysResponse.ListUmengAppkeys_ResultItem> listUmengAppkeysResponse_result = new List<ListUmengAppkeysResponse.ListUmengAppkeys_ResultItem>();
			for (int i = 0; i < context.Length("ListUmengAppkeys.Result.Length"); i++) {
				ListUmengAppkeysResponse.ListUmengAppkeys_ResultItem resultItem = new ListUmengAppkeysResponse.ListUmengAppkeys_ResultItem();
				resultItem.Name = context.StringValue("ListUmengAppkeys.Result["+ i +"].Name");
				resultItem.Appkey = context.StringValue("ListUmengAppkeys.Result["+ i +"].Appkey");
				resultItem.Platform = context.StringValue("ListUmengAppkeys.Result["+ i +"].Platform");

				listUmengAppkeysResponse_result.Add(resultItem);
			}
			listUmengAppkeysResponse.Result = listUmengAppkeysResponse_result;
        
			return listUmengAppkeysResponse;
        }
    }
}
