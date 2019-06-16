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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class ListDashboardUidResponseUnmarshaller
    {
        public static ListDashboardUidResponse Unmarshall(UnmarshallerContext context)
        {
			ListDashboardUidResponse listDashboardUidResponse = new ListDashboardUidResponse();

			listDashboardUidResponse.HttpResponse = context.HttpResponse;
			listDashboardUidResponse.RequestId = context.StringValue("ListDashboardUid.RequestId");
			listDashboardUidResponse.Code = context.StringValue("ListDashboardUid.Code");
			listDashboardUidResponse.Message = context.StringValue("ListDashboardUid.Message");

			ListDashboardUidResponse.ListDashboardUid_Result result = new ListDashboardUidResponse.ListDashboardUid_Result();
			result.Num = context.IntegerValue("ListDashboardUid.Result.Num");

			List<string> result_uid = new List<string>();
			for (int i = 0; i < context.Length("ListDashboardUid.Result.Uid.Length"); i++) {
				result_uid.Add(context.StringValue("ListDashboardUid.Result.Uid["+ i +"]"));
			}
			result.Uid = result_uid;
			listDashboardUidResponse.Result = result;
        
			return listDashboardUidResponse;
        }
    }
}
