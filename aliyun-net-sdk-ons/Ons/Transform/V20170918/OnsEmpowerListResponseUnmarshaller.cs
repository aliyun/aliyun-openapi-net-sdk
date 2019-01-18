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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ons.Model.V20170918;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20170918
{
    public class OnsEmpowerListResponseUnmarshaller
    {
        public static OnsEmpowerListResponse Unmarshall(UnmarshallerContext context)
        {
			OnsEmpowerListResponse onsEmpowerListResponse = new OnsEmpowerListResponse();

			onsEmpowerListResponse.HttpResponse = context.HttpResponse;
			onsEmpowerListResponse.RequestId = context.StringValue("OnsEmpowerList.RequestId");
			onsEmpowerListResponse.HelpUrl = context.StringValue("OnsEmpowerList.HelpUrl");

			List<OnsEmpowerListResponse.OnsEmpowerList_AuthOwnerInfoDo> onsEmpowerListResponse_data = new List<OnsEmpowerListResponse.OnsEmpowerList_AuthOwnerInfoDo>();
			for (int i = 0; i < context.Length("OnsEmpowerList.Data.Length"); i++) {
				OnsEmpowerListResponse.OnsEmpowerList_AuthOwnerInfoDo authOwnerInfoDo = new OnsEmpowerListResponse.OnsEmpowerList_AuthOwnerInfoDo();
				authOwnerInfoDo.Topic = context.StringValue("OnsEmpowerList.Data["+ i +"].Topic");
				authOwnerInfoDo.Owner = context.LongValue("OnsEmpowerList.Data["+ i +"].Owner");
				authOwnerInfoDo.Relation = context.IntegerValue("OnsEmpowerList.Data["+ i +"].Relation");

				onsEmpowerListResponse_data.Add(authOwnerInfoDo);
			}
			onsEmpowerListResponse.Data = onsEmpowerListResponse_data;
        
			return onsEmpowerListResponse;
        }
    }
}