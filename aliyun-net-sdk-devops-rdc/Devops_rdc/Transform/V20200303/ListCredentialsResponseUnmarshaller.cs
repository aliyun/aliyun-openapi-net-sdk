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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListCredentialsResponseUnmarshaller
    {
        public static ListCredentialsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCredentialsResponse listCredentialsResponse = new ListCredentialsResponse();

			listCredentialsResponse.HttpResponse = _ctx.HttpResponse;
			listCredentialsResponse.RequestId = _ctx.StringValue("ListCredentials.RequestId");
			listCredentialsResponse.ErrorCode = _ctx.StringValue("ListCredentials.ErrorCode");
			listCredentialsResponse.ErrorMessage = _ctx.StringValue("ListCredentials.ErrorMessage");
			listCredentialsResponse.Success = _ctx.BooleanValue("ListCredentials.Success");

			List<Dictionary<string, string>> listCredentialsResponse_object = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("ListCredentials.Object.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "ListCredentials.Object["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					listCredentialsResponse_object.Add(tmp);
				}
			}
			listCredentialsResponse._Object = listCredentialsResponse_object;
        
			return listCredentialsResponse;
        }
    }
}
