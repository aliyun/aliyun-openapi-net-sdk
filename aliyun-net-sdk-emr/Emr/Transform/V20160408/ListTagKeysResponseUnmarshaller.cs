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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListTagKeysResponseUnmarshaller
    {
        public static ListTagKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagKeysResponse listTagKeysResponse = new ListTagKeysResponse();

			listTagKeysResponse.HttpResponse = _ctx.HttpResponse;
			listTagKeysResponse.RequestId = _ctx.StringValue("ListTagKeys.RequestId");
			listTagKeysResponse.Code = _ctx.StringValue("ListTagKeys.Code");
			listTagKeysResponse.Message = _ctx.StringValue("ListTagKeys.Message");
			listTagKeysResponse.Success = _ctx.BooleanValue("ListTagKeys.Success");
			listTagKeysResponse.PageSize = _ctx.IntegerValue("ListTagKeys.PageSize");
			listTagKeysResponse.TotalCount = _ctx.IntegerValue("ListTagKeys.TotalCount");
			listTagKeysResponse.NextToken = _ctx.StringValue("ListTagKeys.NextToken");

			List<string> listTagKeysResponse_keys = new List<string>();
			for (int i = 0; i < _ctx.Length("ListTagKeys.Keys.Length"); i++) {
				listTagKeysResponse_keys.Add(_ctx.StringValue("ListTagKeys.Keys["+ i +"]"));
			}
			listTagKeysResponse.Keys = listTagKeysResponse_keys;
        
			return listTagKeysResponse;
        }
    }
}
