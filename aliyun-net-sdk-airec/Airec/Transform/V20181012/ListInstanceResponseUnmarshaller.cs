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
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = context.HttpResponse;
			listInstanceResponse.RequestId = context.StringValue("ListInstance.RequestId");
			listInstanceResponse.Code = context.StringValue("ListInstance.Code");
			listInstanceResponse.Message = context.StringValue("ListInstance.Message");

			List<ListInstanceResponse.ListInstance_ResultItem> listInstanceResponse_result = new List<ListInstanceResponse.ListInstance_ResultItem>();
			for (int i = 0; i < context.Length("ListInstance.Result.Length"); i++) {
				ListInstanceResponse.ListInstance_ResultItem resultItem = new ListInstanceResponse.ListInstance_ResultItem();
				resultItem.InstanceId = context.StringValue("ListInstance.Result["+ i +"].InstanceId");
				resultItem.ChargeType = context.StringValue("ListInstance.Result["+ i +"].ChargeType");
				resultItem.RegionId = context.StringValue("ListInstance.Result["+ i +"].RegionId");
				resultItem.Name = context.StringValue("ListInstance.Result["+ i +"].Name");
				resultItem.Type = context.StringValue("ListInstance.Result["+ i +"].Type");
				resultItem.ExpiredTime = context.StringValue("ListInstance.Result["+ i +"].ExpiredTime");
				resultItem.GmtCreate = context.StringValue("ListInstance.Result["+ i +"].GmtCreate");
				resultItem.GmtModified = context.StringValue("ListInstance.Result["+ i +"].GmtModified");
				resultItem.Status = context.StringValue("ListInstance.Result["+ i +"].Status");
				resultItem.Industry = context.StringValue("ListInstance.Result["+ i +"].Industry");
				resultItem.Scene = context.StringValue("ListInstance.Result["+ i +"].Scene");
				resultItem.DataSetVersion = context.StringValue("ListInstance.Result["+ i +"].DataSetVersion");
				resultItem.CommodityCode = context.StringValue("ListInstance.Result["+ i +"].CommodityCode");
				resultItem.LockMode = context.StringValue("ListInstance.Result["+ i +"].LockMode");

				listInstanceResponse_result.Add(resultItem);
			}
			listInstanceResponse.Result = listInstanceResponse_result;
        
			return listInstanceResponse;
        }
    }
}
