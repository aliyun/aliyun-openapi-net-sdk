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
    public class ListAppSecretIdsResponseUnmarshaller
    {
        public static ListAppSecretIdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppSecretIdsResponse listAppSecretIdsResponse = new ListAppSecretIdsResponse();

			listAppSecretIdsResponse.HttpResponse = _ctx.HttpResponse;
			listAppSecretIdsResponse.RequestId = _ctx.StringValue("ListAppSecretIds.RequestId");

			List<ListAppSecretIdsResponse.ListAppSecretIds_AppSecret> listAppSecretIdsResponse_appSecrets = new List<ListAppSecretIdsResponse.ListAppSecretIds_AppSecret>();
			for (int i = 0; i < _ctx.Length("ListAppSecretIds.AppSecrets.Length"); i++) {
				ListAppSecretIdsResponse.ListAppSecretIds_AppSecret appSecret = new ListAppSecretIdsResponse.ListAppSecretIds_AppSecret();
				appSecret.AppId = _ctx.StringValue("ListAppSecretIds.AppSecrets["+ i +"].AppId");
				appSecret.AppSecretId = _ctx.StringValue("ListAppSecretIds.AppSecrets["+ i +"].AppSecretId");
				appSecret.CreateDate = _ctx.StringValue("ListAppSecretIds.AppSecrets["+ i +"].CreateDate");

				listAppSecretIdsResponse_appSecrets.Add(appSecret);
			}
			listAppSecretIdsResponse.AppSecrets = listAppSecretIdsResponse_appSecrets;
        
			return listAppSecretIdsResponse;
        }
    }
}
