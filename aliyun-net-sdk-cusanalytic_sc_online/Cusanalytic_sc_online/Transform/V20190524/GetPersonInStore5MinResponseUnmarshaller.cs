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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetPersonInStore5MinResponseUnmarshaller
    {
        public static GetPersonInStore5MinResponse Unmarshall(UnmarshallerContext context)
        {
			GetPersonInStore5MinResponse getPersonInStore5MinResponse = new GetPersonInStore5MinResponse();

			getPersonInStore5MinResponse.HttpResponse = context.HttpResponse;
			getPersonInStore5MinResponse.Success = context.BooleanValue("GetPersonInStore5Min.Success");
			getPersonInStore5MinResponse.Msg = context.StringValue("GetPersonInStore5Min.Msg");

			List<GetPersonInStore5MinResponse.GetPersonInStore5Min_PersonInStore> getPersonInStore5MinResponse_personInStores = new List<GetPersonInStore5MinResponse.GetPersonInStore5Min_PersonInStore>();
			for (int i = 0; i < context.Length("GetPersonInStore5Min.PersonInStores.Length"); i++) {
				GetPersonInStore5MinResponse.GetPersonInStore5Min_PersonInStore personInStore = new GetPersonInStore5MinResponse.GetPersonInStore5Min_PersonInStore();
				personInStore.Number = context.IntegerValue("GetPersonInStore5Min.PersonInStores["+ i +"].Number");
				personInStore.Time = context.LongValue("GetPersonInStore5Min.PersonInStores["+ i +"].Time");

				getPersonInStore5MinResponse_personInStores.Add(personInStore);
			}
			getPersonInStore5MinResponse.PersonInStores = getPersonInStore5MinResponse_personInStores;
        
			return getPersonInStore5MinResponse;
        }
    }
}
