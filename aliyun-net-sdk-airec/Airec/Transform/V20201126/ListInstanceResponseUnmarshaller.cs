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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceResponse.Code = _ctx.StringValue("ListInstance.code");
			listInstanceResponse.Message = _ctx.StringValue("ListInstance.message");
			listInstanceResponse.RequestId = _ctx.StringValue("ListInstance.requestId");

			List<ListInstanceResponse.ListInstance_ResultItem> listInstanceResponse_result = new List<ListInstanceResponse.ListInstance_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListInstance.Result.Length"); i++) {
				ListInstanceResponse.ListInstance_ResultItem resultItem = new ListInstanceResponse.ListInstance_ResultItem();
				resultItem.ChargeType = _ctx.StringValue("ListInstance.Result["+ i +"].chargeType");
				resultItem.CommodityCode = _ctx.StringValue("ListInstance.Result["+ i +"].commodityCode");
				resultItem.DataSetVersion = _ctx.StringValue("ListInstance.Result["+ i +"].dataSetVersion");
				resultItem.ExpiredTime = _ctx.StringValue("ListInstance.Result["+ i +"].expiredTime");
				resultItem.GmtCreate = _ctx.StringValue("ListInstance.Result["+ i +"].gmtCreate");
				resultItem.GmtModified = _ctx.StringValue("ListInstance.Result["+ i +"].gmtModified");
				resultItem.Industry = _ctx.StringValue("ListInstance.Result["+ i +"].industry");
				resultItem.InstanceId = _ctx.StringValue("ListInstance.Result["+ i +"].instanceId");
				resultItem.LockMode = _ctx.StringValue("ListInstance.Result["+ i +"].lockMode");
				resultItem.Name = _ctx.StringValue("ListInstance.Result["+ i +"].name");
				resultItem.RegionId = _ctx.StringValue("ListInstance.Result["+ i +"].regionId");
				resultItem.Status = _ctx.StringValue("ListInstance.Result["+ i +"].status");
				resultItem.Type = _ctx.StringValue("ListInstance.Result["+ i +"].type");

				listInstanceResponse_result.Add(resultItem);
			}
			listInstanceResponse.Result = listInstanceResponse_result;
        
			return listInstanceResponse;
        }
    }
}
