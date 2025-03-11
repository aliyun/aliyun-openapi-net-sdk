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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class GetDrdsDbRdsRelationInfoResponseUnmarshaller
    {
        public static GetDrdsDbRdsRelationInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDrdsDbRdsRelationInfoResponse getDrdsDbRdsRelationInfoResponse = new GetDrdsDbRdsRelationInfoResponse();

			getDrdsDbRdsRelationInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDrdsDbRdsRelationInfoResponse.Success = _ctx.BooleanValue("GetDrdsDbRdsRelationInfo.Success");
			getDrdsDbRdsRelationInfoResponse.RequestId = _ctx.StringValue("GetDrdsDbRdsRelationInfo.RequestId");

			List<GetDrdsDbRdsRelationInfoResponse.GetDrdsDbRdsRelationInfo_DataItem> getDrdsDbRdsRelationInfoResponse_data = new List<GetDrdsDbRdsRelationInfoResponse.GetDrdsDbRdsRelationInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("GetDrdsDbRdsRelationInfo.Data.Length"); i++) {
				GetDrdsDbRdsRelationInfoResponse.GetDrdsDbRdsRelationInfo_DataItem dataItem = new GetDrdsDbRdsRelationInfoResponse.GetDrdsDbRdsRelationInfo_DataItem();
				dataItem.RdsInstanceId = _ctx.StringValue("GetDrdsDbRdsRelationInfo.Data["+ i +"].RdsInstanceId");
				dataItem.UsedInstanceType = _ctx.StringValue("GetDrdsDbRdsRelationInfo.Data["+ i +"].UsedInstanceType");
				dataItem.UsedInstanceId = _ctx.StringValue("GetDrdsDbRdsRelationInfo.Data["+ i +"].UsedInstanceId");

				List<string> dataItem_readOnlyInstanceInfo = new List<string>();
				for (int j = 0; j < _ctx.Length("GetDrdsDbRdsRelationInfo.Data["+ i +"].ReadOnlyInstanceInfo.Length"); j++) {
					dataItem_readOnlyInstanceInfo.Add(_ctx.StringValue("GetDrdsDbRdsRelationInfo.Data["+ i +"].ReadOnlyInstanceInfo["+ j +"]"));
				}
				dataItem.ReadOnlyInstanceInfo = dataItem_readOnlyInstanceInfo;

				getDrdsDbRdsRelationInfoResponse_data.Add(dataItem);
			}
			getDrdsDbRdsRelationInfoResponse.Data = getDrdsDbRdsRelationInfoResponse_data;
        
			return getDrdsDbRdsRelationInfoResponse;
        }
    }
}
