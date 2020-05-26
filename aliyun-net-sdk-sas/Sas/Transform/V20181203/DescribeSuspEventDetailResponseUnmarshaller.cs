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
        public static DescribeSuspEventDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspEventDetailResponse describeSuspEventDetailResponse = new DescribeSuspEventDetailResponse();

			describeSuspEventDetailResponse.HttpResponse = context.HttpResponse;
			describeSuspEventDetailResponse.RequestId = context.StringValue("DescribeSuspEventDetail.RequestId");
			describeSuspEventDetailResponse.LastTime = context.StringValue("DescribeSuspEventDetail.LastTime");
			describeSuspEventDetailResponse.Id = context.IntegerValue("DescribeSuspEventDetail.Id");
			describeSuspEventDetailResponse.InstanceName = context.StringValue("DescribeSuspEventDetail.InstanceName");
			describeSuspEventDetailResponse.InternetIp = context.StringValue("DescribeSuspEventDetail.InternetIp");
			describeSuspEventDetailResponse.IntranetIp = context.StringValue("DescribeSuspEventDetail.IntranetIp");
			describeSuspEventDetailResponse.Uuid = context.StringValue("DescribeSuspEventDetail.Uuid");
			describeSuspEventDetailResponse.EventDesc = context.StringValue("DescribeSuspEventDetail.EventDesc");
			describeSuspEventDetailResponse.EventTypeDesc = context.StringValue("DescribeSuspEventDetail.EventTypeDesc");
			describeSuspEventDetailResponse.Level = context.StringValue("DescribeSuspEventDetail.Level");
			describeSuspEventDetailResponse.EventStatus = context.StringValue("DescribeSuspEventDetail.EventStatus");
			describeSuspEventDetailResponse.SaleVersion = context.StringValue("DescribeSuspEventDetail.SaleVersion");
			describeSuspEventDetailResponse.DataSource = context.StringValue("DescribeSuspEventDetail.DataSource");
			describeSuspEventDetailResponse.Type = context.StringValue("DescribeSuspEventDetail.Type");
			describeSuspEventDetailResponse.OperateMsg = context.StringValue("DescribeSuspEventDetail.OperateMsg");
			describeSuspEventDetailResponse.SasId = context.StringValue("DescribeSuspEventDetail.SasId");
			describeSuspEventDetailResponse.EventName = context.StringValue("DescribeSuspEventDetail.EventName");
			describeSuspEventDetailResponse.CanBeDealOnLine = context.BooleanValue("DescribeSuspEventDetail.CanBeDealOnLine");
			describeSuspEventDetailResponse.OperateErrorCode = context.StringValue("DescribeSuspEventDetail.OperateErrorCode");

			List<DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile> describeSuspEventDetailResponse_details = new List<DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile>();
			for (int i = 0; i < context.Length("DescribeSuspEventDetail.Details.Length"); i++) {
				DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile quaraFile = new DescribeSuspEventDetailResponse.DescribeSuspEventDetail_QuaraFile();
				quaraFile.Name = context.StringValue("DescribeSuspEventDetail.Details["+ i +"].Name");
				quaraFile.Type = context.StringValue("DescribeSuspEventDetail.Details["+ i +"].Type");
				quaraFile.InfoType = context.StringValue("DescribeSuspEventDetail.Details["+ i +"].InfoType");
				quaraFile._Value = context.StringValue("DescribeSuspEventDetail.Details["+ i +"].Value");

				describeSuspEventDetailResponse_details.Add(quaraFile);
			}
			describeSuspEventDetailResponse.Details = describeSuspEventDetailResponse_details;
        
			return describeSuspEventDetailResponse;
        }
    }
}
