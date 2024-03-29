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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSuspEventDetailResponseUnmarshaller
    {
        public static DescribeSuspEventDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSuspEventDetailResponse describeSuspEventDetailResponse = new DescribeSuspEventDetailResponse();

			describeSuspEventDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeSuspEventDetailResponse.Type = _ctx.StringValue("DescribeSuspEventDetail.Type");
			describeSuspEventDetailResponse.DataSource = _ctx.StringValue("DescribeSuspEventDetail.DataSource");
			describeSuspEventDetailResponse.EventName = _ctx.StringValue("DescribeSuspEventDetail.EventName");
			describeSuspEventDetailResponse.InternetIp = _ctx.StringValue("DescribeSuspEventDetail.InternetIp");
			describeSuspEventDetailResponse.IntranetIp = _ctx.StringValue("DescribeSuspEventDetail.IntranetIp");
			describeSuspEventDetailResponse.LastTime = _ctx.StringValue("DescribeSuspEventDetail.LastTime");
			describeSuspEventDetailResponse.OperateMsg = _ctx.StringValue("DescribeSuspEventDetail.OperateMsg");
			describeSuspEventDetailResponse.Uuid = _ctx.StringValue("DescribeSuspEventDetail.Uuid");
			describeSuspEventDetailResponse.CanBeDealOnLine = _ctx.BooleanValue("DescribeSuspEventDetail.CanBeDealOnLine");
			describeSuspEventDetailResponse.RequestId = _ctx.StringValue("DescribeSuspEventDetail.RequestId");
			describeSuspEventDetailResponse.EventTypeDesc = _ctx.StringValue("DescribeSuspEventDetail.EventTypeDesc");
			describeSuspEventDetailResponse.EventDesc = _ctx.StringValue("DescribeSuspEventDetail.EventDesc");
			describeSuspEventDetailResponse.InstanceName = _ctx.StringValue("DescribeSuspEventDetail.InstanceName");
			describeSuspEventDetailResponse.EventStatus = _ctx.StringValue("DescribeSuspEventDetail.EventStatus");
			describeSuspEventDetailResponse.SaleVersion = _ctx.StringValue("DescribeSuspEventDetail.SaleVersion");
			describeSuspEventDetailResponse.OperateErrorCode = _ctx.StringValue("DescribeSuspEventDetail.OperateErrorCode");
			describeSuspEventDetailResponse.SasId = _ctx.StringValue("DescribeSuspEventDetail.SasId");
			describeSuspEventDetailResponse.Level = _ctx.StringValue("DescribeSuspEventDetail.Level");
			describeSuspEventDetailResponse.Id = _ctx.IntegerValue("DescribeSuspEventDetail.Id");

			List<DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile> describeSuspEventDetailResponse_details = new List<DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile>();
			for (int i = 0; i < _ctx.Length("DescribeSuspEventDetail.Details.Length"); i++) {
				DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile quaraFile = new DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile();
				quaraFile.Type = _ctx.StringValue("DescribeSuspEventDetail.Details["+ i +"].Type");
				quaraFile._Value = _ctx.StringValue("DescribeSuspEventDetail.Details["+ i +"].Value");
				quaraFile.InfoType = _ctx.StringValue("DescribeSuspEventDetail.Details["+ i +"].InfoType");
				quaraFile.NameDisplay = _ctx.StringValue("DescribeSuspEventDetail.Details["+ i +"].NameDisplay");
				quaraFile.Name = _ctx.StringValue("DescribeSuspEventDetail.Details["+ i +"].Name");

				describeSuspEventDetailResponse_details.Add(quaraFile);
			}
			describeSuspEventDetailResponse.Details = describeSuspEventDetailResponse_details;
        
			return describeSuspEventDetailResponse;
        }
    }
}
