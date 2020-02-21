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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListTagKeysResponseUnmarshaller
    {
        public static ListTagKeysResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagKeysResponse listTagKeysResponse = new ListTagKeysResponse();

			listTagKeysResponse.HttpResponse = context.HttpResponse;
			listTagKeysResponse.RequestId = context.StringValue("ListTagKeys.RequestId");
			listTagKeysResponse.MaxResults = context.IntegerValue("ListTagKeys.MaxResults");
			listTagKeysResponse.NextToken = context.StringValue("ListTagKeys.NextToken");

			List<string> listTagKeysResponse_keys = new List<string>();
			for (int i = 0; i < context.Length("ListTagKeys.Keys.Length"); i++) {
				listTagKeysResponse_keys.Add(context.StringValue("ListTagKeys.Keys["+ i +"]"));
			}
			listTagKeysResponse.Keys = listTagKeysResponse_keys;
        
			return listTagKeysResponse;
        }
    }
}
