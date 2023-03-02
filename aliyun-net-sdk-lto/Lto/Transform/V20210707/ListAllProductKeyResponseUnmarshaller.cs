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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListAllProductKeyResponseUnmarshaller
    {
        public static ListAllProductKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllProductKeyResponse listAllProductKeyResponse = new ListAllProductKeyResponse();

			listAllProductKeyResponse.HttpResponse = _ctx.HttpResponse;
			listAllProductKeyResponse.Code = _ctx.StringValue("ListAllProductKey.Code");
			listAllProductKeyResponse.HttpStatusCode = _ctx.IntegerValue("ListAllProductKey.HttpStatusCode");
			listAllProductKeyResponse.Message = _ctx.StringValue("ListAllProductKey.Message");
			listAllProductKeyResponse.RequestId = _ctx.StringValue("ListAllProductKey.RequestId");
			listAllProductKeyResponse.Success = _ctx.BooleanValue("ListAllProductKey.Success");

			List<ListAllProductKeyResponse.ListAllProductKey_ProductKeyInfo> listAllProductKeyResponse_data = new List<ListAllProductKeyResponse.ListAllProductKey_ProductKeyInfo>();
			for (int i = 0; i < _ctx.Length("ListAllProductKey.Data.Length"); i++) {
				ListAllProductKeyResponse.ListAllProductKey_ProductKeyInfo productKeyInfo = new ListAllProductKeyResponse.ListAllProductKey_ProductKeyInfo();
				productKeyInfo.Name = _ctx.StringValue("ListAllProductKey.Data["+ i +"].Name");
				productKeyInfo.ProductKey = _ctx.StringValue("ListAllProductKey.Data["+ i +"].ProductKey");

				listAllProductKeyResponse_data.Add(productKeyInfo);
			}
			listAllProductKeyResponse.Data = listAllProductKeyResponse_data;
        
			return listAllProductKeyResponse;
        }
    }
}
