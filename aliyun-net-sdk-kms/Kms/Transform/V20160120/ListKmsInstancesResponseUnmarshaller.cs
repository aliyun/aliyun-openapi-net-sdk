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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class ListKmsInstancesResponseUnmarshaller
    {
        public static ListKmsInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListKmsInstancesResponse listKmsInstancesResponse = new ListKmsInstancesResponse();

			listKmsInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listKmsInstancesResponse.RequestId = _ctx.StringValue("ListKmsInstances.RequestId");
			listKmsInstancesResponse.TotalCount = _ctx.LongValue("ListKmsInstances.TotalCount");
			listKmsInstancesResponse.PageNumber = _ctx.LongValue("ListKmsInstances.PageNumber");
			listKmsInstancesResponse.PageSize = _ctx.LongValue("ListKmsInstances.PageSize");

			List<ListKmsInstancesResponse.ListKmsInstances_KmsInstance> listKmsInstancesResponse_kmsInstances = new List<ListKmsInstancesResponse.ListKmsInstances_KmsInstance>();
			for (int i = 0; i < _ctx.Length("ListKmsInstances.KmsInstances.Length"); i++) {
				ListKmsInstancesResponse.ListKmsInstances_KmsInstance kmsInstance = new ListKmsInstancesResponse.ListKmsInstances_KmsInstance();
				kmsInstance.KmsInstanceArn = _ctx.StringValue("ListKmsInstances.KmsInstances["+ i +"].KmsInstanceArn");
				kmsInstance.KmsInstanceId = _ctx.StringValue("ListKmsInstances.KmsInstances["+ i +"].KmsInstanceId");

				listKmsInstancesResponse_kmsInstances.Add(kmsInstance);
			}
			listKmsInstancesResponse.KmsInstances = listKmsInstancesResponse_kmsInstances;
        
			return listKmsInstancesResponse;
        }
    }
}
