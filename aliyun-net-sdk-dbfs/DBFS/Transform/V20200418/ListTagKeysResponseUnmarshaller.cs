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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class ListTagKeysResponseUnmarshaller
    {
        public static ListTagKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTagKeysResponse listTagKeysResponse = new ListTagKeysResponse();

			listTagKeysResponse.HttpResponse = _ctx.HttpResponse;
			listTagKeysResponse.RequestId = _ctx.StringValue("ListTagKeys.RequestId");

			List<string> listTagKeysResponse_tagKeys = new List<string>();
			for (int i = 0; i < _ctx.Length("ListTagKeys.TagKeys.Length"); i++) {
				listTagKeysResponse_tagKeys.Add(_ctx.StringValue("ListTagKeys.TagKeys["+ i +"]"));
			}
			listTagKeysResponse.TagKeys = listTagKeysResponse_tagKeys;
        
			return listTagKeysResponse;
        }
    }
}
