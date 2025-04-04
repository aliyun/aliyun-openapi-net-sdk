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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class ListAccessKeysResponseUnmarshaller
    {
        public static ListAccessKeysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAccessKeysResponse listAccessKeysResponse = new ListAccessKeysResponse();

			listAccessKeysResponse.HttpResponse = _ctx.HttpResponse;
			listAccessKeysResponse.RequestId = _ctx.StringValue("ListAccessKeys.RequestId");

			List<ListAccessKeysResponse.ListAccessKeys_AccessKey> listAccessKeysResponse_accessKeys = new List<ListAccessKeysResponse.ListAccessKeys_AccessKey>();
			for (int i = 0; i < _ctx.Length("ListAccessKeys.AccessKeys.Length"); i++) {
				ListAccessKeysResponse.ListAccessKeys_AccessKey accessKey = new ListAccessKeysResponse.ListAccessKeys_AccessKey();
				accessKey.Status = _ctx.StringValue("ListAccessKeys.AccessKeys["+ i +"].Status");
				accessKey.UpdateDate = _ctx.StringValue("ListAccessKeys.AccessKeys["+ i +"].UpdateDate");
				accessKey.AccessKeyId = _ctx.StringValue("ListAccessKeys.AccessKeys["+ i +"].AccessKeyId");
				accessKey.CreateDate = _ctx.StringValue("ListAccessKeys.AccessKeys["+ i +"].CreateDate");

				listAccessKeysResponse_accessKeys.Add(accessKey);
			}
			listAccessKeysResponse.AccessKeys = listAccessKeysResponse_accessKeys;
        
			return listAccessKeysResponse;
        }
    }
}
